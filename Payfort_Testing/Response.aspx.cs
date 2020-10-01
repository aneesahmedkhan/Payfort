using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft;
using Payfort_Testing;
using System.IO;

namespace Payfort_Testing
{
    public partial class Response : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PayData paydata = new PayData
            {              
                merchant_reference = "XYX8777-yu898",
                fort_id = "169996200000132829",               
            };


          var signature=   AjaxCaller.GetVerifySignature(paydata);
            paydata.signature = signature;            

            string baseAddress = "https://sbpaymentservices.payfort.com/FortAPI/paymentApi";
            string responseStream = "";

            using (var client = new HttpClient())
            {
                // TODO - Send HTTP requests              
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject(paydata);
                HttpContent content = new StringContent(json);
                HttpResponseMessage responseNew = client.PostAsync(baseAddress, content).GetAwaiter().GetResult();
                if (responseNew.IsSuccessStatusCode)
                {
                    responseStream = responseNew.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    Console.WriteLine(responseStream);
                    txtCheckStatusResponse.Text =responseStream;                    
                }                
            }           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {             
            CheckStatusResponse objStaus = JsonConvert.DeserializeObject<CheckStatusResponse>(txtCheckStatusResponse.Text);
            var signature = AjaxCaller.VerifyReceivedCheckStatusSignature(objStaus);
            lblCheckResponseSignature.Text =signature;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            TransactionResponse objStaus = JsonConvert.DeserializeObject<TransactionResponse>(txtCheckTransactionResponse.Text);
            var signature = AjaxCaller.VerifTransactionResponseSignature(objStaus);
            lblCheckTransactionResponseSignature.Text = signature;
        }
    }   
}