using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class PatientSearchDto
    {
        public string hn { get; set; }
        public string pt_fname { get; set; }
        public string pt_lname { get; set; }

        public string DisplayText =>
        $"{hn} - {pt_fname} {pt_lname}";
    }
}
