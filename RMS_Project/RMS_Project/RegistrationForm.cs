﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Json;
using Newtonsoft.Json.Linq;

namespace RMS_Project
{
    public partial class RegistrantionForm : Form
    {
        public RegistrantionForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comfirmButton(object sender, EventArgs e)
        {
            PostProduct();
            LoginForm lgf = new LoginForm();
            this.Hide();
            lgf.Show();
        }

        private async void PostProduct()
        {
            JObject jObject = new JObject();
            jObject["name"] = userName.Text;
            jObject["email"] = email.Text;
            jObject["password"] = password.Text;

            HttpClient client = new HttpClient();

            HttpResponseMessage response;
            Console.WriteLine(jObject.ToString());
            var httpClient = new HttpClient();
            try
            {
                response = await httpClient.PostAsync("http://140.124.183.32:3000/user/register", new StringContent(jObject.ToString(), Encoding.UTF8, "application/json"));
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine(content);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
