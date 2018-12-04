Imports System.Data
Imports System.Text
Imports System.IO
Imports EMAB = Itis.ApplicationBlocks.ExceptionManagement.UnTrappedExceptionManager
Imports MyMethod = System.Reflection.MethodBase
Partial Class m_data
    Inherits System.Web.UI.Page

   Public BC AS NEW MDataBC
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

        Me.lblMsg.Text = ""
        If Not IsPostBack Then

            '固定項目設定
            KoteiInit()

            '明細項目設定
            MsInit()
        End If

    End Sub
    ''' <summary>
    ''' 固定項目設定
    ''' </summary>
    public Sub KoteiInit()
      'EMAB障害対応情報の格納処理
       EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
       MyMethod.GetCurrentMethod.Name)
       Me.tbxDataOwner.Attributes.Item("itType") = "nvarchar"
       Me.tbxDataOwner.Attributes.Item("itLength") = "10"
       Me.tbxDataOwner.Attributes.Item("itName") = "所有者"
       Me.tbxFileName.Attributes.Item("itType") = "nvarchar"
       Me.tbxFileName.Attributes.Item("itLength") = "100"
       Me.tbxFileName.Attributes.Item("itName") = "ファイル名"
       Me.tbxEdpNo.Attributes.Item("itType") = "nvarchar"
       Me.tbxEdpNo.Attributes.Item("itLength") = "8"
       Me.tbxEdpNo.Attributes.Item("itName") = "EDP番号"
       Me.tbxSystemName.Attributes.Item("itType") = "nvarchar"
       Me.tbxSystemName.Attributes.Item("itLength") = "16"
       Me.tbxSystemName.Attributes.Item("itName") = "システム名"
       Me.tbxEditorKind.Attributes.Item("itType") = "nvarchar"
       Me.tbxEditorKind.Attributes.Item("itLength") = "20"
       Me.tbxEditorKind.Attributes.Item("itName") = "Editor種類"
       Me.tbxDataTxt.Attributes.Item("itType") = "ntext"
       Me.tbxDataTxt.Attributes.Item("itLength") = "8"
       Me.tbxDataTxt.Attributes.Item("itName") = "内容TXT"
       Me.tbxDataHtml.Attributes.Item("itType") = "ntext"
       Me.tbxDataHtml.Attributes.Item("itLength") = "8"
       Me.tbxDataHtml.Attributes.Item("itName") = "内容HTML"
       Me.tbxShareType.Attributes.Item("itType") = "nvarchar"
       Me.tbxShareType.Attributes.Item("itLength") = "1"
       Me.tbxShareType.Attributes.Item("itName") = "共有"
       Me.tbxTourokuTime.Attributes.Item("itType") = "datetime"
       Me.tbxTourokuTime.Attributes.Item("itLength") = "23,3"
       Me.tbxTourokuTime.Attributes.Item("itName") = "登録時間"

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
       Return BC.SelMData(tbxDataOwner_key.Text, tbxFileName_key.Text, tbxEdpNo_key.Text, tbxSystemName_key.Text, tbxEditorKind_key.Text)
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
       Return BC.SelMData(tbxDataOwner.Text, tbxFileName.Text, tbxEdpNo.Text, tbxSystemName.Text, tbxEditorKind.Text).Rows.Count > 0
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
       BC.UpdMData(hiddataOwner.Text, hidfileName.Text, hidedpNo.Text, hidsystemName.Text, hideditorKind.Text,tbxdataOwner.Text, tbxfileName.Text, tbxedpNo.Text, tbxsystemName.Text, tbxeditorKind.Text, tbxdataTxt.Text, tbxdataHtml.Text, tbxshareType.Text, tbxtourokuTime.Text)
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
            BC.InsMData(tbxdataOwner.Text, tbxfileName.Text, tbxedpNo.Text, tbxsystemName.Text, tbxeditorKind.Text, tbxdataTxt.Text, tbxdataHtml.Text, tbxshareType.Text, tbxtourokuTime.Text)
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
       BC.DelMData(hiddataOwner.Text, hidfileName.Text, hidedpNo.Text, hidsystemName.Text, hideditorKind.Text)
        MsInit()
            Catch ex As Exception
                Common.ShowMsg(Me.Page, ex.Message)
                Exit Sub
            End Try
Me.hidOldRowIdx.Text = ""
    End Sub

End Class
