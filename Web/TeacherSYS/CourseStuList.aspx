<%@ Page Title="" Language="C#" MasterPageFile="~/TeacUser.Master" AutoEventWireup="true" CodeBehind="CourseStuList.aspx.cs" Inherits="Web.CourseStuList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link rel="stylesheet" href="css/StuList.css" />
    <link rel="stylesheet" href="css/AddStu_Style.css" />
    <style type="text/css">
        .auto-style2 {
            width: 84px;
            height: 19px;
        }
        .auto-style3 {
            height: 19px;
        }
        .auto-style4 {
            width: 190px;
            height: 19px;
        }
        .auto-style5 {
            height: 19px;
            width: 180px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="right01">
            <img src="images/04.gif" />
            教师用户系统 &gt; 
			<span>查看所授课程选课情况</span>
        </div>
        <div class="content">
            <div class="StuList_contend_body">
                <h2 class="content_h2">已选学生列表</h2>
                <table style="width: 70%;" class="SelTable">
                    <tr>
                        <td class="auto-style2" style="font-weight: bold">所授课程：</td>
                        <td class="auto-style4">
                            <asp:Label ID="Lab_CourseName" runat="server" Text="Label" ForeColor="Black"></asp:Label>

                        </td>
                        <td class="auto-style2" style="font-weight: bold">
                            开设专业：</td>
                        <td class="auto-style5">
                            <asp:Label ID="Lab_Sp" runat="server" ForeColor="Black" Text="Label"></asp:Label>

                        </td>
                        <td class="auto-style3" style="font-weight: bold">
                            班级：</td>
                        <td class="auto-style3">
                            <asp:DropDownList ID="DDL_StuClass" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_StuClass_SelectedIndexChanged">
                            </asp:DropDownList>

                        </td>
                    </tr>
                </table>
                <asp:GridView ID="GV_CourseStuList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="StuListTable" ForeColor="Black" GridLines="Vertical" Width="70%">
                    <AlternatingRowStyle BackColor="White" />
              
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
            </div>
        </div>

</asp:Content>
