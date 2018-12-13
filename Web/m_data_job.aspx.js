//AJAX Reload GridView (Delete Insert Select)
function AjaxPost(ajaxActionType) {

    $('#btnUpdate').hide();
    $('#btnDelete').hide();

    $.ajax({
        type: 'POST',
        url: 'm_data_job.aspx',
        async:false,
        data: {
            ajaxActionType : ajaxActionType
            , tbxIdx_key:$('#tbxIdx_key').val()
            , tbxSiryouKind_key:$('#tbxSiryouKind_key').val()
            , tbxSystemName_key:$('#tbxSystemName_key').val()
            , tbxKinouName_key:$('#tbxKinouName_key').val()
            , tbxEdpNo_key: $('#tbxEdpNo_key').val().split(":")[0]
            , tbxEditorKind_key: $('#ddlType').val()
            , tbxConnectNo_key: $('#tbxConnectNo_key').val().split(":")[0]
            , tbxMenuNo_key:$('#tbxMenuNo_key').val()
            , tbxIdx: $('#tbxIdx_key').val()
            , tbxSiryouKind: $('#tbxSiryouKind_key').val()
            , tbxSystemName: $('#tbxSystemName_key').val()
            , tbxKinouName: $('#tbxKinouName_key').val()
            , tbxEdpNo: $('#tbxEdpNo_key').val().split(":")[0]
            , tbxEditorKind: $('#ddlType').val()
            , tbxConnectNo: $('#tbxConnectNo_key').val().split(":")[0]
            , tbxMenuNo: $('#tbxMenuNo_key').val()
            , tbxFileName:$('#tbxFileName').val()
            , tbxDataTxt: editor.getValue()
            , tbxDataHtml: editor2.getValue()
            , tbxShareType: $('#ddlShareType').val()
            , tbxDataOwner: $('#tbxDataOwner').val()
            , tbxTourokuTime: ''
            , txt_key: $('#tbxTxt').val()
        },
        datatype: 'json',//'xml', 'html', 'script', 'json', 'jsonp', 'text'.
        beforeSend: function () {
            WaitPanelRemove();
        },
        //when success
        success: function (data) {
            
            document.getElementById("divGvw").innerHTML = data;
            MsInit();
        },
        //when complete
        complete: function (XMLHttpRequest, textStatus) {
        },
        //when error
        error: function () {
            WaitPanelRemove();
            alert('Error');
        }
    });
}

