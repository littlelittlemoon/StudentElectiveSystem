<%@ Page Title="" Language="C#" MasterPageFile="~/StuUser.Master" AutoEventWireup="true" CodeBehind="ReturnCourse.aspx.cs" Inherits="Web.ReturnCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/StuList.css" />
    <link rel="stylesheet" href="css/AddStu_Style.css" />
    <style type="text/css">
        .auto-style1 {
            width: 76px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="right01">
            <img src="images/04.gif" />
            选课系统 &gt; 
			<span>退课</span>
        </div>
        <div class="content">
            <div class="StuList_contend_body">
                <h2 class="content_h2">已选课程列表</h2>

                <asp:GridView ID="GV_HaveCourseList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="StuListTable" ForeColor="Black" GridLines="Vertical" Width="86%">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="退选">
                            <ItemTemplate>
                                <asp:CheckBox ID="CB_ReCourse" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
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

                <table style="width: 80%;" class="StuListTable">
                    <tr>
                        <td>
                            <asp:Button ID="btn_ReturnCourse" runat="server" Text="确认退选" CssClass="btn" OnClick="btn_ReturnCourse_Click"  />

                        </td>
                    </tr>
                </table>
            </div>
        </div>
</asp:Content>

