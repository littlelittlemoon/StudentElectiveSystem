﻿<%@ Page Title="" Language="C#" MasterPageFile="~/TeacUser.Master" AutoEventWireup="true" CodeBehind="ViewStuOfCourse.aspx.cs" Inherits="Web.ViewStuOfCourse" %>
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
            教师用户系统 &gt; 
			<span>查看所授课程选课情况</span>
        </div>
        <div class="content">
            <div class="StuList_contend_body">
                <h2 class="content_h2">所授课程列表</h2>
                <asp:GridView ID="GV_TeachCourseList" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="StuListTable" ForeColor="Black" GridLines="Vertical" Width="86%">
                    <AlternatingRowStyle BackColor="White" />
              
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="课程代码" DataNavigateUrlFormatString="CourseStuList.aspx?课程代码={0}" HeaderText="选课情况" Text="查看" />
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