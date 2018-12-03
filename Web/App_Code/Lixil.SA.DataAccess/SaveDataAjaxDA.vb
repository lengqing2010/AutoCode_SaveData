Imports EMAB = Itis.ApplicationBlocks.ExceptionManagement.UnTrappedExceptionManager
Imports MyMethod = System.Reflection.MethodBase
Imports Itis.ApplicationBlocks.Data.SQLHelper
Imports Itis.ApplicationBlocks.Data
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Transactions
Imports System.Configuration.ConfigurationSettings
Imports System.Collections.Generic

Public Class SaveDataAjaxDA

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を検索する
    ''' </summary>
    '''<param name="no_key">番号</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="kind_key">種類</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMData(ByVal no_key As String, _
           ByVal edpNo_key As String, _
           ByVal systemName_key As String, _
           ByVal kind_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               no_key, _
               edpNo_key, _
               systemName_key, _
               kind_key)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("no")                                                            '番号
        sb.AppendLine(", edp_no")                                                      'EDP番号
        sb.AppendLine(", system_name")                                                 'システム名
        sb.AppendLine(", kind")                                                        '種類
        sb.AppendLine(", title")                                                       'タイトル
        sb.AppendLine(", child_title")                                                 '子タイトル
        sb.AppendLine(", data_txt")                                                    '内容TXT
        sb.AppendLine(", data_html")                                                   '内容HTML
        sb.AppendLine(", enclosure1")                                                  '添付ファイル１
        sb.AppendLine(", enclosure2")                                                  '添付ファイル２
        sb.AppendLine(", enclosure3")                                                  '添付ファイル３
        sb.AppendLine(", enclosure4")                                                  '添付ファイル４
        sb.AppendLine(", enclosure5")                                                  '添付ファイル５
        sb.AppendLine(", save_path")                                                   '保存パス
        sb.AppendLine(", share_type")                                                  '共有
        sb.AppendLine(", touroku_user")                                                '登録者
        sb.AppendLine(", touroku_time")                                                '登録時間

        sb.AppendLine("FROM m_data")
        sb.AppendLine("WHERE 1=1")
        If no_key <> "" Then
            sb.AppendLine("AND no=@no_key")   '番号
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If kind_key <> "" Then
            sb.AppendLine("AND kind=@kind_key")   '種類
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@no_key", SqlDbType.Int, 4, GetIntValue(no_key)))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 10, edpNo_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 50, systemName_key))
        paramList.Add(MakeParam("@kind_key", SqlDbType.nvarchar, 20, kind_key))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_data", paramList.ToArray)

        Return dsInfo.Tables("m_data")

    End Function

    ''' <summary>
    ''' MAX No
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelMaxNo() As String
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("MAX(no)+1")                                                            '番号
        sb.AppendLine("FROM m_data")

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "SelMaxNo", paramList.ToArray)

        Return dsInfo.Tables("SelMaxNo").Rows(0).Item(0).ToString

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を更新する
    ''' </summary>
    '''<param name="no_key">番号</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="kind_key">種類</param>
    '''<param name="no">番号</param>
    '''<param name="edpNo">EDP番号</param>
    '''<param name="systemName">システム名</param>
    '''<param name="kind">種類</param>
    '''<param name="title">タイトル</param>
    '''<param name="childTitle">子タイトル</param>
    '''<param name="dataTxt">内容TXT</param>
    '''<param name="dataHtml">内容HTML</param>
    '''<param name="enclosure1">添付ファイル１</param>
    '''<param name="enclosure2">添付ファイル２</param>
    '''<param name="enclosure3">添付ファイル３</param>
    '''<param name="enclosure4">添付ファイル４</param>
    '''<param name="enclosure5">添付ファイル５</param>
    '''<param name="savePath">保存パス</param>
    '''<param name="shareType">共有</param>
    '''<param name="tourokuUser">登録者</param>
    '''<param name="tourokuTime">登録時間</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function UpdMData(ByVal no_key As String, _
               ByVal edpNo_key As String, _
               ByVal systemName_key As String, _
               ByVal kind_key As String, _
               ByVal no As String, _
               ByVal edpNo As String, _
               ByVal systemName As String, _
               ByVal kind As String, _
               ByVal title As String, _
               ByVal childTitle As String, _
               ByVal dataTxt As String, _
               ByVal dataHtml As String, _
               ByVal enclosure1 As String, _
               ByVal enclosure2 As String, _
               ByVal enclosure3 As String, _
               ByVal enclosure4 As String, _
               ByVal enclosure5 As String, _
               ByVal savePath As String, _
               ByVal shareType As String, _
               ByVal tourokuUser As String, _
               ByVal tourokuTime As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               no_key, _
               edpNo_key, _
               systemName_key, _
               kind_key, _
               no, _
               edpNo, _
               systemName, _
               kind, _
               title, _
               childTitle, _
               dataTxt, _
               dataHtml, _
               enclosure1, _
               enclosure2, _
               enclosure3, _
               enclosure4, _
               enclosure5, _
               savePath, _
               shareType, _
               tourokuUser, _
               tourokuTime)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("UPDATE m_data")
        sb.AppendLine("SET")
        sb.AppendLine("no=@no")                                                        '番号
        sb.AppendLine(", edp_no=@edp_no")                                              'EDP番号
        sb.AppendLine(", system_name=@system_name")   'システム名
        sb.AppendLine(", kind=@kind")                                                  '種類
        sb.AppendLine(", title=@title")                                                'タイトル
        sb.AppendLine(", child_title=@child_title")   '子タイトル
        sb.AppendLine(", data_txt=@data_txt")   '内容TXT
        sb.AppendLine(", data_html=@data_html")   '内容HTML
        sb.AppendLine(", enclosure1=@enclosure1")   '添付ファイル１
        sb.AppendLine(", enclosure2=@enclosure2")   '添付ファイル２
        sb.AppendLine(", enclosure3=@enclosure3")   '添付ファイル３
        sb.AppendLine(", enclosure4=@enclosure4")   '添付ファイル４
        sb.AppendLine(", enclosure5=@enclosure5")   '添付ファイル５
        sb.AppendLine(", save_path=@save_path")   '保存パス
        sb.AppendLine(", share_type=@share_type")   '共有
        sb.AppendLine(", touroku_user=@touroku_user")   '登録者
        sb.AppendLine(", touroku_time=@touroku_time")   '登録時間

        sb.AppendLine("FROM m_data")
        sb.AppendLine("WHERE 1=1")
        If no_key <> "" Then
            sb.AppendLine("AND no=@no_key")   '番号
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If kind_key <> "" Then
            sb.AppendLine("AND kind=@kind_key")   '種類
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@no_key", SqlDbType.Int, 4, GetIntValue(no_key)))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 10, edpNo_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 50, systemName_key))
        paramList.Add(MakeParam("@kind_key", SqlDbType.nvarchar, 20, kind_key))

        paramList.Add(MakeParam("@no", SqlDbType.Int, 4, GetIntValue(no)))
        paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 10, edpNo))
        paramList.Add(MakeParam("@system_name", SqlDbType.nvarchar, 50, systemName))
        paramList.Add(MakeParam("@kind", SqlDbType.nvarchar, 20, kind))
        paramList.Add(MakeParam("@title", SqlDbType.nvarchar, 200, title))
        paramList.Add(MakeParam("@child_title", SqlDbType.nvarchar, 200, childTitle))
        paramList.Add(MakeParam("@data_txt", SqlDbType.ntext, 8, dataTxt))
        paramList.Add(MakeParam("@data_html", SqlDbType.ntext, 8, dataHtml))
        paramList.Add(MakeParam("@enclosure1", SqlDbType.ntext, 8, enclosure1))
        paramList.Add(MakeParam("@enclosure2", SqlDbType.ntext, 8, enclosure2))
        paramList.Add(MakeParam("@enclosure3", SqlDbType.ntext, 8, enclosure3))
        paramList.Add(MakeParam("@enclosure4", SqlDbType.ntext, 8, enclosure4))
        paramList.Add(MakeParam("@enclosure5", SqlDbType.ntext, 8, enclosure5))
        paramList.Add(MakeParam("@save_path", SqlDbType.nvarchar, 800, savePath))
        paramList.Add(MakeParam("@share_type", SqlDbType.nvarchar, 1, shareType))
        paramList.Add(MakeParam("@touroku_user", SqlDbType.nvarchar, 20, tourokuUser))
        paramList.Add(MakeParam("@touroku_time", SqlDbType.Date, 24, IIf(tourokuTime = "", DBNull.Value, tourokuTime)))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を登録する
    ''' </summary>
    '''<param name="no">番号</param>
    '''<param name="edpNo">EDP番号</param>
    '''<param name="systemName">システム名</param>
    '''<param name="kind">種類</param>
    '''<param name="title">タイトル</param>
    '''<param name="childTitle">子タイトル</param>
    '''<param name="dataTxt">内容TXT</param>
    '''<param name="dataHtml">内容HTML</param>
    '''<param name="enclosure1">添付ファイル１</param>
    '''<param name="enclosure2">添付ファイル２</param>
    '''<param name="enclosure3">添付ファイル３</param>
    '''<param name="enclosure4">添付ファイル４</param>
    '''<param name="enclosure5">添付ファイル５</param>
    '''<param name="savePath">保存パス</param>
    '''<param name="shareType">共有</param>
    '''<param name="tourokuUser">登録者</param>
    '''<param name="tourokuTime">登録時間</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function InsMData(ByVal no As String, _
               ByVal edpNo As String, _
               ByVal systemName As String, _
               ByVal kind As String, _
               ByVal title As String, _
               ByVal childTitle As String, _
               ByVal dataTxt As String, _
               ByVal dataHtml As String, _
               ByVal enclosure1 As String, _
               ByVal enclosure2 As String, _
               ByVal enclosure3 As String, _
               ByVal enclosure4 As String, _
               ByVal enclosure5 As String, _
               ByVal savePath As String, _
               ByVal shareType As String, _
               ByVal tourokuUser As String, _
               ByVal tourokuTime As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               no, _
               edpNo, _
               systemName, _
               kind, _
               title, _
               childTitle, _
               dataTxt, _
               dataHtml, _
               enclosure1, _
               enclosure2, _
               enclosure3, _
               enclosure4, _
               enclosure5, _
               savePath, _
               shareType, _
               tourokuUser, _
               tourokuTime)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("INSERT INTO  m_data")
        sb.AppendLine("(")
        sb.AppendLine("no")                                                            '番号
        sb.AppendLine(", edp_no")                                                      'EDP番号
        sb.AppendLine(", system_name")                                                 'システム名
        sb.AppendLine(", kind")                                                        '種類
        sb.AppendLine(", title")                                                       'タイトル
        sb.AppendLine(", child_title")                                                 '子タイトル
        sb.AppendLine(", data_txt")                                                    '内容TXT
        sb.AppendLine(", data_html")                                                   '内容HTML
        sb.AppendLine(", enclosure1")                                                  '添付ファイル１
        sb.AppendLine(", enclosure2")                                                  '添付ファイル２
        sb.AppendLine(", enclosure3")                                                  '添付ファイル３
        sb.AppendLine(", enclosure4")                                                  '添付ファイル４
        sb.AppendLine(", enclosure5")                                                  '添付ファイル５
        sb.AppendLine(", save_path")                                                   '保存パス
        sb.AppendLine(", share_type")                                                  '共有
        sb.AppendLine(", touroku_user")                                                '登録者
        sb.AppendLine(", touroku_time")                                                '登録時間

        sb.AppendLine(")")
        sb.AppendLine("VALUES(")
        sb.AppendLine("@no")                                                           '番号
        sb.AppendLine(", @edp_no")                                                     'EDP番号
        sb.AppendLine(", @system_name")                                                'システム名
        sb.AppendLine(", @kind")                                                       '種類
        sb.AppendLine(", @title")                                                      'タイトル
        sb.AppendLine(", @child_title")                                                '子タイトル
        sb.AppendLine(", @data_txt")                                                   '内容TXT
        sb.AppendLine(", @data_html")                                                  '内容HTML
        sb.AppendLine(", @enclosure1")                                                 '添付ファイル１
        sb.AppendLine(", @enclosure2")                                                 '添付ファイル２
        sb.AppendLine(", @enclosure3")                                                 '添付ファイル３
        sb.AppendLine(", @enclosure4")                                                 '添付ファイル４
        sb.AppendLine(", @enclosure5")                                                 '添付ファイル５
        sb.AppendLine(", @save_path")                                                  '保存パス
        sb.AppendLine(", @share_type")                                                 '共有
        sb.AppendLine(", @touroku_user")                                               '登録者
        sb.AppendLine(", @touroku_time")                                               '登録時間

        sb.AppendLine(")")
        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@no", SqlDbType.Int, 4, GetIntValue(no)))
        paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 10, edpNo))
        paramList.Add(MakeParam("@system_name", SqlDbType.nvarchar, 50, systemName))
        paramList.Add(MakeParam("@kind", SqlDbType.nvarchar, 20, kind))
        paramList.Add(MakeParam("@title", SqlDbType.nvarchar, 200, title))
        paramList.Add(MakeParam("@child_title", SqlDbType.nvarchar, 200, childTitle))
        paramList.Add(MakeParam("@data_txt", SqlDbType.ntext, 8, dataTxt))
        paramList.Add(MakeParam("@data_html", SqlDbType.ntext, 8, dataHtml))
        paramList.Add(MakeParam("@enclosure1", SqlDbType.ntext, 8, enclosure1))
        paramList.Add(MakeParam("@enclosure2", SqlDbType.ntext, 8, enclosure2))
        paramList.Add(MakeParam("@enclosure3", SqlDbType.ntext, 8, enclosure3))
        paramList.Add(MakeParam("@enclosure4", SqlDbType.ntext, 8, enclosure4))
        paramList.Add(MakeParam("@enclosure5", SqlDbType.ntext, 8, enclosure5))
        paramList.Add(MakeParam("@save_path", SqlDbType.nvarchar, 800, savePath))
        paramList.Add(MakeParam("@share_type", SqlDbType.nvarchar, 1, shareType))
        paramList.Add(MakeParam("@touroku_user", SqlDbType.nvarchar, 20, tourokuUser))
        paramList.Add(MakeParam("@touroku_time", SqlDbType.Date, 24, IIf(tourokuTime = "", DBNull.Value, tourokuTime)))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を削除する
    ''' </summary>
    '''<param name="no_key">番号</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="kind_key">種類</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function DelMData(ByVal no_key As String, _
               ByVal edpNo_key As String, _
               ByVal systemName_key As String, _
               ByVal kind_key As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               no_key, _
               edpNo_key, _
               systemName_key, _
               kind_key)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("DELETE FROM m_data")
        sb.AppendLine("WHERE 1=1")
        If no_key <> "" Then
            sb.AppendLine("AND no=@no_key")   '番号
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If kind_key <> "" Then
            sb.AppendLine("AND kind=@kind_key")   '種類
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@no_key", SqlDbType.Int, 4, GetIntValue(no_key)))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 10, edpNo_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 50, systemName_key))
        paramList.Add(MakeParam("@kind_key", SqlDbType.nvarchar, 20, kind_key))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' GetIntValue
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetIntValue(ByVal v As Object) As Object
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name)
        If v Is DBNull.Value Or v.ToString = "" Then
            Return DBNull.Value

        Else
            Return Convert.ToInt32(v)
        End If

    End Function

End Class
