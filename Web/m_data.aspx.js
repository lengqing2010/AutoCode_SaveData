// Do Ajax function
function AjaxPost(ajaxActionType){
    $.ajax({
        type: 'POST',
        url: 'SaveDataAjax.aspx',
        data: {
            ajaxActionType : ajaxActionType
            ,tbxNo_key:$('#tbxNo_key').val()
            ,tbxEdpNo_key:$('#tbxEdpNo_key').val()
            ,tbxSystemName_key:$('#tbxSystemName_key').val()
            ,tbxKind_key:$('#tbxKind_key').val()
            ,tbxNo:$('#tbxNo').val()
            ,tbxEdpNo:$('#tbxEdpNo').val()
            ,tbxSystemName:$('#tbxSystemName').val()
            ,tbxKind:$('#tbxKind').val()
            ,tbxTitle:$('#tbxTitle').val()
            ,tbxChildTitle:$('#tbxChildTitle').val()
            ,tbxDataTxt:$('#tbxDataTxt').val()
            ,tbxDataHtml:$('#tbxDataHtml').val()
            ,tbxEnclosure1:$('#tbxEnclosure1').val()
            ,tbxEnclosure2:$('#tbxEnclosure2').val()
            ,tbxEnclosure3:$('#tbxEnclosure3').val()
            ,tbxEnclosure4:$('#tbxEnclosure4').val()
            ,tbxEnclosure5:$('#tbxEnclosure5').val()
            ,tbxSavePath:$('#tbxSavePath').val()
            ,tbxShareType:$('#tbxShareType').val()
            ,tbxTourokuUser:$('#tbxTourokuUser').val()
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
    //Dim tbxNo_key As String = Request.Form("tbxNo_key")
    //Dim tbxEdpNo_key As String = Request.Form("tbxEdpNo_key")
    //Dim tbxSystemName_key As String = Request.Form("tbxSystemName_key")
    //Dim tbxKind_key As String = Request.Form("tbxKind_key")
    //Dim tbxNo As String = Request.Form("tbxNo")
    //Dim tbxEdpNo As String = Request.Form("tbxEdpNo")
    //Dim tbxSystemName As String = Request.Form("tbxSystemName")
    //Dim tbxKind As String = Request.Form("tbxKind")
    //Dim tbxTitle As String = Request.Form("tbxTitle")
    //Dim tbxChildTitle As String = Request.Form("tbxChildTitle")
    //Dim tbxDataTxt As String = Request.Form("tbxDataTxt")
    //Dim tbxDataHtml As String = Request.Form("tbxDataHtml")
    //Dim tbxEnclosure1 As String = Request.Form("tbxEnclosure1")
    //Dim tbxEnclosure2 As String = Request.Form("tbxEnclosure2")
    //Dim tbxEnclosure3 As String = Request.Form("tbxEnclosure3")
    //Dim tbxEnclosure4 As String = Request.Form("tbxEnclosure4")
    //Dim tbxEnclosure5 As String = Request.Form("tbxEnclosure5")
    //Dim tbxSavePath As String = Request.Form("tbxSavePath")
    //Dim tbxShareType As String = Request.Form("tbxShareType")
    //Dim tbxTourokuUser As String = Request.Form("tbxTourokuUser")
    //Dim tbxTourokuTime As String = Request.Form("tbxTourokuTime")

//検索
//       Return BC.SelMData(tbxNo_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxKind_key)
//登録
//       Return BC.InsMData(tbxNo ,tbxEdpNo ,tbxSystemName ,tbxKind ,tbxTitle ,tbxChildTitle ,tbxDataTxt ,tbxDataHtml ,tbxEnclosure1 ,tbxEnclosure2 ,tbxEnclosure3 ,tbxEnclosure4 ,tbxEnclosure5 ,tbxSavePath ,tbxShareType ,tbxTourokuUser ,tbxTourokuTime)
//削除
//       Return BC.DelMData(tbxNo_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxKind_key)
//更新
//       Return BC.UpdMData(tbxNo_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxKind_key ,tbxNo ,tbxEdpNo ,tbxSystemName ,tbxKind ,tbxTitle ,tbxChildTitle ,tbxDataTxt ,tbxDataHtml ,tbxEnclosure1 ,tbxEnclosure2 ,tbxEnclosure3 ,tbxEnclosure4 ,tbxEnclosure5 ,tbxSavePath ,tbxShareType ,tbxTourokuUser ,tbxTourokuTime)