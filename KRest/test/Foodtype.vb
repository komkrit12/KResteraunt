Public Class Foodtype
    Dim class_conn As New class_conn
    Sub insert_data()
        Dim sql As String = ""
        sql += " insert into FoodType "
        sql += " Values('" + Me.txt_foodtype.Text + "') "
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub clear_text()
        Me.txt_foodtype.Text = ""
        Me.lb_foodtype.Text = ""
    End Sub
    Sub update_data()
        Dim sql As String = ""
        sql += " update FoodType set "
        sql += " FoodTypeName='" + Me.txt_foodtype.Text + "'"
        sql += " where FoodTypeID='" + Me.lb_foodtype.Text + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()
            clear_text()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub delete()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Delete from FoodType "
        sql += " where FoodTypeID = '" + Me.lb_foodtype.Text + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select * from FoodType "
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        insert_data()
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        update_data()
    End Sub

    Private Sub testtype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_data()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.lb_foodtype.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("FoodTypeID").Value.ToString
        Me.txt_foodtype.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("FoodTypeName").Value.ToString

    End Sub
    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If MsgBox("ต้องการลบไหม" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            delete()
            clear_text()
        End If
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear_text()
    End Sub

End Class