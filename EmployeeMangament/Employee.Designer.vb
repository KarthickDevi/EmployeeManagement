<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Panel1 = New Panel()
        dgView = New DataGridView()
        btnHome = New Button()
        btndelete = New Button()
        btnEdit = New Button()
        btnAdd = New Button()
        dtpDob = New DateTimePicker()
        cmbEducation = New ComboBox()
        cmbPosition = New ComboBox()
        cmbGender = New ComboBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        txtEmpName = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(dgView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(dgView)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btndelete)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnAdd)
        Panel1.Controls.Add(dtpDob)
        Panel1.Controls.Add(cmbEducation)
        Panel1.Controls.Add(cmbPosition)
        Panel1.Controls.Add(cmbGender)
        Panel1.Controls.Add(txtPhone)
        Panel1.Controls.Add(txtAddress)
        Panel1.Controls.Add(txtEmpName)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(1, 120)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1346, 554)
        Panel1.TabIndex = 0
        ' 
        ' dgView
        ' 
        dgView.AllowUserToAddRows = False
        dgView.AllowUserToDeleteRows = False
        dgView.CausesValidation = False
        dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgView.Location = New Point(517, 39)
        dgView.Name = "dgView"
        dgView.ReadOnly = True
        dgView.RowHeadersWidth = 51
        dgView.Size = New Size(826, 488)
        dgView.TabIndex = 18
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.RoyalBlue
        btnHome.CausesValidation = False
        btnHome.FlatStyle = FlatStyle.Popup
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(214, 494)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(112, 33)
        btnHome.TabIndex = 10
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.RoyalBlue
        btndelete.FlatStyle = FlatStyle.Popup
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(381, 437)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(112, 33)
        btndelete.TabIndex = 9
        btndelete.Text = "Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.RoyalBlue
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(214, 437)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(112, 33)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.RoyalBlue
        btnAdd.FlatStyle = FlatStyle.Popup
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(49, 437)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 33)
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' dtpDob
        ' 
        dtpDob.CalendarForeColor = Color.Black
        dtpDob.CalendarTitleForeColor = Color.RoyalBlue
        dtpDob.CalendarTrailingForeColor = Color.RoyalBlue
        dtpDob.CustomFormat = "dd-MMM-yyyy"
        dtpDob.Format = DateTimePickerFormat.Custom
        dtpDob.Location = New Point(172, 374)
        dtpDob.Name = "dtpDob"
        dtpDob.Size = New Size(208, 27)
        dtpDob.TabIndex = 6
        dtpDob.Value = New Date(2024, 9, 18, 0, 0, 0, 0)
        ' 
        ' cmbEducation
        ' 
        cmbEducation.ForeColor = Color.Black
        cmbEducation.FormattingEnabled = True
        cmbEducation.Location = New Point(302, 280)
        cmbEducation.Name = "cmbEducation"
        cmbEducation.Size = New Size(191, 28)
        cmbEducation.TabIndex = 5
        ' 
        ' cmbPosition
        ' 
        cmbPosition.ForeColor = Color.Black
        cmbPosition.FormattingEnabled = True
        cmbPosition.Location = New Point(302, 173)
        cmbPosition.Name = "cmbPosition"
        cmbPosition.Size = New Size(191, 28)
        cmbPosition.TabIndex = 3
        ' 
        ' cmbGender
        ' 
        cmbGender.ForeColor = Color.Black
        cmbGender.FormattingEnabled = True
        cmbGender.Location = New Point(23, 173)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(191, 28)
        cmbGender.TabIndex = 2
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.ForeColor = Color.Black
        txtPhone.Location = New Point(23, 280)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(191, 27)
        txtPhone.TabIndex = 4
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.ForeColor = Color.Black
        txtAddress.Location = New Point(302, 73)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(191, 27)
        txtAddress.TabIndex = 1
        ' 
        ' txtEmpName
        ' 
        txtEmpName.BorderStyle = BorderStyle.FixedSingle
        txtEmpName.ForeColor = Color.Black
        txtEmpName.Location = New Point(23, 73)
        txtEmpName.Name = "txtEmpName"
        txtEmpName.Size = New Size(191, 27)
        txtEmpName.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.RoyalBlue
        Label8.Location = New Point(234, 340)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 20)
        Label8.TabIndex = 6
        Label8.Text = "Employee DOB"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.RoyalBlue
        Label7.Location = New Point(302, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 20)
        Label7.TabIndex = 5
        Label7.Text = "Employee Education"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.RoyalBlue
        Label6.Location = New Point(302, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 20)
        Label6.TabIndex = 4
        Label6.Text = "Employee Position"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.RoyalBlue
        Label5.Location = New Point(23, 243)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 20)
        Label5.TabIndex = 3
        Label5.Text = "Employee Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(23, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 20)
        Label4.TabIndex = 2
        Label4.Text = "Employee Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(302, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 20)
        Label3.TabIndex = 1
        Label3.Text = "Employee Address"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(23, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 20)
        Label2.TabIndex = 0
        Label2.Text = "Employee Name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 86)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(103, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(177, 23)
        Label1.TabIndex = 2
        Label1.Text = "Manage Employee"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.RoyalBlue
        Label9.Font = New Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(1320, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(20, 21)
        Label9.TabIndex = 3
        Label9.Text = "X"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(1363, 670)
        ControlBox = False
        Controls.Add(Label9)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Employee"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents cmbEducation As ComboBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgView As DataGridView
    Friend WithEvents Label9 As Label
End Class
