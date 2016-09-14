<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ModifyTeacher.aspx.cs" Inherits="Web.ModifyTeacher" %>

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
		<span>修改教师信息</span>
    </div>
    <div class="content">
        <div class="AddTea_contend_body">
            <h2 class="content_h2">修改教师信息</h2>
            <p class="content_p">请填写教师信息</p>
            <div class="content_formdiv">
                <table class="content_table">
                    <tr>
                        <td align="right">教师姓名:</td>
                        <td>
                            <asp:TextBox ID="txt_MTName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="auto-style1">用户名:</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txt_MTUName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">密码:</td>
                        <td>
                            <asp:TextBox ID="txt_MTUPass" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">确认密码:</td>
                        <td>
                            <asp:TextBox ID="txt_MTAPass" runat="server" Width="200px"></asp:TextBox>
                            <asp:CompareValidator ID="CV_Pass" runat="server" ControlToCompare="txt_MTUPass" ControlToValidate="txt_MTAPass" Display="Dynamic" ErrorMessage="*两次密码不一致" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">性别：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_MTSex" runat="server" BackColor="White">
                                <asp:ListItem Selected="True">女</asp:ListItem>
                                <asp:ListItem>男</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">年龄：</td>
                        <td>
                            <asp:TextBox ID="txt_MTAge" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">部门：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_MDocument" runat="server" Width="200px" OnSelectedIndexChanged="DDL_MDocument_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td colspan="2" align="center">
                            <asp:Button ID="btn_ModifyTeacher" runat="server" Text="确认修改" CssClass="btn" OnClick="btn_ModifyTeacher_Click" />
                    </tr>

                </table>
            </div>
        </div>
    </div>
</asp:Content>
