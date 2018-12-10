// Do Ajax function
function AjaxPost(ajaxActionType){
    $.ajax({
        type: 'POST',
        url: 'SaveDataAjax.aspx',
        data: {
            ajaxActionType : ajaxActionType
            ,tbxConnectNo_key:$('#tbxConnectNo_key').val()
            ,tbxConnectNo:$('#tbxConnectNo').val()
            ,tbxConnectName:$('#tbxConnectName').val()
            ,tbxConnectStr:$('#tbxConnectStr').val()
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
    //Dim tbxConnectNo_key As String = Request.Form("tbxConnectNo_key")
    //Dim tbxConnectNo As String = Request.Form("tbxConnectNo")
    //Dim tbxConnectName As String = Request.Form("tbxConnectName")
    //Dim tbxConnectStr As String = Request.Form("tbxConnectStr")

//検索
//       Return BC.SelMDbConnect(tbxConnectNo_key)
//登録
//       Return BC.InsMDbConnect(tbxConnectNo ,tbxConnectName ,tbxConnectStr)
//削除
//       Return BC.DelMDbConnect(tbxConnectNo_key)
//更新
//       Return BC.UpdMDbConnect(tbxConnectNo_key ,tbxConnectNo ,tbxConnectName ,tbxConnectStr)