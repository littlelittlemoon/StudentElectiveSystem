<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="DeleteStu.aspx.cs" Inherits="Web.DeleteStu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/AddStu_Style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        学生用户管理 &gt; 
		<span>删除学生</span>
    </div>
    <div class="content">
        <div class="AddStu_contend_body">
            <h2 class="content_h2">删除学生</h2>
            <p class="content_p">你确定要删除该学生？</p>
            <div class="content_formdiv">
                <table class="content_table">
                    <tr>
                        <td align="right">学号:</td>
                        <td>
                            <asp:Label ID="Lab_Id" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">姓名:</td>
                        <td>
                            <asp:Label ID="Lab_SName" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">学院：
                        </td>
                        <td>
                            <asp:Label ID="Lab_SAc" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">专业：
                        </td>
                        <td>
                            <asp:Label ID="Lab_Sp" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">班级：
                        </td>
                        <td>
                            <asp:Label ID="Lab_Cl" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                    <tr>

                        <td colspan="2" align="center">
                            <asp:Button ID="btn_DelStudent" runat="server" Text="确认删除" CssClass="btn" OnClick="btn_DelStudent_Click" />
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
