<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebFormsDemo.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>

        <tr>
            <td>FirstName</td>
            <td>
                <asp:TextBox ID="firstNameBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>LastName</td>
            <td>
                <asp:TextBox ID="lastNameBox" runat="server"></asp:TextBox>

            </td>
        </tr>


        <tr>
            <td>Birth Date</td>
            <td>
                <asp:TextBox ID="birthDayTextBox" runat="server" Text="DD/MM/YYYY"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="emailBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 59px">Gender</td>
            <td style="height: 59px">
                <asp:RadioButtonList ID="genderCheckBoxList" runat="server" Height="59px">
                    <asp:ListItem>male</asp:ListItem>
                    <asp:ListItem>female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Registered</td>
            <td>
                <asp:CheckBox ID="registeredCheckBox" runat="server" />
            </td>
        </tr>
        <tr>
            <td>Country</td>
            <td>
                <asp:DropDownList ID="countryDropDownList" runat="server">
                    <asp:ListItem>Tajikistan</asp:ListItem>
                    <asp:ListItem>Canada</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>Russia</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>

                <asp:Button ID="sendEmailButton" runat="server" Height="29px" Text="Send Email" Width="130px" OnClick="sendEmailButton_Click" />

            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Label ID="resultName" runat="server"></asp:Label><br />
                <asp:Label ID="resultLastName" runat="server"></asp:Label><br />
                <asp:Label ID="resultBirthDay" runat="server"></asp:Label><br />
                <asp:Label ID="resultEmail" runat="server"></asp:Label><br />
                <asp:Label ID="resultGender" runat="server"></asp:Label><br />
                <asp:Label ID="resultRegistered" runat="server"></asp:Label><br />
                <asp:Label ID="resultCountry" runat="server"></asp:Label>

            </td>
        </tr>

    </table>
</asp:Content>

