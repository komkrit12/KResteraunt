Public Class update
    Sub data_combobox()
        Dim sql As String
        Dim dta As DataTable
        sql = " select OrderCode  from OrderTb where OrderStatus= 'ยืนยันการสั่งซื้อ'  group by OrderCode"
        dta = class_conn.selectbase(sql)
        Dim dr As DataRow = dta.NewRow()
        dr("OrderCode") = "0"
        dr("OrderCode") = "กรุณาเลือก"
        dta.Rows.InsertAt(dr, 0)
        Me.cmb_search.DisplayMember = "OrderCode"
        Me.cmb_search.ValueMember = "OrderID"
        Me.cmb_search.DataSource = dta


    End Sub

    Private Sub update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_combobox()
    End Sub
    Private Sub cmb_search_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_search.SelectedIndexChanged
        If Me.cmb_search.Text <> "กรุณาเลือก" Then
            strordercode = Me.cmb_search.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class