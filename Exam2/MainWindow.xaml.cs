using Exam2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exam2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.Users.Load();

        }

        private void Login(object sender, RoutedEventArgs e)
        {

            var user = db.Users.Where(p => p.login == login.Text).ToList().Where(p => p.password == password.Password).ToList();
            if(user.Count > 0)
            {
                PavWindow pv = new PavWindow();
                this.Close();
                pv.Show();
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

        }
    }
    
}
