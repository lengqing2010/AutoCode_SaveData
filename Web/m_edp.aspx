<%@ Page Language="VB" AutoEventWireup="false" CodeFile="m_edp.aspx.vb" Inherits="m_edp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1"  />
    <meta http-equiv="pragma" content="no-cache" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>ファイル種類</title>

    <!--JS-->
    <script language="javascript" type="text/javascript" src="./js/jquery-1.4.1.min.js"></script>
    <script language="javascript" type="text/javascript" src="./JidouTemp.js"></script>
    <script language="javascript" type="text/javascript" src="./m_edp.aspx.js"></script>

    <!--CSS-->
    <link href="tmp.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
    <div>
        <div class='title_div'>ファイル種類</div>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        <hr />
<!--条件部-->
        <table class='jyouken_panel' cellpadding="0" cellspacing="0">
            <tr>
            <td>EDP_番号 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxEdpNo_key" class="jq_edp_no_key" runat="server" style="width:160px;background-color: #FFAA00;"></asp:TextBox>
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
      <table class='ms_title' style="width:420px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:170px;">
                  EDP_番号 10
              </td>
              <td style="width:210px;">
                  EDP_名 200
              </td>
              <td style="">
                  STAUS 1
              </td>
          </tr>
      </table>
</div>

<!--明細Body部-->
<div id="divGvw" class='jq_ms_div' runat ="server" style="overflow:scroll ; height:294px;margin-left:0px; width:1020px; margin-top :0px; border-collapse :collapse ;">
      <table class='ms_input' style="width:420px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:170px;">
              <asp:TextBox ID="tbxEdpNo" class="jq_edp_no_ipt" runat="server" style="width:164px;background-color: #FFAA00;"></asp:TextBox>
          </td>
              <td style="width:210px;">
              <asp:TextBox ID="tbxEdpName" class="jq_edp_name_ipt" runat="server" style="width:204px;"></asp:TextBox>
          </td>
              <td style="">
              <asp:TextBox ID="tbxEdpStaus" class="jq_edp_staus_ipt" runat="server" style="width:20px;"></asp:TextBox>
          </td>
          </tr>
      </table>
   <asp:GridView CssClass ="jq_ms" Width="420px"  runat="server" ID="gvMs" EnableTheming="True" ShowHeader="False" AutoGenerateColumns="False" BorderColor="black" style=" margin-top :-1px; " TabIndex="-1" >
      <Columns>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_no")%></ItemTemplate><ItemStyle Width="170px" HorizontalAlign="Left" CssClass="jq_edp_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_name")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_edp_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_staus")%></ItemTemplate><ItemStyle  HorizontalAlign="Left" CssClass="jq_edp_staus" /></asp:TemplateField>
      </Columns>
   </asp:GridView>
</div>

        <asp:TextBox ID="hidEdpNo" runat="server" class="jq_edp_no_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidEdpName" runat="server" class="jq_edp_name_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidEdpStaus" runat="server" class="jq_edp_staus_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidOldRowIdx" runat="server" class="jq_hidOldRowIdx" style=" visibility:hidden;"></asp:TextBox>
    </div>
    </form>
</body>
</html>