//AJAX Reload GridView (Update)
function AjaxPostUpdate(ajaxActionType) {
    $.ajax({
        type: 'POST',
        url: 'm_data_job.aspx',
        async: false,
        data: {
            ajaxActionType: ajaxActionType
            , tbxIdx_key: $('#hidIdx').val()
            , tbxSiryouKind_key: $('#hidSiryouKind').val()
            , tbxSystemName_key: $('#hidSystemName').val()
            , tbxKinouName_key: $('#hidKinouName').val()
            , tbxEdpNo_key: $('#hidEdpNo').val().split(":")[0]
            , tbxEditorKind_key: $('#hidEditorKind').val()
            , tbxConnectNo_key: $('#hidConnectNo').val().split(":")[0]
            , tbxMenuNo_key: $('#hidMenuNo').val()
            , tbxIdx: $('#tbxIdx_key').val()
            , tbxSiryouKind: $('#tbxSiryouKind_key').val()
            , tbxSystemName: $('#tbxSystemName_key').val()
            , tbxKinouName: $('#tbxKinouName_key').val()
            , tbxEdpNo: $('#tbxEdpNo_key').val().split(":")[0]
            , tbxEditorKind: $('#ddlType').val()
            , tbxConnectNo: $('#tbxConnectNo_key').val().split(":")[0]
            , tbxMenuNo: $('#tbxMenuNo_key').val()
            , tbxFileName: $('#tbxFileName').val()
            , tbxDataTxt: editor.getValue()
            , tbxDataHtml: editor2.getValue()
            , tbxShareType: $('#ddlShareType').val()
            , tbxDataOwner: $('#tbxDataOwner').val()
            , tbxTourokuTime: ''
        },
        datatype: 'json',//'xml', 'html', 'script', 'json', 'jsonp', 'text'.
        beforeSend: function () {
            WaitPanelShow('');
        },
        //when success
        success: function (data) {
            document.getElementById("divGvw").innerHTML = data;
            MsInit();
        },
        //when complete
        complete: function (XMLHttpRequest, textStatus) {
            WaitPanelRemove();
        },
        //when error
        error: function () {
            alert('Error');
        }
    });
}
var splitor = "@!--lis-->||";
//AJAX editorの値を取得する
function AjaxPostTxt(ajaxActionType) {
    $.ajax({
        type: 'POST',
        url: 'm_data_job.aspx',
        async: false,
        data: {
            ajaxActionType: ajaxActionType
            , tbxIdx_key: $('#hidIdx').val()
            , tbxSiryouKind_key: $('#hidSiryouKind').val()
            , tbxSystemName_key: $('#hidSystemName').val()
            , tbxKinouName_key: $('#hidKinouName').val()
            , tbxEdpNo_key: $('#hidEdpNo').val().split(":")[0]
            , tbxEditorKind_key:$('#hidEditorKind').val()
            , tbxConnectNo_key: $('#hidConnectNo').val().split(":")[0]
            , tbxMenuNo_key: $('#hidMenuNo').val()
            , tbxIdx: $('#tbxIdx_key').val()
            , tbxSiryouKind: $('#tbxSiryouKind_key').val()
            , tbxSystemName: $('#tbxSystemName_key').val()
            , tbxKinouName: $('#tbxKinouName_key').val()
            , tbxEdpNo: $('#tbxEdpNo_key').val().split(":")[0]
            , tbxEditorKind: $('#ddlType').val()
            , tbxConnectNo: $('#tbxConnectNo_key').val().split(":")[0]
            , tbxMenuNo: $('#tbxMenuNo_key').val()
            , tbxFileName: $('#tbxFileName').val()
            , tbxDataTxt: editor.getValue()
            , tbxDataHtml: editor2.getValue()
            , tbxShareType: $('#ddlShareType').val()
            , tbxDataOwner: $('#tbxDataOwner').val()
            , tbxTourokuTime: ''
        },
        datatype: 'json',//'xml', 'html', 'script', 'json', 'jsonp', 'text'.
        beforeSend: function () {
            WaitPanelShow('');
        },
        //when success
        success: function (data) {
            var arr;
            arr = data.split(splitor);
            editor.setValue(arr[0]);
            editor2.setValue(arr[1]);
            $('#ddlShareType').val(arr[2]);
            $('#tbxDataOwner').val(arr[3]);

        },
        //when complete
        complete: function (XMLHttpRequest, textStatus) {
            WaitPanelRemove();
        },
        //when error
        error: function () {
            alert('Error');
        }
    });
}

// Do Ajax textboxのlist
function AjaxList(ajaxActionType, ajaxUrl, datalistId) {
    $.ajax({
        type: 'POST',
        url: ajaxUrl,
        async: false,
        data: {
            ajaxActionType: ajaxActionType
        },
        datatype: 'text',//'xml', 'html', 'script', 'json', 'jsonp', 'text'.
        beforeSend: function () {
            WaitPanelShow('');
        },
        //when success
        success: function (data) {
            var i, arr;
            arr = data.split(',');
            $(datalistId).empty();
            for (i = 0; i <= arr.length - 1; i++) {
                $(datalistId).append('<option value="' + arr[i] + '"></option>');
            }
        },
        //when complete
        complete: function (XMLHttpRequest, textStatus) {
            WaitPanelRemove();
        },
        //when error
        error: function () {
        }
    });
}


// Do Ajax SQL
function AjaxSQL(ajaxActionType) {

    var sql;
    sql = editor2.session.getTextRange(editor2.getSelectionRange());
    if (sql == "") { sql = editor2.getValue() }
    

    $.ajax({
        type: 'POST',
        url: 'm_data_job.aspx',
        async: false,
        data: {
            ajaxActionType: ajaxActionType
            , tbxConnectNo_key: $('#hidConnectNo').val().split(":")[0]
            , sql: sql
        },
        datatype: 'json',//'xml', 'html', 'script', 'json', 'jsonp', 'text'.
        beforeSend: function () {
            WaitPanelShow('');
        },
        //when success
        success: function (data) {
            document.getElementById("divSqlDiv").innerHTML = data;
        },
        //when complete
        complete: function (XMLHttpRequest, textStatus) {
            WaitPanelRemove();
        },
        //when error
        error: function () {
            alert('Error');
            document.getElementById("divSqlDiv").innerHTML = '';
        }
    });
}


