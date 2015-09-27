<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Lab2.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta charset="utf-8">
	</head>
	<body>
		<section>
			<div>
				<h1>Войти как админ</h1>
				<form action="do_login.aspx" method="post">
                    <% 
                        string code = GetErrorMessage();
                        if (code != null)
                        {
                            Response.Write(code);
                        }    
                    %>
					<div>
						<label class="text_label">Логин:</label>
					</div>
					<input type="text" class="login_element" name="username" id="username" autofocus="autofocus" tabindex="1" style="width: 200px" required/><br>
					<div>
						<label class="text_label">Пароль:</label>
					</div>
					<input type="password" class="login_element" name="userpassword" id="userpassword" tabindex="2" style="width: 200px" required/><br>
					<!--<label for="remember_me">Remember me on this device</label>
					<input type="checkbox" class="login_element" name="remember_me" id="remember_me" checked="checked" tabindex="3"/><br><br>-->
					<input type="submit" class="login_element" value="Войти" tabindex="4" style="text-align: center;">
				</form>
			</div>
		</section>
	</body>
</html>
