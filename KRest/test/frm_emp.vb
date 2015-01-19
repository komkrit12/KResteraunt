Public Class frm_emp
    Dim class_conn As New class_conn
     Sub cal_id()
        Dim sql As String = ""
        Dim dta As DataTable
        Dim num As Integer = 0
        Dim na As Integer = 0
        Dim a As String = ""
        sql += "select max(EMID) as EMID from Employee"
        dta = class_conn.selectbase(sql)
        num = dta.Rows.Count
        If num = "0" Or dta.Rows(0).Item("EMID").ToString = "" Then
            a = "E0001"
        Else
            a = dta.Rows(0).Item("EMID").ToString
            a = a.Substring(1, a.Length() - 1)
            na = Convert.ToInt32(a)
            na = na + 1
            a = "E" & Format(na, "0000")
        End If
        Me.Lbid.Text = a
    End Sub
    Sub data_combobox()
        Dim sql As String
        Dim dta As DataTable
        sql = " select * from Department "
        dta = class_conn.selectbase(sql)
        Dim dr As DataRow = dta.NewRow()
        dr("DepID") = 0
        dr("DepName") = "กรุณาเลือก"
        dta.Rows.InsertAt(dr, 0)
        Me.Cmb_dep.DisplayMember = "DepName"
        Me.Cmb_dep.ValueMember = "DepID"
        Me.Cmb_dep.DataSource = dta
    End Sub
    Sub insert_data()
        Dim date_birth As String
        date_birth = Me.dtt_date.Value.Year.ToString & "-" & Me.dtt_date.Value.Month.ToString & "-" & Me.dtt_date.Value.Day.ToString
        Dim sql As String = ""
        sql += " insert into Employee (EMID,EMName,EMLName,EMIDCard,EMPDep,EMHouseNumber,EMMOO,EMSoi,EMDatein,EMBirth,EMRoad,EMPassword,EMDistrict,EMCity,EMProvince,EMPostCode,EMPhone) "
        sql += " Values('" + Me.Lbid.Text + "','" + Me.txt_name.Text + "','" + Me.txt_surname.Text + "','" + Me.txt_citizenid.Text + "','" + Me.Cmb_dep.SelectedValue.ToString + "','" + Me.txt_no.Text + "','" + Me.txt_moo.Text + "','" + Me.txt_soi.Text + "',getdate(),'" + date_birth + "','" + Me.txt_rd.Text + "','" + Me.txt_pwd.Text + "','" + Me.txt_tambol.Text + "','" + Me.txt_city.Text + "','" + Me.txt_province.Text + "','" + Me.txt_postal.Text + "','" + Me.txt_tel.Text + "')"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_text()
            select_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub clear_text()
        Me.txt_name.Text = ""
        Me.txt_tel.Text = ""
        Me.lb_id.Text = ""
        Me.txt_citizenid.Text = ""
        Me.txt_city.Text = ""
        Me.Cmb_dep.Text = ""
        Me.txt_moo.Text = ""
        Me.txt_no.Text = ""
        Me.txt_postal.Text = ""
        Me.txt_province.Text = ""
        Me.txt_pwd.Text = ""
        Me.txt_surname.Text = ""
        Me.txt_tambol.Text = ""
        Me.txt_soi.Text = ""
        Me.txt_rd.Text = ""
        cal_id()
    End Sub
    Sub select_data()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " select * from view_empdep "
        dta = class_conn.selectbase(sql)
        Me.DataGridView1.DataSource = dta
    End Sub
    Sub delete()
        Dim sql As String = ""
        Dim dta As DataTable
        sql += " Delete from Employee "
        sql += " where EMID ='" + Me.lb_id.Text + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_text()
            select_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Sub update_data()
        Dim sql As String = ""
        sql += " update Employee set "
        sql += " EMName='" + Me.txt_name.Text + "',"
        sql += " EMLName='" + Me.txt_surname.Text + "',"
        sql += " EMIDCard='" + Me.txt_citizenid.Text + "',"
        sql += " EMHouseNumber='" + Me.txt_no.Text + "',"
        sql += " EMMOO='" + Me.txt_moo.Text + "',"
        sql += " EMSoi='" + Me.txt_soi.Text + "',"
        sql += " EMRoad='" + Me.txt_rd.Text + "',"
        sql += " EMDistrict='" + Me.txt_tambol.Text + "',"
        sql += " EMCity='" + Me.txt_city.Text + "',"
        sql += " EMProvince='" + Me.txt_province.Text + "',"
        sql += " EMPostCode='" + Me.txt_postal.Text + "',"
        sql += " EMPhone='" + Me.txt_tel.Text + "',"
        sql += " EMPassword='" + Me.txt_pwd.Text + "',"
        sql += " EMBirth='" + Me.dtt_date.Value + "',"
        sql += " EMPDep='" + Me.Cmb_dep.SelectedValue.ToString + "'"
        sql += " where EMID='" + Me.lb_id.Text + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("สำเร็จ", "ไม่มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Information)
            select_data()
        Else
            MessageBox.Show("ไม่สำเร็จ", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub frm_emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        data_combobox()
        cal_id()
        select_data()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        insert_data()
        select_data()
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear_text()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim UserSelectRow As Integer = 0
        UserSelectRow = CInt(Me.DataGridView1.CurrentRow.Index.ToString)
        Me.Lbid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMID").Value.ToString
        Me.txt_surname.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMLName").Value.ToString
        Me.txt_citizenid.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMIDCard").Value.ToString
        Me.Cmb_dep.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMPDep").Value.ToString
        Me.txt_no.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMHouseNumber").Value.ToString
        Me.txt_moo.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMMOO").Value.ToString
        Me.txt_soi.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMSoi").Value.ToString
        Me.txt_rd.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMRoad").Value.ToString
        Me.txt_tambol.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMDistrict").Value.ToString
        Me.txt_city.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMCity").Value.ToString
        Me.txt_province.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMProvince").Value.ToString
        Me.txt_postal.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMPostCode").Value.ToString
        Me.txt_tel.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMPhone").Value.ToString
        Me.txt_pwd.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMPassword").Value.ToString
        Me.txt_name.Text = DataGridView1.Rows.Item(UserSelectRow).Cells("EMName").Value.ToString
        Me.dtt_date.Value = DataGridView1.Rows.Item(UserSelectRow).Cells("EMBirth").Value.ToString
    End Sub
    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If MsgBox("คุณต้องการลบหรือไม่" & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            delete_data()
            clear_text()
        End If
    End Sub
    Sub delete_data()
        Dim sql As String = ""
        sql += "delete from Employee "
        sql += "where EMID ='" + Me.Lbid.Text + "'"
        If class_conn.writebase(sql) = True Then
            MessageBox.Show("ทำการบันทึกสำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clear_text()
            select_data()

        Else
            MessageBox.Show("ทำการบันทึกล้มเหลว", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        update_data()
    End Sub

    Private Sub Cmb_dep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_dep.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class