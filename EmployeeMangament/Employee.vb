Imports System.ComponentModel
Imports System.Data.SqlClient
Imports EmployeeMangament.ApplicationMain
Imports Microsoft.SqlServer.Server
Public Class Employee
    Dim Empid As String = ""
    Dim strsql As String
    Dim Cmd As New SqlCommand()
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Clear()
        Me.Hide()
        Show_Form(MainForm)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Trim(txtEmpName.Text) = "" Or Trim(txtPhone.Text) = "" Or Trim(txtAddress.Text) = "" Or Trim(cmbGender.Text) = "" Or Trim(cmbEducation.Text) = "" Or Trim(cmbPosition.Text) = "" Then
                MsgBox("Please fill the Employee Details", MessageBoxButtons.OK, "Warning")
                Exit Sub
            End If
            If Conn.State = ConnectionState.Open Then Conn.Close()
            Conn.Open()
            strsql = "insert into Employee values('" + txtEmpName.Text + "','" + txtAddress.Text + "','" + cmbGender.Text + "','"
            strsql = strsql + "" + cmbPosition.Text + "','" + txtPhone.Text + "','" + cmbEducation.Text + "','" + Convert.ToDateTime(dtpDob.Value).ToString("ddMMMyyyy") + "')"
            Cmd = New SqlCommand()
            Cmd.Connection = Conn
            Cmd.CommandText = strsql
            Cmd.ExecuteNonQuery()
            Conn.Close()
            Clear()
            MsgBox("Employee Added", MessageBoxButtons.OK, "Success")
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, "Error")
        End Try
    End Sub
    Private Sub Clear()
        txtAddress.Text = ""
        txtEmpName.Text = ""
        txtPhone.Text = ""
        dtpDob.Value = Date.Today
        With cmbEducation
            .Items.Clear()
            .Items.Add("Diploma")
            .Items.Add("UG")
            .Items.Add("PG")
        End With
        With cmbPosition
            .Items.Clear()
            .Items.Add("Manager")
            .Items.Add("Security")
            .Items.Add("Cleaner")
            .Items.Add("Accountant")
            .Items.Add("IT")
        End With
        With cmbGender
            .Items.Clear()
            .Items.Add("Male")
            .Items.Add("Female")
        End With
        btnAdd.Enabled = True
        btnEdit.Enabled = False
        btndelete.Enabled = False
        Empid = ""
        View()
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub
    Private Sub View()
        Dim cmd As New SqlCommand()
        Dim da As New SqlDataAdapter()
        Dim ds As New DataSet()
        cmd = New SqlCommand()
        cmd.CommandText = "Select * from Employee"
        cmd.Connection = Conn
        da = New SqlDataAdapter(cmd)
        da.Fill(ds)
        If ds.Tables(0).Rows.Count <> 0 Then
            dgView.DataSource = ds.Tables(0)
        End If

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

    Private Sub dgView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgView.MouseDoubleClick

    End Sub
    Private Sub dgView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellDoubleClick
        If dgView.Rows(e.RowIndex).Cells(0).Value.ToString() <> "" Then
            Empid = dgView.Rows(e.RowIndex).Cells(0).Value
            txtEmpName.Text = dgView.Rows(e.RowIndex).Cells(1).Value
            txtAddress.Text = dgView.Rows(e.RowIndex).Cells(2).Value
            txtPhone.Text = dgView.Rows(e.RowIndex).Cells(5).Value
            cmbGender.Text = dgView.Rows(e.RowIndex).Cells(3).Value
            cmbPosition.Text = dgView.Rows(e.RowIndex).Cells(4).Value
            cmbEducation.Text = dgView.Rows(e.RowIndex).Cells(6).Value
            dtpDob.Value = dgView.Rows(e.RowIndex).Cells(7).Value
            btnAdd.Enabled = False
            btnEdit.Enabled = True
            btndelete.Enabled = True
            txtEmpName.Focus()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If Trim(txtEmpName.Text) = "" Or Trim(txtPhone.Text) = "" Or Trim(txtAddress.Text) = "" Or Trim(cmbGender.Text) = "" Or Trim(cmbEducation.Text) = "" Or Trim(cmbPosition.Text) = "" Then
                MsgBox("Please fill the Employee Details", MessageBoxButtons.OK, "Warning")
                Exit Sub
            End If
            If Empid <> "" Then
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                strsql = "Update Employee Set EmpName ='" + txtEmpName.Text + "',Empadd='" + txtAddress.Text + "',EmpPhone='" + txtPhone.Text + "',"
                strsql = strsql + "EmpGen='" + cmbGender.Text + "',EmpPos='" + cmbPosition.Text + "',EmpEdu='" + cmbEducation.Text + "'"
                strsql = strsql + ",EmpDob='" + Convert.ToDateTime(dtpDob.Value).ToString("ddMMMyyyy") + "' Where Empid = " + Empid
                Cmd = New SqlCommand()
                Cmd.Connection = Conn
                Cmd.CommandText = strsql
                Cmd.ExecuteNonQuery()
                Conn.Close()
                MsgBox("Record Updated", MessageBoxButtons.OK, "Success")
                Clear()
            Else
                MsgBox("Select the Record to Update", MessageBoxButtons.OK + MessageBoxIcon.Information, "Information")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxButtons.OK, "Error")
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            If Trim(txtEmpName.Text) = "" Or Trim(txtPhone.Text) = "" Or Trim(txtAddress.Text) = "" Or Trim(cmbGender.Text) = "" Or Trim(cmbEducation.Text) = "" Or Trim(cmbPosition.Text) = "" Then
                MsgBox("Please fill the Employee Details", MessageBoxButtons.OK, "Warning")
                Exit Sub
            End If
            If Empid <> "" Then
                If Conn.State = ConnectionState.Open Then Conn.Close()
                Conn.Open()
                strsql = "Delete from Employee Where Empid = " + Empid
                Cmd = New SqlCommand()
                Cmd.CommandText = strsql
                Cmd.Connection = Conn
                Cmd.ExecuteNonQuery()
                Conn.Close()
                MsgBox("Record Deleted", MessageBoxButtons.OK, "Success")
                Clear()
            Else
                MsgBox("Select the Record to Delete", MessageBoxButtons.OK, "Information")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtEmpName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmpName.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub cmbGender_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbGender.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub cmbPosition_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbPosition.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub cmbEducation_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbEducation.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub dtpDob_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpDob.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub txtAddress_Validating(sender As Object, e As CancelEventArgs) Handles txtAddress.Validating
        If Trim(txtAddress.Text) = "" Then
            MsgBox("Address should not be Empty", MessageBoxButtons.OK, "Warning")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtEmpName_Validating(sender As Object, e As CancelEventArgs) Handles txtEmpName.Validating
        If Trim(txtEmpName.Text) = "" Then
            MsgBox("Employee Name should not be Empty", MessageBoxButtons.OK, "Warning")
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbGender_Validating(sender As Object, e As CancelEventArgs) Handles cmbGender.Validating
        If Trim(cmbGender.Text) = "" Then
            MsgBox("Gender should not be Empty", MessageBoxButtons.OK, "Warning")
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbPosition_Validating(sender As Object, e As CancelEventArgs) Handles cmbPosition.Validating
        If Trim(cmbPosition.Text) = "" Then
            MsgBox("Employee Position should not be Empty", MessageBoxButtons.OK, "Warning")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtPhone_Validating(sender As Object, e As CancelEventArgs) Handles txtPhone.Validating
        If Trim(txtPhone.Text) = "" Then
            MsgBox("Phone no should not be Empty", MessageBoxButtons.OK, "Warning")
            e.Cancel = True
        End If
    End Sub

    Private Sub cmbEducation_Validating(sender As Object, e As CancelEventArgs) Handles cmbEducation.Validating
        If Trim(cmbEducation.Text) = "" Then
            MsgBox("Employee Education should not be Empty", MessageBoxButtons.OK, "Warning")
            e.Cancel = True
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Clear()
        Application.Exit()
    End Sub

    Private Sub dgView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub
End Class