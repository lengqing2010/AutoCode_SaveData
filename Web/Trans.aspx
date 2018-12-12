<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Trans.aspx.vb" Inherits="Trans" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!--JS-->
    <script language="javascript" type="text/javascript" src="./js/jquery-1.4.1.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" value="exciteTran" />


        <iframe id="excite" name="excite" src="" width="100%" height="1000px">


        </iframe>
    <script>
        $(document).ready(function () {

            var iframe;
            iframe = document.getElementById("excite");
            $(iframe).attr("src", "https://www.excite.co.jp/world/chinese/");
            if (iframe.attachEvent) {    
                iframe.attachEvent("onload", function () {
                    alert(iframe.document);
                    //iframe加载完成后你需要进行的操作  
                    Reload_excite();
                });    
            } else {    
                iframe.onload = function () {
                    alert(iframe.document);
                    Reload_excite();
                    //iframe加载完成后你需要进行的操作  
                };    
            }    

            //$.ajax({

            //    cache: false,

            //    type: "get",

            //    url: "https://www.excite.co.jp/world/chinese/",

            //    success: function (data) {
            //        alert(data);
            //        $(window.frames["excite"].document).html(data.replace("<img", "<noimg"));
            //    }

            //});
           
        });

        function Reload_excite() {

        }
    </script>
    </div>
    </form>
</body>
</html>
