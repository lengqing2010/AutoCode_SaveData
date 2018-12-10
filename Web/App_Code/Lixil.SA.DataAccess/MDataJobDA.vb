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

Public Class MDataJobDA


    ''' <summary>
    ''' 
    ''' システム名Info情報を検索する
    ''' </summary>
    '''<param name="systemName_key">システム名</param>
    ''' <returns>システム名Info情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMSystemName(ByVal systemName_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
           systemName_key)
        'SQLコメント
        '--**テーブル：システム名Info : m_system_name
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("system_name")                                               'システム名
        sb.AppendLine(", junban")                                                  '順番

        sb.AppendLine("FROM m_system_name")
        sb.AppendLine("WHERE 1=1")
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 20, systemName_key))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_system_name", paramList.ToArray)

        Return dsInfo.Tables("m_system_name")

    End Function


    ''' <summary>
    ''' 
    ''' ファイル種類情報を検索する
    ''' </summary>
    '''<param name="edpNo_key">EDP_番号</param>
    ''' <returns>ファイル種類情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMEdp(ByVal edpNo_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
           edpNo_key)
        'SQLコメント
        '--**テーブル：ファイル種類 : m_edp
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("edp_no+':'+edp_name")                                                    'EDP_番号
        sb.AppendLine("FROM m_edp")
        sb.AppendLine("WHERE 1=1")
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP_番号
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 10, edpNo_key))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_edp", paramList.ToArray)

        Return dsInfo.Tables("m_edp")

    End Function


    ''' <summary>
    ''' DB接続情報
    ''' DB接続情報情報を検索する
    ''' </summary>
    '''<param name="connectNo_key">DB接続No</param>
    ''' <returns>DB接続情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMDbConnect(ByVal connectNo_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
           connectNo_key)
        'SQLコメント
        '--**テーブル：DB接続情報 : m_db_connect
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("cast(connect_no as varchar)+':('+connect_name+')'+connect_str as conn")                                                'DB接続No
        'sb.AppendLine(", connect_name")                                            '－ＣＯＮＮＥＣＴ－ＮＡＭＥ
        'sb.AppendLine(", connect_str")                                             '－ＣＯＮＮＥＣＴ－ＳＴＲ

        sb.AppendLine("FROM m_db_connect")
        sb.AppendLine("WHERE 1=1")
        If connectNo_key <> "" Then
            sb.AppendLine("AND connect_no=@connect_no_key")   'DB接続No
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@connect_no_key", SqlDbType.Int, 4, GetIntValue(connectNo_key)))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_db_connect", paramList.ToArray)

        Return dsInfo.Tables("m_db_connect")

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 仕事データ情報を検索する
    ''' </summary>
    '''<param name="idx_key">INDEX</param>
    '''<param name="siryouKind_key">資料分類</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="kinouName_key">機能名</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="editorKind_key">Editor種類</param>
    '''<param name="connectNo_key">DB接続No</param>
    '''<param name="menuNo_key">メニューNo</param>
    ''' <returns>仕事データ情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMDataJob(ByVal idx_key As String, _
           ByVal siryouKind_key As String, _
           ByVal systemName_key As String, _
           ByVal kinouName_key As String, _
           ByVal edpNo_key As String, _
           ByVal editorKind_key As String, _
           ByVal connectNo_key As String, _
           ByVal menuNo_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
           idx_key, _
           siryouKind_key, _
           systemName_key, _
           kinouName_key, _
           edpNo_key, _
           editorKind_key, _
           connectNo_key, _
           menuNo_key)
        'SQLコメント
        '--**テーブル：仕事データ : m_data_job
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("idx")                                                       'INDEX
        sb.AppendLine(", siryou_kind")                                             '資料分類
        sb.AppendLine(", system_name")                                             'システム名
        sb.AppendLine(", kinou_name")                                              '機能名
        sb.AppendLine(", edp_no")                                                  'EDP番号
        sb.AppendLine(", editor_kind")                                             'Editor種類
        sb.AppendLine(", connect_no")                                              'DB接続No
        sb.AppendLine(", menu_no")                                                 'メニューNo
        sb.AppendLine(", file_name")                                               'ファイル名
        sb.AppendLine(", data_txt")                                                '内容TXT
        sb.AppendLine(", data_html")                                               '内容HTML
        sb.AppendLine(", share_type")                                              '共有
        sb.AppendLine(", data_owner")                                              '所有者
        sb.AppendLine(", touroku_time")                                            '登録時間

        sb.AppendLine("FROM m_data_job")
        sb.AppendLine("WHERE 1=1")
        If idx_key <> "" Then
            sb.AppendLine("AND idx=@idx_key")   'INDEX
        End If
        If siryouKind_key <> "" Then
            sb.AppendLine("AND siryou_kind=@siryou_kind_key")   '資料分類
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If kinouName_key <> "" Then
            sb.AppendLine("AND kinou_name=@kinou_name_key")   '機能名
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If editorKind_key <> "" Then
            sb.AppendLine("AND editor_kind=@editor_kind_key")   'Editor種類
        End If
        If connectNo_key <> "" Then
            sb.AppendLine("AND connect_no=@connect_no_key")   'DB接続No
        End If
        If menuNo_key <> "" Then
            sb.AppendLine("AND menu_no=@menu_no_key")   'メニューNo
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@idx_key", SqlDbType.Int, 4, GetIntValue(idx_key)))
        paramList.Add(MakeParam("@siryou_kind_key", SqlDbType.NVarChar, 1, siryouKind_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.NVarChar, 20, systemName_key))
        paramList.Add(MakeParam("@kinou_name_key", SqlDbType.NVarChar, 20, kinouName_key))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.NVarChar, 8, edpNo_key))
        paramList.Add(MakeParam("@editor_kind_key", SqlDbType.NVarChar, 20, editorKind_key))
        paramList.Add(MakeParam("@connect_no_key", SqlDbType.Int, 4, GetIntValue(connectNo_key)))
        paramList.Add(MakeParam("@menu_no_key", SqlDbType.NVarChar, 20, menuNo_key))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_data_job", paramList.ToArray)

        Return dsInfo.Tables("m_data_job")

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 仕事データ情報を更新する
    ''' </summary>
    '''<param name="idx_key">INDEX</param>
    '''<param name="siryouKind_key">資料分類</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="kinouName_key">機能名</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="editorKind_key">Editor種類</param>
    '''<param name="connectNo_key">DB接続No</param>
    '''<param name="menuNo_key">メニューNo</param>
    '''<param name="idx">INDEX</param>
    '''<param name="siryouKind">資料分類</param>
    '''<param name="systemName">システム名</param>
    '''<param name="kinouName">機能名</param>
    '''<param name="edpNo">EDP番号</param>
    '''<param name="editorKind">Editor種類</param>
    '''<param name="connectNo">DB接続No</param>
    '''<param name="menuNo">メニューNo</param>
    '''<param name="fileName">ファイル名</param>
    '''<param name="dataTxt">内容TXT</param>
    '''<param name="dataHtml">内容HTML</param>
    '''<param name="shareType">共有</param>
    '''<param name="dataOwner">所有者</param>
    '''<param name="tourokuTime">登録時間</param>
    ''' <returns>仕事データ情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function UpdMDataJob(ByVal idx_key As String, _
               ByVal siryouKind_key As String, _
               ByVal systemName_key As String, _
               ByVal kinouName_key As String, _
               ByVal edpNo_key As String, _
               ByVal editorKind_key As String, _
               ByVal connectNo_key As String, _
               ByVal menuNo_key As String, _
               ByVal idx As String, _
               ByVal siryouKind As String, _
               ByVal systemName As String, _
               ByVal kinouName As String, _
               ByVal edpNo As String, _
               ByVal editorKind As String, _
               ByVal connectNo As String, _
               ByVal menuNo As String, _
               ByVal fileName As String, _
               ByVal dataTxt As String, _
               ByVal dataHtml As String, _
               ByVal shareType As String, _
               ByVal dataOwner As String, _
               ByVal tourokuTime As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               idx_key, _
               siryouKind_key, _
               systemName_key, _
               kinouName_key, _
               edpNo_key, _
               editorKind_key, _
               connectNo_key, _
               menuNo_key, _
               idx, _
               siryouKind, _
               systemName, _
               kinouName, _
               edpNo, _
               editorKind, _
               connectNo, _
               menuNo, _
               fileName, _
               dataTxt, _
               dataHtml, _
               shareType, _
               dataOwner, _
               tourokuTime)
        'SQLコメント
        '--**テーブル：仕事データ : m_data_job
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("UPDATE m_data_job")
        sb.AppendLine("SET")
        sb.AppendLine("idx=@idx")                                                      'INDEX
        sb.AppendLine(", siryou_kind=@siryou_kind")   '資料分類
        sb.AppendLine(", system_name=@system_name")   'システム名
        sb.AppendLine(", kinou_name=@kinou_name")   '機能名
        sb.AppendLine(", edp_no=@edp_no")                                              'EDP番号
        sb.AppendLine(", editor_kind=@editor_kind")   'Editor種類
        sb.AppendLine(", connect_no=@connect_no")   'DB接続No
        sb.AppendLine(", menu_no=@menu_no")                                            'メニューNo
        sb.AppendLine(", file_name=@file_name")   'ファイル名
        sb.AppendLine(", data_txt=@data_txt")   '内容TXT
        sb.AppendLine(", data_html=@data_html")   '内容HTML
        sb.AppendLine(", share_type=@share_type")   '共有
        sb.AppendLine(", data_owner=@data_owner")   '所有者
        sb.AppendLine(", touroku_time=@touroku_time")   '登録時間

        sb.AppendLine("FROM m_data_job")
        sb.AppendLine("WHERE 1=1")
        If idx_key <> "" Then
            sb.AppendLine("AND idx=@idx_key")   'INDEX
        End If
        If siryouKind_key <> "" Then
            sb.AppendLine("AND siryou_kind=@siryou_kind_key")   '資料分類
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If kinouName_key <> "" Then
            sb.AppendLine("AND kinou_name=@kinou_name_key")   '機能名
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If editorKind_key <> "" Then
            sb.AppendLine("AND editor_kind=@editor_kind_key")   'Editor種類
        End If
        If connectNo_key <> "" Then
            sb.AppendLine("AND connect_no=@connect_no_key")   'DB接続No
        End If
        If menuNo_key <> "" Then
            sb.AppendLine("AND menu_no=@menu_no_key")   'メニューNo
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@idx_key", SqlDbType.Int, 4, GetIntValue(idx_key)))
        paramList.Add(MakeParam("@siryou_kind_key", SqlDbType.NVarChar, 1, siryouKind_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.NVarChar, 20, systemName_key))
        paramList.Add(MakeParam("@kinou_name_key", SqlDbType.NVarChar, 20, kinouName_key))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.NVarChar, 8, edpNo_key))
        paramList.Add(MakeParam("@editor_kind_key", SqlDbType.NVarChar, 20, editorKind_key))
        paramList.Add(MakeParam("@connect_no_key", SqlDbType.Int, 4, GetIntValue(connectNo_key)))
        paramList.Add(MakeParam("@menu_no_key", SqlDbType.NVarChar, 20, menuNo_key))

        paramList.Add(MakeParam("@idx", SqlDbType.Int, 4, GetIntValue(idx)))
        paramList.Add(MakeParam("@siryou_kind", SqlDbType.NVarChar, 1, siryouKind))
        paramList.Add(MakeParam("@system_name", SqlDbType.NVarChar, 20, systemName))
        paramList.Add(MakeParam("@kinou_name", SqlDbType.NVarChar, 20, kinouName))
        paramList.Add(MakeParam("@edp_no", SqlDbType.NVarChar, 8, edpNo))
        paramList.Add(MakeParam("@editor_kind", SqlDbType.NVarChar, 20, editorKind))
        paramList.Add(MakeParam("@connect_no", SqlDbType.Int, 4, GetIntValue(connectNo)))
        paramList.Add(MakeParam("@menu_no", SqlDbType.NVarChar, 20, menuNo))
        paramList.Add(MakeParam("@file_name", SqlDbType.NVarChar, 100, fileName))
        paramList.Add(MakeParam("@data_txt", SqlDbType.NText, 8, dataTxt))
        paramList.Add(MakeParam("@data_html", SqlDbType.NText, 8, dataHtml))
        paramList.Add(MakeParam("@share_type", SqlDbType.NVarChar, 1, shareType))
        paramList.Add(MakeParam("@data_owner", SqlDbType.NVarChar, 10, dataOwner))
        paramList.Add(MakeParam("@touroku_time", SqlDbType.Date, 24, IIf(tourokuTime = "", DBNull.Value, tourokuTime)))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 仕事データ情報を登録する
    ''' </summary>
    '''<param name="idx">INDEX</param>
    '''<param name="siryouKind">資料分類</param>
    '''<param name="systemName">システム名</param>
    '''<param name="kinouName">機能名</param>
    '''<param name="edpNo">EDP番号</param>
    '''<param name="editorKind">Editor種類</param>
    '''<param name="connectNo">DB接続No</param>
    '''<param name="menuNo">メニューNo</param>
    '''<param name="fileName">ファイル名</param>
    '''<param name="dataTxt">内容TXT</param>
    '''<param name="dataHtml">内容HTML</param>
    '''<param name="shareType">共有</param>
    '''<param name="dataOwner">所有者</param>
    '''<param name="tourokuTime">登録時間</param>
    ''' <returns>仕事データ情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function InsMDataJob(ByVal idx As String, _
               ByVal siryouKind As String, _
               ByVal systemName As String, _
               ByVal kinouName As String, _
               ByVal edpNo As String, _
               ByVal editorKind As String, _
               ByVal connectNo As String, _
               ByVal menuNo As String, _
               ByVal fileName As String, _
               ByVal dataTxt As String, _
               ByVal dataHtml As String, _
               ByVal shareType As String, _
               ByVal dataOwner As String, _
               ByVal tourokuTime As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               idx, _
               siryouKind, _
               systemName, _
               kinouName, _
               edpNo, _
               editorKind, _
               connectNo, _
               menuNo, _
               fileName, _
               dataTxt, _
               dataHtml, _
               shareType, _
               dataOwner, _
               tourokuTime)
        'SQLコメント
        '--**テーブル：仕事データ : m_data_job
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("INSERT INTO  m_data_job")
        sb.AppendLine("(")
        sb.AppendLine("idx")                                                       'INDEX
        sb.AppendLine(", siryou_kind")                                             '資料分類
        sb.AppendLine(", system_name")                                             'システム名
        sb.AppendLine(", kinou_name")                                              '機能名
        sb.AppendLine(", edp_no")                                                  'EDP番号
        sb.AppendLine(", editor_kind")                                             'Editor種類
        sb.AppendLine(", connect_no")                                              'DB接続No
        sb.AppendLine(", menu_no")                                                 'メニューNo
        sb.AppendLine(", file_name")                                               'ファイル名
        sb.AppendLine(", data_txt")                                                '内容TXT
        sb.AppendLine(", data_html")                                               '内容HTML
        sb.AppendLine(", share_type")                                              '共有
        sb.AppendLine(", data_owner")                                              '所有者
        sb.AppendLine(", touroku_time")                                            '登録時間

        sb.AppendLine(")")
        sb.AppendLine("VALUES(")
        sb.AppendLine("(SELECT ISNULL(max([idx]),0)+1 as idx FROM [m_data_job])")                                                          'INDEX
        sb.AppendLine(", @siryou_kind")                                                '資料分類
        sb.AppendLine(", @system_name")                                                'システム名
        sb.AppendLine(", @kinou_name")                                                 '機能名
        sb.AppendLine(", @edp_no")                                                     'EDP番号
        sb.AppendLine(", @editor_kind")                                                'Editor種類
        sb.AppendLine(", @connect_no")                                                 'DB接続No
        sb.AppendLine(", @menu_no")                                                    'メニューNo
        sb.AppendLine(", @file_name")                                                  'ファイル名
        sb.AppendLine(", @data_txt")                                                   '内容TXT
        sb.AppendLine(", @data_html")                                                  '内容HTML
        sb.AppendLine(", @share_type")                                                 '共有
        sb.AppendLine(", @data_owner")                                                 '所有者
        sb.AppendLine(", @touroku_time")                                               '登録時間

        sb.AppendLine(")")
        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@idx", SqlDbType.Int, 4, GetIntValue(idx)))
        paramList.Add(MakeParam("@siryou_kind", SqlDbType.NVarChar, 1, siryouKind))
        paramList.Add(MakeParam("@system_name", SqlDbType.NVarChar, 20, systemName))
        paramList.Add(MakeParam("@kinou_name", SqlDbType.NVarChar, 20, kinouName))
        paramList.Add(MakeParam("@edp_no", SqlDbType.NVarChar, 8, edpNo))
        paramList.Add(MakeParam("@editor_kind", SqlDbType.NVarChar, 20, editorKind))
        paramList.Add(MakeParam("@connect_no", SqlDbType.Int, 4, GetIntValue(connectNo)))
        paramList.Add(MakeParam("@menu_no", SqlDbType.NVarChar, 20, menuNo))
        paramList.Add(MakeParam("@file_name", SqlDbType.NVarChar, 100, fileName))
        paramList.Add(MakeParam("@data_txt", SqlDbType.NText, 8, dataTxt))
        paramList.Add(MakeParam("@data_html", SqlDbType.NText, 8, dataHtml))
        paramList.Add(MakeParam("@share_type", SqlDbType.NVarChar, 1, shareType))
        paramList.Add(MakeParam("@data_owner", SqlDbType.NVarChar, 10, dataOwner))
        paramList.Add(MakeParam("@touroku_time", SqlDbType.Date, 24, IIf(tourokuTime = "", DBNull.Value, tourokuTime)))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 資料保存する
    ''' 仕事データ情報を削除する
    ''' </summary>
    '''<param name="idx_key">INDEX</param>
    '''<param name="siryouKind_key">資料分類</param>
    '''<param name="systemName_key">システム名</param>
    '''<param name="kinouName_key">機能名</param>
    '''<param name="edpNo_key">EDP番号</param>
    '''<param name="editorKind_key">Editor種類</param>
    '''<param name="connectNo_key">DB接続No</param>
    '''<param name="menuNo_key">メニューNo</param>
    ''' <returns>仕事データ情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function DelMDataJob(ByVal idx_key As String, _
               ByVal siryouKind_key As String, _
               ByVal systemName_key As String, _
               ByVal kinouName_key As String, _
               ByVal edpNo_key As String, _
               ByVal editorKind_key As String, _
               ByVal connectNo_key As String, _
               ByVal menuNo_key As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               idx_key, _
               siryouKind_key, _
               systemName_key, _
               kinouName_key, _
               edpNo_key, _
               editorKind_key, _
               connectNo_key, _
               menuNo_key)
        'SQLコメント
        '--**テーブル：仕事データ : m_data_job
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("DELETE FROM m_data_job")
        sb.AppendLine("WHERE 1=1")
        If idx_key <> "" Then
            sb.AppendLine("AND idx=@idx_key")   'INDEX
        End If
        If siryouKind_key <> "" Then
            sb.AppendLine("AND siryou_kind=@siryou_kind_key")   '資料分類
        End If
        If systemName_key <> "" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If
        If kinouName_key <> "" Then
            sb.AppendLine("AND kinou_name=@kinou_name_key")   '機能名
        End If
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP番号
        End If
        If editorKind_key <> "" Then
            sb.AppendLine("AND editor_kind=@editor_kind_key")   'Editor種類
        End If
        If connectNo_key <> "" Then
            sb.AppendLine("AND connect_no=@connect_no_key")   'DB接続No
        End If
        If menuNo_key <> "" Then
            sb.AppendLine("AND menu_no=@menu_no_key")   'メニューNo
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@idx_key", SqlDbType.Int, 4, GetIntValue(idx_key)))
        paramList.Add(MakeParam("@siryou_kind_key", SqlDbType.NVarChar, 1, siryouKind_key))
        paramList.Add(MakeParam("@system_name_key", SqlDbType.NVarChar, 20, systemName_key))
        paramList.Add(MakeParam("@kinou_name_key", SqlDbType.NVarChar, 20, kinouName_key))
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.NVarChar, 8, edpNo_key))
        paramList.Add(MakeParam("@editor_kind_key", SqlDbType.NVarChar, 20, editorKind_key))
        paramList.Add(MakeParam("@connect_no_key", SqlDbType.Int, 4, GetIntValue(connectNo_key)))
        paramList.Add(MakeParam("@menu_no_key", SqlDbType.NVarChar, 20, menuNo_key))


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
