using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class pavilions
    {
        [Key]
        public int idpavilion { get; set; }
        public string mall_name { get; set; }
        public string number { get; set; }
        public int floor { get; set; }
        public string status { get; set; }
        public double area { get; set; }
        public double areacost { get; set; }
        public double added_value_ratio { get; set; }
    }
}
