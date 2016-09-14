<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="TeacherList.aspx.cs" Inherits="Web.TeacherList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/StuList.css" />
    <link rel="stylesheet" href="css/AddStu_Style.css" />
    <style type="text/css">
        .auto-style1 {
            width: 136px;
        }

        .auto-style2 {
            width: 90px;
        }

        .GV_tablehead {
            background: #008e62;
            color: #fff;
        }

        .auto-style3 {
            width: 180px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        教师用户管理 &gt; 
			<span>查看教师列表</span>

    </div>
    <div class="content">
        <div class="StuList_contend_body">
            <h2 class="content_h2">教师用户列表</h2>
            <table style="width: 75%;" class="SelTable" border="0">
                <tr>
                    <td class="auto-style1">检索条件： 部门:
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DDL_SelDc" runat="server" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelDc_SelectedIndexChanged">
                            <asp:ListItem Selected="True">--------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">输入教师姓名或教师编号：</td>
                    <td>
                        <asp:TextBox ID="txt_SearchBox" runat="server" Width="140px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_SearchTeacher" runat="server" Text="搜索" CssClass="btn" OnClick="btn_SearchTeacher_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="GV_StuList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="StuListTable" ForeColor="Black" GridLines="Vertical" Width="80%">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:HyperLinkField HeaderText="删除用户" NavigateUrl="DeleteTeacher.aspx" Text="删除" DataNavigateUrlFields="教师编号" DataNavigateUrlFormatString="DeleteTeacher.aspx?T_Id={0}" />
                    <asp:HyperLinkField HeaderText="修改信息" NavigateUrl="ModifyTeacher.aspx" Text="修改" DataNavigateUrlFields="教师编号" DataNavigateUrlFormatString="ModifyTeacher.aspx?T_Id={0}" />
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
