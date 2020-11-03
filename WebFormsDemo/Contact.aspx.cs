using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsDemo
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userContactInfo"] != null)
            {
                HttpCookie userContactInfo = Request.Cookies["userContactInfo"];
                firstNameBox.Text = userContactInfo["firstName"];
                lastNameBox.Text = userContactInfo["lastName"];
                birthDayTextBox.Text = userContactInfo["birthDay"];
                emailBox.Text = userContactInfo["email"];
                genderCheckBoxList.SelectedValue = userContactInfo["gender"];
                registeredCheckBox.Checked = userContactInfo["isRegistered"].Equals("registered")? true:false;
                countryDropDownList.SelectedValue = userContactInfo["country"];

            }
        }

        protected void sendEmailButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameBox.Text;
            string lastName = lastNameBox.Text;
            string birthDay = birthDayTextBox.Text;
            string email = emailBox.Text;
            string gender = genderCheckBoxList.SelectedValue;
            string isRegistered = registeredCheckBox.Checked ? "registered" : "not registered";
            string country = countryDropDownList.SelectedValue;

            resultName.Text = firstName;
            resultLastName.Text = lastName;
            resultBirthDay.Text = birthDay;
            resultEmail.Text = email;
            resultGender.Text = gender;
            resultRegistered.Text = isRegistered;
            resultCountry.Text = country;
            //saving data  as a cookies
            HttpCookie userContactInfo = new HttpCookie("userContactInfo");
            userContactInfo["firstName"] = firstName;
            userContactInfo["lastName"] = lastName;
            userContactInfo["birthDay"] = birthDay;
            userContactInfo["email"] = email;
            userContactInfo["gender"] = gender;
            userContactInfo["isRegistered"] = isRegistered;
            userContactInfo["country"] = country;
            Response.Cookies.Add(userContactInfo);
        }
    }
}