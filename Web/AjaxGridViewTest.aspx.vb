Imports System.Web.UI.WebControls

Partial Class AjaxGridViewTest
    Inherits System.Web.UI.Page

    Public Function CreateDataSourceByXianhuiMeng() As System.Data.DataView
        Dim dt As New System.Data.DataTable()

        dt.Columns.Add(New System.Data.DataColumn("id", GetType(System.Int32)))
        dt.Columns.Add(New System.Data.DataColumn(" 学生姓名 ", GetType(System.String)))
        dt.Columns.Add(New System.Data.DataColumn(" 语文 ", GetType(System.Decimal)))
        dt.Columns.Add(New System.Data.DataColumn(" 数学 ", GetType(System.Decimal)))
        dt.Columns.Add(New System.Data.DataColumn(" 英语 ", GetType(System.Decimal)))
        dt.Columns.Add(New System.Data.DataColumn(" 计算机 ", GetType(System.Decimal)))

        For i As Integer = 1 To 20

            Dim dr As System.Data.DataRow

            dr = dt.NewRow()
            dr.Item(0) = i.ToString()
            dr.Item(1) = i.ToString()
            dr.Item(2) = i.ToString()
            dr.Item(3) = i.ToString()
            dr.Item(4) = i.ToString()
            dr.Item(5) = i.ToString()
            dt.Rows.Add(dr)
        Next

        Return New System.Data.DataView(dt)

    End Function


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Request.QueryString("id") <> "" Then
            Response.ClearContent()
            GridView1.DataSource = CreateDataSourceByXianhuiMeng()
            GridView1.DataBind()
            Dim sb As New System.Text.StringBuilder()
            Dim sw As New System.IO.StringWriter(sb)
            Dim htw As New HtmlTextWriter(sw)
            'Dim Header As New Literal()
            'Header.Text = " <h2>项目 " + Request.QueryString("id") + " </h2> "
            'Header.Controls.Add(Header)
            'Header.RenderControl(htw)
            GridView1.RenderControl(htw)
            'Response.Write(" 这里查询数据，输出结果就可以了。结果： " + sb.ToString())
            Response.End()


        End If

    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)

    End Sub




    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs)
        MsgBox(Me.GridView1.Rows.Count)

    End Sub
End Class
