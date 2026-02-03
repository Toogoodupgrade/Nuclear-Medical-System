using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Common
{
    public static class AppSession
    {
        public static PatientDto SelectedPatient { get; set; }

        public static string EmpId { get; set; }
        public static string Empfname { get; set; }
        public static string Emplname { get; set; }
        public static string EmpDepartment { get; set; }
        public static void ClearCurrentEmp()
        {
            EmpId = null;
            Empfname = null;
            Emplname = null;
            EmpDepartment = null;
            SelectedPatient = null;
        }
    }
}
