<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="AddTeacher.aspx.cs" Inherits="Web.AddTeacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/AddStu_Style.css" />
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        教师用户管理 &gt; 
		<span>添加教师</span>
    </div>
    <div class="content">
        <div class="AddTea_contend_body">
            <h2 class="content_h2">添加教师</h2>
            <p class="content_p">请填写教师信息</p>
            <div class="content_formdiv">

                <table class="content_table">
                    <tr>
                        <td align="right">教师姓名:</td>
                        <td>
                            <asp:TextBox ID="txt_TName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="auto-style1">用户名:</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txt_TUName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">密码:</td>
                        <td>
                            <asp:TextBox ID="txt_TUPass" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">确认密码:</td>
                        <td>
                            <asp:TextBox ID="txt_TAPass" runat="server" Width="200px"></asp:TextBox>
                            <asp:CompareValidator ID="CV_Pass" runat="server" ControlToCompare="txt_TUPass" ControlToValidate="txt_TAPass" Display="Dynamic" ErrorMessage="*两次密码不一致" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">性别：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_TSex" runat="server" BackColor="White">
                                <asp:ListItem Selected="True">女</asp:ListItem>
                                <asp:ListItem>男</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">年龄：</td>
                        <td>
                            <asp:TextBox ID="txt_TAge" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">部门：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_Document" runat="server" AutoPostBack="True" Width="200px" OnSelectedIndexChanged="DDL_Document_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td colspan="2" align="center">
                            <asp:Button ID="btn_AddTeacher" runat="server" Text="添加" CssClass="btn" OnClick="btn_AddTeacher_Click" />
                    </tr>

                </table>

            </div>
        </div>
    </div>
</asp:Content>
