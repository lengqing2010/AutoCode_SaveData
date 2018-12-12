Imports System.Data
Imports System.Text
Imports System.IO
Imports EMAB = Itis.ApplicationBlocks.ExceptionManagement.UnTrappedExceptionManager
Imports MyMethod = System.Reflection.MethodBase
Imports System.Web

Partial Class m_data_job
    Inherits System.Web.UI.Page

   Public BC AS NEW MDataJobBC
    ''' <summary>
    ''' PAGE LOAD
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        If Not IsPostBack Then

            If Context.Items("User") Is Nothing AndAlso tbxDataOwner.Text = "" Then
                tbxDataOwner.Text = "guest"
            End If

            'tbxDataOwner.Text = Security.Principal.WindowsIdentity.GetCurrent().Name
        End If
        'Response.Write(Request.ServerVariables("LOGON_USER"))
        Ajax()

        Me.lblMsg.Text = ""
        If Not IsPostBack Then

            '固定項目設定
            KoteiInit()

            '明細項目設定
            MsInit()
        End If

    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)

    End Sub


    Public splitor As String = "@!--lis-->||"

    Sub Ajax()
        If Request.Form("ajaxActionType") IsNot Nothing Then

            Dim tbxIdx_key As String = Request.Form("tbxIdx_key")
            Dim tbxSiryouKind_key As String = Request.Form("tbxSiryouKind_key")
            Dim tbxSystemName_key As String = Request.Form("tbxSystemName_key")
            Dim tbxKinouName_key As String = Request.Form("tbxKinouName_key")
            Dim tbxEdpNo_key As String = Request.Form("tbxEdpNo_key").Split(":")(0)
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

            If Request.Form("ajaxActionType") = "txt" Then
                Dim dt As DataTable = BC.SelMDataJob(tbxIdx_key, "", "", "", "", "", "", "")
                Response.Write(dt.Rows(0).Item("data_txt"))
                Response.Write(splitor)
                Response.Write(dt.Rows(0).Item("data_html"))
                Response.Write(splitor)
                Response.Write(dt.Rows(0).Item("share_type"))
                Response.Write(splitor)
                Response.Write(dt.Rows(0).Item("data_owner"))
                Response.End()
            ElseIf Request.Form("ajaxActionType") = "update" Then
                BC.UpdMDataJob(tbxIdx_key, tbxSiryouKind_key, tbxSystemName_key, tbxKinouName_key, tbxEdpNo_key, tbxEditorKind_key, tbxConnectNo_key, tbxMenuNo_key, tbxIdx, tbxSiryouKind, tbxSystemName, tbxKinouName, tbxEdpNo, tbxEditorKind, tbxConnectNo, tbxMenuNo, tbxFileName, tbxDataTxt, tbxDataHtml, tbxShareType, tbxDataOwner, tbxTourokuTime)
            ElseIf Request.Form("ajaxActionType") = "insert" Then
                BC.InsMDataJob(tbxIdx, tbxSiryouKind, tbxSystemName, tbxKinouName, tbxEdpNo, tbxEditorKind, tbxConnectNo, tbxMenuNo, tbxFileName, tbxDataTxt, tbxDataHtml, tbxShareType, tbxDataOwner, tbxTourokuTime)
            ElseIf Request.Form("ajaxActionType") = "delete" Then
                BC.DelMDataJob(tbxIdx_key, tbxSiryouKind_key, tbxSystemName_key, tbxKinouName_key, tbxEdpNo_key, tbxEditorKind_key, tbxConnectNo_key, tbxMenuNo_key)
            End If


            'Gridview もどり
            If Request.Form("ajaxActionType") = "select" Then
                Response.ClearContent()
                Dim dt As DataTable = BC.SelMDataJob("", tbxSiryouKind_key, tbxSystemName_key, tbxKinouName_key, tbxEdpNo_key, tbxEditorKind_key, tbxConnectNo_key, tbxMenuNo_key)
                Me.gvMs.DataSource = dt
                gvMs.DataBind()
                Dim sb As New System.Text.StringBuilder()
                Dim sw As New System.IO.StringWriter(sb)
                Dim htw As New HtmlTextWriter(sw)
                gvMs.RenderControl(htw)
                Response.Write(htw.InnerWriter.ToString)
                Response.End()

            ElseIf Request.Form("ajaxActionType") = "select_itibu" Then
                Response.ClearContent()
                Dim dt As DataTable = BC.SelMDataJob("", "", tbxSystemName_key, "", tbxEdpNo_key, "", "", "")
                Me.gvMs.DataSource = dt
                gvMs.DataBind()
                Dim sb As New System.Text.StringBuilder()
                Dim sw As New System.IO.StringWriter(sb)
                Dim htw As New HtmlTextWriter(sw)
                gvMs.RenderControl(htw)
                Response.Write(htw.InnerWriter.ToString)
                Response.End()
            ElseIf Request.Form("ajaxActionType") = "sql_select" Then

                Dim sql As String = Request.Form("sql")
                Dim connectNo As String = Request.Form("tbxConnectNo_key")
                Dim MDbConnectDA As New MDbConnectDA
                Dim conn As String = MDbConnectDA.SelMDbConnect(connectNo).Rows(0).Item("connect_str")

                Dim MDataJobDA As New MDataJobDA
                Dim dt As DataTable = MDataJobDA.SelSql(conn, sql)

                Dim db_name As String = GetConnDataByKey(conn, "Initial Catalog")


                For i As Integer = 0 To dt.Columns.Count - 1
                    Dim item_en As String = dt.Columns(i).ColumnName.Trim
                    Dim rtv As String = MDataJobDA.SelKj(db_name, item_en)
                    If rtv <> "" Then
                        dt.Columns(i).ColumnName &= vbNewLine & "(" & rtv & ")"
                    End If
                Next


                Me.gvSql.DataSource = dt
                gvSql.DataBind()

   




                Dim sb As New System.Text.StringBuilder()
                Dim sw As New System.IO.StringWriter(sb)
                Dim htw As New HtmlTextWriter(sw)
                gvSql.RenderControl(htw)
                Response.Write(htw.InnerWriter.ToString)
                Response.End()
            ElseIf Request.Form("ajaxActionType") = "sql_run" Then

                Dim sql As String = Request.Form("sql")
                Dim connectNo As String = Request.Form("tbxConnectNo_key")
                Dim MDbConnectDA As New MDbConnectDA
                Dim conn As String = MDbConnectDA.SelMDbConnect(connectNo).Rows(0).Item("connect_str")
                Dim MDataJobDA As New MDataJobDA
                Response.Write(MDataJobDA.SqlRun(conn, sql))
                Response.End()
            Else
                Response.ClearContent()
                Dim dt As DataTable = BC.SelMDataJob("", "", tbxSystemName_key, "", tbxEdpNo_key, "", "", "")
                Me.gvMs.DataSource = dt
                gvMs.DataBind()
                Dim sb As New System.Text.StringBuilder()
                Dim sw As New System.IO.StringWriter(sb)
                Dim htw As New HtmlTextWriter(sw)
                gvMs.RenderControl(htw)
                Response.Write(htw.InnerWriter.ToString)
                Response.End()

            End If


        End If

    End Sub
    ''' <summary>
    ''' 固定項目設定
    ''' </summary>
    public Sub KoteiInit()
      'EMAB障害対応情報の格納処理
       EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
       MyMethod.GetCurrentMethod.Name)
        'Me.tbxIdx.Attributes.Item("itType") = "int"
        'Me.tbxIdx.Attributes.Item("itLength") = "4"
        'Me.tbxIdx.Attributes.Item("itName") = "INDEX"
        'Me.tbxSiryouKind.Attributes.Item("itType") = "nvarchar"
        'Me.tbxSiryouKind.Attributes.Item("itLength") = "1"
        'Me.tbxSiryouKind.Attributes.Item("itName") = "資料分類"
        'Me.tbxSystemName.Attributes.Item("itType") = "nvarchar"
        'Me.tbxSystemName.Attributes.Item("itLength") = "20"
        'Me.tbxSystemName.Attributes.Item("itName") = "システム名"
        'Me.tbxKinouName.Attributes.Item("itType") = "nvarchar"
        'Me.tbxKinouName.Attributes.Item("itLength") = "20"
        'Me.tbxKinouName.Attributes.Item("itName") = "機能名"
        'Me.tbxEdpNo.Attributes.Item("itType") = "nvarchar"
        'Me.tbxEdpNo.Attributes.Item("itLength") = "8"
        'Me.tbxEdpNo.Attributes.Item("itName") = "EDP番号"
        'Me.tbxEditorKind.Attributes.Item("itType") = "nvarchar"
        'Me.tbxEditorKind.Attributes.Item("itLength") = "20"
        'Me.tbxEditorKind.Attributes.Item("itName") = "Editor種類"
        'Me.tbxConnectNo.Attributes.Item("itType") = "int"
        'Me.tbxConnectNo.Attributes.Item("itLength") = "4"
        'Me.tbxConnectNo.Attributes.Item("itName") = "DB接続No"
        'Me.tbxMenuNo.Attributes.Item("itType") = "nvarchar"
        'Me.tbxMenuNo.Attributes.Item("itLength") = "20"
        'Me.tbxMenuNo.Attributes.Item("itName") = "メニューNo"
        'Me.tbxFileName.Attributes.Item("itType") = "nvarchar"
        'Me.tbxFileName.Attributes.Item("itLength") = "100"
        'Me.tbxFileName.Attributes.Item("itName") = "ファイル名"
        'Me.tbxDataTxt.Attributes.Item("itType") = "ntext"
        'Me.tbxDataTxt.Attributes.Item("itLength") = "8"
        'Me.tbxDataTxt.Attributes.Item("itName") = "内容TXT"
        'Me.tbxDataHtml.Attributes.Item("itType") = "ntext"
        'Me.tbxDataHtml.Attributes.Item("itLength") = "8"
        'Me.tbxDataHtml.Attributes.Item("itName") = "内容HTML"
        'Me.tbxShareType.Attributes.Item("itType") = "nvarchar"
        'Me.tbxShareType.Attributes.Item("itLength") = "1"
        'Me.tbxShareType.Attributes.Item("itName") = "共有"
        'Me.tbxDataOwner.Attributes.Item("itType") = "nvarchar"
        'Me.tbxDataOwner.Attributes.Item("itLength") = "10"
        'Me.tbxDataOwner.Attributes.Item("itName") = "所有者"
        'Me.tbxTourokuTime.Attributes.Item("itType") = "datetime"
        'Me.tbxTourokuTime.Attributes.Item("itLength") = "23,3"
        'Me.tbxTourokuTime.Attributes.Item("itName") = "登録時間"

    End Sub

    ''' <summary>
    ''' 明細項目設定
    ''' </summary>
    public Sub MsInit()
      'EMAB障害対応情報の格納処理
       EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
       MyMethod.GetCurrentMethod.Name)
            '明細設定
            Dim dt As DataTable = GetMsData()
            Me.gvMs.DataSource = dt
            Me.gvMs.DataBind()

    End Sub

    ''' <summary>
    ''' 検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnSelect_Click(sender As Object, e As System.EventArgs) Handles btnSelect.Click
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        MsInit()
    End Sub

    ''' <summary>
    ''' 明細データ取得
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetMsData() As Data.DataTable

      'EMAB障害対応情報の格納処理
       EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
       MyMethod.GetCurrentMethod.Name)
        Return BC.SelMDataJob(tbxIdx_key.Text, tbxSiryouKind_key.Text, tbxSystemName_key.Text, tbxKinouName_key.Text, tbxEdpNo_key.Text, ddlType.SelectedValue, tbxConnectNo_key.Text, tbxMenuNo_key.Text)
    End Function

    ''' <summary>
    ''' データ存在チェック
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsHaveData() As Boolean

      'EMAB障害対応情報の格納処理
       EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
       MyMethod.GetCurrentMethod.Name)
        'Return BC.SelMDataJob(tbxIdx.Text, tbxSiryouKind.Text, tbxSystemName.Text, tbxKinouName.Text, tbxEdpNo.Text, tbxEditorKind.Text, tbxConnectNo.Text, tbxMenuNo.Text).Rows.Count > 0
    End Function

    ''' <summary>
    ''' 更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnUpdate_Click(sender As Object, e As System.EventArgs) Handles btnUpdate.Click

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

            Try
            'BC.UpdMDataJob(Convert.ToInt32(hididx.Text), hidsiryouKind.Text, hidsystemName.Text, hidkinouName.Text, hidedpNo.Text, hideditorKind.Text, Convert.ToInt32(hidconnectNo.Text), hidmenuNo.Text,Convert.ToInt32(tbxidx.Text), tbxsiryouKind.Text, tbxsystemName.Text, tbxkinouName.Text, tbxedpNo.Text, tbxeditorKind.Text, Convert.ToInt32(tbxconnectNo.Text), tbxmenuNo.Text, tbxfileName.Text, tbxdataTxt.Text, tbxdataHtml.Text, tbxshareType.Text, tbxdataOwner.Text, tbxtourokuTime.Text)
        MsInit()
            Catch ex As Exception
                Common.ShowMsg(Me.Page, ex.Message)
                Exit Sub
            End Try
