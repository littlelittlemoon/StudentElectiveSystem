<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="CourseList.aspx.cs" Inherits="Web.CourseList" %>

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
        课程管理 &gt; 
			<span>查看课程列表</span>

    </div>
    <div class="content">
        <div class="StuList_contend_body">
            <h2 class="content_h2">课程列表</h2>
            <table style="width: 86%;" class="SelTable" border="0">
                <tr>
                    <td class="auto-style1">开设专业：
                    </td>
                    <td class="">
                        <asp:DropDownList ID="DDL_SelSp" runat="server" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelSp_SelectedIndexChanged">
                            <asp:ListItem Selected="True">---------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style1">课程性质:
                    </td>
                    <td>
                        <asp:DropDownList ID="DDL_SelSpec" runat="server" Width="80px" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelSpec_SelectedIndexChanged">
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
                        <asp:Button ID="btn_SearchCourse" runat="server" CssClass="btn" Text="搜索" OnClick="btn_SearchCourse_Click" />
                    </td>
                </tr>

            </table>
            <asp:GridView ID="GV_CourseList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="StuListTable" ForeColor="Black" GridLines="Vertical" Width="86%">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:HyperLinkField HeaderText="删除课程" NavigateUrl="DeleteCourse.aspx" Text="删除" DataNavigateUrlFields="课程代码" DataNavigateUrlFormatString="DeleteCourse.aspx?C_Id={0}" />
                    <asp:HyperLinkField HeaderText="修改课程信息" NavigateUrl="ModifyCourse.aspx" Text="修改" DataNavigateUrlFields="课程代码" DataNavigateUrlFormatString="ModifyCourse.aspx?C_Id={0}" />
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
        </div>
    </div>

</asp:Content>

