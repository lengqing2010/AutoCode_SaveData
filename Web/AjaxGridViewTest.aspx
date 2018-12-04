<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AjaxGridViewTest.aspx.vb" Inherits="AjaxGridViewTest" %>

<!DOCTYPE html>


<html xmlns ="http://www.w3.org/1999/xhtml"> 
<head id ="Head1" runat ="server"> 
   <title> 使用 AJAX，局部刷新 GridView 进行数据绑定的简单实现 </title> 

   <script type ="text/javascript"> 
     function GetData(p) {
      document.getElementById( "d" ).innerHTML = " 正在读取数据…… " ;
      h = window.XMLHttpRequest ? new window.XMLHttpRequest() : new ActiveXObject( "MSXML2.XMLHTTP" );
      h.open( "GET" , ' <%=Request.FilePath %>?id= ' + p.value, true );
      h.onreadystatechange = function () {
         if (h.readyState == 4 ) {
           if (h.status>= 200 && h.status <300 ) {
            document.getElementById( "d" ).innerHTML = h.responseText;
          }
           else {
            //document.getElementById( "d" ).innerHTML = " <h2>数据操作错误：</h2> " + h.responseText;
          }
        }
      }
      h.send( null );
    }
    alert( " 这个提示，只出现在第一次打开页面。 " );
   </script> 
</head> 
<body> 
   <form id ="form1" runat ="server"> 
   
   <asp:Panel ID ="Header" runat ="server"></asp:Panel> 
   <select onchange ="GetData(this)"> 
     <option value ="1"> 项目一 </option> 
     <option value ="2"> 项目二 </option> 
   </select> 
    <asp:button runat="server" text="Button" OnClick="Unnamed1_Click" />

   </form> 
   <div id ="d" runat ="server"><asp:GridView ID ="GridView1" runat ="server"></asp:GridView></div>
     
</body> 
</html> 


