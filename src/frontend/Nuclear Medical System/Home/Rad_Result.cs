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
using Newtonsoft.Json;
using Home.Common;
using System.IO;

namespace Home
{
    public partial class Rad_Result : Form
    {
        public Rad_Result()
        {
            InitializeComponent();
        }
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8000/")
        };
        public static event Action SelectedPatientChanged;

        private async void Rad_Result_Load(object sender, EventArgs e)
        {
            leftsidebarControl.SetActiveMenu(SidebarMenu.Result);
            headerControl.RefreshFromSession();
            leftsidebarControl.RefreshFromSession();
            dataGrid_Result.AutoGenerateColumns = false;
            dataGrid_Result.Columns.Clear();
            dataGrid_Result.SelectionChanged += DataGrid_Result_SelectionChanged;

            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "rad_res_id",
                HeaderText = "Result ID",
                DataPropertyName = "rad_res_id",
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
                HeaderText = "Machine",
                DataPropertyName = "machine_name"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Result Date",
                DataPropertyName = "rad_res_date"
            });
            dataGrid_Result.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "rad_res_status"
            });
            await LoadRadResultsAsync();
            AppSession.SelectedPatientChanged += PatientChanged;
        }
        private async Task LoadRadResultsAsync()
        {
            try
            {
                if (AppSession.SelectedPatient == null ||
                string.IsNullOrWhiteSpace(AppSession.SelectedPatient.hn))
                {
                    dataGrid_Result.DataSource = null;
                    return;
                }

                var response = await client.GetAsync(
                    $"rad_results/?hn={AppSession.SelectedPatient.hn}"
                );

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Cannot load radiology results");
                    return;
                }

                string json = await response.Content.ReadAsStringAsync();
                var radResults = JsonConvert.DeserializeObject<List<RadResultDto>>(json);

                dataGrid_Result.DataSource = radResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void PatientChanged()
        {
            await LoadRadResultsAsync();
        }
        private async void DataGrid_Result_SelectionChanged(object sender, EventArgs e)
        {
            var item = dataGrid_Result.CurrentRow?.DataBoundItem as RadResultDto;
            if (item == null)
            {
                panel_Detail.Visible = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(item.rad_res_id)) return;
            await LoadRadResultDetail(item.rad_res_id);
        }
        private async Task LoadRadResultDetail(string radResID)
        {
            try
            {
                var response = await client.GetAsync($"rad_results/{radResID}");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                var detail = JsonConvert.DeserializeObject<Rad_ResultDetailDto>(json);
                panel_Detail.Visible = true;
                label_Result_Findings.Text = detail.rad_res_findings_text;
                label_Result_Impression.Text = detail.rad_res_impression;
                pictureBox_Result.Image = null;
                if (!string.IsNullOrEmpty(detail.rad_res_image))
                {

                    await LoadImageAsync(detail.rad_res_image);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadImageAsync(string imageUrl)
        {
            try
            {
                using (var http = new HttpClient())
                {
                    http.DefaultRequestHeaders.UserAgent.ParseAdd(
                        "Mozilla/5.0 (Windows NT 10.0; Win64; x64)"
                    );

                    var bytes = await http.GetByteArrayAsync(imageUrl);

                    using (var ms = new MemoryStream(bytes))
                    {
                        pictureBox_Result.Image = Image.FromStream(ms);
                        pictureBox_Result.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load image failed: " + ex.Message);
                pictureBox_Result.Image = null;
            }
        }
    }
}
