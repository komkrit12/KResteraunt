Public Class Menu1
    Dim class_conn As New class_conn
    Sub cal_id()
        Dim sql As String = ""
        Dim dta As DataTable
        Dim num As Integer = 0
        Dim a As String = ""
        Dim b As Integer
        Dim c As String
        sql += "select OrderCode from OrderTb order by OrderCode desc"
        dta = class_conn.selectbase(sql)
        num = dta.Rows.Count
        If num = "0" Then
            a = "OD0001"
        Else
            a = dta.Rows(0).Item("OrderCode").ToString
            c = a.Substring(3)
        End If
        b = CInt(c) + 1
        If b >= 0 And b <= 9 Then
            a = "OD000" + CStr(b)
        ElseIf b >= 10 And b <= 99 Then
            a = "OD00" + CStr(b)
        ElseIf b >= 100 And b <= 999 Then
            a = "OD0" + CStr(b)
        ElseIf b >= 1000 And b <= 9999 Then
            a = "OD" + CStr(b)
        Else
            a = "OD" + CStr(b)
        End If
        Me.lb_order.Text = a
    End Sub
    Sub selectfood_dat()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += "select * from view_foodfoodtype where  FoodTypeID ='7'"
        dta = class_conn.selectbase(sql)
        Me.DataGridView2.DataSource = dta
    End Sub
    Sub selectbeverage_dat()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += "select * from view_foodfoodtype where  FoodTypeID ='11'"
        dta = class_conn.selectbase(sql)
        Me.DataGridView2.DataSource = dta
    End Sub
    Sub selectappen_dat()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += "select * from view_foodfoodtype where  FoodTypeID ='15'"
        dta = class_conn.selectbase(sql)
        Me.DataGridView2.DataSource = dta
    End Sub
    Sub update_data()
        Dim sql As String = ""
        sql += " update OrderTb set "
        sql += " OrderStatus='ยืนยันการสั่งซื้อ'"
        sql += " where OrderCode ='" + Me.lb_order.Text + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim frm As New result
            frm.lb_order.Text = Me.lb_order.Text
            frm.Show()
            cal_id()
            select_dat()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub choose_food(ByVal foodid As String)

        Dim sql As String = ""
        If Me.lb_table.Text = "-" Then
            sql += " Insert into OrderTb(OrderCode,OrderDate,OrderStatus,FoodID)"
            sql += " Values('" + lb_order.Text + "',getdate(),'สั่งซื้อ','" + foodid + "')"
        Else
            sql += " Insert into OrderTb(OrderCode,OrderDate,OrderStatus,FoodID,TID)"
            sql += " Values('" + lb_order.Text + "',getdate(),'สั่งซื้อ','" + foodid + "','" + Me.lb_table.Text + "')"
            Dim sql2 As String
            sql2 += " update Tables set Tstatus = 'ไม่ว่าง' where TID = '" + Me.lb_table.Text + "'"
            class_conn.writebase(sql2)
        End If
        class_conn.writebase(sql)
        select_dat()
    End Sub
    Sub select_dat()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += "select * from view_foodorder where OrderCode = '" + Me.lb_order.Text + "' "
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub
    Sub choose_delorder(ByVal orderid As String)
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Delete from OrderTb "
        sql += " where OrderID ='" + orderid + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_dat()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btn_streak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_streak.Click
        selectfood_dat()
    End Sub

    Private Sub btn_drink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_drink.Click
        selectbeverage_dat()
    End Sub

    Private Sub btn_appen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_appen.Click
        selectappen_dat()
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim foodid As String = DataGridView2.Rows(e.RowIndex).Cells("FoodID").Value.ToString()
        If DataGridView2.Columns(e.ColumnIndex).Name = "select_food" Then
            choose_food(foodid)
        End If
    End Sub
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cal_id()
        If strdepart = "เจ้าของกิจการ" Then
            m_emp.Enabled = True
        ElseIf strdepart = "ครัว" Then

        Else
            m_emp.Enabled = False
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim orderid As String = DataGridView1.Rows(e.RowIndex).Cells("OrderID").Value.ToString()
        If DataGridView1.Columns(e.ColumnIndex).Name = "select_del" Then
            choose_delorder(orderid)
        End If
    End Sub

    Private Sub btn_summit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_summit.Click
        update_data()

    End Sub

    Private Sub btn_table_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_table.Click
        Table.ShowDialog()
        If Table.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.lb_table.Text = strtable_id
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub จดการพนกงานToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m_emp.Click
        Dim frm As New frm_emp
        frm.ShowDialog()
    End Sub

    Private Sub btn_pay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pay.Click
        Dim frm As New PayOrder
        frm.ShowDialog()
    End Sub

    Private Sub จดการอาหารToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles จดการอาหารToolStripMenuItem.Click
        Dim frm As New Food
        frm.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btn_updateorder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_updateorder.Click
        Dim frm As New update
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.lb_order.Text = strordercode
            Dim sql As String
            Dim dta As DataTable
            sql = " select OrderCode,TID  from OrderTb where OrderCode='" + Me.lb_order.Text + "'  group by OrderCode,TID"
            dta = class_conn.selectbase(sql)
            Try
                If dta.Rows(0).Item("TID") <> "0" Then

                    Me.lb_table.Text = dta.Rows(0).Item("TID")
                Else
                    Me.lb_table.Text = "-"
                End If
            Catch ex As Exception

            End Try
            
        End If

    End Sub
End Class