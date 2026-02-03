using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home.Common;

namespace Home
{
    public partial class SidebarControl : UserControl
    {
        public event EventHandler HomeClicked;
        public event EventHandler PatientClicked;
        public event EventHandler RequestClicked;
        public event EventHandler PendingClicked;
        public event EventHandler ResultClicked;
        public event EventHandler LogoutClicked;
        public SidebarControl()
        {
            InitializeComponent();
            button_Home.Click += (s, e) => HomeClicked?.Invoke(this, e);
            button_Patient.Click += (s, e) => PatientClicked?.Invoke(this, e);
            button_Request.Click += (s, e) => RequestClicked?.Invoke(this, e);
            button_Pending.Click += (s, e) => PendingClicked?.Invoke(this, e);
            button_Result.Click += (s, e) => ResultClicked?.Invoke(this, e);
            button_Logout.Click += (s, e) => LogoutClicked?.Invoke(this, e);
        }

        public void SetActiveMenu(SidebarMenu menu)
        {
            ResetHighlight();
            Highlight(menu);
        }
        private void ResetHighlight()
        {
            button_Home.BackColor = Color.White;
            button_Patient.BackColor = Color.White;
            button_Request.BackColor = Color.White;
            button_Pending.BackColor = Color.White;
            button_Result.BackColor = Color.White;
            button_Home.FlatAppearance.BorderColor = Color.White;
            button_Patient.FlatAppearance.BorderColor = Color.White;
            button_Request.FlatAppearance.BorderColor = Color.White;
            button_Pending.FlatAppearance.BorderColor = Color.White;
            button_Result.FlatAppearance.BorderColor = Color.White;
        }
        private void Highlight(SidebarMenu menu)
        {
            Button btn = null;
            switch (menu)
            {
                case SidebarMenu.Home:
                    btn = button_Home;
                    break;
                case SidebarMenu.Patient:
                    btn = button_Patient;
                    break;
                case SidebarMenu.Request:
                    btn = button_Request;
                    break;
                case SidebarMenu.Pending:
                    btn = button_Pending;
                    break;
                case SidebarMenu.Result:
                    btn = button_Result;
                    break;
                default:
                    break;
            }
            if (btn != null)
            {
                btn.BackColor = System.Drawing.Color.FromArgb(255, 210, 230, 230);
                btn.FlatAppearance.BorderColor = Color.Green;
            }
        }
        private void button_Home_Click(object sender, EventArgs e)
        {
            OpenForm<MainForm>();
        }

        private void button_Patient_Click(object sender, EventArgs e)
        {
            OpenForm<Patient>();
        }

        private void button_Request_Click(object sender, EventArgs e)
        {
            OpenForm<Request>();
        }

        private void button_Pending_Click(object sender, EventArgs e)
        {
            OpenForm<Pending>();
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            OpenForm<Result>();
        }


        private void button_Logout_Click(object sender, EventArgs e)
        {
            OpenForm<Login>();
            AppSession.ClearCurrentEmp();
        }

        private static Dictionary<Type, Form> _forms = new Dictionary<Type, Form>();
        private void OpenForm<T>() where T : Form, new()
        {
            Form current = this.FindForm();
            if (current is T)
            {
                return;
            }
            if (!_forms.TryGetValue(typeof(T), out Form form) || form.IsDisposed)
            {
                form = new T();
                _forms[typeof(T)] = form;
            }

            form.Show();
            form.BringToFront();
            current?.Hide();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Logout_MouseEnter(object sender, EventArgs e)
        {
            button_Logout.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
        }

        private void button_Logout_MouseLeave(object sender, EventArgs e)
        {
            button_Logout.BackColor = Color.White;
        }

        private void button_Exit_MouseEnter(object sender, EventArgs e)
        {
            button_Exit.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
        }

        private void button_Exit_MouseLeave(object sender, EventArgs e)
        {
            button_Exit.BackColor = Color.White;
        }
        public void RefreshFromSession()
        {
            label_Name.Text = $"{AppSession.Empfname ?? ""} {AppSession.Emplname ?? ""}".Trim();
            label_Department.Text = AppSession.EmpDepartment ?? "-";
        }
    }
}                                               
