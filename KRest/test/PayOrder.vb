Public Class PayOrder
    Dim Class_conn As New class_conn
    Sub cal_id()
        Dim sql As String = ""
        Dim dta As DataTable
        Dim num As Integer = 0
        Dim a As String = ""
        Dim b As Integer
        Dim c As String
        sql += "select InvID from InvoiceItem order by InvID desc"
        dta = class_conn.selectbase(sql)
        num = dta.Rows.Count
        If num = "0" Then
            a = "INV0001"
        Else
            a = dta.Rows(0).Item("InvID").ToString
            c = a.Substring(3)
        End If
        b = CInt(c) + 1
        If b >= 0 And b <= 9 Then
            a = "INV000" + CStr(b)
        ElseIf b >= 10 And b <= 99 Then
            a = "INV00" + CStr(b)
        ElseIf b >= 100 And b <= 999 Then
            a = "INV0" + CStr(b)
        ElseIf b >= 1000 And b <= 9999 Then
            a = "INV" + CStr(b)
        Else
            a = "INV" + CStr(b)
        End If
        Me.lb_invid.Text = a
    End Sub
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

    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += "select FoodName,unit,(unit*FoodPrice) as sum_p,FoodPrice from vw_countorder where OrderCode = '" + Me.cmb_search.Text + "' group by FoodName,unit,FoodPrice"
        dta = Class_conn.selectbase(sql)
        Me.DataGrid.DataSource = dta
        Dim sql_s As String = ""
        Dim dta_s As DataTable
        sql_s += " select sum(FoodPrice) as sum_price,TID from view_foodorder where OrderCode = '" + Me.cmb_search.Text + "' group by TID"
        dta_s = Class_conn.selectbase(sql_s)
        Me.lb_sum.Text = dta_s.Rows(0).Item("sum_price")
        Try

        
        If dta_s.Rows(0).Item("TID") <> "NULL" Then
            strtable_id2 = dta_s.Rows(0).Item("TID")
        End If
        Catch ex As Exception

        End Try
    End Sub
    Sub insert_data()
        Dim sql As String = ""
        sql += " insert into InvoiceItem (InvID,OrderCode,InvDatePay,InvSum,InvRecive,InvChange,EMID) "
        sql += " Values('" + Me.lb_invid.Text + "','" + Me.cmb_search.Text + "',getdate(),'" + Me.lb_sum.Text + "','" + Me.txt_recieve.Text + "','" + Me.lb_change.Text + "','" + stremp_id + "')"
        If strtable_id2 <> "" Then
            Dim sql2 As String
            sql2 += " update Tables set Tstatus = 'ว่าง' where TID = '" + strtable_id2 + "'"
            Class_conn.writebase(sql2)
        End If
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cal_id()
            update_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub update_data()
        Dim sql As String = ""
        sql += " update OrderTb set "
        sql += " OrderStatus='ยืนยันการชำระเงิน'"
        sql += " where OrderCode ='" + Me.cmb_search.Text + "'"
        Class_conn.writebase(sql)
        Dim frm As New re_invoince
        strordercode = Me.cmb_search.Text
        frm.Show()
    End Sub
    Private Sub PayOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_combobox()
        cal_id()

    End Sub

    Private Sub cmb_search_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_search.SelectedIndexChanged
        If Me.cmb_search.Text <> "กรุณาเลือก" Then
            select_data()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_recieve.TextChanged
        If Me.txt_recieve.Text = "" Then
            Me.txt_recieve.Text = "0"
        End If
        Me.lb_change.Text = Me.txt_recieve.Text - Me.lb_sum.Text

    End Sub

    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click
        insert_data()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_change.Click

    End Sub
End Class