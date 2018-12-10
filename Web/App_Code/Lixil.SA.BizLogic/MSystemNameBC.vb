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

Public Class MSystemNameBC
Public DA AS NEW MSystemNameDA

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
    Return DA.SelMSystemName( _
           systemName_key)
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
    Return DA.UpdMSystemName( _
           systemName_key, _
           systemName, _
           junban)

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
    Return DA.InsMSystemName( _
           systemName, _
           junban)

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
    Return DA.DelMSystemName( _
           systemName_key)


End Function

End Class
