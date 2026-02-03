using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class Rad_ReqCreateDto
    {
        public string hn { get; set; }
        public string emp_id { get; set; }
        public DateTime rad_req_date { get; set; }
        public string rad_req_impression { get; set; }
        public string rad_req_history { get; set; }
        public string rad_req_urgency_level { get; set; }
        public List<Rad_ReqDetailDto> details { get; set; }
    }
}
