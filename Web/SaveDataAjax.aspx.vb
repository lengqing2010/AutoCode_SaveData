
Partial Class SaveDataAjax
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim type As String = Request.Form("type")



        If type = "save" Then
            Dim SaveDataAjaxBC As New SaveDataAjaxBC
            Dim no As String = SaveDataAjaxBC.SelMaxNo
            Dim edp_no As String = Request.Form("tbxedpNo_key")
            Dim system_name As String = Request.Form("tbxsystemName_key")
            Dim title As String = Request.Form("tbxtitle_key")
            Dim child_title As String = Request.Form("tbxChildtitle_key")
            Dim kind As String = Request.Form("kind")
            Dim tbxSavePath As String = Request.Form("tbxSavePath")
            Dim data_txt As String = Request.Form("data_txt")
            Dim data_html As String = Request.Form("data_html")
            Dim shareType As String = IIf(Request.Form("shareType") = "on", 1, 0)


            If SaveDataAjaxBC.SelMData(no, edp_no, system_name, kind).Rows.Count > 0 Then
                'Is have data
                'Update
                SaveDataAjaxBC.UpdMData(no, edp_no, system_name, kind, no, edp_no, system_name, kind, title, child_title, data_txt, data_html, "", "", "", "", "", tbxSavePath, shareType, "", "")
            Else
                'No data
                'Insert
                SaveDataAjaxBC.InsMData(no, edp_no, system_name, kind, title, child_title, data_txt, data_html, "", "", "", "", "", tbxSavePath, shareType, "", "")
            End If




        End If


    End Sub
End Class
