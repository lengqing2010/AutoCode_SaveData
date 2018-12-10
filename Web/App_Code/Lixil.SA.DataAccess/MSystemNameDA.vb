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

Public Class MSystemNameDA

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

    Public Function SelMSystemName(Byval systemName_key AS String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
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
            If systemName_key<>"" Then
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
    ''' システム名Info情報を更新する
    ''' </summary>
    '''<param name="systemName_key">システム名</param>
'''<param name="systemName">システム名</param>
'''<param name="junban">順番</param>
    ''' <returns>システム名Info情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

Public Function UpdMSystemName(Byval systemName_key AS String, _
           Byval systemName AS String, _
           Byval junban AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           systemName_key, _
           systemName, _
           junban)
    'SQLコメント
    '--**テーブル：システム名Info : m_system_name
    Dim sb As New StringBuilder
        'SQL文
    sb.AppendLine("UPDATE m_system_name")
    sb.AppendLine("SET")
    sb.AppendLine("system_name=@system_name")   'システム名
    sb.AppendLine(", junban=@junban")                                              '順番

    sb.AppendLine("FROM m_system_name")
    sb.AppendLine("WHERE 1=1")
        If systemName_key<>"" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If

    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 20, systemName_key))

    paramList.Add(MakeParam("@system_name", SqlDbType.nvarchar, 20, systemName))
    paramList.Add(MakeParam("@junban", SqlDbType.Int, 4, GetIntValue(junban)))


    SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray) 

    Return True 

End Function

    ''' <summary>
    ''' 
    ''' システム名Info情報を登録する
    ''' </summary>
    '''<param name="systemName">システム名</param>
'''<param name="junban">順番</param>
    ''' <returns>システム名Info情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

Public Function InsMSystemName(Byval systemName AS String, _
           Byval junban AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           systemName, _
           junban)
    'SQLコメント
    '--**テーブル：システム名Info : m_system_name
    Dim sb As New StringBuilder
        'SQL文
    sb.AppendLine("INSERT INTO  m_system_name")
    sb.AppendLine("(")
        sb.AppendLine("system_name")                                               'システム名
        sb.AppendLine(", junban")                                                  '順番

    sb.AppendLine(")")
    sb.AppendLine("VALUES(")
    sb.AppendLine("@system_name")                                                  'システム名
    sb.AppendLine(", @junban")                                                     '順番

    sb.AppendLine(")")
    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@system_name", SqlDbType.nvarchar, 20, systemName))
    paramList.Add(MakeParam("@junban", SqlDbType.Int, 4, GetIntValue(junban)))


    SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray) 

    Return True 

End Function

    ''' <summary>
    ''' 
    ''' システム名Info情報を削除する
    ''' </summary>
    '''<param name="systemName_key">システム名</param>
    ''' <returns>システム名Info情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/10  李松涛さん 新規作成 </para>
    ''' </history>

Public Function DelMSystemName(Byval systemName_key AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           systemName_key)
    'SQLコメント
    '--**テーブル：システム名Info : m_system_name
    Dim sb As New StringBuilder
        'SQL文
    sb.AppendLine("DELETE FROM m_system_name")
    sb.AppendLine("WHERE 1=1")
        If systemName_key<>"" Then
            sb.AppendLine("AND system_name=@system_name_key")   'システム名
        End If

    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@system_name_key", SqlDbType.nvarchar, 20, systemName_key))


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
