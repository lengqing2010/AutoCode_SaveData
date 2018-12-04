
Partial Class SaveDataAjax
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim type As String = Request.Form("ajaxActionType")



        If type = "insert" Then
            Dim SaveDataAjaxBC As New SaveDataAjaxBC

            'Ajax page use
            Dim tbxDataOwner_key As String = Request.Form("tbxDataOwner_key")
            Dim tbxFileName_key As String = Request.Form("tbxFileName_key")
            Dim tbxEdpNo_key As String = Request.Form("tbxEdpNo_key")
            Dim tbxSystemName_key As String = Request.Form("tbxSystemName_key")
            Dim tbxEditorKind_key As String = Request.Form("tbxEditorKind_key")
            Dim tbxDataOwner As String = Request.Form("tbxDataOwner")
            Dim tbxFileName As String = Request.Form("tbxFileName")
            Dim tbxEdpNo As String = Request.Form("tbxEdpNo")
            Dim tbxSystemName As String = Request.Form("tbxSystemName")
            Dim tbxEditorKind As String = Request.Form("tbxEditorKind")
            Dim tbxDataTxt As String = Request.Form("tbxDataTxt")
            Dim tbxDataHtml As String = Request.Form("tbxDataHtml")
            Dim tbxShareType As String = Request.Form("tbxShareType")




            '//検索
            '//       Return BC.SelMData(tbxDataOwner_key ,tbxFileName_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxEditorKind_key)
            '登録
            SaveDataAjaxBC.InsMData(tbxDataOwner, tbxFileName, tbxEdpNo, tbxSystemName, tbxEditorKind, tbxDataTxt, tbxDataHtml, tbxShareType, "")
            '//削除
            '//       Return BC.DelMData(tbxDataOwner_key ,tbxFileName_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxEditorKind_key)
            '//更新
            '//       Return BC.UpdMData(tbxDataOwner_key ,tbxFileName_key ,tbxEdpNo_key ,tbxSystemName_key ,tbxEditorKind_key ,tbxDataOwner ,tbxFileName ,tbxEdpNo ,tbxSystemName ,tbxEditorKind ,tbxDataTxt ,tbxDataHtml ,tbxShareType ,tbxTourokuTime)



        End If


    End Sub
End Class
