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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8000/")
        };

        private async void button_Login_Click(object sender, EventArgs e)
        {
            if ((text_Username.Text == null | text_Username.Text == "") && 
                (text_Password.Text == null | text_Password.Text == ""))
            {
                MessageBox.Show("Please enter username or password first");
                return;
            }

            var request = new LoginDto
            {
                emp_fname = text_Username.Text,
                password = text_Password.Text,
            };

            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("employees/login", content);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Login failed");
                return;
            }
            var responseJson = await response.Content.ReadAsStringAsync();
            var emp = JsonConvert.DeserializeObject<LoginResponseDto>(responseJson);
            AppSession.setCurrentEmp(emp);

            OpenForm<MainForm>();
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

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
