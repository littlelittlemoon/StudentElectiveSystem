<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="DeleteTeacher.aspx.cs" Inherits="Web.DeleteTeacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/AddStu_Style.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        教师用户管理 &gt; 
		<span>删除教师</span>
    </div>
    <div class="content">
        <div class="AddStu_contend_body">
            <h2 class="content_h2">删除教师</h2>
            <p class="content_p">你确定要删除该教师？</p>
            <div class="content_formdiv">
                <table class="content_table">
                    <tr>
                        <td align="right">教师编号:</td>
                        <td>
                            <asp:Label ID="Lab_Id" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">教师姓名:</td>
                        <td>
                            <asp:Label ID="Lab_TName" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>

                        </td>
                    </tr>
                    <tr>
                        <td align="right">所属部门:
                        </td>
                        <td>
                            <asp:Label ID="Lab_TDoc" runat="server" Text="Label" Font-Bold="True" ForeColor="Black"></asp:Label>
                        </td>
                    </tr>

                    <tr>
                        <td colspan="2" align="center">
                            <asp:Button ID="btn_DelTeacher" runat="server" Text="确认删除" CssClass="btn" OnClick="btn_DelTeacher_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
