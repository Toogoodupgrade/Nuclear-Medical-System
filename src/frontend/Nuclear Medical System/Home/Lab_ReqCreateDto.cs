using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Lab_ReqCreateDto
    {

        public string emp_id { get; set; }
        public string hn { get; set; }
        public DateTime lab_req_date { get; set; }
        public string lab_req_status { get; set; }
        public List<Lab_ReqDetailDto> details { get; set; }
    }
}
