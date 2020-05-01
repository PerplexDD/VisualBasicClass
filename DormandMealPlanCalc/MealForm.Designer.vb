<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealForm
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
        Me.lstMealPlans = New System.Windows.Forms.ListBox()
        Me.btnAddMealPlan = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMealPlans)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Weekly Meal Plan"
        '
        'lstMealPlans
        '
        Me.lstMealPlans.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMealPlans.FormattingEnabled = True
        Me.lstMealPlans.ItemHeight = 16
        Me.lstMealPlans.Location = New System.Drawing.Point(22, 24)
        Me.lstMealPlans.Name = "lstMealPlans"
        Me.lstMealPlans.Size = New System.Drawing.Size(362, 148)
        Me.lstMealPlans.TabIndex = 0
        '
        'btnAddMealPlan
        '
        Me.btnAddMealPlan.Location = New System.Drawing.Point(486, 58)
        Me.btnAddMealPlan.Name = "btnAddMealPlan"
        Me.btnAddMealPlan.Size = New System.Drawing.Size(115, 61)
        Me.btnAddMealPlan.TabIndex = 1
        Me.btnAddMealPlan.Text = "&Add Meal Plan"
        Me.btnAddMealPlan.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(486, 151)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 61)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MealPlansForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 271)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddMealPlan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MealPlansForm"
        Me.Text = "Meal Plans"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddMealPlan As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstMealPlans As ListBox

End Class
