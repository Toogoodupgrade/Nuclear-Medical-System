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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Result);
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


        private void btn_Lab_Res_Pathology_Click(object sender, EventArgs e)
        {
            OpenForm<Lab_Result>();
        }

        private void btn_Rad_Res_Click(object sender, EventArgs e)
        {
            OpenForm<Rad_Result>();
        }
    }
}
