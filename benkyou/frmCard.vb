Imports System.IO
Public Class frmCard
    Dim panickey As String = frmMain.txtPanic.Text
    Dim kanji As String = "###"
    Dim eigo As String = "###"
    Dim correct As String = "###"
    Dim activ As Boolean = True
    Dim alrlost As Boolean = False
    Dim answered1 As Boolean = False 'for english answer first
    Dim nnn As Integer = 3
    Dim created As DateTime
    Private Sub frmCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str() As String = Split(lblPass.Text, "@@")
        kanji = str(0)
        correct = str(1).ToUpper()
        eigo = str(2).ToUpper()
        If frmMain.chkEigo.Checked = True Then
            Dim tmp As String = kanji
            kanji = eigo
            eigo = tmp
        End If
        '0 = kanji, 1 = bottom, 2 = answer-hiragana
        lbl1.Text = kanji
        lbl2.Text = eigo
        lbl3.Text = correct
        tTime.Interval = CInt(frmMain.lblTime.Text)
        tTime2.Interval = CInt(frmMain.lblTime.Text) / 2 '50%
        tTime3.Interval = CInt(frmMain.lblTime.Text) / 1.25 '20%
        tTime.Enabled = True
        If frmMain.chkTip.Checked = True Then tTime2.Enabled = True
        If frmMain.chkAnswer.Checked = True Then tTime3.Enabled = True
        If frmMain.chkNeedEigo.Checked = False Then answered1 = True 'Set answered english to true
        If IsNumeric(frmMain.txtEigoChars.Text) Then nnn = CInt(frmMain.txtEigoChars.Text)
        Me.Enabled = True
        created = TimeOfDay
    End Sub

    Public Sub New()
        InitializeComponent()
        AddHandler frmMain.OnTyped, AddressOf Typed
    End Sub

    Private Sub Typed()
        If activ = True Then
            Dim str As String = frmMain.lastPressed.Text
            If str = "Back" Then
                If txtAnswer.Text.Length > 0 Then txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1)
            ElseIf str = "Return" Then
                txtAnswer.Clear()
            Else
                Try
                    txtAnswer.AppendText(str)
                Catch ex As Exception
                End Try
            End If
            If txtAnswer.Text.Contains("CLEAR") Then Me.Visible = False
        End If
    End Sub

    Private Sub frmCard_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        RemoveHandler frmMain.OnTyped, AddressOf Typed
    End Sub


    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

        If answered1 = True Then ' English is answered OR not applicable

            'Check KANJI answer (english is alr done or not applicable)
            If Not txtAnswer.Text = "" Then
                If txtAnswer.Text.Contains(correct) Then
                    If alrlost = True Then RanOut() Else Win() 'Check if answer was shown and if it is don't win
                End If
            End If

        Else

            'Check ENGLISH answer
            If Not txtAnswer.Text = "" Then
                If txtAnswer.Text.Length >= nnn Then
                    If eigo.Contains(txtAnswer.Text) Then
                        txtAnswer.Clear()
                        answered1 = True
                        lbl2.ForeColor = Color.DarkGreen
                    End If
                End If

            End If

        End If
    End Sub
    Private Sub Disappear()
        If frmMain.curCards.Text.Contains(lblPass.Text) Then
            frmMain.curCards.Text = frmMain.curCards.Text.Replace(lblPass.Text, "")
        End If
        txtAnswer.Enabled = False
        tTime.Enabled = False
        activ = False
        RemoveHandler frmMain.OnTyped, AddressOf Typed
        Me.Visible = False
        Me.Close()
    End Sub
    Private Sub tTime_Tick(sender As Object, e As EventArgs) Handles tTime.Tick
        Lose()
    End Sub
    Private Sub tTime2_Tick(sender As Object, e As EventArgs) Handles tTime2.Tick
        'Show english when half the time is up, interval is half of tTime
        lbl2.Visible = True
    End Sub
    Private Sub tTime3_Tick(sender As Object, e As EventArgs) Handles tTime3.Tick
        'Show answer at end
        lbl3.Visible = True
        If Me.Visible = True Then alrlost = True 'Answer was shown so no point
    End Sub

    Private Sub Win()
        frmStatistics.lstCorrect.Items.Add(kanji)
        frmStatistics.RefreshListView(1, kanji, correct, eigo, created)
        Disappear()
    End Sub
    Private Sub Lose()
        frmStatistics.lstWrong.Items.Add(kanji)
        frmStatistics.RefreshListView(0, kanji, correct, eigo, created)
        Disappear()
    End Sub
    Private Sub RanOut()
        frmStatistics.lstWrong.Items.Add(kanji)
        frmStatistics.RefreshListView(0, kanji, correct, eigo, created)
        Disappear()
    End Sub

End Class