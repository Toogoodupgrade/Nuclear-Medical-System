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
using System.Net.Http;
using static Home.Patient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Home.Common;

namespace Home
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
            text_Search.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            text_Search.AutoCompleteSource = AutoCompleteSource.CustomSource;
            text_Search.Multiline = false;
            text_Search.AutoCompleteCustomSource = new AutoCompleteStringCollection();
        }

        public string HN
        {
            get => label_HN.Text;
            set => label_HN.Text = value;
        }
        public string pt_FName
        {
            get => label_pt_FName.Text;
            set => label_pt_FName.Text = value;
        }
        public string pt_LName
        {
            get => label_pt_LName.Text;
            set => label_pt_LName.Text = value;
        }
        public string pt_Gender
        {
            get => label_pt_Gender.Text;
            set => label_pt_Gender.Text = value;
        }
        public DateTime? DateOfBirth
        {
            set
            {
                if (value.HasValue)
                {
                    int age = DateTime.Now.Year - value.Value.Year;
                    label_pt_Age.Text = age.ToString();
                }
                else
                {
                    label_pt_Age.Text = "";
                }
            }
        }

        public string pt_Tel
        {
            get => label_pt_Tel.Text;
            set => label_pt_Tel.Text = value;
        }
        public string pt_Level
        {
            get => label_pt_level.Text;
            set => label_pt_level.Text = value;
        }
        public string pt_Right
        {
            get => label_pt_Right.Text;
            set => label_pt_Right.Text = value;
        }
        public string pt_Medical_Condition
        {
            get => label_pt_MedicalCondition.Text;
            set => label_pt_MedicalCondition.Text = value;
        }

        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8000/")
        };

        private async void text_Search_TextChanged(object sender, EventArgs e)
        {
            if (text_Search.Text.Length < 1)
            {
                list_SearchResult.Visible = false;
                return;
            }
            try
            {
                var responseSearch = await client.GetAsync(
                    $"patients/search?q={text_Search.Text}");
                if (!responseSearch.IsSuccessStatusCode) return;

                string json = await responseSearch.Content.ReadAsStringAsync();
                var patients = JsonConvert.DeserializeObject<List<PatientSearchDto>>(json);

                list_SearchResult.Items.Clear();

                foreach (var p in patients)
                {
                    list_SearchResult.Items.Add(p);
                }

                list_SearchResult.DisplayMember = "DisplayText";
                list_SearchResult.Visible = patients.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_Clear_Pt_Click(object sender, EventArgs e)
        {
            ClearPatient();
            AppSession.SetSelectedPatient(null);
        }
        private async void text_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && list_SearchResult.Items.Count > 0)
            {
                var p = list_SearchResult.Items[0] as PatientSearchDto;
                if (p == null) return;

                var patient = await LoadPatientByHN(p.hn);
                if (patient != null)
                {
                    list_SearchResult.Visible = false;
                    CurrentPatientSelected(patient);
                    text_Search.Clear();
                }
            }
        }

        private async void label_Search_Click(object sender, EventArgs e)
        {
            if (list_SearchResult.Items.Count > 0)
            {
                var p = list_SearchResult.Items [0] as PatientSearchDto;
                if (p == null) return;

                var patient = await LoadPatientByHN(p.hn);
                if (patient != null)
                {
                    list_SearchResult.Visible = false;
                    CurrentPatientSelected(patient);
                    text_Search.Clear();
                }
            }
        }

        private async void list_SearchResult_Click(object sender, EventArgs e)
        {
            if (list_SearchResult.SelectedItem is PatientSearchDto p)
            {
                var patient = await LoadPatientByHN(p.hn);
                if (patient != null)
                {
                    list_SearchResult.Visible = false;
                    CurrentPatientSelected(patient);
                    text_Search.Clear();
                }
            }
        }
        private async Task<PatientDto> LoadPatientByHN(string hn)
        {
            var response = await client.GetAsync($"patients/{hn}");
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Patient not found");
                return null;
            }

            string json = await response.Content.ReadAsStringAsync();
            var patient = JsonConvert.DeserializeObject<PatientDto>(json);

            ShowPatient(patient);
            return patient;
        }

        public void RefreshFromSession()
        {
            if (AppSession.SelectedPatient != null)
            {
                ShowPatient(AppSession.SelectedPatient);
            }
            else
            {
                ClearPatient();
            }
        }
        private void ShowPatient(PatientDto p)
        {
            HN = p.hn;
            pt_FName = p.pt_fname;
            pt_LName = p.pt_lname;
            pt_Gender = p.pt_gender;
            pt_Tel = p.pt_tel;
            DateOfBirth = p.pt_dob;
            pt_Right = p.right_name;
            pt_Level = p.pt_level;
            pt_Medical_Condition = p.pt_medical_condition;
        }
        private void ClearPatient()
        {
            text_Search.Clear();
            list_SearchResult.Items.Clear();
            list_SearchResult.Visible = false;
            HN = "";
            pt_FName = "";
            pt_LName = "";
            pt_Gender = "";
            pt_Tel = "";
            pt_Level = "";
            pt_Right = "";
            pt_Medical_Condition = "";
            label_pt_Age.Text = "-";
        }
        private void CurrentPatientSelected(PatientDto patient)
        {
            AppSession.SetSelectedPatient(patient);
        }
    }
}
