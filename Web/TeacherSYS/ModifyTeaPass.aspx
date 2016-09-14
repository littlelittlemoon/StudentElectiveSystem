<%@ Page Title="" Language="C#" MasterPageFile="~/TeacUser.Master" AutoEventWireup="true" CodeBehind="ModifyTeaPass.aspx.cs" Inherits="Web.ModifyTeaPass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <link rel="stylesheet" href="css/AddStu_Style.css" />
    <style type="text/css">
        .form-control {
            margin-bottom: 0px;
        }
        .auto-style1 {
            height: 49px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="right01">
		<img src="images/04.gif" /> 
		个人管理 &gt; 
		<span>修改密码</span>
	</div>
	<div class="content">
		<div class="AddStu_contend_body">
			<h2 class="content_h2">修改密码</h2>
			<p class="content_p">请根据提示填写信息</p>
			<div class="content_formdiv">
				<form runat="server">
					<table class="content_table">
						<tr>
							<td align="right" class="auto-style1">请输入原密码:</td>
							<td class="auto-style1">
                                <asp:TextBox ID="txt_PTUPass" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
							</td>
						</tr>
                        <tr>
							<td align="right">请输入新密码:</td>
							<td>
                                <asp:TextBox ID="txt_NTUPass" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td align="right">再次输入新密码:</td>
							<td>
                                <asp:TextBox ID="txt_NTAPass" runat="server" CssClass="form-control" Width="200px" ></asp:TextBox>
                                <asp:CompareValidator ID="CV_CPass" runat="server" ControlToCompare="txt_NTUPass" ControlToValidate="txt_NTAPass" Display="Dynamic" ErrorMessage="*两次密码不一致" ForeColor="#FF3300"></asp:CompareValidator>
							</td>
						</tr>			
						<tr>
							<td colspan="2" align="center">
                                <asp:Button ID="btn_ModifyTeaPass" runat="server" Text="确认修改" CssClass="btn" OnClick="btn_ModifyTeaPass_Click1"  />
						    </td>
						</tr>			
					</table>
				</form>
			</div>
		</div>
	</div>
</asp:Content>
