<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterNotLoggedIn.master" AutoEventWireup="true" CodeBehind="MainNotLoggedIn.aspx.cs" Inherits="ProjektKoncowyV5.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="content">
        <h1>Witaj na stronie do zarządzania zgłoszeniami</h1>
        <p >Żeby dodawać i przeglądać zgłoszenia zarejestruj się lub zaloguj jeśli posiadasz już konto</p>
    </div>
    <div class="content">
        <div class="buttons">
            <a class="button" href="/LoginForm.aspx">Zaloguj się</a>
            <a class="button" href="/RegisterForm.aspx">Zarejestruj się</a>
        </div>
    </div>
</asp:Content>
