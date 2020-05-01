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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxTickets = New System.Windows.Forms.GroupBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.lblNumTicSold = New System.Windows.Forms.Label()
        Me.gbxRevGenerated = New System.Windows.Forms.GroupBox()
        Me.lblTotRevDollars = New System.Windows.Forms.Label()
        Me.lblClassCRev = New System.Windows.Forms.Label()
        Me.lblClassBRev = New System.Windows.Forms.Label()
        Me.lblClassARev = New System.Windows.Forms.Label()
        Me.lblTotRev = New System.Windows.Forms.Label()
        Me.lblClassC2Copy = New System.Windows.Forms.Label()
        Me.lblClassB2Copy = New System.Windows.Forms.Label()
        Me.lblClassACopy = New System.Windows.Forms.Label()
        Me.gbxTickets.SuspendLayout()
        Me.gbxRevGenerated.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(66, 245)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 39)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(239, 246)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(71, 38)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(342, 246)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbxTickets
        '
        Me.gbxTickets.Controls.Add(Me.txtClassC)
        Me.gbxTickets.Controls.Add(Me.txtClassB)
        Me.gbxTickets.Controls.Add(Me.txtClassA)
        Me.gbxTickets.Controls.Add(Me.lblClassC)
        Me.gbxTickets.Controls.Add(Me.lblClassB)
        Me.gbxTickets.Controls.Add(Me.lblClassA)
        Me.gbxTickets.Controls.Add(Me.lblNumTicSold)
        Me.gbxTickets.Location = New System.Drawing.Point(40, 31)
        Me.gbxTickets.Name = "gbxTickets"
        Me.gbxTickets.Size = New System.Drawing.Size(182, 172)
        Me.gbxTickets.TabIndex = 3
        Me.gbxTickets.TabStop = False
        Me.gbxTickets.Text = "Tickets Sold"
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(85, 143)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(63, 20)
        Me.txtClassC.TabIndex = 6
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(85, 105)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(63, 20)
        Me.txtClassB.TabIndex = 5
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(85, 67)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(63, 20)
        Me.txtClassA.TabIndex = 4
        '
        'lblClassC
        '
        Me.lblClassC.AutoSize = True
        Me.lblClassC.Location = New System.Drawing.Point(23, 146)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(45, 13)
        Me.lblClassC.TabIndex = 3
        Me.lblClassC.Text = "Class C:"
        '
        'lblClassB
        '
        Me.lblClassB.AutoSize = True
        Me.lblClassB.Location = New System.Drawing.Point(23, 108)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Size = New System.Drawing.Size(45, 13)
        Me.lblClassB.TabIndex = 2
        Me.lblClassB.Text = "Class B:"
        '
        'lblClassA
        '
        Me.lblClassA.AutoSize = True
        Me.lblClassA.Location = New System.Drawing.Point(23, 70)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Size = New System.Drawing.Size(45, 13)
        Me.lblClassA.TabIndex = 1
        Me.lblClassA.Text = "Class A:"
        '
        'lblNumTicSold
        '
        Me.lblNumTicSold.Location = New System.Drawing.Point(8, 28)
        Me.lblNumTicSold.Name = "lblNumTicSold"
        Me.lblNumTicSold.Size = New System.Drawing.Size(159, 31)
        Me.lblNumTicSold.TabIndex = 0
        Me.lblNumTicSold.Text = "Enter the number of tickets sold for each class of seats"
        '
        'gbxRevGenerated
        '
        Me.gbxRevGenerated.Controls.Add(Me.lblTotRevDollars)
        Me.gbxRevGenerated.Controls.Add(Me.lblClassCRev)
        Me.gbxRevGenerated.Controls.Add(Me.lblClassBRev)
        Me.gbxRevGenerated.Controls.Add(Me.lblClassARev)
        Me.gbxRevGenerated.Controls.Add(Me.lblTotRev)
        Me.gbxRevGenerated.Controls.Add(Me.lblClassC2Copy)
        Me.gbxRevGenerated.Controls.Add(Me.lblClassB2Copy)
        Me.gbxRevGenerated.Controls.Add(Me.lblClassACopy)
        Me.gbxRevGenerated.Location = New System.Drawing.Point(274, 31)
        Me.gbxRevGenerated.Name = "gbxRevGenerated"
        Me.gbxRevGenerated.Size = New System.Drawing.Size(201, 172)
        Me.gbxRevGenerated.TabIndex = 4
        Me.gbxRevGenerated.TabStop = False
        Me.gbxRevGenerated.Text = "Revenue Generated"
        '
        'lblTotRevDollars
        '
        Me.lblTotRevDollars.AutoSize = True
        Me.lblTotRevDollars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotRevDollars.Location = New System.Drawing.Point(106, 139)
        Me.lblTotRevDollars.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblTotRevDollars.Name = "lblTotRevDollars"
        Me.lblTotRevDollars.Size = New System.Drawing.Size(80, 20)
        Me.lblTotRevDollars.TabIndex = 9
        '
        'lblClassCRev
        '
        Me.lblClassCRev.AutoSize = True
        Me.lblClassCRev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassCRev.Location = New System.Drawing.Point(106, 98)
        Me.lblClassCRev.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblClassCRev.Name = "lblClassCRev"
        Me.lblClassCRev.Size = New System.Drawing.Size(80, 20)
        Me.lblClassCRev.TabIndex = 8
        '
        'lblClassBRev
        '
        Me.lblClassBRev.AutoSize = True
        Me.lblClassBRev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassBRev.Location = New System.Drawing.Point(106, 60)
        Me.lblClassBRev.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblClassBRev.Name = "lblClassBRev"
        Me.lblClassBRev.Size = New System.Drawing.Size(80, 20)
        Me.lblClassBRev.TabIndex = 7
        '
        'lblClassARev
        '
        Me.lblClassARev.AutoSize = True
        Me.lblClassARev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassARev.Location = New System.Drawing.Point(106, 21)
        Me.lblClassARev.MinimumSize = New System.Drawing.Size(80, 20)
        Me.lblClassARev.Name = "lblClassARev"
        Me.lblClassARev.Size = New System.Drawing.Size(80, 20)
        Me.lblClassARev.TabIndex = 6
        '
        'lblTotRev
        '
        Me.lblTotRev.AutoSize = True
        Me.lblTotRev.Location = New System.Drawing.Point(19, 143)
        Me.lblTotRev.Name = "lblTotRev"
        Me.lblTotRev.Size = New System.Drawing.Size(81, 13)
        Me.lblTotRev.TabIndex = 5
        Me.lblTotRev.Text = "Total Revenue:"
        '
        'lblClassC2Copy
        '
        Me.lblClassC2Copy.AutoSize = True
        Me.lblClassC2Copy.Location = New System.Drawing.Point(55, 105)
        Me.lblClassC2Copy.Name = "lblClassC2Copy"
        Me.lblClassC2Copy.Size = New System.Drawing.Size(45, 13)
        Me.lblClassC2Copy.TabIndex = 4
        Me.lblClassC2Copy.Text = "Class C:"
        '
        'lblClassB2Copy
        '
        Me.lblClassB2Copy.AutoSize = True
        Me.lblClassB2Copy.Location = New System.Drawing.Point(55, 67)
        Me.lblClassB2Copy.Name = "lblClassB2Copy"
        Me.lblClassB2Copy.Size = New System.Drawing.Size(45, 13)
        Me.lblClassB2Copy.TabIndex = 3
        Me.lblClassB2Copy.Text = "Class B:"
        '
        'lblClassACopy
        '
        Me.lblClassACopy.AutoSize = True
        Me.lblClassACopy.Location = New System.Drawing.Point(55, 28)
        Me.lblClassACopy.Name = "lblClassACopy"
        Me.lblClassACopy.Size = New System.Drawing.Size(45, 13)
        Me.lblClassACopy.TabIndex = 2
        Me.lblClassACopy.Text = "Class A:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 304)
        Me.Controls.Add(Me.gbxRevGenerated)
        Me.Controls.Add(Me.gbxTickets)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.gbxTickets.ResumeLayout(False)
        Me.gbxTickets.PerformLayout()
        Me.gbxRevGenerated.ResumeLayout(False)
        Me.gbxRevGenerated.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents gbxTickets As GroupBox
    Friend WithEvents lblClassC As Label
    Friend WithEvents lblClassB As Label
    Friend WithEvents lblClassA As Label
    Friend WithEvents lblNumTicSold As Label
    Friend WithEvents gbxRevGenerated As GroupBox
    Friend WithEvents txtClassC As TextBox
    Friend WithEvents txtClassB As TextBox
    Friend WithEvents txtClassA As TextBox
    Friend WithEvents lblTotRevDollars As Label
    Friend WithEvents lblClassCRev As Label
    Friend WithEvents lblClassBRev As Label
    Friend WithEvents lblClassARev As Label
    Friend WithEvents lblTotRev As Label
    Friend WithEvents lblClassC2Copy As Label
    Friend WithEvents lblClassB2Copy As Label
    Friend WithEvents lblClassACopy As Label
End Class
