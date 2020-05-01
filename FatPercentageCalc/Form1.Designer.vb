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
        Me.lblEnterCal = New System.Windows.Forms.Label()
        Me.lblFatGrams = New System.Windows.Forms.Label()
        Me.lblCalFromFat = New System.Windows.Forms.Label()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtFatGrams = New System.Windows.Forms.TextBox()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 187)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(87, 34)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(156, 187)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 34)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 187)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblEnterCal
        '
        Me.lblEnterCal.AutoSize = True
        Me.lblEnterCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterCal.Location = New System.Drawing.Point(24, 26)
        Me.lblEnterCal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnterCal.Name = "lblEnterCal"
        Me.lblEnterCal.Size = New System.Drawing.Size(292, 20)
        Me.lblEnterCal.TabIndex = 3
        Me.lblEnterCal.Text = "Enter the number of calories in the food:"
        '
        'lblFatGrams
        '
        Me.lblFatGrams.AutoSize = True
        Me.lblFatGrams.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatGrams.Location = New System.Drawing.Point(11, 79)
        Me.lblFatGrams.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFatGrams.Name = "lblFatGrams"
        Me.lblFatGrams.Size = New System.Drawing.Size(305, 20)
        Me.lblFatGrams.TabIndex = 4
        Me.lblFatGrams.Text = "Enter the number of fat grams in the food:"
        '
        'lblCalFromFat
        '
        Me.lblCalFromFat.AutoSize = True
        Me.lblCalFromFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalFromFat.Location = New System.Drawing.Point(11, 135)
        Me.lblCalFromFat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCalFromFat.Name = "lblCalFromFat"
        Me.lblCalFromFat.Size = New System.Drawing.Size(305, 20)
        Me.lblCalFromFat.TabIndex = 5
        Me.lblCalFromFat.Text = "Percentage of calories that come from fat:"
        '
        'txtCalories
        '
        Me.txtCalories.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCalories.Location = New System.Drawing.Point(320, 24)
        Me.txtCalories.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCalories.MinimumSize = New System.Drawing.Size(72, 40)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(72, 26)
        Me.txtCalories.TabIndex = 6
        '
        'txtFatGrams
        '
        Me.txtFatGrams.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFatGrams.Location = New System.Drawing.Point(320, 77)
        Me.txtFatGrams.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFatGrams.MinimumSize = New System.Drawing.Size(72, 40)
        Me.txtFatGrams.Name = "txtFatGrams"
        Me.txtFatGrams.Size = New System.Drawing.Size(72, 26)
        Me.txtFatGrams.TabIndex = 7
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(320, 132)
        Me.lblPercentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPercentage.MinimumSize = New System.Drawing.Size(70, 21)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(70, 22)
        Me.lblPercentage.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 234)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.txtFatGrams)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.lblCalFromFat)
        Me.Controls.Add(Me.lblFatGrams)
        Me.Controls.Add(Me.lblEnterCal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Fat Percentage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblEnterCal As Label
    Friend WithEvents lblFatGrams As Label
    Friend WithEvents lblCalFromFat As Label
    Friend WithEvents txtCalories As TextBox
    Friend WithEvents txtFatGrams As TextBox
    Friend WithEvents lblPercentage As Label
End Class
