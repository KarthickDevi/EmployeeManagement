Imports System.ComponentModel
Imports System.Data.SqlClient
Imports EmployeeMangament.ApplicationMain
Public Class EmployeeSalary
    Dim strsql As String
    Dim cmd As New SqlCommand()
    Dim da As New SqlDataAdapter()
    Dim ds As New DataSet
    Dim Total As Double
    Dim DailyPay As Double
    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Try
            If txtEmpid.Text <> "" Then
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                strsql = "Select * from Employee Where empid = " + txtEmpid.Text + ""
                cmd = New SqlCommand()
                cmd.CommandText = strsql
                cmd.Connection = Conn
                da = New SqlDataAdapter(cmd)
                da.Fill(ds)
                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("Employee Id is not Valid", MessageBoxButtons.OK, "Information")
                Else
                    EmpNamelbl.Visible = True
                    Positionlbl.Visible = True
                    EmpNamelbl.Text = ds.Tables(0).Rows(0)(1).ToString
                    Positionlbl.Text = ds.Tables(0).Rows(0)(4).ToString

                    txtWorkingdays.Focus()
                End If

                Conn.Close()
            Else
                MsgBox("Enter the Employee Id", MessageBoxButtons.OK, "Information")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, "Error")
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Clear()
        Me.Hide()
        Show_Form(MainForm)
    End Sub

    Private Sub btView_Click(sender As Object, e As EventArgs) Handles btView.Click
        Try
            If Positionlbl.Text = "" Then
                MsgBox("Select an Employee", MessageBoxButtons.OK, "Information")
            ElseIf txtWorkingdays.Text = "" Or Convert.ToInt32(txtWorkingdays.Text) > 28 Then
                MsgBox("Enter a Valid Number of Working Days", MessageBoxButtons.OK, "Warning")
            Else
                If Positionlbl.Text = "Manager" Then
                    DailyPay = 1200
                ElseIf Positionlbl.Text = "Accountant" Then
                    DailyPay = 1200
                ElseIf Positionlbl.Text = "Security" Then
                    DailyPay = 600
                ElseIf Positionlbl.Text = "IT" Then
                    DailyPay = 850
                Else
                    DailyPay = 500
                End If
                Total = DailyPay * Convert.ToInt32(txtWorkingdays.Text)
                'DailyPay = DailyPay.ToString()
                'Total = Total.ToString()
                rtxtDetails.Text = "Employee Id :   " + txtEmpid.Text + vbCrLf + "Employee Name :   " + EmpNamelbl.Text + vbCrLf
                rtxtDetails.Text = rtxtDetails.Text + "Employee Position :   " + Positionlbl.Text + vbCrLf + "Days Worked :    " + txtWorkingdays.Text + vbCrLf
                rtxtDetails.Text = rtxtDetails.Text + "Daily Salary Rs. :   " + Convert.ToString(DailyPay) + vbCrLf + "Total Amount Rs :   " + Convert.ToString(Total)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, "Error")
        End Try
    End Sub
    Public Sub Clear()
        txtEmpid.Text = ""
        txtWorkingdays.Text = ""
        rtxtDetails.Text = ""
        EmpNamelbl.Visible = False
        Positionlbl.Visible = False
    End Sub

    Private Sub txtEmpid_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmpid.Validating
        If Trim(txtEmpid.Text) = "" Then
            MsgBox("Enter Employee id", MessageBoxButtons.OK, "Warning")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtEmpid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpid.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtWorkingdays_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWorkingdays.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtWorkingdays_Validating(sender As Object, e As CancelEventArgs) Handles txtWorkingdays.Validating
        If Trim(txtWorkingdays.Text) = "" Then
            MsgBox("Enter the Employee Working days", MessageBoxButtons.OK, "Information")
            e.Cancel = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub EmployeeSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Cambria", 25), Brushes.RoyalBlue, 180, 40)
        e.Graphics.DrawString("***EMPLOYEE SUMMARY***", New Font("Cambria", 20), Brushes.Crimson, 250, 100)
        e.Graphics.DrawString(rtxtDetails.Text, New Font("Cambria", 18), Brushes.Black, 140, 205)
    End Sub
End Class