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

Public Class MDataBC
Public DA AS NEW MDataDA

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

Public Function SelMData(Byval dataOwner_key AS String, _
           Byval fileName_key AS String, _
           Byval edpNo_key AS String, _
           Byval systemName_key AS String, _
           Byval editorKind_key AS String) As Data.DataTable
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           dataOwner_key, _
           fileName_key, _
           edpNo_key, _
           systemName_key, _
           editorKind_key)
    'SQLコメント
    Return DA.SelMData( _
           dataOwner_key, _
           fileName_key, _
           edpNo_key, _
           systemName_key, _
           editorKind_key)
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

Public Function UpdMData(Byval dataOwner_key AS String, _
           Byval fileName_key AS String, _
           Byval edpNo_key AS String, _
           Byval systemName_key AS String, _
           Byval editorKind_key AS String, _
           Byval dataOwner AS String, _
           Byval fileName AS String, _
           Byval edpNo AS String, _
           Byval systemName AS String, _
           Byval editorKind AS String, _
           Byval dataTxt AS String, _
           Byval dataHtml AS String, _
           Byval shareType AS String, _
           Byval tourokuTime AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
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
    Return DA.UpdMData( _
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

Public Function InsMData(Byval dataOwner AS String, _
           Byval fileName AS String, _
           Byval edpNo AS String, _
           Byval systemName AS String, _
           Byval editorKind AS String, _
           Byval dataTxt AS String, _
           Byval dataHtml AS String, _
           Byval shareType AS String, _
           Byval tourokuTime AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
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
    Return DA.InsMData( _
           dataOwner, _
           fileName, _
           edpNo, _
           systemName, _
           editorKind, _
           dataTxt, _
           dataHtml, _
           shareType, _
           tourokuTime)

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

Public Function DelMData(Byval dataOwner_key AS String, _
           Byval fileName_key AS String, _
           Byval edpNo_key AS String, _
           Byval systemName_key AS String, _
           Byval editorKind_key AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           dataOwner_key, _
           fileName_key, _
           edpNo_key, _
           systemName_key, _
           editorKind_key)
    'SQLコメント
    '--**テーブル：資料 : m_data
    Return DA.DelMData( _
           dataOwner_key, _
           fileName_key, _
           edpNo_key, _
           systemName_key, _
           editorKind_key)


End Function

End Class
