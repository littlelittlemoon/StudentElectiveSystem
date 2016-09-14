<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="DeleteCourse.aspx.cs" Inherits="Web.DeleteCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/AddStu_Style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        课程管理 &gt; 
		<span>删除课程</span>
    </div>
    <div class="content">
        <div class="AddStu_contend_body">
            <h2 class="content_h2">删除课程</h2>
            <p class="content_p">你确定要删除该课程？</p>
            <div class="content_formdiv">
                <table class="content_table">
                    <tr>
                        <td align="right">课程代码:</td>
                        <td>
                            <asp:Label ID="Lab_Id" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">课程名称:</td>
                        <td>
                            <asp:Label ID="Lab_CName" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">课程性质:
                        </td>
                        <td>
                            <asp:Label ID="Lab_CSpeci" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">开设专业:
                        </td>
                        <td>
                            <asp:Label ID="Lab_Sp" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">授课教师:
                        </td>
                        <td>
                            <asp:Label ID="Lab_Tea" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>
                    <tr>

                        <td colspan="2" align="center">
                            <asp:Button ID="btn_DelCourse" runat="server" Text="确认删除" CssClass="btn" OnClick="btn_DelCourse_Click" />
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>

