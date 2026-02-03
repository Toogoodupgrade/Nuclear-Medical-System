using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Home
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8000/")
        };
        
        private async void Patient_Load(object sender, EventArgs e)
        {
            headerControl.RefreshFromSession();
            leftsidebarControl.SetActiveMenu(SidebarMenu.Patient);
            dataGridView_Pt.AutoGenerateColumns = false;
            dataGridView_Pt.Columns.Clear();
            leftsidebarControl.RefreshFromSession();

            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "HN",
                DataPropertyName = "hn"
            });

            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                HeaderText = "First Name", DataPropertyName = "pt_fname" 
            });
            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",DataPropertyName = "pt_lname"
            });
            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone Number", DataPropertyName = "pt_tel"
            });
            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gender", DataPropertyName = "pt_gender"
            });
            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "DOB", DataPropertyName = "pt_dob",DefaultCellStyle = {Format = "dd/MM/yyyy"}
            });
            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Medical Condition", DataPropertyName = "pt_medical_condition"
            });
            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Affiliation",DataPropertyName = "pt_affiliation"
            });
            dataGridView_Pt.Columns.Add(new DataGridViewTextBoxColumn 
            { 
                HeaderText = "Patient Right", DataPropertyName = "right_name"
            });

            try
            {
                var response = await client.GetAsync("patients");
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                var patients = JsonConvert.DeserializeObject<List<PatientDto>>(json);
                dataGridView_Pt.DataSource = patients;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

    }
}
