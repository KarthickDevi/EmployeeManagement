Imports System.ComponentModel
Imports EmployeeMangament.ApplicationMain

Public Class FrmLogin


    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub txtUser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Clear()
        txtPass.Clear()
    End Sub

    Private Sub txtUser_Validating(sender As Object, e As CancelEventArgs) Handles txtUser.Validating
        If Trim(txtUser.Text) = "" Then
            MsgBox("User Name Should not be Empty", MessageBoxButtons.OK + MessageBoxIcon.Information, "Error")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtPass_Validating(sender As Object, e As CancelEventArgs) Handles txtPass.Validating
        If Trim(txtPass.Text) = "" Then
            MsgBox("Password should not be Empty", MessageBoxButtons.OK, "Error")
            e.Cancel = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If UCase(txtUser.Text) = UCase("Supervisior") And UCase(txtPass.Text) = UCase("Pass") Then
            txtPass.Clear() : txtUser.Clear()
            Me.Hide()
            Show_Form(MainForm)
        End If
    End Sub
End Class
