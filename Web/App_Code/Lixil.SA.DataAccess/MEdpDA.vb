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

Public Class MEdpDA

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を検索する
    ''' </summary>
    '''<param name="edpNo_key">EDP NUMBER</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMEdp(Byval edpNo_key AS String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           edpNo_key)
        'SQLコメント
        '--**テーブル：EDP情報 : m_edp
        Dim sb As New StringBuilder
    'SQL文
        sb.AppendLine("SELECT")
    sb.AppendLine("edp_no")                                                        'EDP NUMBER
    sb.AppendLine(", edp_name")                                                    'EDP_名

        sb.AppendLine("FROM m_edp")
        sb.AppendLine("WHERE 1=1")
            If edpNo_key<>"" Then
    sb.AppendLine("AND edp_no=@edp_no_key")   'EDP NUMBER
End If

    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 10, edpNo_key))

    Dim dsInfo As New Data.DataSet
    FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_edp", paramList.ToArray)

    Return dsInfo.Tables("m_edp")

End Function

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を更新する
    ''' </summary>
    '''<param name="edpNo_key">EDP NUMBER</param>
'''<param name="edpNo">EDP NUMBER</param>
'''<param name="edpName">EDP_名</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

Public Function UpdMEdp(Byval edpNo_key AS String, _
           Byval edpNo AS String, _
           Byval edpName AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           edpNo_key, _
           edpNo, _
           edpName)
    'SQLコメント
    '--**テーブル：EDP情報 : m_edp
    Dim sb As New StringBuilder
    'SQL文
    sb.AppendLine("UPDATE m_edp")
    sb.AppendLine("SET")
    sb.AppendLine("edp_no=@edp_no")                                                'EDP NUMBER
    sb.AppendLine(", edp_name=@edp_name")   'EDP_名

    sb.AppendLine("FROM m_edp")
    sb.AppendLine("WHERE 1=1")
        If edpNo_key<>"" Then
    sb.AppendLine("AND edp_no=@edp_no_key")   'EDP NUMBER
End If

    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 10, edpNo_key))

    paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 10, edpNo))
    paramList.Add(MakeParam("@edp_name", SqlDbType.nvarchar, 200, edpName))


    SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray) 

    Return True 

End Function

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を登録する
    ''' </summary>
    '''<param name="edpNo">EDP NUMBER</param>
'''<param name="edpName">EDP_名</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

Public Function InsMEdp(Byval edpNo AS String, _
           Byval edpName AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           edpNo, _
           edpName)
    'SQLコメント
    '--**テーブル：EDP情報 : m_edp
    Dim sb As New StringBuilder
    'SQL文
    sb.AppendLine("INSERT INTO  m_edp")
    sb.AppendLine("(")
    sb.AppendLine("edp_no")                                                        'EDP NUMBER
    sb.AppendLine(", edp_name")                                                    'EDP_名

    sb.AppendLine(")")
    sb.AppendLine("VALUES(")
    sb.AppendLine("@edp_no")                                                       'EDP NUMBER
    sb.AppendLine(", @edp_name")                                                   'EDP_名

    sb.AppendLine(")")
    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 10, edpNo))
    paramList.Add(MakeParam("@edp_name", SqlDbType.nvarchar, 200, edpName))


    SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray) 

    Return True 

End Function

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を削除する
    ''' </summary>
    '''<param name="edpNo_key">EDP NUMBER</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/03  李松涛さん 新規作成 </para>
    ''' </history>

Public Function DelMEdp(Byval edpNo_key AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           edpNo_key)
    'SQLコメント
    '--**テーブル：EDP情報 : m_edp
    Dim sb As New StringBuilder
    'SQL文
    sb.AppendLine("DELETE FROM m_edp")
    sb.AppendLine("WHERE 1=1")
        If edpNo_key<>"" Then
    sb.AppendLine("AND edp_no=@edp_no_key")   'EDP NUMBER
End If

    'バラメタ格納
    Dim paramList As New List(Of SqlParameter)
    paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 10, edpNo_key))


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
