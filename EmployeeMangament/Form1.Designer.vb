<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        BtnReset = New Button()
        PictureBox1 = New PictureBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(126, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 23)
        Label1.TabIndex = 0
        Label1.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(136, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 1
        Label2.Text = "User Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(136, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' txtUser
        ' 
        txtUser.BorderStyle = BorderStyle.FixedSingle
        txtUser.Location = New Point(273, 121)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(219, 27)
        txtUser.TabIndex = 0
        ' 
        ' txtPass
        ' 
        txtPass.BorderStyle = BorderStyle.FixedSingle
        txtPass.Location = New Point(273, 172)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(219, 27)
        txtPass.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.RoyalBlue
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.ForeColor = SystemColors.Control
        btnLogin.Location = New Point(182, 255)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(120, 41)
        btnLogin.TabIndex = 2
        btnLogin.Text = "&Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnReset
        ' 
        BtnReset.BackColor = Color.RoyalBlue
        BtnReset.CausesValidation = False
        BtnReset.FlatStyle = FlatStyle.Popup
        BtnReset.ForeColor = SystemColors.Control
        BtnReset.Location = New Point(364, 255)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(120, 41)
        BtnReset.TabIndex = 3
        BtnReset.Text = "&Reset"
        BtnReset.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 124)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.CausesValidation = False
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(533, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 20)
        Label4.TabIndex = 8
        Label4.Text = "X"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(554, 313)
        ControlBox = False
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(BtnReset)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.Fixed3D
        KeyPreview = True
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmLogin"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label

End Class
