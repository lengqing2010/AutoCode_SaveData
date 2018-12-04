// Do Ajax function
function AjaxPost(ajaxActionType){
    $.ajax({
        type: 'POST',
        url: 'SaveDataAjax.aspx',
        data: {
            ajaxActionType : ajaxActionType
            ,tbxDataOwner_key:$('#tbxDataOwner_key').val()
            ,tbxFileName_key:$('#tbxFileName_key').val()
            ,tbxEdpNo_key:$('#tbxEdpNo_key').val()
            ,tbxSystemName_key:$('#tbxSystemName_key').val()
            ,tbxEditorKind_key:$('#tbxEditorKind_key').val()
            ,tbxDataOwner:$('#tbxDataOwner').val()
            ,tbxFileName:$('#tbxFileName').val()
            ,tbxEdpNo:$('#tbxEdpNo').val()
            ,tbxSystemName:$('#tbxSystemName').val()
            ,tbxEditorKind:$('#tbxEditorKind').val()
            ,tbxDataTxt:$('#tbxDataTxt').val()
            ,tbxDataHtml:$('#tbxDataHtml').val()
            ,tbxShareType:$('#tbxShareType').val()
            ,tbxTourokuTime:$('#tbxTourokuTime').val()
        },
        datatype: 'html',//'xml', 'html', 'script', 'json', 'jsonp', 'text'.
        beforeSend: function () {
        },
        //when success
        success: function (data) {
        },
        //when complete
        complete: function (XMLHttpRequest, textStatus) {
            //alert(XMLHttpRequest.responseText);
            alert(textStatus);
        },
        //when error
        error: function () {
        }
    });
}
// 更新
function ajax_update(){
    AjaxPost('update');
}
// 削除
function ajax_delete(){
    AjaxPost('delete');
}
// 登録
function ajax_insert(){
    AjaxPost('insert');
}
// 検索
function ajax_select(){
    AjaxPost('select');
}
// Ajax page use
    //Dim tbxDataOwner_key As String = Request.Form("tbxDataOwner_key")
    //Dim tbxFileName_key As String = Request.Form("tbxFileName_key")
    //Dim tbxEdpNo_key As String = Request.Form("tbxEdpNo_key")
    //Dim tbxSystemName_key As String = Request.Form("tbxSystemName_key")
    //Dim tbxEditorKind_key As String = Request.Form("tbxEditorKind_key")
    //Dim tbxDataOwner As String = Request.Form("tbxDataOwner")
    //Dim tbxFileName As String = Request.Form("tbxFileName")
    //Dim tbxEdpNo As String = Request.Form("tbxEdpNo")
    //Dim tbxSystemName As String = Request.Form("tbxSystemName")
    //Dim tbxEditorKind As String = Request.Form("tbxEditorKind")
    //Dim tbxDataTxt As String = Request.Form("tbxDataTxt")
    //Dim tbxDataHtml As String = Request.Form("tbxDataHtml")
    //Dim tbxShareType As String = Request.Form("tbxShareType")
    //Dim tbxTourokuTime As String = Request.Form("tbxTourokuTime")

//検索
//       Return BC.SelMData(tbxDataOwner_key ,tbxFileName_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxEditorKind_key)
//登録
//       Return BC.InsMData(tbxDataOwner ,tbxFileName ,tbxEdpNo ,tbxSystemName ,tbxEditorKind ,tbxDataTxt ,tbxDataHtml ,tbxShareType ,tbxTourokuTime)
//削除
//       Return BC.DelMData(tbxDataOwner_key ,tbxFileName_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxEditorKind_key)
//更新
//       Return BC.UpdMData(tbxDataOwner_key ,tbxFileName_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxEditorKind_key ,tbxDataOwner ,tbxFileName ,tbxEdpNo ,tbxSystemName ,tbxEditorKind ,tbxDataTxt ,tbxDataHtml ,tbxShareType ,tbxTourokuTime)