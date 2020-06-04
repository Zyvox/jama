<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatistics
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
        Me.lstCorrect = New System.Windows.Forms.ListBox()
        Me.lstWrong = New System.Windows.Forms.ListBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMakeDeck = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCorrect
        '
        Me.lstCorrect.FormattingEnabled = True
        Me.lstCorrect.Location = New System.Drawing.Point(12, 12)
        Me.lstCorrect.Name = "lstCorrect"
        Me.lstCorrect.Size = New System.Drawing.Size(236, 82)
        Me.lstCorrect.TabIndex = 0
        '
        'lstWrong
        '
        Me.lstWrong.FormattingEnabled = True
        Me.lstWrong.Location = New System.Drawing.Point(324, 12)
        Me.lstWrong.Name = "lstWrong"
        Me.lstWrong.Size = New System.Drawing.Size(236, 82)
        Me.lstWrong.TabIndex = 1
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(456, 296)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 23)
        Me.btnExport.TabIndex = 2
        Me.btnExport.Text = "Export to CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 100)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(548, 190)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kanji"
        Me.ColumnHeader1.Width = 136
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Correct"
        Me.ColumnHeader2.Width = 58
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Incorrect"
        Me.ColumnHeader3.Width = 61
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "% Correct"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Avg. Time"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Meaning"
        Me.ColumnHeader6.Width = 203
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(377, 296)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(73, 23)
        Me.btnImport.TabIndex = 14
        Me.btnImport.Text = "Import data"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnMakeDeck
        '
        Me.btnMakeDeck.Location = New System.Drawing.Point(245, 296)
        Me.btnMakeDeck.Name = "btnMakeDeck"
        Me.btnMakeDeck.Size = New System.Drawing.Size(126, 23)
        Me.btnMakeDeck.TabIndex = 16
        Me.btnMakeDeck.Text = "Make deck"
        Me.btnMakeDeck.UseVisualStyleBackColor = True
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 329)
        Me.Controls.Add(Me.btnMakeDeck)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lstWrong)
        Me.Controls.Add(Me.lstCorrect)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStatistics"
        Me.Text = "Study Table"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstCorrect As ListBox
    Friend WithEvents lstWrong As ListBox
    Friend WithEvents btnExport As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnImport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnMakeDeck As Button
End Class
