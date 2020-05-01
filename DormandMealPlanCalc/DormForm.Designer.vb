<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DormForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstDormitory = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMealPlan = New System.Windows.Forms.Label()
        Me.lblDormitory = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddDormitory = New System.Windows.Forms.Button()
        Me.btnViewMealPlan = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstDormitory)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Dormitory"
        '
        'lstDormitory
        '
        Me.lstDormitory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDormitory.FormattingEnabled = True
        Me.lstDormitory.ItemHeight = 16
        Me.lstDormitory.Location = New System.Drawing.Point(21, 37)
        Me.lstDormitory.Name = "lstDormitory"
        Me.lstDormitory.Size = New System.Drawing.Size(313, 180)
        Me.lstDormitory.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblMealPlan)
        Me.GroupBox2.Controls.Add(Me.lblDormitory)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(452, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 273)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Charges for the Semester"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(111, 204)
        Me.lblTotal.MinimumSize = New System.Drawing.Size(180, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(180, 20)
        Me.lblTotal.TabIndex = 5
        '
        'lblMealPlan
        '
        Me.lblMealPlan.AutoSize = True
        Me.lblMealPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMealPlan.Location = New System.Drawing.Point(111, 123)
        Me.lblMealPlan.MinimumSize = New System.Drawing.Size(180, 20)
        Me.lblMealPlan.Name = "lblMealPlan"
        Me.lblMealPlan.Size = New System.Drawing.Size(180, 20)
        Me.lblMealPlan.TabIndex = 4
        '
        'lblDormitory
        '
        Me.lblDormitory.AutoSize = True
        Me.lblDormitory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDormitory.Location = New System.Drawing.Point(111, 39)
        Me.lblDormitory.MinimumSize = New System.Drawing.Size(180, 20)
        Me.lblDormitory.Name = "lblDormitory"
        Me.lblDormitory.Size = New System.Drawing.Size(180, 20)
        Me.lblDormitory.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Meal Plan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dormitory"
        '
        'btnAddDormitory
        '
        Me.btnAddDormitory.Location = New System.Drawing.Point(37, 359)
        Me.btnAddDormitory.Name = "btnAddDormitory"
        Me.btnAddDormitory.Size = New System.Drawing.Size(127, 61)
        Me.btnAddDormitory.TabIndex = 2
        Me.btnAddDormitory.Text = "&Add Dormitory"
        Me.btnAddDormitory.UseVisualStyleBackColor = True
        '
        'btnViewMealPlan
        '
        Me.btnViewMealPlan.Location = New System.Drawing.Point(267, 359)
        Me.btnViewMealPlan.Name = "btnViewMealPlan"
        Me.btnViewMealPlan.Size = New System.Drawing.Size(127, 61)
        Me.btnViewMealPlan.TabIndex = 3
        Me.btnViewMealPlan.Text = "&View Meal Plan"
        Me.btnViewMealPlan.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(452, 359)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(127, 61)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(631, 359)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(127, 61)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnViewMealPlan)
        Me.Controls.Add(Me.btnAddDormitory)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "Dorm and Meal Plan Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMealPlan As Label
    Friend WithEvents lblDormitory As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddDormitory As Button
    Friend WithEvents btnViewMealPlan As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstDormitory As ListBox
End Class
