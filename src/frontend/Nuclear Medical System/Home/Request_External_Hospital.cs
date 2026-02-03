using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home.Common;
using Newtonsoft.Json;

namespace Home
{
    public partial class Request_External_Hospital : Form
    {
        List<LabTestCheckboxMap> mappings;
        public Request_External_Hospital()
        {
            InitializeComponent();
            mappings = new List<LabTestCheckboxMap>
            {
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Serum_Protein,
                    Lab_TestID = "lab_ts0144"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Vitamin_B12,
                    Lab_TestID = "lab_ts0145"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Folate,
                    Lab_TestID = "lab_ts0146"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Aldosterone,
                    Lab_TestID = "lab_ts0147"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Renin,
                    Lab_TestID = "lab_ts0148"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_ACTH,
                    Lab_TestID = "lab_ts0149"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Growth_Hormone,
                    Lab_TestID = "lab_ts0150"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Calcitonin,
                    Lab_TestID = "lab_ts0151"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_DHT,
                    Lab_TestID = "lab_ts0152"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Urine_VMA,
                    Lab_TestID = "lab_ts0153"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Urine_Metanephrine,
                    Lab_TestID = "lab_ts0154"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_C_peptide,
                    Lab_TestID = "lab_ts0155"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Acid_Phosphatase,
                    Lab_TestID = "lab_ts0156"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Fructosamine,
                    Lab_TestID = "lab_ts0157"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Cerulophlasmin,
                    Lab_TestID = "lab_ts0158"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_17OHP,
                    Lab_TestID = "lab_ts0159"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Copper,
                    Lab_TestID = "lab_ts0160"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Urine_Copper,
                    Lab_TestID = "lab_ts0161"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Lithium,
                    Lab_TestID = "lab_ts0162"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_DHEAS,
                    Lab_TestID = "lab_ts0163"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Progesterone,
                    Lab_TestID = "lab_ts0164"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Haptoglobin,
                    Lab_TestID = "lab_ts0165"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Zinc,
                    Lab_TestID = "lab_ts0166"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Vitamin_A,
                    Lab_TestID = "lab_ts0167"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Vitamin_B,
                    Lab_TestID = "lab_ts0168"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Vitamin_C,
                    Lab_TestID = "lab_ts0169"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Theophylline,
                    Lab_TestID = "lab_ts0170"
                },
            };

            foreach (var map in mappings)
            {
                map.CheckBoxLab.CheckedChanged += UpdateTotalCount;
            }
        }

        private async void Request_External_Hospital_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Request);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
            await LoadHospitals();
        }

        private void comboBox_Hospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Hospital.SelectedIndex != -1)
            {
                string hospital_id = comboBox_Hospital.SelectedValue?.ToString(); 
            }
        }
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8000/")
        };
        private async Task LoadHospitals()
        {
            var response = await client.GetAsync("hospitals/");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var hospitals = JsonConvert.DeserializeObject<List<HospitalDto>>(json);

            comboBox_Hospital.DataSource = hospitals;
            comboBox_Hospital.DisplayMember = "hospital_name"; 
            comboBox_Hospital.ValueMember = "hospital_id";    
        }
        private void Cleardata()
        {
            foreach (var map in mappings)
            {
                map.CheckBoxLab.Checked = false;
            }

        }
        private void UpdateTotalCount(object sender, EventArgs e)
        {
            int count = mappings.Count(m => m.CheckBoxLab.Checked);
            label_Selected_Count.Text = count.ToString();
            btn_Send_Request.Enabled = count > 0;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Cleardata();
        }

        private async void btn_Send_Request_Click(object sender, EventArgs e)
        {
            if (AppSession.SelectedPatient == null)
            {
                MessageBox.Show("Please select patient first");
                return;
            }
            var request = new Req_ExtCreateDto
            {
                hn = AppSession.SelectedPatient.hn,
                emp_id = AppSession.EmpId,
                lab_req_date = DateTime.Now,
                hospital_id = comboBox_Hospital.SelectedValue.ToString(),
                details = new List<Lab_ReqDetailDto>()
            };

            foreach (var map in mappings)
            {
                if (!map.CheckBoxLab.Checked) continue;

                request.details.Add(new Lab_ReqDetailDto
                {
                    lab_test_id = map.Lab_TestID,
                    other = map.LabOtherTextBox != null && !string.IsNullOrWhiteSpace(map.LabOtherTextBox.Text) ? map.LabOtherTextBox.Text : null,
                    examtp = null,
                });
            }

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("req_exts/", content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Send request failed");
                return;
            }

            MessageBox.Show("Request External Hospital sent successfully");
            Cleardata();
        }
    }
}
