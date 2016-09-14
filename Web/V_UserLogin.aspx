<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="V_UserLogin.aspx.cs" Inherits="Web.V_UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <title>用户登录</title>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/> 
		<link rel="shortcut icon" href="images/logo.ico" type="image/x-icon"/>
        <link rel="stylesheet" type="text/css" href="css/Loginstyle.css" />
    </head>
    <body>
		<div class="wrapper">
			<div class="content">
				<div id="form_wrapper" class="form_wrapper">
					<form runat="server" class="login active">
						<h3>用户登录</h3>
						<div>
							<label>用户名:</label>
							<asp:TextBox ID="txt_UName" CssClass ="username" runat="server"></asp:TextBox>
							
						</div>
						<div>
							<label>密码: </label>
							<asp:TextBox ID="txt_UPass" CssClass ="pass" runat="server" TextMode="Password"></asp:TextBox>
							
						</div>
						<div>
							<label>身份: </label>
							<asp:DropDownList ID="DDL_URole" CssClass ="select" runat="server" OnSelectedIndexChanged="DDL_URole_SelectedIndexChanged">
                            </asp:DropDownList>
							
						</div>
						<div class="bottom">
							<asp:Button ID="btn_ULogin" runat="server" OnClick="btn_ULogin_Click" Text="登录" />
							<div class="clear"></div>
						</div>
					</form>
					
				</div>
				<div class="clear"></div>
			</div>
		</div>
	
    </body>
</html>
