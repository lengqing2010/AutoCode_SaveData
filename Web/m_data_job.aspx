<%@ Page Language="VB" AutoEventWireup="false" CodeFile="m_data_job.aspx.vb" Inherits="m_data_job" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1"  />
    <meta http-equiv="pragma" content="no-cache" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>仕事データ</title>

    <!--JS-->
    <script language="javascript" type="text/javascript" src="./js/jquery-1.4.1.min.js"></script>
    <script language="javascript" type="text/javascript" src="./JidouTemp.js"></script>
    <script language="javascript" type="text/javascript" src="./m_data_job.aspx.js"></script>

    <!--Editor Import-->
    <script src="src-noconflict/ace.js" type="text/javascript" charset="utf-8"></script>
    <script src="src-noconflict/ext-language_tools.js" type="text/javascript" charset="utf-8"></script>

    <!--CSS-->
    <link href="tmp.css" rel="stylesheet" type="text/css" />
</head>
<body>
<form id="form1" runat="server">
    <div>
        <div class='title_div'>仕事データ</div>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
               
        <hr />
<!--条件部-->
        <table class='jyouken_panel' cellpadding="0" cellspacing="0">
            <tr>
            <th>項目</th>
            <th>
                INPUT</th>
            <th> 説明</th>
            <th> MS</th>
            <th> &nbsp;</th>
            <th> &nbsp;</th>
            </tr>
            <tr>
            <td>INDEX : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxIdx_key" class="jq_idx_key" runat="server" style="width:64px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            <td> キー</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            <td> <asp:Button ID="btnSelect" runat="server" Text="Select" CssClass="jq_sel" Width="80" OnClientClick="ajax_select();return false;" /></td>
            </tr>
            <tr>
            <td>資料分類 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxSiryouKind_key" class="jq_siryou_kind_key" runat="server" style="width:20px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            <td> 0:案件、1:技術　</td>
            <td> &nbsp;</td>
            <td> 

        
                &nbsp;</td>
            <td> 

                &nbsp;</td>
            </tr>
            <tr>
            <td>システム名 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxSystemName_key" class="jq_system_name_key" runat="server" style="width:200px;background-color: #FFAA00;" list="tbxSystemName_key_list"></asp:TextBox>
              <datalist id="tbxSystemName_key_list"></datalist>
            </td>
            <td> VAPM、SA</td>
            <td> <input type ="button" value="EDIT" style="height:20px;" onclick="window.open('m_system_name.aspx')" /></td>
            <td> 
                &nbsp;</td>
            <td> &nbsp;</td>
            </tr>

            <tr>
            <td>EDP番号 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxEdpNo_key" class="jq_edp_no_key" runat="server" style="width:128px;background-color: #FFAA00;" list="tbxEdpNo_key_list"></asp:TextBox>
              <datalist id="tbxEdpNo_key_list"></datalist>
            </td>
            <td> 自分：Zxxxxxx Company：Rxxxxx</td>
            <td> <input type ="button" value="EDIT" style="height:20px;" onclick="window.open('m_edp.aspx')" /></td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>

            <tr>
            <td>機能名 : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxKinouName_key" class="jq_kinou_name_key" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            <td> 機能名</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>


            <tr>
            <td>DB接続No : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxConnectNo_key" class="jq_connect_no_key" runat="server" style="width:600px;background-color: #FFAA00;" list="tbxConnectNo_key_list"></asp:TextBox>
              <datalist id="tbxConnectNo_key_list"></datalist>
            </td>
            <td> DB接続</td>
            <td> <input type ="button" value="EDIT" style="height:20px;" onclick="window.open('m_db_connect.aspx')" /></td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>
            <tr>
            <td>メニューNo : &nbsp;</td>
            <td>
              <asp:TextBox ID="tbxMenuNo_key" class="jq_menu_no_key" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
            </td>
            <td> メニューNo（空白可）</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>
            <tr>
            <td>ファイル名</td>
            <td><asp:TextBox ID="tbxFileName" class="jq_file_name_ipt" runat="server" style="width:204px;"></asp:TextBox></td>
            <td></td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>
            <tr>
            <td>共有</td>
            <td>
                 <asp:DropDownList ID="ddlShareType" runat="server" Width="100px" BackColor="#EEE8AA" CssClass="txt">
                     <asp:ListItem Value="1">1:共有</asp:ListItem>
                     <asp:ListItem Value="0">0:自分</asp:ListItem>
                 </asp:DropDownList>  
            </td>
            <td>&nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>
            <tr>
            <td>USER</td>
            <td>
                 <asp:TextBox ID="tbxDataOwner" class="jq_data_owner_ipt" runat="server" style="width:164px;"></asp:TextBox>
  
            </td>
            <td>&nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>
            <tr>
            <td>Editor種類 : &nbsp;</td>
            <td>
                <asp:DropDownList ID="ddlType" runat="server" Width="100px" BackColor="#EEE8AA" CssClass="txt">
                    <asp:ListItem Value=""></asp:ListItem>
            <asp:ListItem Value="text">Text</asp:ListItem>
            <asp:ListItem Value="sqlserver">SQLServer</asp:ListItem>
            <asp:ListItem Value="sql">SQL</asp:ListItem>
            <asp:ListItem Value="mysql">MySQL</asp:ListItem>
            <asp:ListItem Value="javascript">JavaScript</asp:ListItem>
            <asp:ListItem Value="vbscript">VBScript</asp:ListItem>
            <asp:ListItem Value="html">HTML</asp:ListItem>
            <asp:ListItem Value="rhtml">RHTML</asp:ListItem>
            <asp:ListItem Value="svg">SVG</asp:ListItem>
            <asp:ListItem Value="xml">XML</asp:ListItem>
            <asp:ListItem Value="pgsql">pgSQL</asp:ListItem>
            <asp:ListItem Value="php">PHP</asp:ListItem>
            <asp:ListItem Value="abap">ABAP</asp:ListItem>
            <asp:ListItem Value="abc">ABC</asp:ListItem>
            <asp:ListItem Value="css">CSS</asp:ListItem>
            <asp:ListItem Value="csharp">C#</asp:ListItem>
            <asp:ListItem Value="actionscript">ActionScript</asp:ListItem>
            <asp:ListItem Value="ada">ADA</asp:ListItem>
            <asp:ListItem Value="apache_conf">Apache Conf</asp:ListItem>
            <asp:ListItem Value="asciidoc">AsciiDoc</asp:ListItem>
            <asp:ListItem Value="assembly_x86">Assembly x86</asp:ListItem>
            <asp:ListItem Value="autohotkey">AutoHotKey</asp:ListItem>
            <asp:ListItem Value="batchfile">BatchFile</asp:ListItem>
            <asp:ListItem Value="bro">Bro</asp:ListItem>
            <asp:ListItem Value="c_cpp">C and C++</asp:ListItem>
            <asp:ListItem Value="c9search">C9Search</asp:ListItem>
            <asp:ListItem Value="cirru">Cirru</asp:ListItem>
            <asp:ListItem Value="clojure">Clojure</asp:ListItem>
            <asp:ListItem Value="cobol">Cobol</asp:ListItem>
            <asp:ListItem Value="coffee">CoffeeScript</asp:ListItem>
            <asp:ListItem Value="coldfusion">ColdFusion</asp:ListItem>
            <asp:ListItem Value="csound_document">Csound Document</asp:ListItem>
            <asp:ListItem Value="csound_orchestra">Csound</asp:ListItem>
            <asp:ListItem Value="csound_score">Csound Score</asp:ListItem>
            <asp:ListItem Value="curly">Curly</asp:ListItem>
            <asp:ListItem Value="d">D</asp:ListItem>
            <asp:ListItem Value="dart">Dart</asp:ListItem>
            <asp:ListItem Value="diff">Diff</asp:ListItem>
            <asp:ListItem Value="dockerfile">Dockerfile</asp:ListItem>
            <asp:ListItem Value="dot">Dot</asp:ListItem>
            <asp:ListItem Value="drools">Drools</asp:ListItem>
            <asp:ListItem Value="dummy">Dummy</asp:ListItem>
            <asp:ListItem Value="dummysyntax">DummySyntax</asp:ListItem>
            <asp:ListItem Value="eiffel">Eiffel</asp:ListItem>
            <asp:ListItem Value="ejs">EJS</asp:ListItem>
            <asp:ListItem Value="elixir">Elixir</asp:ListItem>
            <asp:ListItem Value="elm">Elm</asp:ListItem>
            <asp:ListItem Value="erlang">Erlang</asp:ListItem>
            <asp:ListItem Value="forth">Forth</asp:ListItem>
            <asp:ListItem Value="fortran">Fortran</asp:ListItem>
            <asp:ListItem Value="ftl">FreeMarker</asp:ListItem>
            <asp:ListItem Value="gcode">Gcode</asp:ListItem>
            <asp:ListItem Value="gherkin">Gherkin</asp:ListItem>
            <asp:ListItem Value="gitignore">Gitignore</asp:ListItem>
            <asp:ListItem Value="glsl">Glsl</asp:ListItem>
            <asp:ListItem Value="gobstones">Gobstones</asp:ListItem>
            <asp:ListItem Value="golang">Go</asp:ListItem>
            <asp:ListItem Value="graphqlschema">GraphQLSchema</asp:ListItem>
            <asp:ListItem Value="groovy">Groovy</asp:ListItem>
            <asp:ListItem Value="haml">HAML</asp:ListItem>
            <asp:ListItem Value="handlebars">Handlebars</asp:ListItem>
            <asp:ListItem Value="haskell">Haskell</asp:ListItem>
            <asp:ListItem Value="haskell_cabal">Haskell Cabal</asp:ListItem>
            <asp:ListItem Value="haxe">haXe</asp:ListItem>
            <asp:ListItem Value="hjson">Hjson</asp:ListItem>
            <asp:ListItem Value="html_elixir">HTML (Elixir)</asp:ListItem>
            <asp:ListItem Value="html_ruby">HTML (Ruby)</asp:ListItem>
            <asp:ListItem Value="ini">INI</asp:ListItem>
            <asp:ListItem Value="io">Io</asp:ListItem>
            <asp:ListItem Value="jack">Jack</asp:ListItem>
            <asp:ListItem Value="jade">Jade</asp:ListItem>
            <asp:ListItem Value="java">Java</asp:ListItem>
            <asp:ListItem Value="json">JSON</asp:ListItem>
            <asp:ListItem Value="jsoniq">JSONiq</asp:ListItem>
            <asp:ListItem Value="jsp">JSP</asp:ListItem>
            <asp:ListItem Value="jssm">JSSM</asp:ListItem>
            <asp:ListItem Value="jsx">JSX</asp:ListItem>
            <asp:ListItem Value="julia">Julia</asp:ListItem>
            <asp:ListItem Value="kotlin">Kotlin</asp:ListItem>
            <asp:ListItem Value="latex">LaTeX</asp:ListItem>
            <asp:ListItem Value="less">LESS</asp:ListItem>
            <asp:ListItem Value="liquid">Liquid</asp:ListItem>
            <asp:ListItem Value="lisp">Lisp</asp:ListItem>
            <asp:ListItem Value="livescript">LiveScript</asp:ListItem>
            <asp:ListItem Value="logiql">LogiQL</asp:ListItem>
            <asp:ListItem Value="lsl">LSL</asp:ListItem>
            <asp:ListItem Value="lua">Lua</asp:ListItem>
            <asp:ListItem Value="luapage">LuaPage</asp:ListItem>
            <asp:ListItem Value="lucene">Lucene</asp:ListItem>
            <asp:ListItem Value="makefile">Makefile</asp:ListItem>
            <asp:ListItem Value="markdown">Markdown</asp:ListItem>
            <asp:ListItem Value="mask">Mask</asp:ListItem>
            <asp:ListItem Value="matlab">MATLAB</asp:ListItem>
            <asp:ListItem Value="maze">Maze</asp:ListItem>
            <asp:ListItem Value="mel">MEL</asp:ListItem>
            <asp:ListItem Value="mushcode">MUSHCode</asp:ListItem>
            <asp:ListItem Value="nix">Nix</asp:ListItem>
            <asp:ListItem Value="nsis">NSIS</asp:ListItem>
            <asp:ListItem Value="objectivec">Objective-C</asp:ListItem>
            <asp:ListItem Value="ocaml">OCaml</asp:ListItem>
            <asp:ListItem Value="pascal">Pascal</asp:ListItem>
            <asp:ListItem Value="perl">Perl</asp:ListItem>
            <asp:ListItem Value="pig">Pig</asp:ListItem>
            <asp:ListItem Value="powershell">Powershell</asp:ListItem>
            <asp:ListItem Value="praat">Praat</asp:ListItem>
            <asp:ListItem Value="prolog">Prolog</asp:ListItem>
            <asp:ListItem Value="properties">Properties</asp:ListItem>
            <asp:ListItem Value="protobuf">Protobuf</asp:ListItem>
            <asp:ListItem Value="python">Python</asp:ListItem>
            <asp:ListItem Value="r">R</asp:ListItem>
            <asp:ListItem Value="razor">Razor</asp:ListItem>
            <asp:ListItem Value="rdoc">RDoc</asp:ListItem>
            <asp:ListItem Value="red">Red</asp:ListItem>
            <asp:ListItem Value="rst">RST</asp:ListItem>
            <asp:ListItem Value="ruby">Ruby</asp:ListItem>
            <asp:ListItem Value="rust">Rust</asp:ListItem>
            <asp:ListItem Value="sass">SASS</asp:ListItem>
            <asp:ListItem Value="scad">SCAD</asp:ListItem>
            <asp:ListItem Value="scala">Scala</asp:ListItem>
            <asp:ListItem Value="scheme">Scheme</asp:ListItem>
            <asp:ListItem Value="scss">SCSS</asp:ListItem>
            <asp:ListItem Value="sh">SH</asp:ListItem>
            <asp:ListItem Value="sjs">SJS</asp:ListItem>
            <asp:ListItem Value="smarty">Smarty</asp:ListItem>
            <asp:ListItem Value="snippets">snippets</asp:ListItem>
            <asp:ListItem Value="soy_template">Soy Template</asp:ListItem>
            <asp:ListItem Value="space">Space</asp:ListItem>
            <asp:ListItem Value="stylus">Stylus</asp:ListItem>
            <asp:ListItem Value="swift">Swift</asp:ListItem>
            <asp:ListItem Value="tcl">Tcl</asp:ListItem>
            <asp:ListItem Value="tex">Tex</asp:ListItem>
            <asp:ListItem Value="textile">Textile</asp:ListItem>
            <asp:ListItem Value="toml">Toml</asp:ListItem>
            <asp:ListItem Value="tsx">TSX</asp:ListItem>
            <asp:ListItem Value="twig">Twig</asp:ListItem>
            <asp:ListItem Value="typescript">Typescript</asp:ListItem>
            <asp:ListItem Value="vala">Vala</asp:ListItem>
            <asp:ListItem Value="velocity">Velocity</asp:ListItem>
            <asp:ListItem Value="verilog">Verilog</asp:ListItem>
            <asp:ListItem Value="vhdl">VHDL</asp:ListItem>
            <asp:ListItem Value="wollok">Wollok</asp:ListItem>
            <asp:ListItem Value="xquery">XQuery</asp:ListItem>
            <asp:ListItem Value="yaml">YAML</asp:ListItem>
            <asp:ListItem Value="django">Django</asp:ListItem>
        </asp:DropDownList>  
             <%-- <asp:TextBox ID="tbxEditorKind_key" class="jq_editor_kind_key" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>--%>
            </td>
            <td> Editorの TXT、VBS</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            <td> &nbsp;</td>
            </tr>           
        </table>
        <br /> <hr />

