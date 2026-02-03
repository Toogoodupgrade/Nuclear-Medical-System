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
    public partial class Pending : Form
    {
        public Pending()
        {
            InitializeComponent();
        }

        private void Pending_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Pending);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
        }
    }
}
