<%@ Page Title="" Language="C#" MasterPageFile="~/StuUser.Master" AutoEventWireup="true" CodeBehind="StuAddCourseList.aspx.cs" Inherits="Web.StuAddCourseList" %>
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
			<span>可选课程列表</span>

        </div>
        <div class="content">
            <div class="StuList_contend_body">
                <h2 class="content_h2">课程列表</h2>
                <table style="width: 86%;" class="SelTable" border="0">
                    <tr>
                        <td class="auto-style1">开设专业：
                        </td>
                        <td class="">
                            <asp:Label ID="Lab_Sp" runat="server" Text="Label" ForeColor="Black"></asp:Label>
                        </td>
                        <td class="auto-style1">课程性质:
                        </td>
                        <td>
                            <asp:DropDownList ID="DDL_SelSpec" runat="server" Width="80px" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelSpec_SelectedIndexChanged" >
                                <asp:ListItem Selected="True">------------------</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>请输入课程号、授课<br />
                            教师或课程名称：
                        </td>
                        <td class="">
                            <asp:TextBox ID="txt_SearchCourse" runat="server" Width="160px"></asp:TextBox>
                        </td>
                        <td class="">
                            <asp:Button ID="btn_SearchCourse" runat="server" CssClass="btn" Text="搜索" OnClick="btn_SearchCourse_Click"  />
                        </td>
                    </tr>

                </table>
                <asp:GridView ID="GV_CourseList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="StuListTable" ForeColor="Black" GridLines="Vertical" Width="86%">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="选课">
                            <ItemTemplate>
                                <asp:CheckBox ID="CB_AddCourse" runat="server" />
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
                            <asp:Button ID="btn_HavaCourseList" runat="server" Text="查看已选课程列表" CssClass="btn" OnClick="btn_HavaCourseList_Click" Width="124px" />

                        </td>
                        <td>
                            <asp:Button ID="btn_AddCourse" runat="server" Text="提交选课" CssClass="btn" OnClick="btn_AddCourse_Click" />

                        </td>
                    </tr>
                </table>
            </div>
        </div>

</asp:Content>

