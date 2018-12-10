// Do Ajax function
function AjaxPost(ajaxActionType){
    $.ajax({
        type: 'POST',
        url: 'SaveDataAjax.aspx',
        data: {
            ajaxActionType : ajaxActionType
            ,tbxSystemName_key:$('#tbxSystemName_key').val()
            ,tbxSystemName:$('#tbxSystemName').val()
            ,tbxJunban:$('#tbxJunban').val()
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
    //Dim tbxSystemName_key As String = Request.Form("tbxSystemName_key")
    //Dim tbxSystemName As String = Request.Form("tbxSystemName")
    //Dim tbxJunban As String = Request.Form("tbxJunban")

//検索
//       Return BC.SelMSystemName(tbxSystemName_key)
//登録
//       Return BC.InsMSystemName(tbxSystemName ,tbxJunban)
//削除
//       Return BC.DelMSystemName(tbxSystemName_key)
//更新
//       Return BC.UpdMSystemName(tbxSystemName_key ,tbxSystemName ,tbxJunban)