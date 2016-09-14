<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="Web.StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/StuList.css" />
    <link rel="stylesheet" href="css/AddStu_Style.css" />
    <style type="text/css">
        .auto-style1 {
        }

        .auto-style2 {
            width: 90px;
        }

        .GV_tablehead {
            background: #008e62;
            color: #fff;
        }

        .auto-style3 {
            width: 56px;
        }

        .auto-style4 {
            width: 69px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
        <img src="images/04.gif" />
        学生用户管理 &gt; 
			<span>查看学生列表</span>

    </div>
    <div class="content">
        <div class="StuList_contend_body">
            <h2 class="content_h2">学生用户列表</h2>
            <table style="width: 84%;" class="SelTable" border="0">
                <tr>
                    <td class="auto-style1">检索条件： 学院:
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DDL_SelAc" runat="server" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelAc_SelectedIndexChanged1">
                            <asp:ListItem Selected="True">--------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">专业：
                    </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DDL_SelSp" runat="server" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelSp_SelectedIndexChanged1">
                            <asp:ListItem Selected="True">---------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>班级:
                    </td>
                    <td>
                        <asp:DropDownList ID="DDL_SelCl" runat="server" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="DDL_SelCl_SelectedIndexChanged1">
                            <asp:ListItem Selected="True">------------------</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">请输入学号或姓名</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_SearchStu" runat="server" Width="160px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="btn_SearchStu" runat="server" CssClass="btn" Text="搜索" />
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <asp:GridView ID="GV_StuList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="StuListTable" ForeColor="Black" GridLines="Vertical" OnSelectedIndexChanged="GV_StuList_SelectedIndexChanged" Width="84%">

                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:HyperLinkField HeaderText="修改信息" NavigateUrl="ModifyStudent" Text="修改" DataNavigateUrlFields="学号" DataNavigateUrlFormatString="ModifyStudent.aspx?S_Id={0}" />

                    <asp:HyperLinkField DataNavigateUrlFields="学号" DataNavigateUrlFormatString="DeleteStu.aspx?S_Id={0}" HeaderText="删除" Text="删除" NavigateUrl="DeleteStu.aspx" />
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
