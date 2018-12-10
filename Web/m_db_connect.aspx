<%@ Page Language="VB" AutoEventWireup="false" CodeFile="m_db_connect.aspx.vb" Inherits="m_db_connect" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1"  />
    <meta http-equiv="pragma" content="no-cache" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>DB接続情報</title>

    <!--JS-->
    <script language="javascript" type="text/javascript" src="./js/jquery-1.4.1.min.js"></script>
    <script language="javascript" type="text/javascript" src="./JidouTemp.js"></script>
    <script language="javascript" type="text/javascript" src="./m_db_connect.aspx.js"></script>

    <!--CSS-->
    <link href="tmp.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
    <div>
        <div class='title_div'>DB接続情報</div>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        <hr />
<!--条件部-->
        <table class='jyouken_panel' cellpadding="0" cellspacing="0">
            <tr>
            <td>DB接続No : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxConnectNo_key" class="jq_connect_no_key" runat="server" style="width:64px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            <td></td>
            </tr>
        </table>
        <br /> <hr />

<!--Button部-->
        <asp:Button ID="btnSelect" runat="server" Text="Select" CssClass="jq_sel" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="jq_upd" />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="jq_ins" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="jq_del" />
 <br /> <hr />

<!--明細Title部-->
<div id="divGvwTitle" class='jq_title_div' runat ="server" style="overflow:hidden ;margin-left:0px; width:1004px; margin-top :0px; border-collapse :collapse ;">
      <table class='ms_title' style="width:1004px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:74px;">
                  DB接続No 4
              </td>
              <td style="width:210px;">
                  －ＣＯＮＮＥＣＴ－ＮＡＭＥ 200
              </td>
              <td style="">
                  －ＣＯＮＮＥＣＴ－ＳＴＲ 200
              </td>
          </tr>
      </table>
</div>

<!--明細Body部-->
<div id="divGvw" class='jq_ms_div' runat ="server" style="overflow:scroll ; height:294px;margin-left:0px; width:1020px; margin-top :0px; border-collapse :collapse ;">
      <table class='ms_input' style="width:1004px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:74px;">
              <asp:TextBox ID="tbxConnectNo" class="jq_connect_no_ipt" runat="server" style="width:68px;background-color: #FFAA00;"></asp:TextBox>
          </td>
              <td style="width:210px;">
              <asp:TextBox ID="tbxConnectName" class="jq_connect_name_ipt" runat="server" style="width:204px;"></asp:TextBox>
          </td>
              <td style="">
              <asp:TextBox ID="tbxConnectStr" class="jq_connect_str_ipt" runat="server" style="width:600px;"></asp:TextBox>
          </td>
          </tr>
      </table>
   <asp:GridView CssClass ="jq_ms" Width="1004px"  runat="server" ID="gvMs" EnableTheming="True" ShowHeader="False" AutoGenerateColumns="False" BorderColor="black" style=" margin-top :-1px; " TabIndex="-1" >
      <Columns>
          <asp:TemplateField><ItemTemplate ><%#Eval("connect_no")%></ItemTemplate><ItemStyle Width="74px" HorizontalAlign="Left" CssClass="jq_connect_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("connect_name")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_connect_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("connect_str")%></ItemTemplate><ItemStyle  HorizontalAlign="Left" CssClass="jq_connect_str" /></asp:TemplateField>
      </Columns>
   </asp:GridView>
</div>

        <asp:TextBox ID="hidConnectNo" runat="server" class="jq_connect_no_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidConnectName" runat="server" class="jq_connect_name_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidConnectStr" runat="server" class="jq_connect_str_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidOldRowIdx" runat="server" class="jq_hidOldRowIdx" style=" visibility:hidden;"></asp:TextBox>
    </div>
    </form>
</body>
</html>
