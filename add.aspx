<%@ Page Title="" Language="C#" MasterPageFile="~/NestedMasterLoggedIn.master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="ProjektKoncowyV5.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="content">
        <h1>Dodaj zgłoszenie</h1>
        <form>
            <label for="SubjectInput">Temat</label>
            <asp:TextBox ID="SubjectInput" CssClass="input" runat="server"  placeholder="Temat..."></asp:TextBox>
            <label for="SenderInput">Osoba zgłaszająca</label>
            <asp:TextBox ID="SenderInput" CssClass="input" runat="server"  placeholder="Jak się nazywasz"></asp:TextBox>

            <label for="InputPriority">Priorytet</label>
            <asp:DropDownList ID="InputPriority" runat="server" CssClass="input">
                <asp:ListItem  text="Niski"/>
                <asp:ListItem  Selected="True" text="Średni" />
                <asp:ListItem  text="Wysoki"/>
            </asp:DropDownList>
            <label for="InputDescription">Opis zgłoszenia</label>
            <asp:TextBox ID="InputDescription" CssClass="input" runat="server" TextMode="multiline" Columns="50" Rows="5" />
      <div class="content">
        <asp:Button CssClass="button"  ID="Submit" runat="server" Text="Wyślij" onclick="Submit_Click" />
    </div>

        </form>

    </div>
</asp:Content>
