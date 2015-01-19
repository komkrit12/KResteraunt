Public Class Food
    Dim Class_conn As New class_conn
    Sub cal_id()
        Dim sql As String = ""
        Dim dta As DataTable
        Dim num As Integer = 0
        Dim na As Integer = 0
        Dim a As String = ""
        sql += "select max(FoodID) as FoodID from Food"
        dta = class_conn.selectbase(sql)
        num = dta.Rows.Count
        If num = "0" Or dta.Rows(0).Item("FoodID").ToString = "" Then
            a = "F0001"
        Else
            a = dta.Rows(0).Item("FoodID").ToString
            a = a.Substring(1, a.Length() - 1)
            na = Convert.ToInt32(a)
            na = na + 1
            a = "F" & Format(na, "0000")
        End If
        Me.lb_foodid.Text = a
    End Sub
    Sub update_data()
        Dim sql As String = ""
        sql += " update Food set "
        sql += " FoodName='" + Me.txt_name.Text + "',"
        sql += " FoodPrice='" + Me.txt_cos.Text + "',"
        sql += " FoodType='" + Me.Cmb_food.SelectedValue.ToString + "'"
        sql += " where FoodID='" + Me.lb_foodid.Text + "'"
        If Class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()
            clear_text()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub insert_data()
        Dim sql As String = ""
        sql += " insert into Food (FoodID,FoodType,FoodName,FoodPrice) "
        sql += " Values('" + Me.lb_foodid.Text + "','" + Me.Cmb_food.SelectedValue.ToString + "','" + Me.txt_name.Text + "','" + Me.txt_cos.Text + "') "
        If Class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_text()
            select_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub clear_text()
        Me.lb_foodid.Text = ""
        Me.Cmb_food.Text = ""
        Me.txt_name.Text = ""
        Me.txt_cos.Text = ""
        cal_id()
    End Sub
    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select * from view_foodfoodtype "
        dta = Class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub
    Sub delete()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Delete from Food "
        sql += " where Food ='" + Me.lb_foodid.Text + "'"
        If Class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_text()
            select_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Sub data_combobox()
        Dim sql As String
        Dim dta As DataTable
        sql = " select * from FoodType "
        dta = Class_conn.selectbase(sql)
        Dim dr As DataRow = dta.NewRow()
        dr("FoodTypeID") = 0
        dr("FoodTypeName") = "กรุณาเลือก"
        dta.Rows.InsertAt(dr, 0)
        Me.Cmb_food.DisplayMember = "FoodTypeName"
        Me.Cmb_food.ValueMember = "FoodTypeID"
        Me.Cmb_food.DataSource = dta
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.lb_foodid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("FoodID").Value.ToString
        Me.txt_name.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("FoodName").Value.ToString
        Me.Cmb_food.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("FoodTypeName").Value.ToString
        Me.txt_cos.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("FoodPrice").Value.ToString
    End Sub

    Sub delete_data()
        Dim sql As String = ""
        sql += "delete from Food "
        sql += "where FoodID ='" + Me.lb_foodid.Text + "'"
        If Class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการบันทึกสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_text()
            select_data()

        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Food_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cal_id()
        select_data()
        data_combobox()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        insert_data()

    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If MsgBox("คุณต้องการลบหรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            delete_data()
            clear_text()
        End If
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        update_data()
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear_text()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txt_name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub Cmb_food_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_food.SelectedIndexChanged

    End Sub
End Class