<!--Button部-->

        
        <asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="jq_ins" Width="80" OnClientClick="ajax_insert();return false;" />

        
        <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="jq_upd" Width="80" OnClientClick="ajax_update();return false;" /> 

        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="jq_del" Width="80" OnClientClick="ajax_delete();return false;" />

 <br /> <hr />

<!--明細Title部-->
<div id="divGvwTitle" class='jq_title_div' runat ="server" style="overflow:hidden ;margin-left:0px; width:1004px; margin-top :0px; border-collapse :collapse ;">
      <table class='ms_title' style="width:1000px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:44px;">
                  INDEX
              </td>
              <td style="width:30px;">
                  資料分類 
              </td>
              <td style="width:110px;">
                  システム名 
              </td>
              <td style="width:210px;">
                  機能名 
              </td>
              <td style="width:68px;">
                  EDP番号 
              </td>
              <td style="width:80px;">
                  Editor種類 
              </td>
              <td style="width:74px;">
                  DB接続No
              </td>
              <td style="width:70px;">
                  メニューNo 
              </td>
              <td style="">
                  ファイル名 
              </td>
          </tr>
      </table>
</div>

<!--明細Body部-->
<div id="divGvw" class='jq_ms_div' runat ="server" style="overflow:scroll ; height:180px;margin-left:0px; width:1020px; margin-top :0px; border-collapse :collapse ;">
   <asp:GridView CssClass ="jq_ms" Width="1000px"  runat="server" ID="gvMs" EnableTheming="True" ShowHeader="False" AutoGenerateColumns="False" BorderColor="black" style=" margin-top :-1px; " TabIndex="-1" >
      <Columns>
          <asp:TemplateField><ItemTemplate ><%#Eval("idx")%></ItemTemplate><ItemStyle Width="44px" HorizontalAlign="Left" CssClass="jq_idx" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("siryou_kind")%></ItemTemplate><ItemStyle Width="30px" HorizontalAlign="Left" CssClass="jq_siryou_kind" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("system_name")%></ItemTemplate><ItemStyle Width="110px" HorizontalAlign="Left" CssClass="jq_system_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("kinou_name")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_kinou_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_no")%></ItemTemplate><ItemStyle Width="68px" HorizontalAlign="Left" CssClass="jq_edp_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("editor_kind")%></ItemTemplate><ItemStyle Width="80px" HorizontalAlign="Left" CssClass="jq_editor_kind" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("connect_no")%></ItemTemplate><ItemStyle Width="74px" HorizontalAlign="Left" CssClass="jq_connect_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("menu_no")%></ItemTemplate><ItemStyle Width="70px" HorizontalAlign="Left" CssClass="jq_menu_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("file_name")%></ItemTemplate><ItemStyle Width="" HorizontalAlign="Left" CssClass="jq_file_name" /></asp:TemplateField>

      </Columns>
   </asp:GridView>
