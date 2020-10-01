using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Payfort_Testing
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var ShaReqeustVar = "91wG1283xoSln4Db9Y7IPZ&?";

            var myArray = new Dictionary<string, string>();
            myArray.Add("access_code", "a9U2M7lKbzlSOKzkyMli");
            myArray.Add("amount", "10000");
            myArray.Add("command", "PURCHASE");
            myArray.Add("currency", "SAR");           
            myArray.Add("customer_email", "m.saad@gama-ksa.com");
            myArray.Add("language", "en");
            myArray.Add("merchant_identifier", "957fafda");
            myArray.Add("merchant_reference", "XYX8239-yu898");
            myArray.Add("return_url", "https://www.eumra.com/login.aspx");
            
            // myArray.Add("order_description", "iPhone 6-S");
            //myArray.Add("payment_option", "VISA");


            var baseString = "";

            foreach (var item in myArray)
            {
                baseString += item.Key + "=" + item.Value;
            }

            var shastring = ShaReqeustVar + baseString + ShaReqeustVar;
            var shaPhrase = SHA256Util.sha256_hash(shastring);
        }

      
    }
}