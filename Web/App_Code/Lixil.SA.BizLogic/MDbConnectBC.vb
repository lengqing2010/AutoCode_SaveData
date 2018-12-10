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

Public Class MDbConnectBC
Public DA AS NEW MDbConnectDA

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
    Return DA.SelMDbConnect( _
           connectNo_key)
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
    Return DA.UpdMDbConnect( _
           connectNo_key, _
           connectNo, _
           connectName, _
           connectStr)

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
    Return DA.InsMDbConnect( _
           connectNo, _
           connectName, _
           connectStr)

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
    Return DA.DelMDbConnect( _
           connectNo_key)


End Function

End Class