Me.hidOldRowIdx.Text = ""
    End Sub
    ''' <summary>
    ''' 登録
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnInsert_Click(sender As Object, e As System.EventArgs) Handles btnInsert.Click
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        'データ存在チェック
            If IsHaveData() Then
                Common.ShowMsg(Me.Page, "データ存在しました。")
                Exit Sub
            End If
            Try
            'BC.InsMDataJob(tbxidx.Text, tbxsiryouKind.Text, tbxsystemName.Text, tbxkinouName.Text, tbxedpNo.Text, tbxeditorKind.Text, tbxconnectNo.Text, tbxmenuNo.Text, tbxfileName.Text, tbxdataTxt.Text, tbxdataHtml.Text, tbxshareType.Text, tbxdataOwner.Text, tbxtourokuTime.Text)
                MsInit()
            Catch ex As Exception
                Common.ShowMsg(Me.Page, ex.Message)
                Exit Sub
            End Try
Me.hidOldRowIdx.Text = ""
    End Sub

    ''' <summary>
    ''' 削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnDelete_Click(sender As Object, e As System.EventArgs) Handles btnDelete.Click

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

            Try
       BC.DelMDataJob(hididx.Text, hidsiryouKind.Text, hidsystemName.Text, hidkinouName.Text, hidedpNo.Text, hideditorKind.Text, hidconnectNo.Text, hidmenuNo.Text)
        MsInit()
            Catch ex As Exception
                Common.ShowMsg(Me.Page, ex.Message)
                Exit Sub
            End Try
Me.hidOldRowIdx.Text = ""
    End Sub



    Public Function GetConnDataByKey(ByVal conn As String, ByVal key As String) As String
        On Error GoTo Err
        Dim arr
        arr = Split(conn, ";")
        Dim i, kmName
        For i = 0 To UBound(arr)
            If UCase(Split(Trim(arr(i)), "=")(0)) = UCase(key) Then
                GetConnDataByKey = Split(Trim(arr(i)), "=")(1)
                Exit Function
            End If
        Next
        Exit Function
Err:
        GetConnDataByKey = ""
    End Function


End Class
