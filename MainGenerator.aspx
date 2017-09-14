<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainGenerator.aspx.cs" Inherits="PokemonRandomName.MainGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnRandom" runat="server" Text="Random Pkmn Name" OnClick="btnRandom_Click" />
        <br /><br />
        <asp:Label ID="lblPkmn" runat="server" Text=""></asp:Label>

        <asp:SqlDataSource ID="SqlDataSourcePkmnNames" runat="server" ConnectionString="<%$ ConnectionStrings:PKMNConnectionString %>" 
            SelectCommand="SELECT [PokemonID], [PokemonName] FROM [Pokemon2] ORDER BY [PokemonID]">
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSourcePkmnID" runat="server" ConnectionString="<%$ ConnectionStrings:PKMNConnectionString %>" 
            SelectCommand="SELECT [PokemonID] FROM [Pokemon2] ORDER BY [PokemonID]"></asp:SqlDataSource>
    </form>
</body>
</html>
