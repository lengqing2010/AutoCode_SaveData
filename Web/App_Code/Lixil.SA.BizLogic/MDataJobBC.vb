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

Public Class MDataJobBC
    Public DA As New MDataJobDA


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
        Return DA.SelMSystemName( _
               systemName_key)
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
        Return DA.SelMEdp( _
               edpNo_key)
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
        Return DA.SelMDbConnect( _
               connectNo_key)
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

Public Function SelMDataJob(Byval idx_key AS String, _
           Byval siryouKind_key AS String, _
           Byval systemName_key AS String, _
           Byval kinouName_key AS String, _
           Byval edpNo_key AS String, _
           Byval editorKind_key AS String, _
           Byval connectNo_key AS String, _
           Byval menuNo_key AS String) As Data.DataTable
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           idx_key, _
           siryouKind_key, _
           systemName_key, _
           kinouName_key, _
           edpNo_key, _
           editorKind_key, _
           connectNo_key, _
           menuNo_key)
    'SQLコメント
    Return DA.SelMDataJob( _
           idx_key, _
           siryouKind_key, _
           systemName_key, _
           kinouName_key, _
           edpNo_key, _
           editorKind_key, _
           connectNo_key, _
           menuNo_key)
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

Public Function UpdMDataJob(Byval idx_key AS String, _
           Byval siryouKind_key AS String, _
           Byval systemName_key AS String, _
           Byval kinouName_key AS String, _
           Byval edpNo_key AS String, _
           Byval editorKind_key AS String, _
           Byval connectNo_key AS String, _
           Byval menuNo_key AS String, _
           Byval idx AS String, _
           Byval siryouKind AS String, _
           Byval systemName AS String, _
           Byval kinouName AS String, _
           Byval edpNo AS String, _
           Byval editorKind AS String, _
           Byval connectNo AS String, _
           Byval menuNo AS String, _
           Byval fileName AS String, _
           Byval dataTxt AS String, _
           Byval dataHtml AS String, _
           Byval shareType AS String, _
           Byval dataOwner AS String, _
           Byval tourokuTime AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
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
    Return DA.UpdMDataJob( _
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

Public Function InsMDataJob(Byval idx AS String, _
           Byval siryouKind AS String, _
           Byval systemName AS String, _
           Byval kinouName AS String, _
           Byval edpNo AS String, _
           Byval editorKind AS String, _
           Byval connectNo AS String, _
           Byval menuNo AS String, _
           Byval fileName AS String, _
           Byval dataTxt AS String, _
           Byval dataHtml AS String, _
           Byval shareType AS String, _
           Byval dataOwner AS String, _
           Byval tourokuTime AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
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
    Return DA.InsMDataJob( _
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

Public Function DelMDataJob(Byval idx_key AS String, _
           Byval siryouKind_key AS String, _
           Byval systemName_key AS String, _
           Byval kinouName_key AS String, _
           Byval edpNo_key AS String, _
           Byval editorKind_key AS String, _
           Byval connectNo_key AS String, _
           Byval menuNo_key AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
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
    Return DA.DelMDataJob( _
           idx_key, _
           siryouKind_key, _
           systemName_key, _
           kinouName_key, _
           edpNo_key, _
           editorKind_key, _
           connectNo_key, _
           menuNo_key)


End Function

End Class
