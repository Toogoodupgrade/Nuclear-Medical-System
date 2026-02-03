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
    public partial class Lab_Req_Immunology : Form
    {
        List<LabTestCheckboxMap> mappings;
        public Lab_Req_Immunology()
        {
            InitializeComponent();
            mappings = new List<LabTestCheckboxMap>
            {
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Cryptococcal,
                    Lab_TestID = "lab_ts0001"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Cold_agg,
                    Lab_TestID = "lab_ts0002"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_E_Histoly,
                    Lab_TestID = "lab_ts0003"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Galactomannan,
                    Lab_TestID = "lab_ts0004"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Helicobacter_IgG,
                    Lab_TestID = "lab_ts0005"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Helicobacter_igM,
                    Lab_TestID = "lab_ts0006"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Latex_agg,
                    Lab_TestID = "lab_ts0007"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Leptospirosis_IgG,
                    Lab_TestID = "lab_ts0008"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Leptospirosis_IFA,
                    Lab_TestID = "lab_ts0009"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Melliod,
                    Lab_TestID = "lab_ts0010"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Mycoplasma,
                    Lab_TestID = "lab_ts0011"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Mycoplasma,
                    Lab_TestID = "lab_ts0012"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Scrub_typhus_Rapid,
                    Lab_TestID = "lab_ts0013"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Scrub_typhus_IFA,
                    Lab_TestID = "lab_ts0014"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_S_typhi,
                    Lab_TestID = "lab_ts0015"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Toxoplasma_IgG,
                    Lab_TestID = "lab_ts0016"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Toxoplasma_IgM,
                    Lab_TestID = "lab_ts0017"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_TPHA,
                    Lab_TestID = "lab_ts0018"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_VDRL,
                    Lab_TestID = "lab_ts0141"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Widal,
                    Lab_TestID = "lab_ts0142"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Infect_Weil,
                    Lab_TestID = "lab_ts0143"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Viral_HIV,
                    Lab_TestID = "lab_ts0019"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Viral_Dengue,
                    Lab_TestID = "lab_ts0020"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Viral__Entero_Antigen,
                    Lab_TestID = "lab_ts0021"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Viral_Entero_IgM,
                    Lab_TestID = "lab_ts0022"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Viral_Influenza,
                    Lab_TestID = "lab_ts0023"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Viral_RSV,
                    Lab_TestID = "lab_ts0024"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Viral_Rota,
                    Lab_TestID = "lab_ts0025"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Allergy_IgE,
                    Lab_TestID = "lab_ts0026"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Allergy_food,
                    Lab_TestID = "lab_ts0027"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Allergy_inhalation,
                    Lab_TestID = "lab_ts0028"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Allergy_Other,
                    LabOtherTextBox = textBox_Allergy_Other,
                    Lab_TestID = "lab_ts0029"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Torch_IgG,
                    Lab_TestID = "lab_ts0030"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Torch_IgM,
                    Lab_TestID = "lab_ts0031"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_ANA,
                    Lab_TestID = "lab_ts0032"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_pANCA,
                    Lab_TestID = "lab_ts0033"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_cANCA,
                    Lab_TestID = "lab_ts0034"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_dsDNA,
                    Lab_TestID = "lab_ts0035"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_Smith,
                    Lab_TestID = "lab_ts0036"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_AMA,
                    Lab_TestID = "lab_ts0037"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_nRNP,
                    Lab_TestID = "lab_ts0038"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_Scl70,
                    Lab_TestID = "lab_ts0039"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_ASM,
                    Lab_TestID = "lab_ts0040"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Auto_cardiolipin,
                    Lab_TestID = "lab_ts0041"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Tumor_AFP,
                    Lab_TestID = "lab_ts0042"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Tumor_CEA,
                    Lab_TestID = "lab_ts0043"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Tumor_CA12,
                    Lab_TestID = "lab_ts0044"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Tumor_CA15,
                    Lab_TestID = "lab_ts0045"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Tumor_CA19,
                    Lab_TestID = "lab_ts0046"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Tumor_PSA,
                    Lab_TestID = "lab_ts0047"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Tumor_Beta,
                    Lab_TestID = "lab_ts0048"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_Hiv_Viral,
                    Lab_TestID = "lab_ts0049"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_Hiv_Drug,
                    Lab_TestID = "lab_ts0050"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_Hiv_PCR,
                    Lab_TestID = "lab_ts0051"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_HBV_Viral,
                    Lab_TestID = "lab_ts0052"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_HBV_Genotype,
                    Lab_TestID = "lab_ts0053"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_Influenza,
                    Lab_TestID = "lab_ts0054"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_MTB,
                    Lab_TestID = "lab_ts0055"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_MDR,
                    Lab_TestID = "lab_ts0056"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_T_Cell,
                    Lab_TestID = "lab_ts0057"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Molecular_Other,
                    LabOtherTextBox = textBox_Molecular_Other,
                    Lab_TestID = "lab_ts0058"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Immumo_Cyclosporin,
                    Lab_TestID = "lab_ts0059"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Immumo_Tacrolimus,
                    Lab_TestID = "lab_ts0060"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Immumo_Sirolimus,
                    Lab_TestID = "lab_ts0061"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_ASO,
                    Lab_TestID = "lab_ts0062"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_CRP_High,
                    Lab_TestID = "lab_ts0063"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_CRP_Full,
                    Lab_TestID = "lab_ts0064"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_C3,
                    Lab_TestID = "lab_ts0065"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_C4,
                    Lab_TestID = "lab_ts0066"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_IgG,
                    Lab_TestID = "lab_ts0067"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_IgM,
                    Lab_TestID = "lab_ts0068"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_IgA,
                    Lab_TestID = "lab_ts0069"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Specific_RF,
                    Lab_TestID = "lab_ts0070"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HAV_IgG,
                    Lab_TestID = "lab_ts0071"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HAV_igM,
                    Lab_TestID = "lab_ts0072"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HBsAG_Quan,
                    Lab_TestID = "lab_ts0073"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HBsAg,
                    Lab_TestID = "lab_ts0074"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HBs,
                    Lab_TestID = "lab_ts0075"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HBs_total,
                    Lab_TestID = "lab_ts0076"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HBc_IgM,
                    Lab_TestID = "lab_ts0077"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HBe_Ag,
                    Lab_TestID = "lab_ts0078"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HBe,
                    Lab_TestID = "lab_ts0079"
                },
                new LabTestCheckboxMap
                {
                    CheckBoxLab = checkBox_Hepatitis_HCV,
                    Lab_TestID = "lab_ts0080"
                },
            };
            foreach (var map in mappings)
            {
                if (map.LabOtherTextBox != null)
                {
                    map.LabOtherTextBox.Enabled = false;
                    map.CheckBoxLab.CheckedChanged += CheckBox_WithOther_CheckedChanged;
                }
            }
            foreach (var map in mappings)
            {
                map.CheckBoxLab.CheckedChanged += UpdateTotalCount;
            }
        }

        private void Lab_Req_Immunology_Load(object sender, EventArgs e)
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
                if (map.CheckBoxLab.Checked &&
                    map.LabOtherTextBox != null &&
                    map.LabOtherTextBox.Enabled &&
                    string.IsNullOrWhiteSpace(map.LabOtherTextBox.Text))
                {
                    MessageBox.Show("Please specify Other part");
                    return;
                }
            }
            var request = new Lab_ReqCreateDto
            {
                hn = AppSession.SelectedPatient.hn,
                emp_id = AppSession.EmpId,
                lab_req_date = dateTime_Lab_Req.Value,
                details = new List<Lab_ReqDetailDto>()
            };

            List<string> examtp = new List<string>();

            foreach (Control ctrl in panel_Type_Specimen.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    switch (cb.Name)
                    {
                        case "checkBox_Type_ClotBlood":
                            examtp.Add("Clot Blood");
                            break;
                        case "checkBox_Type_CSF":
                            examtp.Add("CSF");
                            break;
                        case "checkBox_Type_EDTA":
                            examtp.Add("EDTA Blood");
                            break;
                        case "checkBox_Type_CitrateBlood":
                            examtp.Add("Citrate Blood");
                            break; 
                        case "checkBox_Type_Stool":
                            examtp.Add("Stool");
                            break;
                        case "checkBox_Type_CordBlood":
                            examtp.Add("Cord Blood");
                            break;
                        case "checkBox_Type_ThroatSwab":
                            examtp.Add("Throat swab");
                            break;
                        case "checkBox_Type_Other":
                            examtp.Add(textBox_Type_Other.Text);
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

        private void Cleardata()
        {
            foreach (var map in mappings)
            {
                map.CheckBoxLab.Checked = false;
                if (map.LabOtherTextBox != null)
                {
                    map.LabOtherTextBox.Clear();
                    map.LabOtherTextBox.Enabled = false;
                }
            }
            dateTime_Lab_Req.Value = DateTime.Now;
            textBox_Type_Other.Enabled = false;
            checkBox_Type_Other.Checked = false;
            textBox_Type_Other.Clear();
            foreach (Control ctrl in panel_Type_Specimen.Controls)
            {
                if (ctrl is CheckBox cb && cb.Checked)
                {
                    cb.Checked = false;
                }
            }
        }
        private void CheckBox_WithOther_CheckedChanged(object sender, EventArgs e)
        {
            var cb = sender as CheckBox;
            if (cb == null) return;

            var map = mappings.FirstOrDefault(m => m.CheckBoxLab == cb);
            if (map?.LabOtherTextBox == null) return;

            map.LabOtherTextBox.Enabled = cb.Checked;

            if (!cb.Checked)
            {
                map.LabOtherTextBox.Clear();
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

        private void checkBox_Type_Other_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Type_Other.Checked)
            {
                textBox_Type_Other.Enabled = true;
            }
        }
    }
}
