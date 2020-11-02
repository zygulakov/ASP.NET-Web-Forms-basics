<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormsDemo.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="userNameTextBox" placeholder="Enter User Name" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="passwordTextBox" TextMode="Password" placeholder="Enter Password" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="SignInButton" runat="server" Text="Sign In" OnClick="SignInButton_Click" />
            </td>
        </tr>
        <asp:Label ID="incorrectMessageLabel" runat="server" Text="Incorrect Credentials" ForeColor="Red" Visible="false"></asp:Label>


    </table>


</asp:Content>
