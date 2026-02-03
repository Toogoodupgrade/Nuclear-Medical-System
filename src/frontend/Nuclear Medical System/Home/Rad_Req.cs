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
    public partial class Rad_Req : Form
    {
        List<RadTestCheckboxMap> mappings;

        public Rad_Req()
        {
            InitializeComponent();

            mappings = new List<RadTestCheckboxMap>
            {
                //CT_SCAN
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Brain,
                    Rad_TestID = "rad_ts1"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Orbit,
                    Rad_TestID = "rad_ts2"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Sinuses,
                    Rad_TestID = "rad_ts3"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Nasopharynx,
                    Rad_TestID = "rad_ts4"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_IAC,
                    Rad_TestID = "rad_ts5"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Pituitary,
                    Rad_TestID = "rad_ts6"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Neck,
                    Rad_TestID = "rad_ts7"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Add_Multi,
                    Rad_TestID = "rad_ts8"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Chest,
                    Rad_TestID = "rad_ts9"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Upper_Abdomen,
                    Rad_TestID = "rad_ts10"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Lower_Abdomen,
                    Rad_TestID = "rad_ts11"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Whole_Abdomen,
                    Rad_TestID = "rad_ts12"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_CTA_Coronary,
                    Rad_TestID = "rad_ts13"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Colonoscopy,
                    Rad_TestID = "rad_ts14"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_CTA,
                    OtherTextBox = textBox_CT_CTA,
                    Rad_TestID = "rad_ts15"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Other,
                    OtherTextBox = textBox_CT_Other,
                    Rad_TestID = "rad_ts16"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_C_Spine,
                    Rad_TestID = "rad_ts17"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_T_Spine,
                    Rad_TestID = "rad_ts18"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_LS_Spine,
                    Rad_TestID = "rad_ts19"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Whole_Spine,
                    Rad_TestID = "rad_ts20"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_Bone_Joint,
                    OtherTextBox = textBox_CT_Bone_Joint,
                    Rad_TestID = "rad_ts21"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_NECT,
                    Rad_TestID = "rad_ts22"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_CT_CECT,
                    OtherTextBox = textBox_CT_CECT_Quantity,
                    Rad_TestID = "rad_ts23"
                },

                //MRI
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Brain,
                    Rad_TestID = "rad_ts24"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Orbit,
                    Rad_TestID = "rad_ts25"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Sinuses,
                    Rad_TestID = "rad_ts26"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Nasopharynx,
                    Rad_TestID = "rad_ts27"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_IAC,
                    Rad_TestID = "rad_ts28"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Pituitary,
                    Rad_TestID = "rad_ts29"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Neck,
                    Rad_TestID = "rad_ts30"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Cisternnography,
                    Rad_TestID = "rad_ts31"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Hippocampus,
                    Rad_TestID = "rad_ts32"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Cranial_nerve,
                    Rad_TestID = "rad_ts33"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Chest,
                    Rad_TestID = "rad_ts34"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Upper_Abdomen,
                    Rad_TestID = "rad_ts35"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Lower_Abdomen,
                    Rad_TestID = "rad_ts36"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Whole_Abdomen,
                    Rad_TestID = "rad_ts37"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Breast,
                    Rad_TestID = "rad_ts38"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Brachial,
                    Rad_TestID = "rad_ts39"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_MRCP_Upper,
                    Rad_TestID = "rad_ts55"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Prostate,
                    Rad_TestID = "rad_ts56"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_C_Spine,
                    Rad_TestID = "rad_ts40"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_T_Spine,
                    Rad_TestID = "rad_ts41"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_LS_Spine,
                    Rad_TestID = "rad_ts42"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Whole_Spine,
                    Rad_TestID = "rad_ts43"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_MRI_CSF,
                    OtherTextBox = textBox_MRI_MRI_CSF,
                    Rad_TestID = "rad_ts44"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Bone_Joint,
                    OtherTextBox = textBox_MRI_Bone_Joint,
                    Rad_TestID = "rad_ts45"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_MRA,
                    OtherTextBox = textBox_MRI_MRA,
                    Rad_TestID = "rad_ts46"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_MRV,
                    OtherTextBox = textBox_MRI_MRV,
                    Rad_TestID = "rad_ts47"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_MRI_MRA,
                    OtherTextBox = textBox_MRI_MRI_MRA,
                    Rad_TestID = "rad_ts48"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_MRA_MRV,
                    OtherTextBox = textBox_MRI_MRA_MRV,
                    Rad_TestID = "rad_ts49"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_MRI_MRA_MRV,
                    OtherTextBox = textBox_MRI_MRI_MRA_MRV,
                    Rad_TestID = "rad_ts50"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Other,
                    OtherTextBox = textBox_MRI_Other,
                    Rad_TestID = "rad_ts51"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Gadolinium,
                    Rad_TestID = "rad_ts52"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Gadovist,
                    Rad_TestID = "rad_ts53"
                },
                new RadTestCheckboxMap
                {
                    CheckBox = checkBox_MRI_Primovist,
                    Rad_TestID = "rad_ts54"
                },

            };

            foreach (var map in mappings)
            {
                if (map.OtherTextBox != null)
                {
                    map.OtherTextBox.Enabled = false; 
                    map.CheckBox.CheckedChanged += CheckBox_WithOther_CheckedChanged;
                }
            }
            foreach (var map in mappings)
            {
                map.CheckBox.CheckedChanged += UpdateTotalCount;
            }
        }

        private void Rad_Req_Load(object sender, EventArgs e)
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
            foreach (var map in mappings)
            {
                if (map.CheckBox.Checked &&
                    map.OtherTextBox != null &&
                    map.OtherTextBox.Enabled &&
                    string.IsNullOrWhiteSpace(map.OtherTextBox.Text))
                {
                    MessageBox.Show("Please specify Other part");
                    return;
                }
            }
            var request = new Rad_ReqCreateDto
            {
                hn = AppSession.SelectedPatient.hn,
                emp_id = AppSession.EmpId,
                rad_req_date = dateTime_Rad_Req.Value,
                rad_req_impression = textBox_Impression.Text,
                rad_req_history = textBox_History.Text,
                rad_req_urgency_level = radioButton_Urgent.Checked ? "urgent" : "normal",
                details = new List<Rad_ReqDetailDto>()
            };

            List<string> precautions = new List<string>();

            foreach (Control ctrl in panel_Precaution.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    switch (cb.Name)
                    {
                        case "checkBox_PreCaution_Pacemaker":
                            precautions.Add("PaceMaker");
                            break;
                        case "checkBox_PreCaution_Aneurysm":
                            precautions.Add("Aneurysm");
                            break;
                        case "checkBox_PreCaution_Valve_Pro":
                            precautions.Add("Valve Prosthesis");
                            break;
                        case "checkBox_PreCaution_metallic":
                            precautions.Add("Metallic Implant");
                            break;
                    }
                }
            }

            string precautionString = string.Join(", ", precautions);
            foreach (var map in mappings)
            {
                if (!map.CheckBox.Checked) continue;

                request.details.Add(new Rad_ReqDetailDto
                {
                    rad_test_id = map.Rad_TestID,
                    otherpart = map.OtherTextBox != null && !string.IsNullOrWhiteSpace(map.OtherTextBox.Text)? map.OtherTextBox.Text: null,
                    precaution = precautionString
                });
            }

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("rad_reqs/", content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Send request failed");
                return;
            }

            MessageBox.Show("Radiology request sent successfully");
            Cleardata();
        }
       
        private void btn_Combo_Clear_Click(object sender, EventArgs e)
        {
            Cleardata();
        }
        private void Cleardata()
        {
            foreach (var map in mappings)
            {
                if (map.CheckBox.Parent == panel_MRI)
                {
                    map.CheckBox.Checked = false;
                    map.OtherTextBox?.Clear();
                }
                if (map.CheckBox.Parent == panel_CTSCAN)
                {
                    map.CheckBox.Checked = false;
                    map.OtherTextBox?.Clear();
                }
            }
            foreach (Control ctrl in panel_Precaution.Controls)
            {
                if (ctrl is CheckBox cb)
                {
                    cb.Checked = false;
                }
            }
            radioButton_Urgent.Checked = false;
            radioButton_Normal.Checked = true;
            textBox_Impression.Clear();
            textBox_History.Clear();
            dateTime_Rad_Req.Value = DateTime.Now;
        }
        private void CheckBox_WithOther_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            if (cb == null) return;

            var map = mappings.FirstOrDefault(m => m.CheckBox == cb);
            if (map?.OtherTextBox == null) return;

            map.OtherTextBox.Enabled = cb.Checked;

            if (!cb.Checked)
            {
                map.OtherTextBox.Clear();
            }
        }
        private void UpdateTotalCount(object sender,EventArgs e)
        {
            int count = mappings.Count(m => m.CheckBox.Checked);
            label_Selected_Count.Text = count.ToString();
            btn_Send_Request.Enabled = count > 0;
        }
    }
}
