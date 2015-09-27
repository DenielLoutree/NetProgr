<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Lab1.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 212px;
            width: 1461px;
        }
        #text {
            height: 93px;
            width: 1072px;
        }
    </style>
    <script>

        function initiate()
        {
            if (localStorage.getItem("text") != null) {
                document.getElementById("text").value = localStorage.getItem("text");
            }
        }

        function save()
        {
            localStorage.setItem("text", document.getElementById("text").value);
        }

        addEventListener("load", initiate);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    <p>
        <textarea id="text" name="S1"></textarea></p>
    <button onclick="save()">Сохранить</button>
</body>
</html>
