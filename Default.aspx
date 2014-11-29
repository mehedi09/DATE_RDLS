<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="showRDLC._Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>

    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>

    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css"rel="stylesheet" type="text/css"/> 
 
    <script type="text/javascript">

        $(function () {

            $("[id$=TextBox1]").datepicker({

                changeMonth: true,

                changeYear: true

            });

        });

</script>

       <script type="text/javascript">

           $(function () {

               $("[id$=TextBox2]").datepicker({

                   changeMonth: true,

                   changeYear: true

               });

           });

</script>
    <div><h1>The Report of splendircrm</h1></div>
    <div>
        <label>Select The Start Date:</label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <label>Select The End  Date:</label><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Show" OnClick="Button1_Click" CssClass="btn btn-default" />
    </div>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" ProcessingMode="Remote"></rsweb:ReportViewer>
     
</asp:Content>
