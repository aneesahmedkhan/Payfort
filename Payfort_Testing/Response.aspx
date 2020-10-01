<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Response.aspx.cs" Inherits="Payfort_Testing.Response" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Verigy Transaction Status: 
        <br />
        <br />
    <div>Merchang_reference:
        <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="234px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        fort_Id:
        <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="234px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Check Status" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Check Status Respnse Json"></asp:Label>
        <br />
        <asp:TextBox ID="txtCheckStatusResponse" runat="server" Height="162px" TextMode="MultiLine" Width="575px"></asp:TextBox>
        <br />
    </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Verify Status Response" />
&nbsp;
        <br />
        Hashed Response data: <asp:Label ID="lblCheckResponseSignature" runat="server"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            Verify Transaction Response&nbsp; Json Data</p>
        <p>
        <asp:TextBox ID="txtCheckTransactionResponse" runat="server" Height="162px" TextMode="MultiLine" Width="575px"></asp:TextBox>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Verify Transaction Response" />
        </p>
        <p>
        Hashed Response data: <asp:Label ID="lblCheckTransactionResponseSignature" runat="server"></asp:Label>
        </p>

        Sample Transaction Respnse: <br />
        {
            <br />
        "amount":"77700",
            <br />
        "response_code":"14000",<br />
&nbsp;"card_number":"512345******2346",<br />
&nbsp;"card_holder_name":"anees khan",<br />
&nbsp;"signature":"da19f1bc90427305b7f21d58d3075138781102c04629d1e7b80af9b2694d8ce0",<br />
&nbsp;"merchant_identifier":"957fafda",
            <br />
        "access_code":"a9U2M7lKbzlSOKzkyMli",<br />
&nbsp;"order_description":"iPhone 6-S",
            <br />
        "payment_option":"MASTERCARD",
            <br />
        "expiry_date":"2105",
            <br />
        "customer_ip":"176.44.64.76",
            <br />
        "language":"en",
            "eci":"ECOMMERCE",
            <br />
        "fort_id":"169996200000132829",
            <br />
        "command":"PURCHASE",
            <br />
        "response_message":"Success",
            <br />
        "merchant_reference":"XYX8777-yu898",<br />
&nbsp;"authorization_code":"636973",
            <br />
        "customer_email":"<a href="mailto:m.saad@gama-ksa.com">m.saad@gama-ksa.com</a>",
        <br />
        "currency":"SAR",
            "status":"14"
        <br />
        }

    </form>
</body>
</html>
