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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCardName = New System.Windows.Forms.Label()
        Me.picCardFive = New System.Windows.Forms.PictureBox()
        Me.picCardFour = New System.Windows.Forms.PictureBox()
        Me.picCardThree = New System.Windows.Forms.PictureBox()
        Me.picCardTwo = New System.Windows.Forms.PictureBox()
        Me.picCardOne = New System.Windows.Forms.PictureBox()
        CType(Me.picCardFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCardFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCardThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCardTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCardOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 181)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(74, 29)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCardName
        '
        Me.lblCardName.AutoSize = True
        Me.lblCardName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCardName.Location = New System.Drawing.Point(178, 148)
        Me.lblCardName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCardName.MaximumSize = New System.Drawing.Size(250, 26)
        Me.lblCardName.MinimumSize = New System.Drawing.Size(150, 26)
        Me.lblCardName.Name = "lblCardName"
        Me.lblCardName.Size = New System.Drawing.Size(150, 26)
        Me.lblCardName.TabIndex = 6
        Me.lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picCardFive
        '
        Me.picCardFive.Image = Global.CardIdentifier.My.Resources.Resources.Three_of_Spades
        Me.picCardFive.Location = New System.Drawing.Point(407, 13)
        Me.picCardFive.Margin = New System.Windows.Forms.Padding(2)
        Me.picCardFive.Name = "picCardFive"
        Me.picCardFive.Size = New System.Drawing.Size(86, 123)
        Me.picCardFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCardFive.TabIndex = 5
        Me.picCardFive.TabStop = False
        '
        'picCardFour
        '
        Me.picCardFour.Image = Global.CardIdentifier.My.Resources.Resources.Red_Joker
        Me.picCardFour.Location = New System.Drawing.Point(308, 13)
        Me.picCardFour.Margin = New System.Windows.Forms.Padding(2)
        Me.picCardFour.Name = "picCardFour"
        Me.picCardFour.Size = New System.Drawing.Size(86, 123)
        Me.picCardFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCardFour.TabIndex = 4
        Me.picCardFour.TabStop = False
        '
        'picCardThree
        '
        Me.picCardThree.Image = Global.CardIdentifier.My.Resources.Resources.Queen_of_Clubs
        Me.picCardThree.Location = New System.Drawing.Point(210, 13)
        Me.picCardThree.Margin = New System.Windows.Forms.Padding(2)
        Me.picCardThree.Name = "picCardThree"
        Me.picCardThree.Size = New System.Drawing.Size(86, 123)
        Me.picCardThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCardThree.TabIndex = 3
        Me.picCardThree.TabStop = False
        '
        'picCardTwo
        '
        Me.picCardTwo.Image = Global.CardIdentifier.My.Resources.Resources.Jack_of_Hearts
        Me.picCardTwo.Location = New System.Drawing.Point(112, 13)
        Me.picCardTwo.Margin = New System.Windows.Forms.Padding(2)
        Me.picCardTwo.Name = "picCardTwo"
        Me.picCardTwo.Size = New System.Drawing.Size(86, 123)
        Me.picCardTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCardTwo.TabIndex = 2
        Me.picCardTwo.TabStop = False
        '
        'picCardOne
        '
        Me.picCardOne.Image = Global.CardIdentifier.My.Resources.Resources.Eight_of_Spades
        Me.picCardOne.Location = New System.Drawing.Point(12, 13)
        Me.picCardOne.Margin = New System.Windows.Forms.Padding(2)
        Me.picCardOne.Name = "picCardOne"
        Me.picCardOne.Size = New System.Drawing.Size(86, 123)
        Me.picCardOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCardOne.TabIndex = 1
        Me.picCardOne.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 216)
        Me.Controls.Add(Me.lblCardName)
        Me.Controls.Add(Me.picCardFive)
        Me.Controls.Add(Me.picCardFour)
        Me.Controls.Add(Me.picCardThree)
        Me.Controls.Add(Me.picCardTwo)
        Me.Controls.Add(Me.picCardOne)
        Me.Controls.Add(Me.btnExit)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picCardFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCardFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCardThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCardTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCardOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents picCardOne As PictureBox
    Friend WithEvents picCardTwo As PictureBox
    Friend WithEvents picCardThree As PictureBox
    Friend WithEvents picCardFour As PictureBox
    Friend WithEvents picCardFive As PictureBox
    Friend WithEvents lblCardName As Label
End Class
