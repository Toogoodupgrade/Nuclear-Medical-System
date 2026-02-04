using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Common
{
    public static class AppSession
    {
        public static PatientDto SelectedPatient { get; private set; }
        public static event Action SelectedPatientChanged;
        public static event Action CurrentEmpChanged;
        public static void SetSelectedPatient(PatientDto patient)
        {
            SelectedPatient = patient;
            SelectedPatientChanged?.Invoke();
        }
        public static string EmpId { get; set; }
        public static string Empfname { get; set; }
        public static string Emplname { get; set; }
        public static string EmpDepartment { get; set; }
        public static void setCurrentEmp(LoginResponseDto emp)
        {
            EmpId = emp.emp_id?.Trim();
            Empfname = emp.emp_fname;
            Emplname = emp.emp_lname;
            EmpDepartment = emp.dept_name?.Trim();
            CurrentEmpChanged?.Invoke();
        }
        public static void ClearCurrentEmp()
        {
            EmpId = null;
            Empfname = null;
            Emplname = null;
            EmpDepartment = null;
            SelectedPatient = null;
            CurrentEmpChanged?.Invoke();
        }
    }
}
