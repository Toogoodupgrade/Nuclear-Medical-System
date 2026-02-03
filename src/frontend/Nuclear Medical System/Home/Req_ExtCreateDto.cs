using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Req_ExtCreateDto
    {
        public string hn { get; set; }
        public string emp_id { get; set; }
        public DateTime lab_req_date { get; set; }
        public string hospital_id { get; set; }
        public List<Lab_ReqDetailDto> details { get; set; }
    }
}