// 更新
function ajax_update(){
    AjaxPostUpdate('update');
    $(".jq_ms").find("tr").each(function () {
        if ($(this).find("td")[0].innerText == $("#tbxIdx_key").val()) {
            $(this).click();
            return false;
        }
    });
}
// 削除
function ajax_delete() {
    if (confirm('Do delelte it ?')) {
        AjaxPost('delete');
    }
    
    //$(".jq_ms tr").last().click();
}
// 登録
function ajax_insert(){
    AjaxPost('insert');
    $(".jq_ms tr").last().click();
}
// 検索
function ajax_select(){
    AjaxPost('select');
}
// 検索
function ajax_select_itibu() {
    AjaxPost('select_itibu');
}


function ajax_txt() {
    AjaxPostTxt('txt');
}

//システム名
$(document).ready(function () {


    $('#btnUpdate').hide();
    $('#btnDelete').hide();

    $("#tbxSystemName_key,#tbxSystemName").focus(function () {
        AjaxList('SystemName', 'm_data_job_ajax.aspx', '#tbxSystemName_key_list');
    });
    $("#tbxSystemName_key,#tbxSystemName").blur(function () {
        $(this).val($(this).val().toUpperCase());
    });

    $("#tbxEdpNo_key").focus(function () {
        AjaxList('EdpNo', 'm_data_job_ajax.aspx', '#tbxEdpNo_key_list');
    });
    $("#tbxEdpNo_key").blur(function () {
        //$(this).val($(this).val().split(':')[0]);
        $(this).val($(this).val().toUpperCase());
    });

    $("#tbxConnectNo_key").focus(function () {
        AjaxList('DBconnect', 'm_data_job_ajax.aspx', '#tbxConnectNo_key_list');
    });

    $("#jianlue").click(function () {
        $('.jyouken_panel').hide(500);
        $('#divGvwTitle').hide(500);
        $('#divGvw').hide(500);
        $('#lblMsg').text($('#tbxFileName').val());
    });

    $("#syousai").click(function () {
        $('.jyouken_panel').show(500);
        $('#divGvwTitle').show(500);
        $('#divGvw').show(500);
        $('#lblMsg').text($('#tbxFileName').val());
    });


    $("#btnCopy").zclip({
        path: "./jquery-zclip-master/ZeroClipboard.swf",
        copy: function () {//复制内容 
            return document.getElementById('divSqlDiv').innerHTML;
            //return 'aa';
        },
        afterCopy: function () {//复制成功 
            alert("已复制到剪贴板");
        }
    });


    MsInit();



});



//DBconnect




function MsInit() {



    /*===============================================================*/
    /*行選択                                 
    /*===============================================================*/
    $(".jq_ms tr").click(function () {

        $('#btnUpdate').show();
        $('#btnDelete').show();

        $('.jq_upd').removeAttr("disabled");
        $('.jq_del').removeAttr("disabled");
        if (SelectRow == null) { } else {
            $(SelectRow).css("background", "#ffffff");
        }
        $(this).css("background", "#ffff66");
        SelectRow = $(this);

        $(this).find("td").each(function () {
            var className = $(this).attr("class");
            var ipt = className + '_ipt';
            $("." + ipt).val($(this).text())
        });


        $('#tbxIdx_key').val($(this).find("td")[0].innerText);
        $('#tbxSiryouKind_key').val($(this).find("td")[1].innerText);
        $('#tbxSystemName_key').val($(this).find("td")[2].innerText);
        $('#tbxKinouName_key').val($(this).find("td")[3].innerText);
        $('#tbxEdpNo_key').val($(this).find("td")[4].innerText);
        $('#ddlType').val($(this).find("td")[5].innerText);
        $('#tbxConnectNo_key').val($(this).find("td")[6].innerText);
        $('#tbxMenuNo_key').val($(this).find("td")[7].innerText);
        ajax_txt();
        $('#lblMsg').text($('#tbxFileName').val());
    })

    /*===============================================================*/
    /*明細部↑↓Key 押下                                 
    /*===============================================================*/
    //明細部↑↓
    $(".jq_ms_div").keydown(function (event) {
        if (SelectRow == null) { return true; }

        var keycode = event.which;
        if (keycode == 38) {
            if (SelectRow.prev()) {
                $(".jq_ms_div").scrollTop($(".jq_ms_div").scrollTop() - 21);
                SelectRow.prev().click();
                return false;
            }

        } else if (keycode == 40) {
            if (SelectRow.next()) {
                $(".jq_ms_div").scrollTop($(".jq_ms_div").scrollTop() + 21);
                SelectRow.next().click();
                return false;
            }

        }
    });
}




