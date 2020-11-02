using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebFormsDemo
{
    public partial class GetMessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //getting file destination from web.config
            string websitemessageFile = ConfigurationManager.AppSettings["websitemessagefile"];

            string message = System.IO.File.ReadAllText(websitemessageFile);
            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(message);
            Response.End();

        }
    }
}