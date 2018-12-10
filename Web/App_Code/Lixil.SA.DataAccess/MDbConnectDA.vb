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

Public Class MDbConnectDA

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

    Public Function SelMDbConnect(Byval connectNo_key AS String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           connectNo_key)
        'SQLコメント
        '--**テーブル：DB接続情報 : m_db_connect
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("connect_no")                                                'DB接続No
        sb.AppendLine(", connect_name")                                            '－ＣＯＮＮＥＣＴ－ＮＡＭＥ
        sb.AppendLine(", connect_str")                                             '－ＣＯＮＮＥＣＴ－ＳＴＲ

        sb.AppendLine("FROM m_db_connect")
        sb.AppendLine("WHERE 1=1")
            If connectNo_key<>"" Then
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
    ''' DB接続情報
    ''' DB接続情報情報を更新する
    ''' </summary>
    '''<param name="connectNo_key">DB接続No</param>
'''<param name="connectNo">DB接続No</param>
'''<param name="connectName">－ＣＯＮＮＥＣＴ－ＮＡＭＥ</param>
'''<param name="connectStr">－ＣＯＮＮＥＣＴ－ＳＴＲ</param>
    ''' <returns>DB接続情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

Public Function UpdMDbConnect(Byval connectNo_key AS String, _
           Byval connectNo AS String, _
           Byval connectName AS String, _
           Byval connectStr AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           connectNo_key, _
           connectNo, _
           connectName, _
           connectStr)
    'SQLコメント
    '--**テーブル：DB接続情報 : m_db_connect
    Dim sb As New StringBuilder
        'SQL文
    sb.AppendLine("UPDATE m_db_connect")
    sb.AppendLine("SET")
    sb.AppendLine("connect_no=@connect_no")   'DB接続No
    sb.AppendLine(", connect_name=@connect_name")   '－ＣＯＮＮＥＣＴ－ＮＡＭＥ
    sb.AppendLine(", connect_str=@connect_str")   '－ＣＯＮＮＥＣＴ－ＳＴＲ

    sb.AppendLine("FROM m_db_connect")
    sb.AppendLine("WHERE 1=1")
        If connectNo_key<>"" Then
            sb.AppendLine("AND connect_no=@connect_no_key")   'DB接続No
        End If

    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@connect_no_key", SqlDbType.Int, 4, GetIntValue(connectNo_key)))

    paramList.Add(MakeParam("@connect_no", SqlDbType.Int, 4, GetIntValue(connectNo)))
    paramList.Add(MakeParam("@connect_name", SqlDbType.nvarchar, 200, connectName))
    paramList.Add(MakeParam("@connect_str", SqlDbType.nvarchar, 200, connectStr))


    SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray) 

    Return True 

End Function

    ''' <summary>
    ''' DB接続情報
    ''' DB接続情報情報を登録する
    ''' </summary>
    '''<param name="connectNo">DB接続No</param>
'''<param name="connectName">－ＣＯＮＮＥＣＴ－ＮＡＭＥ</param>
'''<param name="connectStr">－ＣＯＮＮＥＣＴ－ＳＴＲ</param>
    ''' <returns>DB接続情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

Public Function InsMDbConnect(Byval connectNo AS String, _
           Byval connectName AS String, _
           Byval connectStr AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           connectNo, _
           connectName, _
           connectStr)
    'SQLコメント
    '--**テーブル：DB接続情報 : m_db_connect
    Dim sb As New StringBuilder
        'SQL文
    sb.AppendLine("INSERT INTO  m_db_connect")
    sb.AppendLine("(")
        sb.AppendLine("connect_no")                                                'DB接続No
        sb.AppendLine(", connect_name")                                            '－ＣＯＮＮＥＣＴ－ＮＡＭＥ
        sb.AppendLine(", connect_str")                                             '－ＣＯＮＮＥＣＴ－ＳＴＲ

    sb.AppendLine(")")
    sb.AppendLine("VALUES(")
    sb.AppendLine("@connect_no")                                                   'DB接続No
    sb.AppendLine(", @connect_name")                                               '－ＣＯＮＮＥＣＴ－ＮＡＭＥ
    sb.AppendLine(", @connect_str")                                                '－ＣＯＮＮＥＣＴ－ＳＴＲ

    sb.AppendLine(")")
    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@connect_no", SqlDbType.Int, 4, GetIntValue(connectNo)))
    paramList.Add(MakeParam("@connect_name", SqlDbType.nvarchar, 200, connectName))
    paramList.Add(MakeParam("@connect_str", SqlDbType.nvarchar, 200, connectStr))


    SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray) 

    Return True 

End Function

    ''' <summary>
    ''' DB接続情報
    ''' DB接続情報情報を削除する
    ''' </summary>
    '''<param name="connectNo_key">DB接続No</param>
    ''' <returns>DB接続情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

Public Function DelMDbConnect(Byval connectNo_key AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           connectNo_key)
    'SQLコメント
    '--**テーブル：DB接続情報 : m_db_connect
    Dim sb As New StringBuilder
        'SQL文
    sb.AppendLine("DELETE FROM m_db_connect")
    sb.AppendLine("WHERE 1=1")
        If connectNo_key<>"" Then
            sb.AppendLine("AND connect_no=@connect_no_key")   'DB接続No
        End If

    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@connect_no_key", SqlDbType.Int, 4, GetIntValue(connectNo_key)))


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
