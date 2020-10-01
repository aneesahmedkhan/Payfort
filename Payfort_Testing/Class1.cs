using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payfort_Testing
{
    public class payfortParams
    {
        public string command { get; set; } = "PURCHASE";
        public string access_code { get; set; } = "a9U2M7lKbzlSOKzkyMli";
        public string merchant_identifier { get; set; } = "957fafda";
        public string merchant_reference { get; set; }
        public string amount { get; set; }
        public string currency { get; set; }
        public string language { get; set; } = "en";
        public string customer_email { get; set; }
        public string signature { get; set; }
        public string payment_option { get; set; }
        public string order_description { get; set; }
        public string return_url { get; set; } = "http://payfort.eumra.com/Default.aspx";
    }

    public class PayData
    {
        public string query_command { get; set; } = "CHECK_STATUS";
        public string access_code { get; set; } = "a9U2M7lKbzlSOKzkyMli";
        public string merchant_identifier { get; set; } = "957fafda";
        public string merchant_reference { get; set; }
        public string language { get; set; } = "en";
        public string fort_id { get; set; }
        public string signature { get; set; }
    }

    public class CheckStatusResponse
    {
        public string transaction_code { get; set; }
        public string transaction_status { get; set; }
        public string response_code { get; set; }
        public string signature { get; set; }
        public string merchant_identifier { get; set; }
        public string access_code { get; set; }
        public string transaction_message { get; set; }
        public string language { get; set; }
        public string fort_id { get; set; }
        public string refunded_amount { get; set; }
        public string response_message { get; set; }
        public string merchant_reference { get; set; }
        public string query_command { get; set; }
        public string captured_amount { get; set; }
        public string authorized_amount { get; set; }
        public string status { get; set; }
    }


    public class TransactionResponse
    {
        public string amount { get; set; }
        public string response_code { get; set; }
        public string card_number { get; set; }
        public string card_holder_name { get; set; }
        public string signature { get; set; }
        public string merchant_identifier { get; set; }
        public string access_code { get; set; }
        public string order_description { get; set; }
        public string payment_option { get; set; }
        public string expiry_date { get; set; }
        public string customer_ip { get; set; }
        public string language { get; set; }
        public string eci { get; set; }
        public string fort_id { get; set; }
        public string command { get; set; }
        public string response_message { get; set; }
        public string merchant_reference { get; set; }
        public string authorization_code { get; set; }
        public string customer_email { get; set; }
        public string currency { get; set; }
        public string status { get; set; }
    }

}