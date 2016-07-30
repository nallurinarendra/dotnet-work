<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employer Registration Form.aspx.cs" Inherits="EmployerForm.Employer_Registration_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

  
<head runat="server">
    <title></title>
     <link href="http://www.jquerycookbook.com/demos/css/jquery-ui.css" rel="stylesheet" />
    <script src="http://www.jquerycookbook.com/demos/scripts/jquery-1.11.1.min.js"></script>
    <script src="http://www.jquerycookbook.com/demos/scripts/jquery-ui.min.js"></script>
    <script>
        $(function () {
            $("#datep").datepicker();
        });
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 75px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left:100px;margin-right:100px; margin-top:50px; margin-bottom:50px">
        <h2  style="align-content: center; text-align: center; font-weight: bold;">Sample Employement Application Form</h2>
        <div style="height:60px;">
            <div>
                <p style="width:220px;  margin-left:10px;text-align:center; height:auto; border:solid; float:left">PLEASE PRINT ALL INFORMATION REQUESTED EXCEPT SIGNATURE</p>
            </div>
            <div>
                <p style="height:55px;margin-right:10px; width:200px;float:right; border:solid"></p>
            </div>
        </div>
        <h3 style="text-align:center;font-weight:bold">APPLICATION FOR EMPLOYEMENT</h3>
        <div style="border:solid; margin-left:10px; margin-right:10px; margin-top:10px; margin-bottom:10px">
            <p style="font-weight:bold;font-size:small; text-align:center;">APPLICANTS MAY BE TESTED FOR ILLEGAL DRUGS</p>
            <div style="margin-left:10px; margin-right:10px; margin-bottom:10px; border:solid; height:auto">
                <div style="height:50px">
                    <div style="float:left">
                        <h3 style="font-weight:bold">&nbsp;&nbsp;&nbsp;PLEASE COMPLETE PAGES 1-4.</h3>
                    </div>
                    <div style="float:right">
                        <h3 style="font-weight:bold"> DATE:<input type="text" id="datep" /></h3>
                        
                     </div>
                  </div>
                <div>
                    <table style="text-align:left">
                        <tr>
                            <td class="auto-style1"> &nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="First Name:" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                            <td><asp:Label ID="Label2" runat="server" Text="Middle Name:" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox2" runat="server" Width="30"></asp:TextBox></td>
                            <td><asp:Label ID="Label3" runat="server" Text="Last Name:" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                            <td><asp:Label ID="Label4" runat="server" Text="Maiden Name:" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                        </tr>
                    </table>
                    <hr />
                    <h3>
                        &nbsp;&nbsp;&nbsp; ADDRESS DETAILS:
                    </h3>
                    <table>
                        <tr>
                            <td> &nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Text="Address Line 1:" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>                         
                            <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label6" runat="server" Text="Address Line 2:" Font-Bold="True"></asp:Label> </td>                   
                            <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td> &nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="City :" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                            <td> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label8" runat="server" Text="State:" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                            <td><asp:Label ID="Label9" runat="server" Text="ZipCode:" Font-Bold="True"></asp:Label> </td>
                            <td><asp:TextBox ID="TextBox9" runat="server" TextMode="Number"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td> &nbsp;&nbsp;&nbsp;<asp:Label ID="Label11" runat="server" Text="How Long(In years) :" Font-Bold="True"></asp:Label> </td>
                            <td> <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>2</asp:ListItem>
                                <asp:ListItem>3</asp:ListItem>
                                <asp:ListItem>4</asp:ListItem>
                                <asp:ListItem>5</asp:ListItem>
                                <asp:ListItem>6</asp:ListItem>
                                <asp:ListItem>7</asp:ListItem>
                                <asp:ListItem>8</asp:ListItem>
                                <asp:ListItem>9</asp:ListItem>
                                <asp:ListItem>10 +</asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                    </table>
                    <hr />
                    <table>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="Social Security Number :" Font-Bold="True"></asp:Label></td>
                            <td><asp:TextBox ID="TextBox10" runat="server" TextMode="Password"></asp:TextBox></td>
                            <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label12" runat="server" Text="Mobile Number :" Font-Bold="True"></asp:Label></td>
                            <td><asp:TextBox ID="TextBox11" runat="server" TextMode="Phone"></asp:TextBox></td>
                        </tr>
                    </table>
                    <hr />
                    <h3 style="font-weight:bold;"> &nbsp;&nbsp;&nbsp;JOB DETAILS: </h3>
                    <table>
                        <tr>
                            <td style="font-weight:bold">&nbsp;&nbsp;&nbsp; Position Applied For: </td>
                            <td><asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td>
                            <td style="font-weight:bold">&nbsp;&nbsp;&nbsp;&nbsp; Desired Pay:</td>
                            <td><asp:TextBox ID="TextBox13" runat="server" TextMode="Number"></asp:TextBox></td>
                            <td><asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem>Hourly</asp:ListItem>
                                <asp:ListItem>Annually</asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td>&nbsp;&nbsp;&nbsp; Days Available To Work:</td>
                            <td> <asp:CheckBox ID="CheckBox1" runat="server" Text="No Pref" /></td>
                        </tr>
                        <tr>
                            <td> &nbsp;&nbsp;&nbsp; 
                                <asp:CheckBox ID="CheckBox2" runat="server" Text="Mon" />
                                <asp:CheckBox ID="CheckBox3" runat="server" Text="Tue" />
                                <asp:CheckBox ID="CheckBox4" runat="server" Text="Wed" />
                                <asp:CheckBox ID="CheckBox5" runat="server" Text="Thu" />
                                <asp:CheckBox ID="CheckBox6" runat="server" Text="Fri" />
                                <asp:CheckBox ID="CheckBox7" runat="server" Text="Sat" />
                                <asp:CheckBox ID="CheckBox8" runat="server" Text="Sun" />
                            </td>
                        </tr>
                    </table>
                    &nbsp;&nbsp;&nbsp; How Many hours Can you work weekly? &nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox14" runat="server" TextMode="Number"></asp:TextBox>
                     &nbsp;&nbsp;&nbsp; Can You work at night?
                    <asp:RadioButtonList runat="server" ID="RadioButtonList1" RepeatDirection="Horizontal" RepeatLayout="Flow"> 
                                 <asp:ListItem>Yes</asp:ListItem>
                                <asp:ListItem>No</asp:ListItem> 
                                                       </asp:RadioButtonList>&nbsp;
                </div>
                <br />
            <br />

        </div>
      </div>

    </div>
    </form>
</body>
</html>
