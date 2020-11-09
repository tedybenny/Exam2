using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class users
    {
        public string firstname { get; set; }
        public string secondname { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string phoneNumber { get; set; }
        public string sex { get; set; }
        [Key]
        public int iduser { get; set; }
    }
}
