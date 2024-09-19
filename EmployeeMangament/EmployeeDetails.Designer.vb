<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeDetails))
        Panel1 = New Panel()
        txtEmpId = New TextBox()
        btnHome = New Button()
        btnPrint = New Button()
        btnRefresh = New Button()
        lblDOB = New Label()
        Label15 = New Label()
        lblEducation = New Label()
        lblPosition = New Label()
        lblAddress = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        lblPhone = New Label()
        lblGender = New Label()
        lblEmpName = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Label6 = New Label()
        PrintDialog1 = New PrintDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtEmpId)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(lblDOB)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(lblEducation)
        Panel1.Controls.Add(lblPosition)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lblPhone)
        Panel1.Controls.Add(lblGender)
        Panel1.Controls.Add(lblEmpName)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(2, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1138, 482)
        Panel1.TabIndex = 0
        ' 
        ' txtEmpId
        ' 
        txtEmpId.BorderStyle = BorderStyle.FixedSingle
        txtEmpId.Location = New Point(436, 26)
        txtEmpId.Name = "txtEmpId"
        txtEmpId.Size = New Size(227, 27)
        txtEmpId.TabIndex = 0
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.RoyalBlue
        btnHome.CausesValidation = False
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(530, 398)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(110, 41)
        btnHome.TabIndex = 3
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.RoyalBlue
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(323, 398)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(110, 41)
        btnPrint.TabIndex = 2
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.RoyalBlue
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(701, 25)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(110, 41)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblDOB
        ' 
        lblDOB.AutoSize = True
        lblDOB.Location = New Point(480, 315)
        lblDOB.Name = "lblDOB"
        lblDOB.Size = New Size(125, 20)
        lblDOB.TabIndex = 14
        lblDOB.Text = "Employee DOB"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.ForeColor = Color.RoyalBlue
        Label15.Location = New Point(308, 315)
        Label15.Name = "Label15"
        Label15.Size = New Size(125, 20)
        Label15.TabIndex = 13
        Label15.Text = "Employee DOB"
        ' 
        ' lblEducation
        ' 
        lblEducation.AutoSize = True
        lblEducation.Location = New Point(759, 245)
        lblEducation.Name = "lblEducation"
        lblEducation.Size = New Size(168, 20)
        lblEducation.TabIndex = 12
        lblEducation.Text = "Employee Education"
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Location = New Point(759, 177)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(154, 20)
        lblPosition.TabIndex = 11
        lblPosition.Text = "Employee Position"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(759, 107)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(154, 20)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Employee Address"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.ForeColor = Color.RoyalBlue
        Label11.Location = New Point(509, 245)
        Label11.Name = "Label11"
        Label11.Size = New Size(168, 20)
        Label11.TabIndex = 9
        Label11.Text = "Employee Education"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.RoyalBlue
        Label10.Location = New Point(509, 177)
        Label10.Name = "Label10"
        Label10.Size = New Size(154, 20)
        Label10.TabIndex = 8
        Label10.Text = "Employee Position"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.RoyalBlue
        Label9.Location = New Point(509, 107)
        Label9.Name = "Label9"
        Label9.Size = New Size(154, 20)
        Label9.TabIndex = 7
        Label9.Text = "Employee Address"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(246, 245)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(139, 20)
        lblPhone.TabIndex = 6
        lblPhone.Text = "Employee Phone"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(246, 177)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(147, 20)
        lblGender.TabIndex = 5
        lblGender.Text = "Employee Gender"
        ' 
        ' lblEmpName
        ' 
        lblEmpName.AutoSize = True
        lblEmpName.Location = New Point(246, 107)
        lblEmpName.Name = "lblEmpName"
        lblEmpName.Size = New Size(135, 20)
        lblEmpName.TabIndex = 4
        lblEmpName.Text = "Employee Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.RoyalBlue
        Label5.Location = New Point(53, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 20)
        Label5.TabIndex = 3
        Label5.Text = "Employee Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(53, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 20)
        Label4.TabIndex = 2
        Label4.Text = "Employee Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.RoyalBlue
        Label3.Location = New Point(53, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 20)
        Label3.TabIndex = 1
        Label3.Text = "Employee Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(308, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 20)
        Label2.TabIndex = 0
        Label2.Text = "Employee Id"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(85, 67)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.RoyalBlue
        Label1.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(93, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 23)
        Label1.TabIndex = 2
        Label1.Text = "Employee Details "
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.White
        Label6.Location = New Point(1109, 1)
        Label6.Name = "Label6"
        Label6.Size = New Size(20, 20)
        Label6.TabIndex = 3
        Label6.Text = "X"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' EmployeeDetails
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(1128, 548)
        ControlBox = False
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        Name = "EmployeeDetails"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmpId As TextBox
    Friend WithEvents btnHome As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents lblDOB As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblEducation As Label
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblEmpName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
