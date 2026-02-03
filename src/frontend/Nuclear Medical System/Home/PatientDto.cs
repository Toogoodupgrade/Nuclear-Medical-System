using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class PatientDto
    {
        public string hn { get; set; }
        public string pt_fname { get; set; }
        public string pt_lname { get; set; }
        public string pt_tel { get; set; }
        public string pt_gender { get; set; }
        public DateTime pt_dob { get; set; }
        public string pt_medical_condition { get; set; }
        public string pt_affiliation { get; set; }
        public string pt_level { get; set; }
        public string right_name { get; set; }
    }
}
