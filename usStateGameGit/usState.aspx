<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="usState.aspx.cs" Inherits="usStateGameGit.usState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        html {
            margin:0;
            font-family:'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif
        }
        .auto-style1 {
            width: 260px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>How much do you know about US States and their capital,<br/>test your knowledge</h2>
        <p>What is it the capital of : </p>
        <table style="width: 470px; height: 377px">
            
            <tr>
                <td>1. </td>
                <td>
        <asp:Label ID="LblQuestion1" runat="server"></asp:Label>
                    <br />
                </td>
                <td class="auto-style1"> 
                    <asp:TextBox ID="TextBoxQuestion1" runat="server"></asp:TextBox>
                    <asp:Label ID="Lblanswer1" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>2.</td>
                <td>
                    <asp:Label ID="LblQuestion2" runat="server"></asp:Label>
                </td>
                <td class="auto-style1"> 
                    <asp:TextBox ID="TextBoxQuestion2" runat="server"></asp:TextBox>
                    <asp:Label ID="Lblanswer2" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>3.</td>
                <td>
                    <asp:Label ID="LblQuestion3" runat="server"></asp:Label>
                </td>
                <td class="auto-style1"> 
                    <asp:TextBox ID="TextBoxQuestion3" runat="server"></asp:TextBox>
                    <asp:Label ID="Lblanswer3" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>4.</td>
                <td>
                    <asp:Label ID="LblQuestion4" runat="server"></asp:Label>
                </td>
                <td class="auto-style1"> 
                    <asp:TextBox ID="TextBoxQuestion4" runat="server"></asp:TextBox>
                    <asp:Label ID="Lblanswer4" runat="server"></asp:Label>
                </td>
            </tr>

            <tr>
                <td>5.</td>
                <td>
                    <asp:Label ID="LblQuestion5" runat="server"></asp:Label>
                </td>
                <td class="auto-style1"> 
                    <asp:TextBox ID="TextBoxQuestion5" runat="server"></asp:TextBox>
                    <asp:Label ID="Lblanswer5" runat="server"></asp:Label>
                </td>
            </tr>


        </table>
       
    </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Refresh" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Check Answer" />
        <br />
        <br />
        <asp:Label ID="LblCountGoodAnswer" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LblOverAllTotal" runat="server"></asp:Label>
    </form>
</body>
</html>
