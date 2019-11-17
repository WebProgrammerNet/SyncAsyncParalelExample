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

namespace AsyncSyncTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            //long sum = GetSum().Result;
            //Bele yazsaq synchron olacaq await ve async yazmaq lazim deyil
            long sum = await GetSum();
            btnResult.Text = sum.ToString();

        }
        private async Task<long> GetSum()
        {
            long sum = 0;
            // Task task = Task.Run(delegate () {
            Task task = Task.Run(() =>
            {

                for (int i = 0; i < 100000000; i++)
                {
                    sum += i;
                }

            });
            await task;
            return sum;
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();

            foreach (var url in GetURL())
            {
                string response = http.GetStringAsync(url).Result;
                listBox1.Items.Add(response.Length);
            }
        }

        private string[] GetURL()
        {
            string[] result = {
                "https://www.google.com",
                "https://www.youtube.com",
                "https://best.aliexpress.com"
            };
            return result;

        }

        private async void BtnAsync_Click(object sender, EventArgs e)
        {
            HttpClient http = new HttpClient();

            foreach (var url in GetURL())
            {
                string result = await http.GetStringAsync(url);
                listBox1.Items.Add(result.Length);
            }
            
        }

        private async void BtnParalel_Click(object sender, EventArgs e)
        {
            List<Task<string>> tasksList = new List<Task<string>>();
            HttpClient http = new HttpClient();

            foreach (var url in GetURL())
            {
                tasksList.Add(http.GetStringAsync(url));
            }
           await Task.WhenAll(tasksList);

            foreach (var task in tasksList)
            {
                listBox1.Items.Add(task.Result.Length);
            }
        }
    }
}
