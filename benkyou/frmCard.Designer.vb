<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.tTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblPass = New System.Windows.Forms.Label()
        Me.tTime2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.tTime3 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl1 = New System.Windows.Forms.TextBox()
        Me.lblDebug = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(12, 112)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(200, 38)
        Me.txtAnswer.TabIndex = 0
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(2, 50)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(221, 36)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Middle"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl2.Visible = False
        '
        'tTime
        '
        Me.tTime.Interval = 10000
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(9, 153)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(51, 13)
        Me.lblPass.TabIndex = 3
        Me.lblPass.Text = "@@@@"
        Me.lblPass.Visible = False
        '
        'tTime2
        '
        Me.tTime2.Interval = 5000
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(2, 90)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(221, 19)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "Bottom"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl3.Visible = False
        '
        'tTime3
        '
        Me.tTime3.Interval = 5000
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbl1.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(12, 9)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.ReadOnly = True
        Me.lbl1.Size = New System.Drawing.Size(200, 31)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "Top"
        Me.lbl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDebug
        '
        Me.lblDebug.AutoSize = True
        Me.lblDebug.Location = New System.Drawing.Point(0, 0)
        Me.lblDebug.Name = "lblDebug"
        Me.lblDebug.Size = New System.Drawing.Size(39, 13)
        Me.lblDebug.TabIndex = 6
        Me.lblDebug.Text = "Label1"
        Me.lblDebug.Visible = False
        '
        'frmCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(224, 170)
        Me.Controls.Add(Me.lblDebug)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txtAnswer)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCard"
        Me.Text = "Card"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents tTime As Timer
    Friend WithEvents lblPass As Label
    Friend WithEvents tTime2 As Timer
    Friend WithEvents lbl3 As Label
    Friend WithEvents tTime3 As Timer
    Friend WithEvents lbl1 As TextBox
    Friend WithEvents lblDebug As Label
End Class
