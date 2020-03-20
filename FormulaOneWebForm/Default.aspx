<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulaOneWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLoadCountries" runat="server" OnClick="btnLoadCountries_Click" Text="CARICA COUNTRIES" />
            <asp:Button ID="btnLoadDrivers" runat="server" Text="CARICA DRIVERS" OnClick="btnLoadDrivers_Click" />
            <asp:Button ID="btnLoadTeams" runat="server" Text="CARICA TEAMS" OnClick="btnLoadTeams_Click" />
            <br />
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateSelectButton="true">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
