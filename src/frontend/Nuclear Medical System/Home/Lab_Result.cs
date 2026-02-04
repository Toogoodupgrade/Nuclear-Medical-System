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
    public partial class Lab_Result : Form
    {
        public Lab_Result()
        {
            InitializeComponent();
        }
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8000/")
        };

        private async void Lab_Result_Immunology_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Result);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
            dataGrid_Result.AutoGenerateColumns = false;
            dataGrid_Result.Columns.Clear();
            dataGrid_Result.SelectionChanged += DataGrid_Result_SelectionChanged;

            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "lab_res_id",
                HeaderText = "Result ID",
                DataPropertyName = "lab_res_id",
                Visible = false,
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "HN",
                DataPropertyName = "hn"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Patinet First Name",
                DataPropertyName = "pt_fname"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Patinet Last Name",
                DataPropertyName = "pt_lname"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Examiner First Name",
                DataPropertyName = "emp_fname"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Examiner last Name",
                DataPropertyName = "emp_lname"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Test",
                DataPropertyName = "lab_test_name"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Test Category",
                DataPropertyName = "lab_test_category"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Test Category",
                DataPropertyName = "lab_test_category"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Examination Type",
                DataPropertyName = "examtp"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Method",
                DataPropertyName = "method"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Container",
                DataPropertyName = "container"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Volume",
                DataPropertyName = "volume"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Result Date",
                DataPropertyName = "lab_res_date"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "lab_res_status"
            });

            await LoadLabResultsAsync();
            AppSession.SelectedPatientChanged += PatientChanged;
        }
        private async Task LoadLabResultsAsync()
        {
            if (AppSession.SelectedPatient == null ||
                string.IsNullOrWhiteSpace(AppSession.SelectedPatient.hn))
            {
                dataGrid_Result.DataSource = null;
                return;
            }

            try
            {
                var response = await client.GetAsync(
                $"lab_results/?hn={AppSession.SelectedPatient.hn}"
            );

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cannot load laboratory results");
                    return;
                }

                string json = await response.Content.ReadAsStringAsync();
                var labResults = JsonConvert.DeserializeObject<List<Lab_ResultDto>>(json);

                dataGrid_Result.DataSource = labResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void PatientChanged()
        {
            await LoadLabResultsAsync();
        }
        private async void DataGrid_Result_SelectionChanged(object sender, EventArgs e)
        {
            var item = dataGrid_Result.CurrentRow?.DataBoundItem as Lab_ResultDto;
            if (item == null)
            {
                panel_Detail.Visible = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(item.lab_res_id)) return;
            await LoadLabResultDetail(item.lab_res_id);
        }
        private async Task LoadLabResultDetail(string labResID)
        {
            try
            {
                var response = await client.GetAsync($"lab_results/{labResID}");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var detail = JsonConvert.DeserializeObject<Lab_ResultDetailDto>(json);
                panel_Detail.Visible = true;
                label_Diagnosis.Text = detail.lab_res_diagnosis;
                label_Summary.Text = detail.lab_res_summary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
