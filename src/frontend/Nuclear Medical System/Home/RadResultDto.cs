using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class RadResultDto
    {
        public string rad_res_id { get; set; }
        public string hn {  get; set; }
        public string pt_fname { get; set; }
        public string pt_lname { get; set; }
        public string emp_fname { get; set; }
        public string emp_lname { get; set; }

        public string machine_name { get; set; }
        public string rad_res_date {  get; set; }
        public string rad_res_status { get; set; }
    }
}
