<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterLoggedIn.master" AutoEventWireup="true" CodeBehind="MainLogedIn.aspx.cs" Inherits="ProjektKoncowyV5.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content">
        <h1>Witaj na stronie do zarządzania zgłoszeniami</h1>
        <p >W celu dodania lub przejrzenie zgłoszeń przejdź do odpowiednej strony korzystając z menu powyżej lub przycisków poniżej.</p>
    </div>
    <div class="content">
        <div class="buttons">
            <a class="button" href="/add.aspx">Dodaj zgłoszenie</a>
            <a class="button" href="/OpenCases.aspx">Otwarte zgłoszenia</a>
        </div>
    </div>
</asp:Content>
