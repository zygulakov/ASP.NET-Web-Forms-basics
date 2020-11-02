using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsDemo.Models;

namespace WebFormsDemo
{
    public partial class Login : System.Web.UI.Page
    {
       private List<User> db = new List<User>()
        {
            new User(){ Name="sam",Password="123"}
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                Response.Redirect("Welcome.aspx");
            }
                
        }

        protected void SignInButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string pass = passwordTextBox.Text;
            var user = db.Find(u => u.Name.Equals(userName) && u.Password.Equals(pass));
            if (user != null)
            {
                Session["userName"] = userName;
                Response.Redirect("Welcome.aspx");
            }
            else
            {
                incorrectMessageLabel.Visible = true;
            }
        }
    }
}