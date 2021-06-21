<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterNotLoggedIn.master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="ProjektKoncowyV5.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  <div class="content">

            <h1>Zaloguj się</h1>
        <form>
            <asp:TextBox ID="LoginInput" CssClass="loginInput" runat="server"  placeholder="Login"></asp:TextBox>
            <asp:TextBox ID="PasswordInput" CssClass="loginInput" runat="server"  placeholder="Hasło"></asp:TextBox>



        </form>


  </div>

      <asp:Button CssClass="button"  ID="Submit" runat="server" Text="Wyślij" onclick="Submit_Click" />
</asp:Content>
