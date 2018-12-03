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
    Public Sub KoteiInit()
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
        MyMethod.GetCurrentMethod.Name)
        Me.tbxno.Attributes.Item("itType") = "int"
        Me.tbxno.Attributes.Item("itLength") = "4"
        Me.tbxno.Attributes.Item("itName") = "番号"
        Me.tbxedpNo.Attributes.Item("itType") = "nvarchar"
        Me.tbxedpNo.Attributes.Item("itLength") = "10"
        Me.tbxedpNo.Attributes.Item("itName") = "EDP番号"
        Me.tbxsystemName.Attributes.Item("itType") = "nvarchar"
        Me.tbxsystemName.Attributes.Item("itLength") = "50"
        Me.tbxsystemName.Attributes.Item("itName") = "システム名"
        Me.tbxkind.Attributes.Item("itType") = "nvarchar"
        Me.tbxkind.Attributes.Item("itLength") = "20"
        Me.tbxkind.Attributes.Item("itName") = "種類"
        Me.tbxtitle.Attributes.Item("itType") = "nvarchar"
        Me.tbxtitle.Attributes.Item("itLength") = "200"
        Me.tbxtitle.Attributes.Item("itName") = "タイトル"
        Me.tbxchildTitle.Attributes.Item("itType") = "nvarchar"
        Me.tbxchildTitle.Attributes.Item("itLength") = "200"
        Me.tbxchildTitle.Attributes.Item("itName") = "子タイトル"
        Me.tbxdataTxt.Attributes.Item("itType") = "ntext"
        Me.tbxdataTxt.Attributes.Item("itLength") = "8"
        Me.tbxdataTxt.Attributes.Item("itName") = "内容TXT"
        Me.tbxdataHtml.Attributes.Item("itType") = "ntext"
        Me.tbxdataHtml.Attributes.Item("itLength") = "8"
        Me.tbxdataHtml.Attributes.Item("itName") = "内容HTML"
        Me.tbxenclosure1.Attributes.Item("itType") = "ntext"
        Me.tbxenclosure1.Attributes.Item("itLength") = "8"
        Me.tbxenclosure1.Attributes.Item("itName") = "添付ファイル１"
        Me.tbxenclosure2.Attributes.Item("itType") = "ntext"
        Me.tbxenclosure2.Attributes.Item("itLength") = "8"
        Me.tbxenclosure2.Attributes.Item("itName") = "添付ファイル２"
        Me.tbxenclosure3.Attributes.Item("itType") = "ntext"
        Me.tbxenclosure3.Attributes.Item("itLength") = "8"
        Me.tbxenclosure3.Attributes.Item("itName") = "添付ファイル３"
        Me.tbxenclosure4.Attributes.Item("itType") = "ntext"
        Me.tbxenclosure4.Attributes.Item("itLength") = "8"
        Me.tbxenclosure4.Attributes.Item("itName") = "添付ファイル４"
        Me.tbxenclosure5.Attributes.Item("itType") = "ntext"
        Me.tbxenclosure5.Attributes.Item("itLength") = "8"
        Me.tbxenclosure5.Attributes.Item("itName") = "添付ファイル５"
        Me.tbxsavePath.Attributes.Item("itType") = "nvarchar"
        Me.tbxsavePath.Attributes.Item("itLength") = "800"
        Me.tbxsavePath.Attributes.Item("itName") = "保存パス"
        Me.tbxshareType.Attributes.Item("itType") = "nvarchar"
        Me.tbxshareType.Attributes.Item("itLength") = "1"
        Me.tbxshareType.Attributes.Item("itName") = "共有"
        Me.tbxtourokuUser.Attributes.Item("itType") = "nvarchar"
        Me.tbxtourokuUser.Attributes.Item("itLength") = "20"
        Me.tbxtourokuUser.Attributes.Item("itName") = "登録者"
        Me.tbxtourokuTime.Attributes.Item("itType") = "datetime"
        Me.tbxtourokuTime.Attributes.Item("itLength") = "23,3"
        Me.tbxtourokuTime.Attributes.Item("itName") = "登録時間"

    End Sub

    ''' <summary>
    ''' 明細項目設定
    ''' </summary>
    Public Sub MsInit()
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
        Return BC.SelMData(tbxno_key.Text, tbxedpNo_key.Text, tbxsystemName_key.Text, tbxkind_key.Text)

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
        Return BC.SelMData(tbxno.Text, tbxedpNo.Text, tbxsystemName.Text, tbxkind.Text).Rows.Count > 0

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
            BC.UpdMData(Convert.ToInt32(hidno.Text), hidedpNo.Text, hidsystemName.Text, hidkind.Text, Convert.ToInt32(tbxno.Text), tbxedpNo.Text, tbxsystemName.Text, tbxkind.Text, tbxtitle.Text, tbxchildTitle.Text, tbxdataTxt.Text, tbxdataHtml.Text, tbxenclosure1.Text, tbxenclosure2.Text, tbxenclosure3.Text, tbxenclosure4.Text, tbxenclosure5.Text, tbxsavePath.Text, tbxshareType.Text, tbxtourokuUser.Text, tbxtourokuTime.Text)
            MsInit()
        Catch ex As Exception
            Common.ShowMsg(Me.Page, ex.Message)
            Exit Sub
        End Try
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
            BC.InsMData(tbxno.Text, tbxedpNo.Text, tbxsystemName.Text, tbxkind.Text, tbxtitle.Text, tbxchildTitle.Text, tbxdataTxt.Text, tbxdataHtml.Text, tbxenclosure1.Text, tbxenclosure2.Text, tbxenclosure3.Text, tbxenclosure4.Text, tbxenclosure5.Text, tbxsavePath.Text, tbxshareType.Text, tbxtourokuUser.Text, tbxtourokuTime.Text)
            MsInit()
        Catch ex As Exception
            Common.ShowMsg(Me.Page, ex.Message)
            Exit Sub
        End Try
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
            BC.DelMData(hidno.Text, hidedpNo.Text, hidsystemName.Text, hidkind.Text)
            MsInit()
        Catch ex As Exception
            Common.ShowMsg(Me.Page, ex.Message)
            Exit Sub
        End Try
    End Sub

End Class
