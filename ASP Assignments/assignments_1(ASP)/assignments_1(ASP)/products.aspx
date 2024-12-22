<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="assignments_1_ASP_.products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Product Selection</h1>
            
            <!-- Dropdown for Products -->
            <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
                <asp:ListItem Text="Select a product to buy" Value="0" />
                <asp:ListItem Text=" BOOK" Value="1" />
                <asp:ListItem Text="PEN" Value="2" />
                <asp:ListItem Text="BAG" Value="3" />
                <asp:ListItem Text="SHOES" Value="4" />
            </asp:DropDownList>
 
            <br /><br />
 
       
            <asp:Image ID="imgProduct"  runat="server" CssClass="product_design" height="350px" Visible ="false" />
 
            <br /><br />
 
            <asp:Button ID="btnGetPrice" runat="server" Text="Get Price" OnClick="btnGetPrice_Click" />
            
            <br /><br />
    
            <asp:Label ID="Price" runat="server" Text="Price: $" Visible="false" />
        
        </div>
    </form>
</body>
</html>
