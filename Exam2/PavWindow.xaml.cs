using Exam2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exam2
{
    /// <summary>
    /// Логика взаимодействия для PavWindow.xaml
    /// </summary>
    public partial class PavWindow : Window ,INotifyPropertyChanged
    {
        ApplicationContext db;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyChanged)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
        }

        public pavilions pavSelected { get; set; }
        public PavWindow()
        {
            db = new ApplicationContext();
            db.Pavilions.Load();
            InitializeComponent();
            pavGrid.ItemsSource = db.Pavilions.Local.ToBindingList().Where(
                p => p.status != "Удален");
            DataContext = this;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            pavSelected.status = "Удален";
            db.SaveChanges();
            OnPropertyChanged("pavSelected");
            pavGrid.ItemsSource = db.Pavilions.Local.ToBindingList().Where(
               p => p.status != "Удален");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)combo.SelectedItem;


        }
    }
}
