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
    public partial class Lab_Req_Pathology : Form
    {
        List<LabTestCheckboxMap> mappings;
        public Lab_Req_Pathology()
        {
            InitializeComponent();
            mappings = new List<LabTestCheckboxMap> 
            {
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Routine_Blood_Sugar,
                    Lab_TestID = "lab_ts0081"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Routine_HB_A1C,
                    Lab_TestID = "lab_ts0082"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Routine_Bun,
                    Lab_TestID = "lab_ts0083"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Routine_Creatinine,
                    Lab_TestID = "lab_ts0084"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Electrolyte_Sodium,
                    Lab_TestID = "lab_ts0085"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Electrolyte_Potassium,
                    Lab_TestID = "lab_ts0086"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Electrolyte_Chloride,
                    Lab_TestID = "lab_ts0087"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Electrolyte_CO2,
                    Lab_TestID = "lab_ts0088"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_BodyFluid_Sugar,
                    Lab_TestID = "lab_ts0089"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_BodyFluid_Protein,
                    Lab_TestID = "lab_ts0090"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_BodyFluid_LDH,
                    Lab_TestID = "lab_ts0091"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_BodyFluid_Albumin,
                    Lab_TestID = "lab_ts0092"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_BodyFluid_ADA,
                    Lab_TestID = "lab_ts0093"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Transferin,
                    Lab_TestID = "lab_ts0094"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Transferin,
                    Lab_TestID = "lab_ts0094"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Calcium,
                    Lab_TestID = "lab_ts0095"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Phophorus,
                    Lab_TestID = "lab_ts0096"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Magnesium,
                    Lab_TestID = "lab_ts0097"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Urine_Acid,
                    Lab_TestID = "lab_ts0098"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Amylase,
                    Lab_TestID = "lab_ts0099"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Lipase,
                    Lab_TestID = "lab_ts0100"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Gamma_GT,
                    Lab_TestID = "lab_ts0101"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_LHD,
                    Lab_TestID = "lab_ts0102"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_CPK,
                    Lab_TestID = "lab_ts0103"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Lactate,
                    Lab_TestID = "lab_ts0104"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Serum_Ketone,
                    Lab_TestID = "lab_ts0105"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Iron,
                    Lab_TestID = "lab_ts0106"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_TIBC,
                    Lab_TestID = "lab_ts0107"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Special_Ferritin,
                    Lab_TestID = "lab_ts0108"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_Free_T4,
                    Lab_TestID = "lab_ts0109"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_Free_T3,
                    Lab_TestID = "lab_ts0110"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_TSH,
                    Lab_TestID = "lab_ts0111"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_Prolactin,
                    Lab_TestID = "lab_ts0112"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_LH,
                    Lab_TestID = "lab_ts0113"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_FSH,
                    Lab_TestID = "lab_ts0114"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_E2,
                    Lab_TestID = "lab_ts0115"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_Testosterone,
                    Lab_TestID = "lab_ts0117"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_Cortisol,
                    Lab_TestID = "lab_ts0118"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_CK_MB,
                    Lab_TestID = "lab_ts0119"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_Troponin,
                    Lab_TestID = "lab_ts0120"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hormone_IPTH,
                    Lab_TestID = "lab_ts0121"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Urine_Protein,
                    Lab_TestID = "lab_ts0122"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Urine_Creatinine,
                    Lab_TestID = "lab_ts0123"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Urine_Micro_Albumin,
                    Lab_TestID = "lab_ts0124"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Urine_Osmolarity,
                    Lab_TestID = "lab_ts0125"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_Cholesterol,
                    Lab_TestID = "lab_ts0126"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_Total_Protein,
                    Lab_TestID = "lab_ts0127"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_Albunin,
                    Lab_TestID = "lab_ts0128"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_Globulin,
                    Lab_TestID = "lab_ts0129"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_D_Bilirubin,
                    Lab_TestID = "lab_ts0130"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_T_Bilirubin,
                    Lab_TestID = "lab_ts0131"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_AST,
                    Lab_TestID = "lab_ts0132"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_ALT,
                    Lab_TestID = "lab_ts0133"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_LFT_Alkalinephos,
                    Lab_TestID = "lab_ts0134"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Drug_Dilantin,
                    Lab_TestID = "lab_ts0135"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Drug_Phenobabi,
                    Lab_TestID = "lab_ts0136"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Drug_Valproic,
                    Lab_TestID = "lab_ts0137"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Drug_Vancomycin,
                    Lab_TestID = "lab_ts0138"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Drug_Carbamazipine,
                    Lab_TestID = "lab_ts0139"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Drug_Digoxin,
                    Lab_TestID = "lab_ts0140"
                },
            };
            foreach (var map in mappings)
            {
                map.CheckBoxLab.CheckedChanged += UpdateTotalCount;
            }
        }

        private void Lab_Req_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Request);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
        }
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8000/")
        };
        private async void btn_Send_Request_Click(object sender, EventArgs e)
        {
            if (AppSession.SelectedPatient == null)
            {
                MessageBox.Show("Please select patient first");
                return;
            }
            var request = new Lab_ReqCreateDto
            {
                hn = AppSession.SelectedPatient.hn,
                emp_id = AppSession.EmpId,
                lab_req_date = dateTime_Lab_Req.Value,
                details = new List<Lab_ReqDetailDto>()
            };

            List<string> examtp = new List<string>();

            foreach (Control ctrl in panel_Exam_Type.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    switch (cb.Name)
                    {
                        case "checkBox_Type_Blood":
                            examtp.Add("Blood");
                            break;
                        case "checkBox_Type_CSF":
                            examtp.Add("C.S.F");
                            break;
                        case "checkBox_Type_Ascitic":
                            examtp.Add("Ascitic");
                            break;
                        case "checkBox_Type_Pleural":
                            examtp.Add("Pleural");
                            break;
                        case "checkBox_Type_Joint":
                            examtp.Add("Joint");
                            break;
                        case "checkBox_Type_PDF":
                            examtp.Add("PDF");
                            break;
                        case "checkBox_Type_Urine":
                            examtp.Add("Urine");
                            break;
                        case "checkBox_Type_Urine24":
                            examtp.Add("Urine 24");
                            break;
                    }
                }
            }

            string examtpString = string.Join(", ", examtp);
            foreach (var map in mappings)
            {
                if (!map.CheckBoxLab.Checked) continue;

                request.details.Add(new Lab_ReqDetailDto
                {
                    lab_test_id = map.Lab_TestID,
                    other = map.LabOtherTextBox != null && !string.IsNullOrWhiteSpace(map.LabOtherTextBox.Text) ? map.LabOtherTextBox.Text : null,
                    examtp = examtpString,
                });
            }

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("lab_reqs/", content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Send request failed");
                return;
            }

            MessageBox.Show("Laboratory request sent successfully");
            Cleardata();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Cleardata();
        }
        private void Cleardata()
        {
            foreach (var map in mappings)
            {
                map.CheckBoxLab.Checked = false;
            }
            dateTime_Lab_Req.Value = DateTime.Now;
            foreach (Control ctrl in panel_Exam_Type.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    cb.Checked = false;
                }
            }
        }

        private void UpdateTotalCount(object sender, EventArgs e)
        {
            int count = mappings.Count(m => m.CheckBoxLab.Checked);
            label_Selected_Count.Text = count.ToString();
            btn_Send_Request.Enabled = count > 0;
        }

        private void btn_Send_to_External_Click(object sender, EventArgs e)
        {
            OpenForm<Request_External_Hospital>();
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
    }
}
