using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Request);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
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

        private void btn_Lab_Req_Immunology_Click(object sender, EventArgs e)
        {
            OpenForm<Lab_Req_Immunology>();
        }

        private void btn_Lab_Req_Pathology_Click(object sender, EventArgs e)
        {
            OpenForm<Lab_Req_Pathology>();
        }

        private void btn_Rad_Req_Click(object sender, EventArgs e)
        {
            OpenForm<Rad_Req>();
        }
    }
}
