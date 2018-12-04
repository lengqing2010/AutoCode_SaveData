<%@ Page Language="VB" AutoEventWireup="false" CodeFile="m_data.aspx.vb" Inherits="m_data" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1"  />
    <meta http-equiv="pragma" content="no-cache" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>資料</title>

    <!--JS-->
    <script language="javascript" type="text/javascript" src="./js/jquery-1.4.1.min.js"></script>
    <script language="javascript" type="text/javascript" src="./JidouTemp.js"></script>
    <script language="javascript" type="text/javascript" src="./m_data.aspx.js"></script>

    <!--CSS-->
    <link href="tmp.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
    <div>
        <div class='title_div'>資料</div>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        <hr />
<!--条件部-->
        <table class='jyouken_panel' cellpadding="0" cellspacing="0">
            <tr>
            <td>所有者 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxDataOwner_key" class="" runat="server" style="width:160px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td>ファイル名 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxFileName_key" class="" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td>EDP番号 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxEdpNo_key" class="" runat="server" style="width:128px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td>システム名 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxSystemName_key" class="" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td>Editor種類 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxEditorKind_key" class="" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
            </td>
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
      <table class='ms_title' style="width:1494px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:170px;">
                  所有者 10
              </td>
              <td style="width:210px;">
                  ファイル名 100
              </td>
              <td style="width:138px;">
                  EDP番号 8
              </td>
              <td style="width:210px;">
                  システム名 16
              </td>
              <td style="width:210px;">
                  Editor種類 20
              </td>
              <td style="width:138px;">
                  内容TXT 8
              </td>
              <td style="width:138px;">
                  内容HTML 8
              </td>
              <td style="width:30px;">
                  共有 1
              </td>
              <td style="">
                  登録時間 233
              </td>
          </tr>
      </table>
</div>

<!--明細Body部-->
<div id="divGvw" class='jq_ms_div' runat ="server" style="overflow:scroll ; height:294px;margin-left:0px; width:1020px; margin-top :0px; border-collapse :collapse ;">
      <table class='ms_input' style="width:1494px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:170px;">
              <asp:TextBox ID="tbxDataOwner" class="jq_data_owner_ipt" runat="server" style="width:164px;background-color: #FFAA00;"></asp:TextBox>
          </td>
              <td style="width:210px;">
              <asp:TextBox ID="tbxFileName" class="jq_file_name_ipt" runat="server" style="width:204px;background-color: #FFAA00;"></asp:TextBox>
          </td>
              <td style="width:138px;">
              <asp:TextBox ID="tbxEdpNo" class="jq_edp_no_ipt" runat="server" style="width:132px;background-color: #FFAA00;"></asp:TextBox>
          </td>
              <td style="width:210px;">
              <asp:TextBox ID="tbxSystemName" class="jq_system_name_ipt" runat="server" style="width:204px;background-color: #FFAA00;"></asp:TextBox>
          </td>
              <td style="width:210px;">
              <asp:TextBox ID="tbxEditorKind" class="jq_editor_kind_ipt" runat="server" style="width:204px;background-color: #FFAA00;"></asp:TextBox>
          </td>
              <td style="width:138px;">
              <asp:TextBox ID="tbxDataTxt" class="jq_data_txt_ipt" runat="server" style="width:132px;"></asp:TextBox>
          </td>
              <td style="width:138px;">
              <asp:TextBox ID="tbxDataHtml" class="jq_data_html_ipt" runat="server" style="width:132px;"></asp:TextBox>
          </td>
              <td style="width:30px;">
              <asp:TextBox ID="tbxShareType" class="jq_share_type_ipt" runat="server" style="width:24px;"></asp:TextBox>
          </td>
              <td style="">
              <asp:TextBox ID="tbxTourokuTime" class="jq_touroku_time_ipt" runat="server" style="width:100px;"></asp:TextBox>
          </td>
          </tr>
      </table>
   <asp:GridView CssClass ="jq_ms" Width="1494px"  runat="server" ID="gvMs" EnableTheming="True" ShowHeader="False" AutoGenerateColumns="False" BorderColor="black" style=" margin-top :-1px; " TabIndex="-1" >
      <Columns>
          <asp:TemplateField><ItemTemplate ><%#Eval("data_owner")%></ItemTemplate><ItemStyle Width="170px" HorizontalAlign="Left" CssClass="jq_data_owner" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("file_name")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_file_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_no")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_edp_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("system_name")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_system_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("editor_kind")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_editor_kind" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("data_txt")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_data_txt" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("data_html")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_data_html" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("share_type")%></ItemTemplate><ItemStyle Width="30px" HorizontalAlign="Left" CssClass="jq_share_type" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("touroku_time")%></ItemTemplate><ItemStyle  HorizontalAlign="Left" CssClass="jq_touroku_time" /></asp:TemplateField>
      </Columns>
   </asp:GridView>
</div>

        <asp:TextBox ID="hidDataOwner" runat="server" class="jq_data_owner_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidFileName" runat="server" class="jq_file_name_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidEdpNo" runat="server" class="jq_edp_no_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidSystemName" runat="server" class="jq_system_name_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidEditorKind" runat="server" class="jq_editor_kind_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidDataTxt" runat="server" class="jq_data_txt_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidDataHtml" runat="server" class="jq_data_html_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidShareType" runat="server" class="jq_share_type_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidTourokuTime" runat="server" class="jq_touroku_time_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidOldRowIdx" runat="server" class="jq_hidOldRowIdx" style=" visibility:hidden;"></asp:TextBox>
    </div>
    </form>
</body>
</html>