</div>
 <div style="height:1200px;" id="editorDiv"></div>
        <asp:TextBox ID="hidIdx" runat="server" class="jq_idx_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidSiryouKind" runat="server" class="jq_siryou_kind_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidSystemName" runat="server" class="jq_system_name_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidKinouName" runat="server" class="jq_kinou_name_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidEdpNo" runat="server" class="jq_edp_no_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidEditorKind" runat="server" class="jq_editor_kind_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidConnectNo" runat="server" class="jq_connect_no_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidMenuNo" runat="server" class="jq_menu_no_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidFileName" runat="server" class="jq_file_name_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidDataTxt" runat="server" class="jq_data_txt_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidDataHtml" runat="server" class="jq_data_html_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidShareType" runat="server" class="jq_share_type_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidDataOwner" runat="server" class="jq_data_owner_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidTourokuTime" runat="server" class="jq_touroku_time_ipt" style=" visibility:hidden;"></asp:TextBox>
        <asp:TextBox ID="hidOldRowIdx" runat="server" class="jq_hidOldRowIdx" style=" visibility:hidden;"></asp:TextBox>
    </div>

    <script>

        var editor;

        $(document).ready(function () {
            editor = ace.edit("editorDiv");
            //设置编辑器样式，对应theme-*.js文件
            editor.setTheme("ace/theme/twilight");
            //设置代码语言，对应mode-*.js文件
            editor.session.setMode("ace/mode/javascript");
            //设置打印线是否显示
            editor.setShowPrintMargin(false);
            //设置是否只读
            editor.setReadOnly(false);

            editor.setFontSize(16);

            //以下部分是设置输入代码提示的，如果不需要可以不用引用ext-language_tools.js
            ace.require("ace/ext/language_tools");
            editor.setOptions({
                enableBasicAutocompletion: true,
                enableSnippets: true,
                enableLiveAutocompletion: true
            });


            $("#ddlType").change(function () {
                setTimeout(function () {
                    editor.session.setMode('ace/mode/' + $('#ddlType').val());
                    //alert($('#ddlType').val());
                }, 200);
            })




        });

      

    </script>

    </form>
</body>
</html>
