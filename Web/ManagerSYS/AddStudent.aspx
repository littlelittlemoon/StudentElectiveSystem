<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/master.Master" CodeBehind="AddStudent.aspx.cs" Inherits="Web.AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/AddStu_Style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        学生用户管理 &gt; 
		<span>添加学生</span>
    </div>
    <div class="content">
        <div class="AddStu_contend_body">
            <h2 class="content_h2">添加学生</h2>
            <p class="content_p">请填写学生信息</p>
            <div class="content_formdiv">

                <table class="content_table">
                    <tr>
                        <td align="right">学生姓名:</td>
                        <td>
                            <asp:TextBox ID="txt_SName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">用户名:</td>
                        <td>
                            <asp:TextBox ID="txt_SUName" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">密码:</td>
                        <td>
                            <asp:TextBox ID="txt_SUPass" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">确认密码:</td>
                        <td>
                            <asp:TextBox ID="txt_SAPass" runat="server" Width="200px"></asp:TextBox>
                            <asp:CompareValidator ID="CV_Pass" runat="server" ControlToCompare="txt_SUPass" ControlToValidate="txt_SAPass" Display="Dynamic" ErrorMessage="*两次密码不一致" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">性别：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_SSex" runat="server" BackColor="White">
                                <asp:ListItem Selected="True">女</asp:ListItem>
                                <asp:ListItem>男</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">年龄：</td>
                        <td>
                            <asp:TextBox ID="txt_SAge" runat="server" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">学院：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_Academy" runat="server" OnSelectedIndexChanged="DDL_Academy_SelectedIndexChanged" AutoPostBack="True" Width="200px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">专业：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_Specialty" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_Specialty_SelectedIndexChanged" Width="200px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">班级：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_Class" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_Class_SelectedIndexChanged" Width="200px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td colspan="2" align="center">
                            <asp:Button ID="btn_AddStudent" runat="server" OnClick="btn_AddStudent_Click" Text="添加" CssClass="btn" />
                    </tr>

                </table>

            </div>
        </div>
    </div>
</asp:Content>

