// Do Ajax function
function AjaxPost(ajaxActionType){
    $.ajax({
        type: 'POST',
        url: 'SaveDataAjax.aspx',
        data: {
            ajaxActionType : ajaxActionType
            ,tbxEdpNo_key:$('#tbxEdpNo_key').val()
            ,tbxEdpNo:$('#tbxEdpNo').val()
            ,tbxEdpName:$('#tbxEdpName').val()
            ,tbxEdpStaus:$('#tbxEdpStaus').val()
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
    //Dim tbxEdpNo_key As String = Request.Form("tbxEdpNo_key")
    //Dim tbxEdpNo As String = Request.Form("tbxEdpNo")
    //Dim tbxEdpName As String = Request.Form("tbxEdpName")
    //Dim tbxEdpStaus As String = Request.Form("tbxEdpStaus")

//検索
//       Return BC.SelMEdp(tbxEdpNo_key)
//登録
//       Return BC.InsMEdp(tbxEdpNo ,tbxEdpName ,tbxEdpStaus)
//削除
//       Return BC.DelMEdp(tbxEdpNo_key)
//更新
//       Return BC.UpdMEdp(tbxEdpNo_key ,tbxEdpNo ,tbxEdpName ,tbxEdpStaus)