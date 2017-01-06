using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace MultipleInstanceApiTest
{


    public partial class Form1 : Form
    {
        private readonly RestClient _client;



        public Form1()
        {
            InitializeComponent();
            _client = new RestClient(txtURL.Text);
        }

        List<string> AssetId = new List<string>();
        Random rand = new Random(1);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(txtInstances.Text); i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(CallAPIService));
                thread.Start(i);
            }
        }

        public void CallAPIService(object intanceName)
        {
            for (int i = 0; i < Convert.ToInt32(txtNoOfAssets.Text); i++)
            {
                var request = RestRequest();
                var alreadyAdded = false;
                var response = "Error/No Response";

                try
                {
                    if (rbAiringId.Checked)
                    {
                        var data = _client.Execute<AssetIdModel>(request).Data;

                        response = data.AiringId + "  " + data.Version ?? string.Empty;

                        alreadyAdded = AssetId.Contains(response);

                        if (!alreadyAdded)
                        {
                            AssetId.Add(response);
                        }
                    }
                    if (rbHealthCheck.Checked)
                    {
                        response = _client.Execute<HealthCheckModel>(request).Data.Version;
                    }
                }
                catch
                {

                }
                Invoke(new Action(() => ChangeRichText(response, alreadyAdded)));
            }
        }

        private void ChangeRichText(string response, bool isDuplicate)
        {
            if (response == null) return;

            richTextBox1.AppendText(response + "\n");

            if (isDuplicate)
            {
                richTextBox1.Find(response); //Find the text provided
                richTextBox1.SelectionColor = Color.Red;
            }
        }

        private RestRequest RestRequest()
        {
            RestRequest request = null;

            if (rbAiringId.Checked)
                request = new RestRequest("/v1/airingId/generate/{prefix}?rand={randomnumber}");
            if (rbHealthCheck.Checked)
                request = new RestRequest("/v1/healthcheck?rand={randomnumber}");

            request.AddHeader("Authorization", "bfcccc7c-97af-4975-96f2-4c40b783685f");
            request.RequestFormat = DataFormat.Json;
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.Method = Method.GET;
            request.AddUrlSegment("prefix", txtPrefix.Text);
            request.AddUrlSegment("randomnumber", rand.Next(100000000).ToString());

            return request;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            AssetId.Clear();
        }
    }
}
