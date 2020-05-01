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
        Me.btnCalcCharges = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalCostOutput = New System.Windows.Forms.Label()
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.txtPhysRehabInput = New System.Windows.Forms.TextBox()
        Me.txtLabFeesInput = New System.Windows.Forms.TextBox()
        Me.txtSurgChargesInput = New System.Windows.Forms.TextBox()
        Me.txtMedInput = New System.Windows.Forms.TextBox()
        Me.txtDaysInput = New System.Windows.Forms.TextBox()
        Me.lblPhysRehab = New System.Windows.Forms.Label()
        Me.lblLabFees = New System.Windows.Forms.Label()
        Me.lblSurgicalCharges = New System.Windows.Forms.Label()
        Me.lblMedication = New System.Windows.Forms.Label()
        Me.lblLengthofStay = New System.Windows.Forms.Label()
        Me.pnlBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalcCharges
        '
        Me.btnCalcCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCharges.Location = New System.Drawing.Point(31, 334)
        Me.btnCalcCharges.Name = "btnCalcCharges"
        Me.btnCalcCharges.Size = New System.Drawing.Size(137, 51)
        Me.btnCalcCharges.TabIndex = 0
        Me.btnCalcCharges.Text = "&Calculate Charges"
        Me.btnCalcCharges.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearForm.Location = New System.Drawing.Point(189, 334)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(106, 51)
        Me.btnClearForm.TabIndex = 1
        Me.btnClearForm.Text = "C&lear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(314, 334)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(106, 51)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalCostOutput
        '
        Me.lblTotalCostOutput.AutoSize = True
        Me.lblTotalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCostOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCostOutput.Location = New System.Drawing.Point(31, 280)
        Me.lblTotalCostOutput.MinimumSize = New System.Drawing.Size(388, 40)
        Me.lblTotalCostOutput.Name = "lblTotalCostOutput"
        Me.lblTotalCostOutput.Size = New System.Drawing.Size(388, 40)
        Me.lblTotalCostOutput.TabIndex = 3
        Me.lblTotalCostOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBackground
        '
        Me.pnlBackground.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlBackground.Controls.Add(Me.txtPhysRehabInput)
        Me.pnlBackground.Controls.Add(Me.txtLabFeesInput)
        Me.pnlBackground.Controls.Add(Me.txtSurgChargesInput)
        Me.pnlBackground.Controls.Add(Me.txtMedInput)
        Me.pnlBackground.Controls.Add(Me.txtDaysInput)
        Me.pnlBackground.Controls.Add(Me.lblPhysRehab)
        Me.pnlBackground.Controls.Add(Me.lblLabFees)
        Me.pnlBackground.Controls.Add(Me.lblSurgicalCharges)
        Me.pnlBackground.Controls.Add(Me.lblMedication)
        Me.pnlBackground.Controls.Add(Me.lblLengthofStay)
        Me.pnlBackground.Location = New System.Drawing.Point(31, 30)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(388, 237)
        Me.pnlBackground.TabIndex = 4
        '
        'txtPhysRehabInput
        '
        Me.txtPhysRehabInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysRehabInput.Location = New System.Drawing.Point(211, 187)
        Me.txtPhysRehabInput.Name = "txtPhysRehabInput"
        Me.txtPhysRehabInput.Size = New System.Drawing.Size(126, 23)
        Me.txtPhysRehabInput.TabIndex = 9
        '
        'txtLabFeesInput
        '
        Me.txtLabFeesInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabFeesInput.Location = New System.Drawing.Point(211, 150)
        Me.txtLabFeesInput.Name = "txtLabFeesInput"
        Me.txtLabFeesInput.Size = New System.Drawing.Size(126, 23)
        Me.txtLabFeesInput.TabIndex = 8
        '
        'txtSurgChargesInput
        '
        Me.txtSurgChargesInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurgChargesInput.Location = New System.Drawing.Point(211, 113)
        Me.txtSurgChargesInput.Name = "txtSurgChargesInput"
        Me.txtSurgChargesInput.Size = New System.Drawing.Size(126, 23)
        Me.txtSurgChargesInput.TabIndex = 7
        '
        'txtMedInput
        '
        Me.txtMedInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedInput.Location = New System.Drawing.Point(211, 76)
        Me.txtMedInput.Name = "txtMedInput"
        Me.txtMedInput.Size = New System.Drawing.Size(126, 23)
        Me.txtMedInput.TabIndex = 6
        '
        'txtDaysInput
        '
        Me.txtDaysInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysInput.Location = New System.Drawing.Point(211, 36)
        Me.txtDaysInput.Name = "txtDaysInput"
        Me.txtDaysInput.Size = New System.Drawing.Size(126, 23)
        Me.txtDaysInput.TabIndex = 5
        '
        'lblPhysRehab
        '
        Me.lblPhysRehab.AutoSize = True
        Me.lblPhysRehab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysRehab.Location = New System.Drawing.Point(77, 190)
        Me.lblPhysRehab.Name = "lblPhysRehab"
        Me.lblPhysRehab.Size = New System.Drawing.Size(106, 17)
        Me.lblPhysRehab.TabIndex = 4
        Me.lblPhysRehab.Text = "Physical Rehab"
        '
        'lblLabFees
        '
        Me.lblLabFees.AutoSize = True
        Me.lblLabFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabFees.Location = New System.Drawing.Point(116, 153)
        Me.lblLabFees.Name = "lblLabFees"
        Me.lblLabFees.Size = New System.Drawing.Size(67, 17)
        Me.lblLabFees.TabIndex = 3
        Me.lblLabFees.Text = "Lab Fees"
        '
        'lblSurgicalCharges
        '
        Me.lblSurgicalCharges.AutoSize = True
        Me.lblSurgicalCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurgicalCharges.Location = New System.Drawing.Point(67, 116)
        Me.lblSurgicalCharges.Name = "lblSurgicalCharges"
        Me.lblSurgicalCharges.Size = New System.Drawing.Size(116, 17)
        Me.lblSurgicalCharges.TabIndex = 2
        Me.lblSurgicalCharges.Text = "Surgical Charges"
        '
        'lblMedication
        '
        Me.lblMedication.AutoSize = True
        Me.lblMedication.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedication.Location = New System.Drawing.Point(107, 79)
        Me.lblMedication.Name = "lblMedication"
        Me.lblMedication.Size = New System.Drawing.Size(76, 17)
        Me.lblMedication.TabIndex = 1
        Me.lblMedication.Text = "Medication"
        '
        'lblLengthofStay
        '
        Me.lblLengthofStay.AutoSize = True
        Me.lblLengthofStay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLengthofStay.Location = New System.Drawing.Point(45, 38)
        Me.lblLengthofStay.Name = "lblLengthofStay"
        Me.lblLengthofStay.Size = New System.Drawing.Size(138, 17)
        Me.lblLengthofStay.TabIndex = 0
        Me.lblLengthofStay.Text = "Lenth of Stay (Days)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 409)
        Me.Controls.Add(Me.pnlBackground)
        Me.Controls.Add(Me.lblTotalCostOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnCalcCharges)
        Me.Name = "Form1"
        Me.Text = "Hospital Charges"
        Me.pnlBackground.ResumeLayout(False)
        Me.pnlBackground.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalcCharges As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCostOutput As Label
    Friend WithEvents pnlBackground As Panel
    Friend WithEvents lblPhysRehab As Label
    Friend WithEvents lblLabFees As Label
    Friend WithEvents lblSurgicalCharges As Label
    Friend WithEvents lblMedication As Label
    Friend WithEvents lblLengthofStay As Label
    Friend WithEvents txtPhysRehabInput As TextBox
    Friend WithEvents txtLabFeesInput As TextBox
    Friend WithEvents txtSurgChargesInput As TextBox
    Friend WithEvents txtMedInput As TextBox
    Friend WithEvents txtDaysInput As TextBox
End Class
