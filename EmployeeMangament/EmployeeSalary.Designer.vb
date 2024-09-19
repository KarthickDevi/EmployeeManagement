<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeSalary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeSalary))
        Panel1 = New Panel()
        EmpNamelbl = New Label()
        btView = New Button()
        btnPrint = New Button()
        btnHome = New Button()
        btnFetch = New Button()
        rtxtDetails = New RichTextBox()
        txtWorkingdays = New TextBox()
        txtEmpid = New TextBox()
        Label6 = New Label()
        Positionlbl = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label3 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(EmpNamelbl)
        Panel1.Controls.Add(btView)
        Panel1.Controls.Add(btnPrint)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnFetch)
        Panel1.Controls.Add(rtxtDetails)
        Panel1.Controls.Add(txtWorkingdays)
        Panel1.Controls.Add(txtEmpid)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Positionlbl)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1025, 514)
        Panel1.TabIndex = 0
        ' 
        ' EmpNamelbl
        ' 
        EmpNamelbl.AutoSize = True
        EmpNamelbl.ForeColor = Color.RoyalBlue
        EmpNamelbl.Location = New Point(11, 174)
        EmpNamelbl.Name = "EmpNamelbl"
        EmpNamelbl.Size = New Size(135, 20)
        EmpNamelbl.TabIndex = 14
        EmpNamelbl.Text = "Employee Name"
        ' 
        ' btView
        ' 
        btView.BackColor = Color.RoyalBlue
        btView.FlatStyle = FlatStyle.Popup
        btView.ForeColor = Color.White
        btView.Location = New Point(230, 413)
        btView.Name = "btView"
        btView.Size = New Size(115, 43)
        btView.TabIndex = 3
        btView.Text = "View"
        btView.UseVisualStyleBackColor = False
        ' 
        ' btnPrint
        ' 
        btnPrint.BackColor = Color.RoyalBlue
        btnPrint.FlatStyle = FlatStyle.Popup
        btnPrint.ForeColor = Color.White
        btnPrint.Location = New Point(516, 413)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(115, 43)
        btnPrint.TabIndex = 12
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.RoyalBlue
        btnHome.CausesValidation = False
        btnHome.FlatStyle = FlatStyle.Popup
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(23, 413)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(115, 43)
        btnHome.TabIndex = 10
        btnHome.Text = "Home"
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnFetch
        ' 
        btnFetch.BackColor = Color.RoyalBlue
        btnFetch.FlatStyle = FlatStyle.Popup
        btnFetch.ForeColor = Color.White
        btnFetch.Location = New Point(230, 67)
        btnFetch.Name = "btnFetch"
        btnFetch.Size = New Size(115, 35)
        btnFetch.TabIndex = 1
        btnFetch.Text = "Fetch Data"
        btnFetch.UseVisualStyleBackColor = False
        ' 
        ' rtxtDetails
        ' 
        rtxtDetails.ForeColor = Color.RoyalBlue
        rtxtDetails.Location = New Point(377, 3)
        rtxtDetails.Name = "rtxtDetails"
        rtxtDetails.Size = New Size(635, 404)
        rtxtDetails.TabIndex = 8
        rtxtDetails.Text = ""
        ' 
        ' txtWorkingdays
        ' 
        txtWorkingdays.BorderStyle = BorderStyle.FixedSingle
        txtWorkingdays.ForeColor = Color.RoyalBlue
        txtWorkingdays.Location = New Point(11, 345)
        txtWorkingdays.Name = "txtWorkingdays"
        txtWorkingdays.Size = New Size(179, 27)
        txtWorkingdays.TabIndex = 2
        ' 
        ' txtEmpid
        ' 
        txtEmpid.BorderStyle = BorderStyle.FixedSingle
        txtEmpid.ForeColor = Color.RoyalBlue
        txtEmpid.Location = New Point(11, 75)
        txtEmpid.Name = "txtEmpid"
        txtEmpid.Size = New Size(179, 27)
        txtEmpid.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.RoyalBlue
        Label6.Location = New Point(11, 310)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 20)
        Label6.TabIndex = 5
        Label6.Text = "Working Days"
        ' 
        ' Positionlbl
        ' 
        Positionlbl.AutoSize = True
        Positionlbl.ForeColor = Color.RoyalBlue
        Positionlbl.Location = New Point(11, 269)
        Positionlbl.Name = "Positionlbl"
        Positionlbl.Size = New Size(154, 20)
        Positionlbl.TabIndex = 4
        Positionlbl.Text = "Employee Position"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(11, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 20)
        Label4.TabIndex = 3
        Label4.Text = "Employee Position"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(11, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(135, 20)
        Label2.TabIndex = 1
        Label2.Text = "Employee Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(11, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 0
        Label1.Text = "Employee Id"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 73)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.RoyalBlue
        Label7.Font = New Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(107, 45)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 23)
        Label7.TabIndex = 2
        Label7.Text = "Salary"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1002, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(21, 21)
        Label3.TabIndex = 3
        Label3.Text = "X"
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
        ' EmployeeSalary
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(1025, 600)
        ControlBox = False
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Font = New Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        Name = "EmployeeSalary"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnFetch As Button
    Friend WithEvents rtxtDetails As RichTextBox
    Friend WithEvents txtWorkingdays As TextBox
    Friend WithEvents txtEmpid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Positionlbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btView As Button
    Friend WithEvents EmpNamelbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
