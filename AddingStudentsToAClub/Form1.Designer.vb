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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstStudentList = New System.Windows.Forms.ListBox()
        Me.lstMembershipList = New System.Windows.Forms.ListBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnRemoveMember = New System.Windows.Forms.Button()
        Me.cboClubs = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMemberCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstStudentList
        '
        Me.lstStudentList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstStudentList.FormattingEnabled = True
        Me.lstStudentList.ItemHeight = 16
        Me.lstStudentList.Location = New System.Drawing.Point(12, 130)
        Me.lstStudentList.Name = "lstStudentList"
        Me.lstStudentList.Size = New System.Drawing.Size(243, 308)
        Me.lstStudentList.TabIndex = 0
        '
        'lstMembershipList
        '
        Me.lstMembershipList.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMembershipList.FormattingEnabled = True
        Me.lstMembershipList.ItemHeight = 16
        Me.lstMembershipList.Location = New System.Drawing.Point(397, 130)
        Me.lstMembershipList.Name = "lstMembershipList"
        Me.lstMembershipList.Size = New System.Drawing.Size(243, 308)
        Me.lstMembershipList.TabIndex = 1
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Location = New System.Drawing.Point(277, 252)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(97, 109)
        Me.btnAddStudent.TabIndex = 2
        Me.btnAddStudent.Text = "&Add selected student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'btnRemoveMember
        '
        Me.btnRemoveMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveMember.Location = New System.Drawing.Point(664, 252)
        Me.btnRemoveMember.Name = "btnRemoveMember"
        Me.btnRemoveMember.Size = New System.Drawing.Size(97, 109)
        Me.btnRemoveMember.TabIndex = 3
        Me.btnRemoveMember.Text = "&Remove selected member"
        Me.btnRemoveMember.UseVisualStyleBackColor = True
        '
        'cboClubs
        '
        Me.cboClubs.FormattingEnabled = True
        Me.cboClubs.Location = New System.Drawing.Point(244, 71)
        Me.cboClubs.Name = "cboClubs"
        Me.cboClubs.Size = New System.Drawing.Size(187, 21)
        Me.cboClubs.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "General Student List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(429, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Club Membership List"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Select the current club:"
        '
        'lblMemberCount
        '
        Me.lblMemberCount.AutoSize = True
        Me.lblMemberCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMemberCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberCount.Location = New System.Drawing.Point(646, 380)
        Me.lblMemberCount.MinimumSize = New System.Drawing.Size(100, 25)
        Me.lblMemberCount.Name = "lblMemberCount"
        Me.lblMemberCount.Size = New System.Drawing.Size(100, 25)
        Me.lblMemberCount.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(658, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMemberCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboClubs)
        Me.Controls.Add(Me.btnRemoveMember)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.lstMembershipList)
        Me.Controls.Add(Me.lstStudentList)
        Me.Name = "Form1"
        Me.Text = "Adding Students to a Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstStudentList As ListBox
    Friend WithEvents lstMembershipList As ListBox
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnRemoveMember As Button
    Friend WithEvents cboClubs As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMemberCount As Label
    Friend WithEvents Label4 As Label
End Class
