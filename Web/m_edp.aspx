<%@ Page Language="VB" AutoEventWireup="false" CodeFile="m_edp.aspx.vb" Inherits="m_edp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1"  />
  <meta http-equiv="pragma" content="no-cache" />
  <link href="tmp.css" rel="stylesheet" type="text/css" />
  <title>EDP情報</title>
<script language="javascript" type="text/javascript" src="js/jquery-1.4.1.min.js"></script>
<script language="javascript" type="text/javascript" src="JidouTemp.js"></script>
</head>
<body>
<form id="form1" runat="server">
  <div>
      <div class='title_div'>EDP情報</div>
      <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
  <hr />
      <table class='jyouken_panel' cellpadding="0" cellspacing="0">
          <tr>
          <td>
              EDP NUMBER : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxEdpNo_key" class="" runat="server" style="width:160px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          </tr>
      </table>
 <br /> <hr />
        <asp:Button ID="btnSelect" runat="server" Text="Select" CssClass="jq_sel" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="jq_upd" />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="jq_ins" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="jq_del" />
 <br /> <hr />
      <table class='ms_title' style="width:385px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:170px;">
                  EDP NUMBER 10
              </td>
              <td style="">
                  EDP_名 200
              </td>
          </tr>
          <tr>
          <td>
              <asp:TextBox ID="tbxEdpNo" class="jq_edp_no_ipt" runat="server" style="width:166px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxEdpName" class="jq_edp_name_ipt" runat="server" style="width:200px;"></asp:TextBox>
          </td>
          </tr>
      </table>
<div id="divGvw" class='jq_ms_div' runat ="server" style="overflow:scroll ; height:294px;margin-left:0px; width:405px; margin-top :0px; border-collapse :collapse ;">
   <asp:GridView CssClass ="jq_ms" Width="385px"  runat="server" ID="gvMs" EnableTheming="True" ShowHeader="False" AutoGenerateColumns="False" BorderColor="black" style=" margin-top :-1px; " TabIndex="-1" >
      <Columns>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_no")%></ItemTemplate><ItemStyle Width="170px" HorizontalAlign="Left" CssClass="jq_edp_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_name")%></ItemTemplate><ItemStyle  HorizontalAlign="Left" CssClass="jq_edp_name" /></asp:TemplateField>
      </Columns>
   </asp:GridView>
</div>
<asp:TextBox ID="hidEdpNo" runat="server" class="jq_edp_no_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidEdpName" runat="server" class="jq_edp_name_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidOldRowIdx" runat="server" class="jq_hidOldRowIdx" style=" visibility:hidden;"></asp:TextBox>
    </div>
    </form>
</body>
</html>
