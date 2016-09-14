<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ModifyStudent.aspx.cs" Inherits="Web.ModefyStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/AddStu_Style.css" />
    <style type="text/css">
        .form-control {
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        学生用户管理 &gt; 
		<span>修改学生信息</span>
    </div>
    <div class="content">
        <div class="AddStu_contend_body">
            <h2 class="content_h2">修改学生信息</h2>
            <p class="content_p">请填写学生信息</p>
            <div class="content_formdiv">
                <table class="content_table">
                    <tr>
                        <td align="right">学生姓名:</td>
                        <td>
                            <asp:TextBox ID="txt_CSName" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">用户名:</td>
                        <td>
                            <asp:TextBox ID="txt_CSUName" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">密码:</td>
                        <td>
                            <asp:TextBox ID="txt_CSUPass" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">确认密码:</td>
                        <td>
                            <asp:TextBox ID="txt_CSAPass" runat="server" CssClass="form-control" Width="200px"></asp:TextBox>
                            <asp:CompareValidator ID="CV_CPass" runat="server" ControlToCompare="txt_CSUPass" ControlToValidate="txt_CSAPass" Display="Dynamic" ErrorMessage="*两次密码不一致" ForeColor="#FF3300"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">性别：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_CSSex" runat="server" BackColor="White" CssClass="form-control">
                                <asp:ListItem Selected="True">女</asp:ListItem>
                                <asp:ListItem>男</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">年龄：</td>
                        <td>
                            <asp:TextBox ID="txt_CSAge" runat="server" Width="200px" CssClass="form-control" OnTextChanged="txt_CSAge_TextChanged"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">学院：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_CAcademy" runat="server" OnSelectedIndexChanged="DDL_CAcademy_SelectedIndexChanged" AutoPostBack="True" CssClass="form-control" Width="200px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">专业：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_CSpecialty" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_CSpecialty_SelectedIndexChanged" CssClass="form-control" Width="200px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">班级：
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_CClass" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_CClass_SelectedIndexChanged" CssClass="form-control" Width="200px">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>

                        <td colspan="2" align="center">
                            <asp:Button ID="btn_ModifyStudent" runat="server" OnClick="btn_Modify_Student_Click" Text="确认修改" CssClass="btn" />
                        </td>
                    </tr>

                </table>
            </div>
        </div>
    </div>
</asp:Content>
