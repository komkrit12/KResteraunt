Public Class Table
    Dim Class_conn As New class_conn
    Sub select_data1()
        Dim sql1 As String = ""
        Dim dta1 As DataTable
        sql1 += " select * from Tables where TID =1 "
        dta1 = Class_conn.selectbase(sql1)
        Dim TID1 As String = dta1.Rows(0).Item("Tstatus")
        If TID1 = "ว่าง" Then
            Me.btn_1.BackColor = Color.Green
        ElseIf TID1 = "ไม่ว่าง" Then
            Me.btn_1.BackColor = Color.Red
        End If

    End Sub
    Sub select_data2()
        Dim sql2 As String = ""
        Dim dta2 As DataTable
        sql2 += " select * from Tables where TID =2 "
        dta2 = Class_conn.selectbase(sql2)
        Dim TID2 As String = dta2.Rows(0).Item("Tstatus")
        If TID2 = "ว่าง" Then
            Me.btn_2.BackColor = Color.Green
        ElseIf TID2 = "ไม่ว่าง" Then
            Me.btn_2.BackColor = Color.Red
        End If
    End Sub
    Sub select_data3()
        Dim sql3 As String = ""
        Dim dta3 As DataTable
        sql3 += " select * from Tables where TID =3 "
        dta3 = Class_conn.selectbase(sql3)
        Dim TID3 As String = dta3.Rows(0).Item("Tstatus")
        If TID3 = "ว่าง" Then
            Me.btn_3.BackColor = Color.Green
        ElseIf TID3 = "ไม่ว่าง" Then
            Me.btn_3.BackColor = Color.Red
        End If
    End Sub
    Sub select_data4()
        Dim sql4 As String = ""
        Dim dta4 As DataTable
        sql4 += " select * from Tables where TID =4 "
        dta4 = Class_conn.selectbase(sql4)
        Dim TID4 As String = dta4.Rows(0).Item("Tstatus")
        If TID4 = "ว่าง" Then
            Me.btn_4.BackColor = Color.Green
        ElseIf TID4 = "ไม่ว่าง" Then
            Me.btn_4.BackColor = Color.Red
        End If
    End Sub
    Sub select_data5()
        Dim sql5 As String = ""
        Dim dta5 As DataTable
        sql5 += " select * from Tables where TID =5 "
        dta5 = Class_conn.selectbase(sql5)
        Dim TID5 As String = dta5.Rows(0).Item("Tstatus")
        If TID5 = "ว่าง" Then
            Me.btn_5.BackColor = Color.Green
        ElseIf TID5 = "ไม่ว่าง" Then
            Me.btn_5.BackColor = Color.Red
        End If
    End Sub
    Sub select_data6()
        Dim sql6 As String = ""
        Dim dta6 As DataTable
        sql6 += " select * from Tables where TID =6 "
        dta6 = Class_conn.selectbase(sql6)
        Dim TID6 As String = dta6.Rows(0).Item("Tstatus")
        If TID6 = "ว่าง" Then
            Me.btn_6.BackColor = Color.Green
        ElseIf TID6 = "ไม่ว่าง" Then
            Me.btn_6.BackColor = Color.Red
        End If
    End Sub
    Sub select_data7()
        Dim sql7 As String = ""
        Dim dta7 As DataTable
        sql7 += " select * from Tables where TID =7 "
        dta7 = Class_conn.selectbase(sql7)
        Dim TID7 As String = dta7.Rows(0).Item("Tstatus")
        If TID7 = "ว่าง" Then
            Me.btn_7.BackColor = Color.Green
        ElseIf TID7 = "ไม่ว่าง" Then
            Me.btn_7.BackColor = Color.Red
        End If
    End Sub
    Sub select_data8()
        Dim sql8 As String = ""
        Dim dta8 As DataTable
        sql8 += " select * from Tables where TID =8 "
        dta8 = Class_conn.selectbase(sql8)
        Dim TID8 As String = dta8.Rows(0).Item("Tstatus")
        If TID8 = "ว่าง" Then
            Me.btn_8.BackColor = Color.Green
        ElseIf TID8 = "ไม่ว่าง" Then
            Me.btn_8.BackColor = Color.Red
        End If
    End Sub
    Sub select_data9()
        Dim sql9 As String = ""
        Dim dta9 As DataTable
        sql9 += " select * from Tables where TID =9 "
        dta9 = Class_conn.selectbase(sql9)
        Dim TID9 As String = dta9.Rows(0).Item("Tstatus")
        If TID9 = "ว่าง" Then
            Me.btn_9.BackColor = Color.Green
        ElseIf TID9 = "ไม่ว่าง" Then
            Me.btn_9.BackColor = Color.Red
        End If
    End Sub
    Sub select_data10()
        Dim sql10 As String = ""
        Dim dta10 As DataTable
        sql10 += " select * from Tables where TID =10 "
        dta10 = Class_conn.selectbase(sql10)
        Dim TID10 As String = dta10.Rows(0).Item("Tstatus")
        If TID10 = "ว่าง" Then
            Me.btn_10.BackColor = Color.Green
        ElseIf TID10 = "ไม่ว่าง" Then
            Me.btn_10.BackColor = Color.Red
        End If
    End Sub
    Sub select_data11()
        Dim sql11 As String = ""
        Dim dta11 As DataTable
        sql11 += " select * from Tables where TID =11 "
        dta11 = Class_conn.selectbase(sql11)
        Dim TID11 As String = dta11.Rows(0).Item("Tstatus")
        If TID11 = "ว่าง" Then
            Me.btn_11.BackColor = Color.Green
        ElseIf TID11 = "ไม่ว่าง" Then
            Me.btn_11.BackColor = Color.Red
        End If
    End Sub
    Sub select_data12()
        Dim sql12 As String = ""
        Dim dta12 As DataTable
        sql12 += " select * from Tables where TID =12 "
        dta12 = Class_conn.selectbase(sql12)
        Dim TID12 As String = dta12.Rows(0).Item("Tstatus")
        If TID12 = "ว่าง" Then
            Me.btn_12.BackColor = Color.Green
        ElseIf TID12 = "ไม่ว่าง" Then
            Me.btn_12.BackColor = Color.Red
        End If
    End Sub
    Sub select_data13()
        Dim sql13 As String = ""
        Dim dta13 As DataTable
        sql13 += " select * from Tables where TID =13 "
        dta13 = Class_conn.selectbase(sql13)
        Dim TID13 As String = dta13.Rows(0).Item("Tstatus")
        If TID13 = "ว่าง" Then
            Me.btn_13.BackColor = Color.Green
        ElseIf TID13 = "ไม่ว่าง" Then
            Me.btn_13.BackColor = Color.Red
        End If
    End Sub
    Sub select_data14()
        Dim sql14 As String = ""
        Dim dta14 As DataTable
        sql14 += " select * from Tables where TID =14 "
        dta14 = Class_conn.selectbase(sql14)
        Dim TID14 As String = dta14.Rows(0).Item("Tstatus")
        If TID14 = "ว่าง" Then
            Me.btn_14.BackColor = Color.Green
        ElseIf TID14 = "ไม่ว่าง" Then
            Me.btn_14.BackColor = Color.Red
        End If
    End Sub
    Sub select_data15()
        Dim sql15 As String = ""
        Dim dta15 As DataTable
        sql15 += " select * from Tables where TID =15 "
        dta15 = Class_conn.selectbase(sql15)
        Dim TID15 As String = dta15.Rows(0).Item("Tstatus")
        If TID15 = "ว่าง" Then
            Me.btn_15.BackColor = Color.Green
        ElseIf TID15 = "ไม่ว่าง" Then
            Me.btn_15.BackColor = Color.Red
        End If

    End Sub

    Private Sub Table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_data1()
        select_data2()
        select_data3()
        select_data4()
        select_data5()
        select_data6()
        select_data7()
        select_data8()
        select_data9()
        select_data10()
        select_data11()
        select_data12()
        select_data13()
        select_data14()
        select_data15()
    End Sub

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        If btn_1.BackColor = Color.Red Then
            btn_1.Enabled = False
        Else
            btn_1.Enabled = True
            strtable_id = "1"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        If btn_2.BackColor = Color.Red Then
            btn_2.Enabled = False
        Else
            btn_2.Enabled = True
            strtable_id = "2"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        If btn_3.BackColor = Color.Red Then
            btn_3.Enabled = False
        Else
            btn_3.Enabled = True
            strtable_id = "3"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        If btn_4.BackColor = Color.Red Then
            btn_4.Enabled = False
        Else
            btn_4.Enabled = True
            strtable_id = "4"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        If btn_5.BackColor = Color.Red Then
            btn_5.Enabled = False
        Else
            btn_5.Enabled = True
            strtable_id = "5"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        If btn_6.BackColor = Color.Red Then
            btn_6.Enabled = False
        Else
            btn_6.Enabled = True
            strtable_id = "6"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        If btn_7.BackColor = Color.Red Then
            btn_7.Enabled = False
        Else
            btn_7.Enabled = True
            strtable_id = "7"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        If btn_8.BackColor = Color.Red Then
            btn_8.Enabled = False
        Else
            btn_8.Enabled = True
            strtable_id = "8"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        If btn_9.BackColor = Color.Red Then
            btn_9.Enabled = False
        Else
            btn_9.Enabled = True
            strtable_id = "9"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_10.Click
        If btn_10.BackColor = Color.Red Then
            btn_10.Enabled = False
        Else
            btn_10.Enabled = True
            strtable_id = "10"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_11.Click
        If btn_11.BackColor = Color.Red Then
            btn_11.Enabled = False
        Else
            btn_11.Enabled = True
            strtable_id = "11"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_12.Click
        If btn_12.BackColor = Color.Red Then
            btn_12.Enabled = False
        Else
            btn_12.Enabled = True
            strtable_id = "12"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_13.Click
        If btn_13.BackColor = Color.Red Then
            btn_13.Enabled = False
        Else
            btn_13.Enabled = True
            strtable_id = "13"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_14.Click
        If btn_14.BackColor = Color.Red Then
            btn_14.Enabled = False
        Else
            btn_14.Enabled = True
            strtable_id = "14"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btn_15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_15.Click
        If btn_15.BackColor = Color.Red Then
            btn_15.Enabled = False
        Else
            btn_15.Enabled = True
            strtable_id = "15"
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
End Class