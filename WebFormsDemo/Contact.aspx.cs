using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsDemo
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        }
    }
}