<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="ManagerWebIndex.aspx.cs" Inherits="Web.WebIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/Home_style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
					<img src="images/04.gif" />
					 选课系统 &gt; 
					 <span>首页</span>
				</div>	
				<div class="content">
					<div class="Home_contend_body">
						<h2 class="content_h2">系统公告</h2>
						<p class="content_p">本系统供一下几种身份的人群使用</p>
						<ol>
							<li>本系统管理员:使用本系统管理用户信息与课程信息，发布选课信息和授课安排等</li>
							<li>授课教师用户:使用本系统查看个人授课课程信息，以及课程选课情况和已选课学生的信息</li>
							<li>学生用户：使用本系统添加选课和删除选课</li>
						</ol>
						<p class="content_p content_end_p">注：请教师用户和学生用户及时修改自己的个人密码，初始密码为用户名。</p>
					</div>
               </div>
</asp:Content>
