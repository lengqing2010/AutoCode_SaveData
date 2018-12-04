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
    '''<param name="no_key">番号</param>
'''<param name="edpNo_key">EDP番号</param>
'''<param name="systemName_key">システム名</param>
'''<param name="kind_key">種類</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

Public Function SelMData(Byval no_key AS String, _
           Byval edpNo_key AS String, _
           Byval systemName_key AS String, _
           Byval kind_key AS String) As Data.DataTable
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           no_key, _
           edpNo_key, _
           systemName_key, _
           kind_key)
    'SQLコメント
    Return DA.SelMData( _
           no_key, _
           edpNo_key, _
           systemName_key, _
           kind_key)
End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を更新する
    ''' </summary>
    '''<param name="no_key">番号</param>
'''<param name="edpNo_key">EDP番号</param>
'''<param name="systemName_key">システム名</param>
'''<param name="kind_key">種類</param>
'''<param name="no">番号</param>
'''<param name="edpNo">EDP番号</param>
'''<param name="systemName">システム名</param>
'''<param name="kind">種類</param>
'''<param name="title">タイトル</param>
'''<param name="childTitle">子タイトル</param>
'''<param name="dataTxt">内容TXT</param>
'''<param name="dataHtml">内容HTML</param>
'''<param name="enclosure1">添付ファイル１</param>
'''<param name="enclosure2">添付ファイル２</param>
'''<param name="enclosure3">添付ファイル３</param>
'''<param name="enclosure4">添付ファイル４</param>
'''<param name="enclosure5">添付ファイル５</param>
'''<param name="savePath">保存パス</param>
'''<param name="shareType">共有</param>
'''<param name="tourokuUser">登録者</param>
'''<param name="tourokuTime">登録時間</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

Public Function UpdMData(Byval no_key AS String, _
           Byval edpNo_key AS String, _
           Byval systemName_key AS String, _
           Byval kind_key AS String, _
           Byval no AS String, _
           Byval edpNo AS String, _
           Byval systemName AS String, _
           Byval kind AS String, _
           Byval title AS String, _
           Byval childTitle AS String, _
           Byval dataTxt AS String, _
           Byval dataHtml AS String, _
           Byval enclosure1 AS String, _
           Byval enclosure2 AS String, _
           Byval enclosure3 AS String, _
           Byval enclosure4 AS String, _
           Byval enclosure5 AS String, _
           Byval savePath AS String, _
           Byval shareType AS String, _
           Byval tourokuUser AS String, _
           Byval tourokuTime AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           no_key, _
           edpNo_key, _
           systemName_key, _
           kind_key, _
           no, _
           edpNo, _
           systemName, _
           kind, _
           title, _
           childTitle, _
           dataTxt, _
           dataHtml, _
           enclosure1, _
           enclosure2, _
           enclosure3, _
           enclosure4, _
           enclosure5, _
           savePath, _
           shareType, _
           tourokuUser, _
           tourokuTime)
    'SQLコメント
    '--**テーブル：資料 : m_data
    Return DA.UpdMData( _
           no_key, _
           edpNo_key, _
           systemName_key, _
           kind_key, _
           no, _
           edpNo, _
           systemName, _
           kind, _
           title, _
           childTitle, _
           dataTxt, _
           dataHtml, _
           enclosure1, _
           enclosure2, _
           enclosure3, _
           enclosure4, _
           enclosure5, _
           savePath, _
           shareType, _
           tourokuUser, _
           tourokuTime)

End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を登録する
    ''' </summary>
    '''<param name="no">番号</param>
'''<param name="edpNo">EDP番号</param>
'''<param name="systemName">システム名</param>
'''<param name="kind">種類</param>
'''<param name="title">タイトル</param>
'''<param name="childTitle">子タイトル</param>
'''<param name="dataTxt">内容TXT</param>
'''<param name="dataHtml">内容HTML</param>
'''<param name="enclosure1">添付ファイル１</param>
'''<param name="enclosure2">添付ファイル２</param>
'''<param name="enclosure3">添付ファイル３</param>
'''<param name="enclosure4">添付ファイル４</param>
'''<param name="enclosure5">添付ファイル５</param>
'''<param name="savePath">保存パス</param>
'''<param name="shareType">共有</param>
'''<param name="tourokuUser">登録者</param>
'''<param name="tourokuTime">登録時間</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

Public Function InsMData(Byval no AS String, _
           Byval edpNo AS String, _
           Byval systemName AS String, _
           Byval kind AS String, _
           Byval title AS String, _
           Byval childTitle AS String, _
           Byval dataTxt AS String, _
           Byval dataHtml AS String, _
           Byval enclosure1 AS String, _
           Byval enclosure2 AS String, _
           Byval enclosure3 AS String, _
           Byval enclosure4 AS String, _
           Byval enclosure5 AS String, _
           Byval savePath AS String, _
           Byval shareType AS String, _
           Byval tourokuUser AS String, _
           Byval tourokuTime AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           no, _
           edpNo, _
           systemName, _
           kind, _
           title, _
           childTitle, _
           dataTxt, _
           dataHtml, _
           enclosure1, _
           enclosure2, _
           enclosure3, _
           enclosure4, _
           enclosure5, _
           savePath, _
           shareType, _
           tourokuUser, _
           tourokuTime)
    'SQLコメント
    '--**テーブル：資料 : m_data
    Return DA.InsMData( _
           no, _
           edpNo, _
           systemName, _
           kind, _
           title, _
           childTitle, _
           dataTxt, _
           dataHtml, _
           enclosure1, _
           enclosure2, _
           enclosure3, _
           enclosure4, _
           enclosure5, _
           savePath, _
           shareType, _
           tourokuUser, _
           tourokuTime)

End Function

    ''' <summary>
    ''' 資料保存する
    ''' 資料情報を削除する
    ''' </summary>
    '''<param name="no_key">番号</param>
'''<param name="edpNo_key">EDP番号</param>
'''<param name="systemName_key">システム名</param>
'''<param name="kind_key">種類</param>
    ''' <returns>資料情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/12/04  李松涛さん 新規作成 </para>
    ''' </history>

Public Function DelMData(Byval no_key AS String, _
           Byval edpNo_key AS String, _
           Byval systemName_key AS String, _
           Byval kind_key AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           no_key, _
           edpNo_key, _
           systemName_key, _
           kind_key)
    'SQLコメント
    '--**テーブル：資料 : m_data
    Return DA.DelMData( _
           no_key, _
           edpNo_key, _
           systemName_key, _
           kind_key)


End Function

End Class
