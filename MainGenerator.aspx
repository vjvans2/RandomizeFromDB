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
        <br /><br />
        <asp:DropDownList ID="ddlPokemon" AutoPostBack="true" runat="server" DataSourceID="SqlDataSource1" 
            DataTextField="PokemonName" DataValueField="PokemonID"> </asp:DropDownList>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PKMNConnectionString %>" 
            SelectCommand="SELECT [PokemonID], [PokemonName] FROM [Pokemon2] ORDER BY [PokemonID]">
        </asp:SqlDataSource>
    </form>
</body>
</html>
