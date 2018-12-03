﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SaveData.aspx.vb" Inherits="SaveData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge,chrome=1"  />
    <meta http-equiv="pragma" content="no-cache" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="tmp.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript" src="js/jquery-1.4.1.min.js"></script>
    <script language="javascript" type="text/javascript" src="JidouTemp.js"></script>
    <!--TEXT 导入js库-->
    <script src="src-noconflict/ace.js" type="text/javascript" charset="utf-8"></script>
    <script src="src-noconflict/ext-language_tools.js" type="text/javascript" charset="utf-8"></script>




    <script type="text/javascript">


        //$(document).ready(function () {
        //    ace.require("ace/ext/language_tools");
        //    var editor = ace.edit('editor');
        //    editor.$blockScrolling = Infinity;
        //    editor.setFontSize(16);
        //    editor.session.setMode("ace/mode/c_cpp");
        //    editor.setOptions({
        //        enableBasicAutocompletion: true,
        //        enableSnippets: true,
        //        enableLiveAutocompletion: true
        //    });
        //    editor.setTheme("ace/theme/chrome");
   



        //});

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>

      <table class='jyouken_panel' cellpadding="0" cellspacing="0">
          <tr>
          <td>
              EDP番号 : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxedpNo_key" class="" runat="server" style="width:160px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          </tr>
          <tr>
          <td>
              システム名 : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxsystemName_key" class="" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
          

          
          </td>
          </tr>
          <tr>
          <td>
              種類 : &nbsp;
          </td>
          <td>
                    <asp:DropDownList ID="ddlType" runat="server" Width="100px" BackColor="#EEE8AA" CssClass="txt">
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
        </asp:DropDownList>          </td>
          </tr>


          <tr>
          <td>
              タイトル : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxtitle_key" class="" runat="server" style="width:600px;background-color: #fff;"></asp:TextBox>
          </td>
          </tr>

          <tr>
          <td>
              子タイトル : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxChildtitle_key" class="" runat="server" style="width:600px;background-color: #fff;"></asp:TextBox>
          </td>
          </tr>

          <tr>
          <td>
              保存パス: &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxSavePath" class="" runat="server" style="width:600px;background-color: #fff;"></asp:TextBox>
          </td>
          </tr>

          <tr>
          <td>
              共有: &nbsp;
          </td>
          <td>
              
              &nbsp;&nbsp;<asp:CheckBox ID="cbShare" runat="server" Text="" Width="20" />共有
              
          </td>
          </tr>
      </table>

<div id="divGvwTitle" class='jq_title_div' runat ="server" style="overflow:hidden ;margin-left:0px; width:1003px; margin-top :0px; border-collapse :collapse ;">
      <table class='ms_title' style="width:2790px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:74px;">
                  番号 4
              </td>
              <td style="width:170px;">
                  EDP番号 10
              </td>
              <td style="width:210px;">
                  システム名 50
              </td>
              <td style="width:210px;">
                  種類 20
              </td>
              <td style="width:210px;">
                  タイトル 200
              </td>
              <td style="width:210px;">
                  子タイトル 200
              </td>
              <td style="width:138px;">
                  内容TXT 8
              </td>
              <td style="width:138px;">
                  内容HTML 8
              </td>
              <td style="width:138px;">
                  添付ファイル１ 8
              </td>
              <td style="width:138px;">
                  添付ファイル２ 8
              </td>
              <td style="width:138px;">
                  添付ファイル３ 8
              </td>
              <td style="width:138px;">
                  添付ファイル４ 8
              </td>
              <td style="width:138px;">
                  添付ファイル５ 8
              </td>
              <td style="width:210px;">
                  保存パス 800
              </td>
              <td style="width:30px;">
                  共有 1
              </td>
              <td style="width:210px;">
                  登録者 20
              </td>
              <td style="">
                  登録時間 233
              </td>
          </tr>
          <tr>
          <td>
              <asp:TextBox ID="tbxNo" class="jq_no_ipt" runat="server" style="width:70px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxEdpNo" class="jq_edp_no_ipt" runat="server" style="width:166px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxSystemName" class="jq_system_name_ipt" runat="server" style="width:206px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxKind" class="jq_kind_ipt" runat="server" style="width:206px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxTitle" class="jq_title_ipt" runat="server" style="width:206px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxChildTitle" class="jq_child_title_ipt" runat="server" style="width:206px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxDataTxt" class="jq_data_txt_ipt" runat="server" style="width:134px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxDataHtml" class="jq_data_html_ipt" runat="server" style="width:134px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxEnclosure1" class="jq_enclosure1_ipt" runat="server" style="width:134px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxEnclosure2" class="jq_enclosure2_ipt" runat="server" style="width:134px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxEnclosure3" class="jq_enclosure3_ipt" runat="server" style="width:134px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxEnclosure4" class="jq_enclosure4_ipt" runat="server" style="width:134px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxEnclosure5" class="jq_enclosure5_ipt" runat="server" style="width:134px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="TextBox1" class="jq_save_path_ipt" runat="server" style="width:206px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxShareType" class="jq_share_type_ipt" runat="server" style="width:26px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxTourokuUser" class="jq_touroku_user_ipt" runat="server" style="width:206px;"></asp:TextBox>
          </td>
          <td>
              <asp:TextBox ID="tbxTourokuTime" class="jq_touroku_time_ipt" runat="server" style="width:200px;"></asp:TextBox>
          </td>
          </tr>
      </table>
