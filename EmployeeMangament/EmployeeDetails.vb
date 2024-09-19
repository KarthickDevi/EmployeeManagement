Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports EmployeeMangament.ApplicationMain
Public Class EmployeeDetails
    Dim Strsql As String
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Clear()
        Me.Hide()
        Show_Form(MainForm)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Try
            If txtEmpId.Text <> "" Then
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                Strsql = "select * from Employee where empid = " + txtEmpId.Text
                cmd = New SqlCommand()
                Dim dt As DataTable
                dt = New DataTable
                cmd.Connection = Conn
                cmd.CommandText = Strsql
                da = New SqlDataAdapter(cmd)
                ds = New DataSet()
                da.Fill(ds)
                da.Fill(dt)
                If ds.Tables(0).Rows.Count = 0 Then
                    MsgBox("Employee Id not Valid", MessageBoxButtons.OK, "Information")
                    Clear()
                Else
                    lblEmpName.Text = ds.Tables(0).Rows(0)(1).ToString()
                    lblAddress.Text = ds.Tables(0).Rows(0)(2).ToString()
                    lblGender.Text = ds.Tables(0).Rows(0)(3).ToString()
                    lblPosition.Text = ds.Tables(0).Rows(0)(4).ToString()
                    lblPhone.Text = ds.Tables(0).Rows(0)(5).ToString()
                    lblEducation.Text = ds.Tables(0).Rows(0)(6).ToString()
                    lblDOB.Text = Convert.ToDateTime(ds.Tables(0).Rows(0)(7))

                    'For Each dr As DataRow In dt.Rows
                    '    lblEmpName.Text = dr(1)
                    '    lblAddress.Text = dr(2)
                    '    lblGender.Text = dr(3)
                    '    lblPosition.Text = dr(4)
                    '    lblPhone.Text = dr(5)
                    '    lblEducation.Text = dr(6)
                    '    lblDOB.Text = Convert.ToDateTime(dr(7))
                    'Next
                    lblEducation.Visible = True
                    lblEmpName.Visible = True
                    lblPosition.Visible = True
                    lblPhone.Visible = True
                    lblGender.Visible = True
                    lblAddress.Visible = True
                    lblDOB.Visible = True
                End If
                Conn.Close()
            Else
                MsgBox("Enter the Employee Id", MessageBoxButtons.OK, "Information")
                Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, "Error")
        End Try
    End Sub
    Private Sub Clear()
        txtEmpId.Clear()
        lblEmpName.Text = "Employee Name"
        lblAddress.Text = "Employee Address"
        lblDOB.Text = "Employee DOB"
        lblEducation.Text = "Employee Education"
        lblGender.Text = "Employee Gender"
        lblPhone.Text = "Employee Phone"
        lblPosition.Text = "Employee Position"
        lblEmpName.Visible = False
        lblAddress.Visible = False
        lblDOB.Visible = False
        lblEducation.Visible = False
        lblGender.Visible = False
        lblPhone.Visible = False
        lblPosition.Visible = False
        txtEmpId.Focus()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Clear()
        'Me.Hide()
        'Show_Form(MainForm)
        Application.Exit()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Cambria", 25), Brushes.RoyalBlue, 180, 40)
        e.Graphics.DrawString("***EMPLOYEE SUMMARY***", New Font("Cambria", 20), Brushes.Crimson, 250, 100)
        e.Graphics.DrawString("Name      :   " + txtEmpId.Text + "", New Font("Cambria", 18), Brushes.Black, 140, 205)
        e.Graphics.DrawString("Address   :   " + lblAddress.Text + "", New Font("Cambria", 18), Brushes.Black, 140, 260)
        e.Graphics.DrawString("Gender    :   " + lblGender.Text + "", New Font("Cambria", 18), Brushes.Black, 140, 315)
        e.Graphics.DrawString("Position  :   " + lblPosition.Text + "", New Font("Cambria", 18), Brushes.Black, 140, 360)
        e.Graphics.DrawString("Education :   " + lblEducation.Text + "", New Font("Cambria", 18), Brushes.Black, 140, 415)
        e.Graphics.DrawString("Phone No  :   " + lblPhone.Text + "", New Font("Cambria", 18), Brushes.Black, 140, 460)
        e.Graphics.DrawString("DOB       :   " + lblDOB.Text + "", New Font("Cambria", 18), Brushes.Black, 140, 515)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Trim(txtEmpId.Text) = "" Then
            MsgBox("Enter the Employee id", MessageBoxButtons.OK, "Information")
            txtEmpId.Focus()
            Exit Sub
        End If
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
        Clear()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub EmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub txtEmpId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpId.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub
End Class