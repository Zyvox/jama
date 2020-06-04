Imports System.IO
Imports System.Net
Imports System.Linq
Public Class frmMain

    Private WithEvents kbHook As New KeyboardHook
    Shared r As New Random()
    Private tmr As Windows.Forms.Timer
    Event OnTyped()
    Dim tmpListView As ListView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lastPressed.Text = ""
        lblTime.Text = txtTime.Text * 1000
        lblInterval.Text = txtInterval.Text * 1000
        LoadDecks()
        LoadSettings()
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged
        If IsNumeric(txtTime.Text) Then
            lblTime.Text = txtTime.Text * 1000
        End If
    End Sub
    Private Sub txtInterval_TextChanged(sender As Object, e As EventArgs) Handles txtInterval.TextChanged
        If IsNumeric(txtInterval.Text) Then
            If txtInterval.Text >= 0.1 Then lblInterval.Text = txtInterval.Text * 1000
        End If
    End Sub

    Private Sub tMain_Tick(sender As Object, e As EventArgs) Handles tMain.Tick
        Dim canMake As Boolean = True
        If chkMaxCards.Checked = True Then
            Dim cnt As Integer = Application.OpenForms().OfType(Of frmCard).Count
            Dim max As Integer = 1
            If IsNumeric(txtMaxCards.Text) Then max = CInt(txtMaxCards.Text)
            If cnt >= max Then canMake = False
        End If

        If canMake = True Then
            Try
                If chkMultipleCards.Checked = True Then
                    'Just keep adding cards regardless if its already open
                    Randomize()
                    Dim ran As Integer = r.Next(0, ListView1.Items.Count)
                    Dim s As String = ListView1.Items(ran).Text + "@@" + Translate.ConvertToRomaji(ListView1.Items(ran).SubItems(1).Text) + "@@" + ListView1.Items(ran).SubItems(2).Text
                    CreateCard(s)
                Else
                    'Limit to only 1 card, no multiple copies at once
                    Dim b As Boolean = True
                    While b
                        Randomize()
                        Dim ran As Integer = r.Next(0, ListView1.Items.Count)
                        Dim s As String = ListView1.Items(ran).Text + "@@" + Translate.ConvertToRomaji(ListView1.Items(ran).SubItems(1).Text) + "@@" + ListView1.Items(ran).SubItems(2).Text
                        If Not curCards.Text.Contains(s) Then 'Check that card is not currently being shown
                            CreateCard(s)
                            b = False
                        End If
                        wait(0.2) 'wait 0.2s before looping again
                    End While
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub CreateCard(strfull As String)
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim r1 As Integer = r.Next(0, screenWidth - frmCard.Width)
        Dim r2 As Integer = r.Next(0, screenHeight - frmCard.Height)

        curCards.Text += strfull
        Dim card As New frmCard
        With card
            .StartPosition = FormStartPosition.Manual
            .Location = New Point(r1, r2)
            .lblPass.Text = strfull
            .tTime.Interval = CInt(lblTime.Text)
        End With
        card.Show()
    End Sub
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'Find smallest word and set txtEigoChars to that
        Dim iEigoChars As Integer = 3
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems(2).Text.Length < iEigoChars Then
                iEigoChars = ListView1.Items(i).SubItems(2).Text.Length
            End If
            txtEigoChars.Text = iEigoChars.ToString
        Next



        If ListView1.Items.Count > 0 Then
            tMain.Interval = lblInterval.Text
            If btnStart.Text = "Start" Then
                tMain.Enabled = True
                btnStart.Text = "Stop"
                btnImport.Enabled = False
            Else
                tMain.Enabled = False
                btnStart.Text = "Start"
                btnImport.Enabled = True
                CloseCards()
            End If
            lastPressed.Select()
        End If

        SaveSettings()
    End Sub


    Private Sub kbHook_KeyDown(ByVal Key As Keys) Handles kbHook.KeyDown
        Dim str As String = Key.ToString
        If str = "Space" Then str = " "
        If str = "Tab" Then str = ""
        If str = "Capital" Then str = ""
        If str = "LShiftKey" Then str = ""
        If str = "RShiftKey" Then str = ""
        If str = "LControlKey" Then str = ""
        lastPressed.Text = str
        Typed()
        'CHECK IF TEXTBOX MATCHES ANSWER HERE
        If lastPressed.Text = txtPanic.Text Then
            CloseCards()
        ElseIf lastPressed.Text = txtPanic2.Text Then
            Application.Restart()
        End If
    End Sub
    Private Sub Typed()
        RaiseEvent OnTyped()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim c As Integer = 0
        Dim tmp() As String = txtPath.Text.Split(":")
        If tmp(0).Contains("http") Then
            lblStatus.Text = "Importing cards from internet..."
            Dim address As String = txtPath.Text
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address), System.Text.Encoding.GetEncoding("utf-8"))
            Dim data() As String = reader.ReadToEnd.Split(vbCrLf)
            pbarStatus.Maximum = data.Length
            For i = 0 To data.Length - 1
                Dim s() As String = data(i).Replace("、", ",").Split(",")
                If s.Length > 2 Then
                    With ListView1.Items.Add(s(0))
                        .SubItems.Add(s(1))
                        .SubItems.Add(s(2))
                    End With
                End If
                If Not pbarStatus.Value >= pbarStatus.Maximum Then pbarStatus.Value += 1
                c += 1
            Next
            lblStatus.Text = "Successfully imported " + c.ToString() + " of " + data.Length.ToString() + " cards"
        Else
            If My.Computer.FileSystem.FileExists(txtPath.Text) Then
                lblStatus.Text = "Importing cards from local file..."
                Dim reader As String

                reader = My.Computer.FileSystem.ReadAllText(txtPath.Text, System.Text.Encoding.GetEncoding("utf-8"))

                Dim data() As String = reader.Split(vbCrLf)
                pbarStatus.Maximum = data.Length
                For i = 0 To data.Length - 1
                    Dim s() As String = data(i).Replace("、", ",").Split(",")
                    If s.Length > 2 Then
                        With ListView1.Items.Add(s(0))
                            .SubItems.Add(s(1))
                            .SubItems.Add(s(2))
                        End With
                        pbarStatus.Value += 1
                        c += 1
                    End If
                Next
                lblStatus.Text = "Successfully imported " + c.ToString() + " of " + data.Length.ToString() + " cards"
            End If
        End If
        UpdateListCount()
        tAfterImport.Start()
        ListView1.Refresh()
    End Sub

    Private Sub UpdateListCount()
        lblCards.Text = CStr(ListView1.Items.Count) + " cards"
    End Sub

    Private Sub tAfterImport_Tick(sender As Object, e As EventArgs) Handles tAfterImport.Tick
        lblStatus.Text = "Ready"
        pbarStatus.Value = 0
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using fld As New OpenFileDialog()
            If fld.ShowDialog() = Windows.Forms.DialogResult.OK Then
                txtPath.Text = fld.FileName()
            End If
        End Using
    End Sub




    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Remove
        For Each eachItem As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(eachItem)
        Next
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        'Select all
        For i = 0 To ListView1.Items.Count - 1
            ListView1.Items(i).Selected = True
        Next i
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        frmStatistics.Show()
    End Sub
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Public Sub CloseCards()
        My.Application.OpenForms.Cast(Of Form)() _ 'closes all forms except self
             .Except({Me}) _
             .Except({frmStatistics}) _
           .ToList() _
             .ForEach(Sub(form) form.Close())
        curCards.Text = "#"
    End Sub

    Private Sub btnSaveDeck_Click(sender As Object, e As EventArgs) Handles btnSaveDeck.Click
        Dim s As String = ""
        For i = 0 To ListView1.Items.Count - 1
            With ListView1.Items(i)
                s += .Text + ","
                s += .SubItems(1).Text + ","
                s += .SubItems(2).Text + "///"
            End With
        Next
        If Not s = "" Then
            lstDecks.Items.Add(s)
            SaveDecks()
        End If
    End Sub

    Private Sub btnLoadDeck_Click(sender As Object, e As EventArgs) Handles btnLoadDeck.Click
        Try
            If lstDecks.SelectedItems.Count > 0 Then
                For x = 0 To lstDecks.SelectedItems.Count - 1
                    Dim s() As String = (lstDecks.SelectedItems(0).ToString).Replace("///", "ø").Split("ø")
                    's(0), s(1), s(2) = lines
                    For i = 0 To s.Length - 1
                        If s(i).Length > 2 Then
                            Dim str() As String = s(i).Split(",")
                            With ListView1.Items.Add(str(0))
                                .SubItems.Add(str(1))
                                .SubItems.Add(str(2))
                            End With
                        End If
                    Next

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub lstDecks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDecks.SelectedIndexChanged
        ' add preview of selected


        'enable load button
        If lstDecks.SelectedItems.Count > 0 Then
            btnLoadDeck.Enabled = True
        Else
            btnLoadDeck.Enabled = False
        End If
    End Sub

    Private Sub btnRemoveDeck_Click(sender As Object, e As EventArgs) Handles btnRemoveDeck.Click
        If lstDecks.SelectedItems.Count > 0 Then
            For i = 0 To lstDecks.SelectedItems.Count - 1
                lstDecks.Items.Remove(lstDecks.SelectedItems(0))
            Next
            SaveDecks()
        End If
    End Sub

    Private Sub btnClipboard_Click(sender As Object, e As EventArgs) Handles btnClipboard.Click
        Dim c As Integer = 0
        Try
            Dim data() As String = My.Computer.Clipboard.GetText.Split(vbCrLf)
            For i = 0 To data.Length - 1
                Dim s() As String = data(i).Split(",")
                lblStatus.Text = "Importing cards from clipboard..."
                pbarStatus.Maximum = data.Length
                If s.Length > 2 Then
                    With ListView1.Items.Add(s(0))
                        .SubItems.Add(s(1))
                        .SubItems.Add(s(2))
                    End With
                Else
                    MsgBox("Incorrect format", MsgBoxStyle.Exclamation)
                    Exit For
                End If
                pbarStatus.Value += 1
                c += 1
            Next
            lblStatus.Text = "Successfully imported " + c.ToString() + " of " + data.Length.ToString() + " cards"
            tAfterImport.Start()
        Catch ex As Exception
            MsgBox("Incorrect format", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub chkMaxCards_CheckedChanged(sender As Object, e As EventArgs) Handles chkMaxCards.CheckedChanged
        txtMaxCards.Enabled = chkMaxCards.Checked
    End Sub

    Private Sub chkNeedEigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNeedEigo.CheckedChanged
        If chkNeedEigo.Checked = True Then
            chkEigo.Checked = False
            chkEigo.Enabled = False
        Else
            chkEigo.Enabled = True
        End If
    End Sub

    Private Sub chkEigo_CheckedChanged(sender As Object, e As EventArgs) Handles chkEigo.CheckedChanged
        If chkEigo.Checked = True Then
            chkNeedEigo.Checked = False
            chkNeedEigo.Enabled = False
        Else
            chkNeedEigo.Enabled = True
        End If
    End Sub

    Private Sub btnRemoveDupes_Click(sender As Object, e As EventArgs) Handles btnRemoveDupes.Click
        rd(ListView1)
    End Sub
    Private Shared Sub rd(lv As ListView)
        Dim distictItems As ListViewItem() = lv.Items.Cast(Of ListViewItem)().Distinct(New LVItemComparer()).ToArray
        lv.BeginUpdate() ' suppress screen updates
        lv.Items.Clear()
        lv.Items.AddRange(distictItems)
        lv.EndUpdate()
    End Sub

    Private Class LVItemComparer : Implements IEqualityComparer(Of ListViewItem)
        Public Function Equals1(x As ListViewItem, y As ListViewItem) As Boolean Implements IEqualityComparer(Of ListViewItem).Equals
            Return x.Text.Equals(y.Text)
        End Function

        Public Function GetHashCode1(obj As ListViewItem) As Integer Implements IEqualityComparer(Of ListViewItem).GetHashCode
            Return obj.Text.GetHashCode
        End Function
    End Class



    Private Sub SaveDecks()
        If My.Settings.decks Is Nothing Then
            My.Settings.decks = New System.Collections.Specialized.StringCollection()
        End If

        My.Settings.decks.Clear()
        For Each item In lstDecks.Items
            My.Settings.decks.Add(item)
        Next
        My.Settings.Save()
    End Sub

    Private Sub LoadDecks()
        If My.Settings.decks Is Nothing Then
            My.Settings.decks = New System.Collections.Specialized.StringCollection()
        End If

        For Each item In My.Settings.decks
            lstDecks.Items.Add(item)
        Next
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()

        'Save cards if chosen
        If chkKeepCards.Checked = True Then



        End If
    End Sub

    Private Sub LoadSettings()
        'BY ORDER TOP LEFT TO RIGHT AS OF CREATION
        'txtTime, txtInterval, txtPath, chkReplay, txtPanic, txtPanic2, chkTip, chkAnswer, chkMultipleCards, chkEigo, chkNeedEigo, chkKeepCards, chkMaxCards, txtMaxCards, txtEigoChars
        Dim s() As String = My.Settings.settei.Split(",")
        For i = 0 To s.Length - 1
            If s(i).Contains("txtTime") Then Dim t() As String = s(i).Split(">") : txtTime.Text = t(1)
            If s(i).Contains("txtInterval") Then Dim t() As String = s(i).Split(">") : txtInterval.Text = t(1)
            If s(i).Contains("txtPath") Then Dim t() As String = s(i).Split(">") : txtPath.Text = t(1)
            If s(i).Contains("txtPanic") Then Dim t() As String = s(i).Split(">") : txtPanic.Text = t(1)
            If s(i).Contains("txtPanic2") Then Dim t() As String = s(i).Split(">") : txtPanic2.Text = t(1)
            If s(i).Contains("txtMaxCards") Then Dim t() As String = s(i).Split(">") : txtMaxCards.Text = t(1)
            If s(i).Contains("txtEigoChars") Then Dim t() As String = s(i).Split(">") : txtEigoChars.Text = t(1)

            If s(i).Contains("chkReplay") Then Dim t() As String = s(i).Split(">") : chkReplay.Checked = t(1)
            If s(i).Contains("chkTip") Then Dim t() As String = s(i).Split(">") : chkTip.Checked = t(1)
            If s(i).Contains("chkAnswer") Then Dim t() As String = s(i).Split(">") : chkAnswer.Checked = t(1)
            If s(i).Contains("chkMultipleCards") Then Dim t() As String = s(i).Split(">") : chkMultipleCards.Checked = t(1)
            If s(i).Contains("chkEigo") Then Dim t() As String = s(i).Split(">") : chkEigo.Checked = t(1)
            If s(i).Contains("chkNeedEigo") Then Dim t() As String = s(i).Split(">") : chkNeedEigo.Checked = t(1)
            If s(i).Contains("chkKeepCards") Then Dim t() As String = s(i).Split(">") : chkKeepCards.Checked = t(1)
            If s(i).Contains("chkMaxCards") Then Dim t() As String = s(i).Split(">") : chkMaxCards.Checked = t(1)
            'do checkboxes
        Next

    End Sub

    Private Sub SaveSettings()
        Dim s As String
        s += "txtTime>" + txtTime.Text + ","
        s += "txtInterval>" + txtInterval.Text + ","
        s += "txtPath>" + txtPath.Text + ","
        s += "txtPanic>" + txtPanic.Text + ","
        s += "txtPanic2>" + txtPanic2.Text + ","
        s += "txtMaxCards>" + txtMaxCards.Text + ","
        s += "txtEigoChars>" + txtEigoChars.Text + ","

        s += "chkReplay>" + CStr(chkReplay.Checked) + ","
        s += "chkTip>" + CStr(chkTip.Checked) + ","
        s += "chkAnswer>" + CStr(chkAnswer.Checked) + ","
        s += "chkMultipleCards>" + CStr(chkMultipleCards.Checked) + ","
        s += "chkEigo>" + CStr(chkEigo.Checked) + ","
        s += "chkNeedEigo>" + CStr(chkNeedEigo.Checked) + ","
        s += "chkKeepCards>" + CStr(chkKeepCards.Checked) + ","
        s += "chkMaxCards>" + CStr(chkMaxCards.Checked) + ","

        If My.Settings.decks Is Nothing Then
            My.Settings.decks = New System.Collections.Specialized.StringCollection()
        End If

        My.Settings.settei = s
        My.Settings.Save()

    End Sub

    Private Sub lstDecks_DoubleClick(sender As Object, e As EventArgs) Handles lstDecks.DoubleClick
        btnLoadDeck_Click(sender, e)
    End Sub

    Private Sub btnClearListView_Click(sender As Object, e As EventArgs) Handles btnClearListView.Click
        ListView1.Items.Clear()
    End Sub

End Class
