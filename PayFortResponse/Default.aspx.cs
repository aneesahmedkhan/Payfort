using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PayFortResponse
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] keys = Request.Form.AllKeys;
            for (int i = 0; i < keys.Length; i++)
            {
                Response.Write(keys[i] + ": " + Request.Form[keys[i]] + "<br>");
            }

            Response.Write("===================Json Format =========================");
            Response.Write(Request.Form);
        }
    }
}