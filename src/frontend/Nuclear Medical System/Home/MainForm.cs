using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Home.Patient;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Globalization;
namespace Home
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Home);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
            label_Date.Text = "แผนกเวชศาสตร์นิวเคลียร์ - " + DateTime.Now.ToString("dddd d MMMM yyyy", new CultureInfo("en-US"));
        }
    }
}
