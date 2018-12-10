
Partial Class m_data_job_ajax
    Inherits System.Web.UI.Page

    Public BC As New MDataJobBC
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load



        Dim type As String = Request.Form("ajaxActionType")
        If type = "SystemName" Then
            Dim dt As Data.DataTable = BC.SelMSystemName("")
            For i As Integer = 0 To dt.Rows.Count - 1
                If i = 0 Then
                    Response.Write(dt.Rows(i).Item(0))
                Else
                    Response.Write("," & dt.Rows(i).Item(0))
                End If
            Next
        ElseIf type = "EdpNo" Then
            Dim dt As Data.DataTable = BC.SelMEdp("")
            For i As Integer = 0 To dt.Rows.Count - 1
                If i = 0 Then
                    Response.Write(dt.Rows(i).Item(0))
                Else
                    Response.Write("," & dt.Rows(i).Item(0))
                End If
            Next
        ElseIf type = "DBconnect" Then
            Dim dt As Data.DataTable = BC.SelMDbConnect("")
            For i As Integer = 0 To dt.Rows.Count - 1
                If i = 0 Then
                    Response.Write(dt.Rows(i).Item(0))
                Else
                    Response.Write("," & dt.Rows(i).Item(0))
                End If
            Next

        ElseIf type = "Select" Then
            Dim tbxIdx_key As String = Request.Form("tbxIdx_key")
            Dim tbxSiryouKind_key As String = Request.Form("tbxSiryouKind_key")
            Dim tbxSystemName_key As String = Request.Form("tbxSystemName_key")
            Dim tbxKinouName_key As String = Request.Form("tbxKinouName_key")
            Dim tbxEdpNo_key As String = Request.Form("tbxEdpNo_key")
            Dim tbxEditorKind_key As String = Request.Form("tbxEditorKind_key")
            Dim tbxConnectNo_key As String = Request.Form("tbxConnectNo_key")
            Dim tbxMenuNo_key As String = Request.Form("tbxMenuNo_key")
            Dim tbxIdx As String = Request.Form("tbxIdx")
            Dim tbxSiryouKind As String = Request.Form("tbxSiryouKind")
            Dim tbxSystemName As String = Request.Form("tbxSystemName")
            Dim tbxKinouName As String = Request.Form("tbxKinouName")
            Dim tbxEdpNo As String = Request.Form("tbxEdpNo")
            Dim tbxEditorKind As String = Request.Form("tbxEditorKind")
            Dim tbxConnectNo As String = Request.Form("tbxConnectNo")
            Dim tbxMenuNo As String = Request.Form("tbxMenuNo")
            Dim tbxFileName As String = Request.Form("tbxFileName")
            Dim tbxDataTxt As String = Request.Form("tbxDataTxt")
            Dim tbxDataHtml As String = Request.Form("tbxDataHtml")
            Dim tbxShareType As String = Request.Form("tbxShareType")
            Dim tbxDataOwner As String = Request.Form("tbxDataOwner")
            Dim tbxTourokuTime As String = Request.Form("tbxTourokuTime")

            Dim dt As Data.DataTable = BC.SelMDataJob(tbxIdx_key, tbxSiryouKind_key, tbxSystemName_key, tbxKinouName_key, tbxEdpNo_key, tbxEditorKind_key, tbxConnectNo_key, tbxMenuNo_key)


        End If
        Response.End()

    End Sub
End Class
