using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Payfort_Testing;

namespace Payfort_Testing
{
    public partial class AjaxCaller : System.Web.UI.Page
    {
        string JSonOutput;

        protected void Page_Load(object sender, EventArgs e)
        {           
            payfortParams objMaster = new payfortParams();           
            JSonOutput = GetSignature(objMaster);             
        }
      

        [WebMethod]
        [ScriptMethod]
        public static string GetSignature(payfortParams objMaster)
        {
            try
            {
                var ShaReqeustVar = "91wG1283xoSln4Db9Y7IPZ&?";
                var myArray = new Dictionary<string, string>();
                myArray.Add("access_code", "a9U2M7lKbzlSOKzkyMli");
                //myArray.Add("amount", Convert.ToString(Convert.ToDouble(objMaster.amount) *100) );
                myArray.Add("amount", Convert.ToString(Convert.ToDouble(objMaster.amount)));
                myArray.Add("command", "PURCHASE");
                myArray.Add("currency", objMaster.currency);
                myArray.Add("customer_email", objMaster.customer_email);
                myArray.Add("language", "en");
                myArray.Add("merchant_identifier", "957fafda");
                myArray.Add("merchant_reference", objMaster.merchant_reference);
                myArray.Add("order_description", "iPhone 6-S");
                myArray.Add("payment_option",objMaster.payment_option);
                myArray.Add("return_url", "http://payfort.eumra.com/Default.aspx");               
                //myArray.Add("return_url", "http://127.0.0.1:17040/Response.aspx");



                var baseString = "";

                foreach (var item in myArray)
                {
                    baseString += item.Key + "=" + item.Value;
                }

                var shastring = ShaReqeustVar + baseString + ShaReqeustVar;
                var shaPhrase = SHA256Util.sha256_hash(shastring);
                return shaPhrase;
            }
            catch
            {
                return "";
            }
        }

        [WebMethod]
        [ScriptMethod]
        public static string GetVerifySignature(PayData objMaster)
        {
            try
            {
                var ShaReqeustVar = "91wG1283xoSln4Db9Y7IPZ&?";
                var myArray = new Dictionary<string, string>();
                myArray.Add("access_code", "a9U2M7lKbzlSOKzkyMli");
                myArray.Add("fort_id", objMaster.fort_id);
                myArray.Add("language", "en");
                myArray.Add("merchant_identifier", "957fafda");
                myArray.Add("merchant_reference", objMaster.merchant_reference);               
                myArray.Add("query_command", "CHECK_STATUS");

                 var baseString = "";

                foreach (var item in myArray)
                {
                    baseString += item.Key + "=" + item.Value;
                }

                var shastring = ShaReqeustVar + baseString + ShaReqeustVar;
                var shaPhrase = SHA256Util.sha256_hash(shastring);
                return shaPhrase;
            }
            catch
            {
                return "";
            }
        }


        [WebMethod]
        [ScriptMethod]
        public static string VerifyReceivedCheckStatusSignature(CheckStatusResponse objMaster)
        {
            try
            {
                var ShaResponseVar = "344Jy6x7XCNKxsPuFe20n/_-";
                var myArray = new Dictionary<string, string>();
                myArray.Add("access_code", "a9U2M7lKbzlSOKzkyMli");
                myArray.Add("authorized_amount", objMaster.authorized_amount);
                myArray.Add("captured_amount", objMaster.captured_amount);
                myArray.Add("fort_id", objMaster.fort_id);
                myArray.Add("language", "en");
                myArray.Add("merchant_identifier", "957fafda");
                myArray.Add("merchant_reference", objMaster.merchant_reference);
                myArray.Add("query_command", objMaster.query_command);
                myArray.Add("refunded_amount", objMaster.refunded_amount);
                myArray.Add("response_code", objMaster.response_code);
                myArray.Add("response_message", objMaster.response_message);
                // myArray.Add("signature", objMaster.signature);
                myArray.Add("status", objMaster.status);
                myArray.Add("transaction_code", objMaster.transaction_code);
                myArray.Add("transaction_message", objMaster.transaction_message);
                myArray.Add("transaction_status", objMaster.transaction_status); 

        var baseString = "";

                foreach (var item in myArray)
                {
                    baseString += item.Key + "=" + item.Value;
                }

                var shastring = ShaResponseVar + baseString + ShaResponseVar;
                var shaPhrase = SHA256Util.sha256_hash(shastring);

                if(objMaster.signature == shaPhrase) { return "Verified"; } else { return "Signature Mismatch"; }
                 
            }
            catch
            {
                return "";
            }
        }

        
        [WebMethod]
        [ScriptMethod]
        public static string VerifTransactionResponseSignature(TransactionResponse objMaster)
        {
            try
            {
                var ShaResponseVar = "344Jy6x7XCNKxsPuFe20n/_-";
                var myArray = new Dictionary<string, string>();
                myArray.Add("access_code", "a9U2M7lKbzlSOKzkyMli");
                myArray.Add("amount", objMaster.amount);
                myArray.Add("authorization_code", objMaster.authorization_code);
                myArray.Add("card_holder_name", objMaster.card_holder_name);
                myArray.Add("card_number", objMaster.card_number);
                myArray.Add("command", objMaster.command);
                myArray.Add("currency", objMaster.currency);
                myArray.Add("customer_email", objMaster.customer_email);
                myArray.Add("customer_ip", objMaster.customer_ip);
                myArray.Add("eci", objMaster.eci);
                myArray.Add("expiry_date", objMaster.expiry_date);
                myArray.Add("fort_id", objMaster.fort_id);
                myArray.Add("language", objMaster.language);
                myArray.Add("merchant_identifier", "957fafda");
                myArray.Add("merchant_reference", objMaster.merchant_reference);
                myArray.Add("order_description", objMaster.order_description);
                myArray.Add("payment_option", objMaster.payment_option);
                myArray.Add("response_code", objMaster.response_code);
                myArray.Add("response_message", objMaster.response_message);
                myArray.Add("status", objMaster.status);
               
        var baseString = "";

                foreach (var item in myArray)
                {
                    baseString += item.Key + "=" + item.Value;
                }

                var shastring = ShaResponseVar + baseString + ShaResponseVar;
                var shaPhrase = SHA256Util.sha256_hash(shastring);

                if (objMaster.signature == shaPhrase) { return "Verified"; } else { return "Signature Mismatch"; }

            }
            catch
            {
                return "";
            }
        }

    }
}