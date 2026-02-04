using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Lab_ResultDto
    {
        public string lab_res_id { get; set; }
        public string hn { get; set; }
        public string pt_fname { get; set; }
        public string pt_lname { get; set; }
        public string emp_fname { get; set; }
        public string emp_lname { get; set; }
        public string lab_test_name { get; set; }
        public string lab_test_category { get; set; }
        public string examtp { get; set; }
        public string method {  get; set; }
        public string container { get; set; }
        public string volume { get; set; }
        public DateTime lab_res_date { get; set; }
        public string lab_res_status { get; set; }
    }
}
