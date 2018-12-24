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
    Public Function SelMDataJobLike(ByVal idx_key As String, _
           ByVal siryouKind_key As String, _
           ByVal systemName_key As String, _
           ByVal kinouName_key As String, _
           ByVal edpNo_key As String, _
           ByVal editorKind_key As String, _
           ByVal connectNo_key As String, _
           ByVal menuNo_key As String, _
           ByVal txt As String) As Data.DataTable
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
        Return DA.SelMDataJobLike( _
               idx_key, _
               siryouKind_key, _
               systemName_key, _
               kinouName_key, _
               edpNo_key, _
               editorKind_key, _
               connectNo_key, _
               menuNo_key, txt)
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
               ByVal dataCode As String, _
               ByVal dataSql As String, _
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
               dataCode, _
               dataSql, _
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
               ByVal dataCode As String, _
               ByVal dataSql As String, _
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
               dataCode, _
               dataSql, _
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
