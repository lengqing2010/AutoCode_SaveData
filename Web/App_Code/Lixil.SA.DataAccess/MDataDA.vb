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

Public Class MDataDA

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を検索する
    ''' </summary>
    '''<param name="dataOwner_key">所有者</param>
    '''<param name="fileName_key">ファイル名</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="editorKind_key">Editor種類</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMData(ByVal dataOwner_key As String, _
           ByVal fileName_key As String, _
           ByVal edpNo_key As String, _
           ByVal systemName_key As String, _
           ByVal editorKind_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
           dataOwner_key, _
           fileName_key, _
           edpNo_key, _
           systemName_key, _
           editorKind_key)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("data_owner")                                                    '所有者
        sb.AppendLine(", file_name")                                                   'ファイル名
        sb.AppendLine(", edp_no")                                                      'EDP番号
        sb.AppendLine(", system_name")                                                 'システム名
        sb.AppendLine(", editor_kind")                                                 'Editor種類
        sb.AppendLine(", data_txt")                                                    '内容TXT
        sb.AppendLine(", data_html")                                                   '内容HTML
        sb.AppendLine(", share_type")                                                  '共有
        sb.AppendLine(", touroku_time")                                                '登録時間

        sb.AppendLine("FROM m_data")
        sb.AppendLine("WHERE 1=1")
        If dataOwner_key <> "" Then
            sb.AppendLine("AND data_owner=@data_owner_key")   '所有者
        End If
        If fileName_key <> "" Then
            sb.AppendLine("AND file_name=@file_name_key")   'ファイル名
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If editorKind_key <> "" Then
            sb.AppendLine("AND editor_kind=@editor_kind_key")   'Editor種類
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@data_owner_key", SqlDbType.nvarchar, 10, dataOwner_key))
        paramList.Add(MakeParam("@file_name_key", SqlDbType.nvarchar, 100, fileName_key))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 8, edpNo_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 16, systemName_key))
        paramList.Add(MakeParam("@editor_kind_key", SqlDbType.nvarchar, 20, editorKind_key))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_data", paramList.ToArray)

        Return dsInfo.Tables("m_data")

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を更新する
    ''' </summary>
    '''<param name="dataOwner_key">所有者</param>
    '''<param name="fileName_key">ファイル名</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="editorKind_key">Editor種類</param>
    '''<param name="dataOwner">所有者</param>
    '''<param name="fileName">ファイル名</param>
    '''<param name="edpNo">EDP番号</param>
    '''<param name="systemName">システム名</param>
    '''<param name="editorKind">Editor種類</param>
    '''<param name="dataTxt">内容TXT</param>
    '''<param name="dataHtml">内容HTML</param>
    '''<param name="shareType">共有</param>
    '''<param name="tourokuTime">登録時間</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function UpdMData(ByVal dataOwner_key As String, _
               ByVal fileName_key As String, _
               ByVal edpNo_key As String, _
               ByVal systemName_key As String, _
               ByVal editorKind_key As String, _
               ByVal dataOwner As String, _
               ByVal fileName As String, _
               ByVal edpNo As String, _
               ByVal systemName As String, _
               ByVal editorKind As String, _
               ByVal dataTxt As String, _
               ByVal dataHtml As String, _
               ByVal shareType As String, _
               ByVal tourokuTime As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               dataOwner_key, _
               fileName_key, _
               edpNo_key, _
               systemName_key, _
               editorKind_key, _
               dataOwner, _
               fileName, _
               edpNo, _
               systemName, _
               editorKind, _
               dataTxt, _
               dataHtml, _
               shareType, _
               tourokuTime)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("UPDATE m_data")
        sb.AppendLine("SET")
        sb.AppendLine("data_owner=@data_owner")   '所有者
        sb.AppendLine(", file_name=@file_name")   'ファイル名
        sb.AppendLine(", edp_no=@edp_no")                                              'EDP番号
        sb.AppendLine(", system_name=@system_name")   'システム名
        sb.AppendLine(", editor_kind=@editor_kind")   'Editor種類
        sb.AppendLine(", data_txt=@data_txt")   '内容TXT
        sb.AppendLine(", data_html=@data_html")   '内容HTML
        sb.AppendLine(", share_type=@share_type")   '共有
        sb.AppendLine(", touroku_time=@touroku_time")   '登録時間

        sb.AppendLine("FROM m_data")
        sb.AppendLine("WHERE 1=1")
        If dataOwner_key <> "" Then
            sb.AppendLine("AND data_owner=@data_owner_key")   '所有者
        End If
        If fileName_key <> "" Then
            sb.AppendLine("AND file_name=@file_name_key")   'ファイル名
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If editorKind_key <> "" Then
            sb.AppendLine("AND editor_kind=@editor_kind_key")   'Editor種類
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@data_owner_key", SqlDbType.nvarchar, 10, dataOwner_key))
        paramList.Add(MakeParam("@file_name_key", SqlDbType.nvarchar, 100, fileName_key))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 8, edpNo_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 16, systemName_key))
        paramList.Add(MakeParam("@editor_kind_key", SqlDbType.nvarchar, 20, editorKind_key))

        paramList.Add(MakeParam("@data_owner", SqlDbType.nvarchar, 10, dataOwner))
        paramList.Add(MakeParam("@file_name", SqlDbType.nvarchar, 100, fileName))
        paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 8, edpNo))
        paramList.Add(MakeParam("@system_name", SqlDbType.nvarchar, 16, systemName))
        paramList.Add(MakeParam("@editor_kind", SqlDbType.nvarchar, 20, editorKind))
        paramList.Add(MakeParam("@data_txt", SqlDbType.ntext, 8, dataTxt))
        paramList.Add(MakeParam("@data_html", SqlDbType.ntext, 8, dataHtml))
        paramList.Add(MakeParam("@share_type", SqlDbType.nvarchar, 1, shareType))
        paramList.Add(MakeParam("@touroku_time", SqlDbType.Date, 24, IIf(tourokuTime = "", DBNull.Value, tourokuTime)))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を登録する
    ''' </summary>
    '''<param name="dataOwner">所有者</param>
    '''<param name="fileName">ファイル名</param>
    '''<param name="edpNo">EDP番号</param>
    '''<param name="systemName">システム名</param>
    '''<param name="editorKind">Editor種類</param>
    '''<param name="dataTxt">内容TXT</param>
    '''<param name="dataHtml">内容HTML</param>
    '''<param name="shareType">共有</param>
    '''<param name="tourokuTime">登録時間</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function InsMData(ByVal dataOwner As String, _
               ByVal fileName As String, _
               ByVal edpNo As String, _
               ByVal systemName As String, _
               ByVal editorKind As String, _
               ByVal dataTxt As String, _
               ByVal dataHtml As String, _
               ByVal shareType As String, _
               ByVal tourokuTime As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               dataOwner, _
               fileName, _
               edpNo, _
               systemName, _
               editorKind, _
               dataTxt, _
               dataHtml, _
               shareType, _
               tourokuTime)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("INSERT INTO  m_data")
        sb.AppendLine("(")
        sb.AppendLine("data_owner")                                                    '所有者
        sb.AppendLine(", file_name")                                                   'ファイル名
        sb.AppendLine(", edp_no")                                                      'EDP番号
        sb.AppendLine(", system_name")                                                 'システム名
        sb.AppendLine(", editor_kind")                                                 'Editor種類
        sb.AppendLine(", data_txt")                                                    '内容TXT
        sb.AppendLine(", data_html")                                                   '内容HTML
        sb.AppendLine(", share_type")                                                  '共有
        sb.AppendLine(", touroku_time")                                                '登録時間

        sb.AppendLine(")")
        sb.AppendLine("VALUES(")
        sb.AppendLine("@data_owner")                                                   '所有者
        sb.AppendLine(", @file_name")                                                  'ファイル名
        sb.AppendLine(", @edp_no")                                                     'EDP番号
        sb.AppendLine(", @system_name")                                                'システム名
        sb.AppendLine(", @editor_kind")                                                'Editor種類
        sb.AppendLine(", @data_txt")                                                   '内容TXT
        sb.AppendLine(", @data_html")                                                  '内容HTML
        sb.AppendLine(", @share_type")                                                 '共有
        sb.AppendLine(", @touroku_time")                                               '登録時間

        sb.AppendLine(")")
        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@data_owner", SqlDbType.nvarchar, 10, dataOwner))
        paramList.Add(MakeParam("@file_name", SqlDbType.nvarchar, 100, fileName))
        paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 8, edpNo))
        paramList.Add(MakeParam("@system_name", SqlDbType.nvarchar, 16, systemName))
        paramList.Add(MakeParam("@editor_kind", SqlDbType.nvarchar, 20, editorKind))
        paramList.Add(MakeParam("@data_txt", SqlDbType.ntext, 8, dataTxt))
        paramList.Add(MakeParam("@data_html", SqlDbType.ntext, 8, dataHtml))
        paramList.Add(MakeParam("@share_type", SqlDbType.nvarchar, 1, shareType))
        paramList.Add(MakeParam("@touroku_time", SqlDbType.Date, 24, IIf(tourokuTime = "", DBNull.Value, tourokuTime)))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を削除する
    ''' </summary>
    '''<param name="dataOwner_key">所有者</param>
    '''<param name="fileName_key">ファイル名</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="editorKind_key">Editor種類</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function DelMData(ByVal dataOwner_key As String, _
               ByVal fileName_key As String, _
               ByVal edpNo_key As String, _
               ByVal systemName_key As String, _
               ByVal editorKind_key As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               dataOwner_key, _
               fileName_key, _
               edpNo_key, _
               systemName_key, _
               editorKind_key)
        'SQLコメント
        '--**テーブル：資料 : m_data
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("DELETE FROM m_data")
        sb.AppendLine("WHERE 1=1")
        If dataOwner_key <> "" Then
            sb.AppendLine("AND data_owner=@data_owner_key")   '所有者
        End If
        If fileName_key <> "" Then
            sb.AppendLine("AND file_name=@file_name_key")   'ファイル名
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If editorKind_key <> "" Then
            sb.AppendLine("AND editor_kind=@editor_kind_key")   'Editor種類
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@data_owner_key", SqlDbType.nvarchar, 10, dataOwner_key))
        paramList.Add(MakeParam("@file_name_key", SqlDbType.nvarchar, 100, fileName_key))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 8, edpNo_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 16, systemName_key))
        paramList.Add(MakeParam("@editor_kind_key", SqlDbType.nvarchar, 20, editorKind_key))


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
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name )
            If v Is DBNull.Value Or v.ToString = "" Then
                Return DBNull.Value
    
            Else
                Return Convert.ToInt32(v)
            End If
    
        End Function

End Class