</div>
<div id="divGvw" class='jq_ms_div' runat ="server" style="overflow:scroll ; height:294px;margin-left:0px; width:1020px; margin-top :0px; border-collapse :collapse ;">
   <asp:GridView CssClass ="jq_ms" Width="2790px"  runat="server" ID="gvMs" EnableTheming="True" ShowHeader="False" AutoGenerateColumns="False" BorderColor="black" style=" margin-top :-1px; " TabIndex="-1" >
      <Columns>
          <asp:TemplateField><ItemTemplate ><%#Eval("no")%></ItemTemplate><ItemStyle Width="74px" HorizontalAlign="Left" CssClass="jq_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("edp_no")%></ItemTemplate><ItemStyle Width="170px" HorizontalAlign="Left" CssClass="jq_edp_no" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("system_name")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_system_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("kind")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_kind" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("title")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_title" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("child_title")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_child_title" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("data_txt")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_data_txt" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("data_html")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_data_html" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("enclosure1")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_enclosure1" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("enclosure2")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_enclosure2" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("enclosure3")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_enclosure3" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("enclosure4")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_enclosure4" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("enclosure5")%></ItemTemplate><ItemStyle Width="138px" HorizontalAlign="Left" CssClass="jq_enclosure5" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("save_path")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_save_path" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("share_type")%></ItemTemplate><ItemStyle Width="30px" HorizontalAlign="Left" CssClass="jq_share_type" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("touroku_user")%></ItemTemplate><ItemStyle Width="210px" HorizontalAlign="Left" CssClass="jq_touroku_user" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("touroku_time")%></ItemTemplate><ItemStyle  HorizontalAlign="Left" CssClass="jq_touroku_time" /></asp:TemplateField>
      </Columns>
   </asp:GridView>
</div>

        <input type ="button" value="save" onclick="save_ajax()" />

        <div style="height:300px;" id="editorDiv"></div>
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


        function save_ajax() {

            $.ajax({
                //提交数据的类型 POST GET
                type: "POST",
                //提交的网址
                url: "SaveDataAjax.aspx",
                //提交的数据
                data: {
                    type:'save'
                    ,  tbxedpNo_key: $("#tbxedpNo_key").val()
                    , tbxsystemName_key: $("#tbxsystemName_key").val()
                    , tbxtitle_key: $("#tbxtitle_key").val()
                    , tbxChildtitle_key: $("#tbxChildtitle_key").val()
                    , kind: $("#ddlType").val()
                    , tbxSavePath: $("#tbxSavePath").val()
                    , shareType: $("#cbShare").val()
                    , data_txt: editor.getValue()
                    , data_html: ''
                    

                },
                //返回数据的格式
                datatype: "html",//"xml", "html", "script", "json", "jsonp", "text".
                //在请求之前调用的函数
                beforeSend: function () {
                    //$("#msg").html("logining");
                },
                //成功返回之后调用的函数             
                success: function (data) {
                    //$("#msg").html(decodeURI(data));
                    //alert('ajax success');
                },
                //调用执行后调用的函数
                complete: function (XMLHttpRequest, textStatus) {
                    alert(XMLHttpRequest.responseText);
                    alert(textStatus);
                    //HideLoading();
                },
                //调用出错执行的函数
                error: function () {
                    //请求出错处理
                }
            });
        }

    </script>

    </form>
</body>
</html>
