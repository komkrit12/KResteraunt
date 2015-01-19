Imports Microsoft.Reporting.WinForms
Public Class re_invoince
    Dim class_conn As New class_conn

    Sub select_data()

        Dim date_day As String = Now.Day
        Dim date_month As String = Now.Month
        Dim name_month As String
        Dim date_year As String = Now.Year
        Dim date_year2 As String
        Dim date_hrs As String = Now.Hour
        Dim date_min As String = Now.Minute
        Dim sum_time As String = date_hrs + ":" + date_min
        date_year2 = date_year + 543
        If date_month = "1" Then
            name_month = "มกราคม"
        ElseIf date_month = "2" Then
            name_month = "กุมภาพันธ์"
        ElseIf date_month = "3" Then
            name_month = "มีนาคม"
        ElseIf date_month = "4" Then
            name_month = "เมษายน"
        ElseIf date_month = "5" Then
            name_month = "พฤษภาคม"
        ElseIf date_month = "6" Then
            name_month = "มิถุนายน"
        ElseIf date_month = "7" Then
            name_month = "กรกฎาคม"
        ElseIf date_month = "8" Then
            name_month = "สิงหาคม"
        ElseIf date_month = "9" Then
            name_month = "กันยายน"
        ElseIf date_month = "10" Then
            name_month = "ตุลาคม"
        ElseIf date_month = "11" Then
            name_month = "พฤศจิกายน"
        ElseIf date_month = "12" Then
            name_month = "ธันวาคม"
        Else
            name_month = "ธันวาคม"
        End If
        Dim sum_date As String = date_day + " " + name_month + " " + date_year2
        Dim sql As String = ""
        Dim dta As DataTable
        sql += "select FoodName,unit,TID,FoodPrice,OrderCode from vw_countorder where OrderCode = '" + strordercode + "' group by FoodName,unit,FoodPrice,TID,OrderCode"
        dta = class_conn.selectbase(sql)

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.ReportPath = "..\..\Report\re_invoice.rdlc"
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dta))
        Dim myParam1 As New ReportParameter("mypartime", sum_time)
        ReportViewer1.LocalReport.SetParameters(myParam1)
        Dim myParam2 As New ReportParameter("mypar1", sum_date)
        ReportViewer1.LocalReport.SetParameters(myParam2)
        Dim myParam3 As New ReportParameter("emp_id", stremp_id)
        ReportViewer1.LocalReport.SetParameters(myParam3)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub re_invoince_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        select_data()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class