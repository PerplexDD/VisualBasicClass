<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDeptName = New System.Windows.Forms.ComboBox()
        Me.txtEmailAddy = New System.Windows.Forms.TextBox()
        Me.txtPhoneExt = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumb = New System.Windows.Forms.TextBox()
        Me.txtEmpNumb = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMidName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelCombo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveRec = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDeptName)
        Me.GroupBox1.Controls.Add(Me.txtEmailAddy)
        Me.GroupBox1.Controls.Add(Me.txtPhoneExt)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNumb)
        Me.GroupBox1.Controls.Add(Me.txtEmpNumb)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.txtMidName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelCombo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(54, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(773, 623)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Employee Data"
        '
        'cboDeptName
        '
        Me.cboDeptName.FormattingEnabled = True
        Me.cboDeptName.Location = New System.Drawing.Point(338, 353)
        Me.cboDeptName.Name = "cboDeptName"
        Me.cboDeptName.Size = New System.Drawing.Size(396, 45)
        Me.cboDeptName.TabIndex = 15
        '
        'txtEmailAddy
        '
        Me.txtEmailAddy.Location = New System.Drawing.Point(338, 548)
        Me.txtEmailAddy.Name = "txtEmailAddy"
        Me.txtEmailAddy.Size = New System.Drawing.Size(396, 44)
        Me.txtEmailAddy.TabIndex = 14
        '
        'txtPhoneExt
        '
        Me.txtPhoneExt.Location = New System.Drawing.Point(338, 483)
        Me.txtPhoneExt.Name = "txtPhoneExt"
        Me.txtPhoneExt.Size = New System.Drawing.Size(396, 44)
        Me.txtPhoneExt.TabIndex = 13
        '
        'txtPhoneNumb
        '
        Me.txtPhoneNumb.Location = New System.Drawing.Point(338, 418)
        Me.txtPhoneNumb.Name = "txtPhoneNumb"
        Me.txtPhoneNumb.Size = New System.Drawing.Size(396, 44)
        Me.txtPhoneNumb.TabIndex = 12
        '
        'txtEmpNumb
        '
        Me.txtEmpNumb.Location = New System.Drawing.Point(338, 288)
        Me.txtEmpNumb.Name = "txtEmpNumb"
        Me.txtEmpNumb.Size = New System.Drawing.Size(396, 44)
        Me.txtEmpNumb.TabIndex = 11
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(338, 223)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(396, 44)
        Me.txtLastName.TabIndex = 10
        '
        'txtMidName
        '
        Me.txtMidName.Location = New System.Drawing.Point(338, 158)
        Me.txtMidName.Name = "txtMidName"
        Me.txtMidName.Size = New System.Drawing.Size(396, 44)
        Me.txtMidName.TabIndex = 9
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(338, 93)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(396, 44)
        Me.txtFirstName.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 554)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 31)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "E-mail Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Extension:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 424)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telephone:"
        '
        'LabelCombo
        '
        Me.LabelCombo.AutoSize = True
        Me.LabelCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCombo.Location = New System.Drawing.Point(130, 359)
        Me.LabelCombo.Name = "LabelCombo"
        Me.LabelCombo.Size = New System.Drawing.Size(164, 31)
        Me.LabelCombo.TabIndex = 4
        Me.LabelCombo.Text = "Department:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(141, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Middle Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'btnSaveRec
        '
        Me.btnSaveRec.Location = New System.Drawing.Point(54, 700)
        Me.btnSaveRec.Name = "btnSaveRec"
        Me.btnSaveRec.Size = New System.Drawing.Size(203, 106)
        Me.btnSaveRec.TabIndex = 1
        Me.btnSaveRec.Text = "&Save Record"
        Me.btnSaveRec.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(339, 700)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(203, 106)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(624, 700)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(203, 106)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 828)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveRec)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Add Employee Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelCombo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMidName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmailAddy As TextBox
    Friend WithEvents txtPhoneExt As TextBox
    Friend WithEvents txtPhoneNumb As TextBox
    Friend WithEvents txtEmpNumb As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cboDeptName As ComboBox
    Friend WithEvents btnSaveRec As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
