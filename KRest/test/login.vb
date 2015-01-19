Public Class login
    Dim class_conn As New class_conn
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub check_data()
        If Me.txt_user.Text = "" Then
            MessageBox.Show("กรุณากรอกรหัสพนักงาน", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Me.txt_pwd.Text = "" Then
            MessageBox.Show("กรุณากรอกรหัสผ่าน", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            check_login()
        End If
    End Sub
    Sub check_login()
        Dim dta As DataTable
        Dim sql As String = ""
        sql += " select * from view_empdep "
        sql += " where EMID = '" + Me.txt_user.Text + "' "
        sql += " and EMPassword ='" + Me.txt_pwd.Text + "' "
        dta = class_conn.selectbase(sql)
        If dta.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบผู้ใช้งาน", "มีปัญหา", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            stremp_id = dta.Rows(0).Item("EMID")
            stremp_name = dta.Rows(0).Item("EMName")
            strdepart = dta.Rows(0).Item("DepName")
            Me.Hide()
            Dim frm As New Menu1
            frm.Show()

        End If
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        check_data()

    End Sub
End Class