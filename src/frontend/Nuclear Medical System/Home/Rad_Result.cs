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
    public partial class Rad_Result : Form
    {
        public Rad_Result()
        {
            InitializeComponent();
        }

        private void Rad_Result_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Request);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
        }
    }
}
