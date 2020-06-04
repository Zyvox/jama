<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.txtInterval = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tMain = New System.Windows.Forms.Timer(Me.components)
        Me.chkReplay = New System.Windows.Forms.CheckBox()
        Me.lastPressed = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPanic = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCards = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbarStatus = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tAfterImport = New System.Windows.Forms.Timer(Me.components)
        Me.btnRemoveDupes = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.chkTip = New System.Windows.Forms.CheckBox()
        Me.chkAnswer = New System.Windows.Forms.CheckBox()
        Me.curCards = New System.Windows.Forms.Label()
        Me.chkMultipleCards = New System.Windows.Forms.CheckBox()
        Me.txtPanic2 = New System.Windows.Forms.TextBox()
        Me.chkEigo = New System.Windows.Forms.CheckBox()
        Me.btnSaveDeck = New System.Windows.Forms.Button()
        Me.btnLoadDeck = New System.Windows.Forms.Button()
        Me.lstDecks = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRemoveDeck = New System.Windows.Forms.Button()
        Me.btnClipboard = New System.Windows.Forms.Button()
        Me.chkMaxCards = New System.Windows.Forms.CheckBox()
        Me.txtMaxCards = New System.Windows.Forms.TextBox()
        Me.chkNeedEigo = New System.Windows.Forms.CheckBox()
        Me.txtEigoChars = New System.Windows.Forms.TextBox()
        Me.chkKeepCards = New System.Windows.Forms.CheckBox()
        Me.btnClearListView = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(21, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(138, 44)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(62, 62)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(48, 20)
        Me.txtTime.TabIndex = 1
        Me.txtTime.Text = "15"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Time                        s"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(315, 115)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(104, 23)
        Me.btnImport.TabIndex = 3
        Me.btnImport.Text = "Import cards"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'txtInterval
        '
        Me.txtInterval.Location = New System.Drawing.Point(62, 84)
        Me.txtInterval.Name = "txtInterval"
        Me.txtInterval.Size = New System.Drawing.Size(48, 20)
        Me.txtInterval.TabIndex = 4
        Me.txtInterval.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Interval                    s"
        '
        'tMain
        '
        Me.tMain.Interval = 3000
        '
        'chkReplay
        '
        Me.chkReplay.AutoSize = True
        Me.chkReplay.Checked = True
        Me.chkReplay.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkReplay.Enabled = False
        Me.chkReplay.Location = New System.Drawing.Point(37, 422)
        Me.chkReplay.Name = "chkReplay"
        Me.chkReplay.Size = New System.Drawing.Size(88, 17)
        Me.chkReplay.TabIndex = 6
        Me.chkReplay.Text = "Replay cards"
        Me.chkReplay.UseVisualStyleBackColor = True
        '
        'lastPressed
        '
        Me.lastPressed.AutoSize = True
        Me.lastPressed.Location = New System.Drawing.Point(18, 160)
        Me.lastPressed.Name = "lastPressed"
        Me.lastPressed.Size = New System.Drawing.Size(13, 13)
        Me.lastPressed.TabIndex = 7
        Me.lastPressed.Text = "a"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(37, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "panic button"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPanic
        '
        Me.txtPanic.Enabled = False
        Me.txtPanic.Location = New System.Drawing.Point(118, 447)
        Me.txtPanic.Name = "txtPanic"
        Me.txtPanic.Size = New System.Drawing.Size(23, 20)
        Me.txtPanic.TabIndex = 9
        Me.txtPanic.Text = "F1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 471)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Type 'clear' to clear all cards"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(21, 116)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(214, 20)
        Me.txtPath.TabIndex = 11
        Me.txtPath.Text = "C:\Users\zyvox\Desktop\JLPT Study\drill 1-2.txt"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(21, 139)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(398, 230)
        Me.ListView1.TabIndex = 12
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
        Me.ColumnHeader2.Text = "Hiragana (Romaji)"
        Me.ColumnHeader2.Width = 135
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Meaning"
        Me.ColumnHeader3.Width = 122
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem1.Text = "Remove selected"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItem2.Text = "Select all"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(131, 65)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Label2"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(131, 87)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(39, 13)
        Me.lblInterval.TabIndex = 14
        Me.lblInterval.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 91)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "TODO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "avg time is not accurate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     unless you use 1 max card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "add names to dec" &
    "ks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "custom cards" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "fix overlapping somehow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "option to disable replay"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(241, 115)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(68, 23)
        Me.btnBrowse.TabIndex = 16
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCards, Me.lblStatus, Me.pbarStatus, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 492)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(608, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblCards
        '
        Me.lblCards.Name = "lblCards"
        Me.lblCards.Size = New System.Drawing.Size(44, 17)
        Me.lblCards.Text = "0 cards"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblStatus.Text = "Ready"
        '
        'pbarStatus
        '
        Me.pbarStatus.Name = "pbarStatus"
        Me.pbarStatus.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(148, 17)
        Me.ToolStripStatusLabel1.Text = "Close cards: F1     Abort: F2"
        '
        'tAfterImport
        '
        Me.tAfterImport.Interval = 2500
        '
        'btnRemoveDupes
        '
        Me.btnRemoveDupes.Location = New System.Drawing.Point(21, 375)
        Me.btnRemoveDupes.Name = "btnRemoveDupes"
        Me.btnRemoveDupes.Size = New System.Drawing.Size(119, 23)
        Me.btnRemoveDupes.TabIndex = 20
        Me.btnRemoveDupes.Text = "Remove duplicates"
        Me.btnRemoveDupes.UseVisualStyleBackColor = True
        '
        'btnStatistics
        '
        Me.btnStatistics.Location = New System.Drawing.Point(227, 374)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(82, 23)
        Me.btnStatistics.TabIndex = 21
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'chkTip
        '
        Me.chkTip.AutoSize = True
        Me.chkTip.Checked = True
        Me.chkTip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTip.Location = New System.Drawing.Point(200, 404)
        Me.chkTip.Name = "chkTip"
        Me.chkTip.Size = New System.Drawing.Size(109, 17)
        Me.chkTip.TabIndex = 22
        Me.chkTip.Text = "Show tip half-time"
        Me.chkTip.UseVisualStyleBackColor = True
        '
        'chkAnswer
        '
        Me.chkAnswer.AutoSize = True
        Me.chkAnswer.Checked = True
        Me.chkAnswer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAnswer.Location = New System.Drawing.Point(200, 419)
        Me.chkAnswer.Name = "chkAnswer"
        Me.chkAnswer.Size = New System.Drawing.Size(135, 17)
        Me.chkAnswer.TabIndex = 23
        Me.chkAnswer.Text = "Show answer near end"
        Me.chkAnswer.UseVisualStyleBackColor = True
        '
        'curCards
        '
        Me.curCards.AutoSize = True
        Me.curCards.Location = New System.Drawing.Point(0, 0)
        Me.curCards.Name = "curCards"
        Me.curCards.Size = New System.Drawing.Size(14, 13)
        Me.curCards.TabIndex = 24
        Me.curCards.Text = "#"
        Me.curCards.Visible = False
        '
        'chkMultipleCards
        '
        Me.chkMultipleCards.AutoSize = True
        Me.chkMultipleCards.Location = New System.Drawing.Point(200, 434)
        Me.chkMultipleCards.Name = "chkMultipleCards"
        Me.chkMultipleCards.Size = New System.Drawing.Size(196, 17)
        Me.chkMultipleCards.TabIndex = 25
        Me.chkMultipleCards.Text = "Enable copies of same card at once"
        Me.chkMultipleCards.UseVisualStyleBackColor = True
        '
        'txtPanic2
        '
        Me.txtPanic2.Enabled = False
        Me.txtPanic2.Location = New System.Drawing.Point(147, 447)
        Me.txtPanic2.Name = "txtPanic2"
        Me.txtPanic2.Size = New System.Drawing.Size(23, 20)
        Me.txtPanic2.TabIndex = 26
        Me.txtPanic2.Text = "F2"
        '
        'chkEigo
        '
        Me.chkEigo.AutoSize = True
        Me.chkEigo.Location = New System.Drawing.Point(200, 450)
        Me.chkEigo.Name = "chkEigo"
        Me.chkEigo.Size = New System.Drawing.Size(137, 17)
        Me.chkEigo.TabIndex = 27
        Me.chkEigo.Text = "Swap English and Kanji"
        Me.chkEigo.UseVisualStyleBackColor = True
        '
        'btnSaveDeck
        '
        Me.btnSaveDeck.Location = New System.Drawing.Point(315, 374)
        Me.btnSaveDeck.Name = "btnSaveDeck"
        Me.btnSaveDeck.Size = New System.Drawing.Size(104, 23)
        Me.btnSaveDeck.TabIndex = 28
        Me.btnSaveDeck.Text = "Save deck"
        Me.btnSaveDeck.UseVisualStyleBackColor = True
        '
        'btnLoadDeck
        '
        Me.btnLoadDeck.Enabled = False
        Me.btnLoadDeck.Location = New System.Drawing.Point(516, 374)
        Me.btnLoadDeck.Name = "btnLoadDeck"
        Me.btnLoadDeck.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadDeck.TabIndex = 29
        Me.btnLoadDeck.Text = "Load deck"
        Me.btnLoadDeck.UseVisualStyleBackColor = True
        '
        'lstDecks
        '
        Me.lstDecks.FormattingEnabled = True
        Me.lstDecks.Location = New System.Drawing.Point(425, 143)
        Me.lstDecks.Name = "lstDecks"
        Me.lstDecks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstDecks.Size = New System.Drawing.Size(166, 225)
        Me.lstDecks.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "My decks"
        '
        'btnRemoveDeck
        '
        Me.btnRemoveDeck.Location = New System.Drawing.Point(448, 374)
        Me.btnRemoveDeck.Name = "btnRemoveDeck"
        Me.btnRemoveDeck.Size = New System.Drawing.Size(65, 23)
        Me.btnRemoveDeck.TabIndex = 32
        Me.btnRemoveDeck.Text = "Remove"
        Me.btnRemoveDeck.UseVisualStyleBackColor = True
        '
        'btnClipboard
        '
        Me.btnClipboard.Location = New System.Drawing.Point(467, 463)
        Me.btnClipboard.Name = "btnClipboard"
        Me.btnClipboard.Size = New System.Drawing.Size(101, 23)
        Me.btnClipboard.TabIndex = 33
        Me.btnClipboard.Text = "Import Clipboard"
        Me.btnClipboard.UseVisualStyleBackColor = True
        '
        'chkMaxCards
        '
        Me.chkMaxCards.AutoSize = True
        Me.chkMaxCards.Checked = True
        Me.chkMaxCards.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMaxCards.Location = New System.Drawing.Point(338, 421)
        Me.chkMaxCards.Name = "chkMaxCards"
        Me.chkMaxCards.Size = New System.Drawing.Size(81, 17)
        Me.chkMaxCards.TabIndex = 34
        Me.chkMaxCards.Text = "Max cards: "
        Me.chkMaxCards.UseVisualStyleBackColor = True
        '
        'txtMaxCards
        '
        Me.txtMaxCards.Location = New System.Drawing.Point(412, 419)
        Me.txtMaxCards.Name = "txtMaxCards"
        Me.txtMaxCards.Size = New System.Drawing.Size(27, 20)
        Me.txtMaxCards.TabIndex = 35
        Me.txtMaxCards.Text = "2"
        '
        'chkNeedEigo
        '
        Me.chkNeedEigo.AutoSize = True
        Me.chkNeedEigo.Location = New System.Drawing.Point(200, 467)
        Me.chkNeedEigo.Name = "chkNeedEigo"
        Me.chkNeedEigo.Size = New System.Drawing.Size(233, 17)
        Me.chkNeedEigo.TabIndex = 36
        Me.chkNeedEigo.Text = "Require english answer first            (a bit iffy)"
        Me.chkNeedEigo.UseVisualStyleBackColor = True
        '
        'txtEigoChars
        '
        Me.txtEigoChars.Enabled = False
        Me.txtEigoChars.Location = New System.Drawing.Point(353, 466)
        Me.txtEigoChars.Name = "txtEigoChars"
        Me.txtEigoChars.Size = New System.Drawing.Size(27, 20)
        Me.txtEigoChars.TabIndex = 37
        Me.txtEigoChars.Text = "3"
        '
        'chkKeepCards
        '
        Me.chkKeepCards.AutoSize = True
        Me.chkKeepCards.Location = New System.Drawing.Point(338, 403)
        Me.chkKeepCards.Name = "chkKeepCards"
        Me.chkKeepCards.Size = New System.Drawing.Size(133, 17)
        Me.chkKeepCards.TabIndex = 38
        Me.chkKeepCards.Text = "Keep cards on start-up"
        Me.chkKeepCards.UseVisualStyleBackColor = True
        '
        'btnClearListView
        '
        Me.btnClearListView.Location = New System.Drawing.Point(146, 375)
        Me.btnClearListView.Name = "btnClearListView"
        Me.btnClearListView.Size = New System.Drawing.Size(75, 23)
        Me.btnClearListView.TabIndex = 39
        Me.btnClearListView.Text = "Clear list"
        Me.btnClearListView.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 52)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "GUIDE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "First, import cards through a .txt or a url" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Next, set settings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start!"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 514)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClearListView)
        Me.Controls.Add(Me.txtMaxCards)
        Me.Controls.Add(Me.chkKeepCards)
        Me.Controls.Add(Me.txtEigoChars)
        Me.Controls.Add(Me.chkNeedEigo)
        Me.Controls.Add(Me.chkMaxCards)
        Me.Controls.Add(Me.btnClipboard)
        Me.Controls.Add(Me.btnRemoveDeck)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstDecks)
        Me.Controls.Add(Me.btnLoadDeck)
        Me.Controls.Add(Me.btnSaveDeck)
        Me.Controls.Add(Me.chkEigo)
        Me.Controls.Add(Me.txtPanic2)
        Me.Controls.Add(Me.chkMultipleCards)
        Me.Controls.Add(Me.curCards)
        Me.Controls.Add(Me.chkAnswer)
        Me.Controls.Add(Me.chkTip)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnRemoveDupes)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPanic)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lastPressed)
        Me.Controls.Add(Me.chkReplay)
        Me.Controls.Add(Me.txtInterval)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label11)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "JAMA"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents txtInterval As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tMain As Timer
    Friend WithEvents chkReplay As CheckBox
    Friend WithEvents lastPressed As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPanic As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lblTime As Label
    Friend WithEvents lblInterval As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents pbarStatus As ToolStripProgressBar
    Friend WithEvents tAfterImport As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnRemoveDupes As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents btnStatistics As Button
    Friend WithEvents chkTip As CheckBox
    Friend WithEvents chkAnswer As CheckBox
    Friend WithEvents curCards As Label
    Friend WithEvents chkMultipleCards As CheckBox
    Friend WithEvents txtPanic2 As TextBox
    Friend WithEvents chkEigo As CheckBox
    Friend WithEvents btnSaveDeck As Button
    Friend WithEvents btnLoadDeck As Button
    Friend WithEvents lstDecks As ListBox
    Friend WithEvents lblCards As ToolStripStatusLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRemoveDeck As Button
    Friend WithEvents btnClipboard As Button
    Friend WithEvents chkMaxCards As CheckBox
    Friend WithEvents txtMaxCards As TextBox
    Friend WithEvents chkNeedEigo As CheckBox
    Friend WithEvents txtEigoChars As TextBox
    Friend WithEvents chkKeepCards As CheckBox
    Friend WithEvents btnClearListView As Button
    Friend WithEvents Label4 As Label
End Class
