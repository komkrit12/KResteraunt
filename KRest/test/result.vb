Public Class result
    Dim class_conn As New class_conn
    Sub select_dat()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += "select * from view_foodorder where OrderCode = '" + Me.lb_order.Text + "' "
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub
    Private Sub result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_dat()
    End Sub
End Class