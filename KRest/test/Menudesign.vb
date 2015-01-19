Public Class Menudesign
    Private Sub MENUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub จดการพนกงานToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles จดการพนกงานToolStripMenuItem.Click
        frm_emp.ShowDialog()
    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub จดการอาหารToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles จดการอาหารToolStripMenuItem.Click
        Food.ShowDialog()
    End Sub

    Private Sub ออกจากระบบToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ออกจากระบบToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub เมนToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles เมนToolStripMenuItem.Click
        Menu1.ShowDialog()
    End Sub
End Class