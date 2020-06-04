Imports System.IO
Public Class frmStatistics
    Private Sub frmStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub RefreshListView(ByVal r As Integer, ByVal kanji As String, ByVal correct As String, ByVal eigo As String, ByVal created As DateTime)
        'r: 0 is wrong, 1 is right
        'LISTVIEW" 0KANJI, 1CORRECT, 2INCORRECT, 3%CORRECT, 4AVGTIME, 5MEANING
        'If kanji entry already exists
        Dim exists As Boolean = False
        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).Text = kanji Then
                exists = True
                With ListView1.Items(i)
                    If r = 1 Then .SubItems(1).Text = CStr(CInt(.SubItems(1).Text) + 1)
                    If r = 0 Then .SubItems(2).Text = CStr(CInt(.SubItems(2).Text) + 1)
                    .SubItems(3).Text = CStr((CInt(.SubItems(1).Text) / (CInt(.SubItems(1).Text) + CInt(.SubItems(2).Text))) * 100) + "%"
                    .SubItems(4).Text += CStr((TimeOfDay - created).Seconds) + "`"
                    'Insert avg here maybe
                    .SubItems(5).Text = eigo
                End With
            End If
        Next
        If exists = False Then
            'Kanji doesn\t exist, add new
            With ListView1.Items.Add(kanji)
                If r = 1 Then .SubItems.Add("1") : .SubItems.Add("0")
                If r = 0 Then .SubItems.Add("0") : .SubItems.Add("1")
                .SubItems.Add(CStr((CInt(.SubItems(1).Text) / (CInt(.SubItems(1).Text) + CInt(.SubItems(2).Text))) * 100) + "%")
                .SubItems.Add("")
                .SubItems(4).Text += CStr((TimeOfDay - created).Seconds) + "`"

                .SubItems.Add(eigo)
            End With
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim s As String = ""
        For i = 0 To ListView1.Items.Count - 1
            With ListView1.Items(i)
                s += .Text + ","
                s += .SubItems(1).Text + ","
                s += .SubItems(2).Text + ","
                s += .SubItems(3).Text + ","
                s += .SubItems(4).Text + ","
                s += .SubItems(5).Text
                If i > ListView1.Items.Count - 1 Then s += vbNewLine
            End With
        Next
        Dim sfd As New SaveFileDialog
        sfd.DefaultExt = "*.csv"
        sfd.Filter = "CSV File (.csv)|*.csv"
        sfd.FileName = "List"
        If sfd.ShowDialog() Then
            If sfd.FileName.Length > 0 Then
                Dim path As String = sfd.FileName
                Using wr As New StreamWriter(path, False)
                    wr.WriteLine(s)
                End Using
            End If
        End If
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.DefaultExt = "*.csv"
            ofd.Filter = "CSV File (.csv)|*.csv"
            If ofd.ShowDialog() Then
                If ofd.FileName.Length > 0 Then
                    Dim path As String = ofd.FileName
                    Dim reader As StreamReader = New StreamReader(path, System.Text.Encoding.GetEncoding("utf-8"))
                    Dim data() As String = reader.ReadToEnd.Split(vbCrLf)
                    For i = 0 To data.Length - 1
                        If Not data(i) = "" Then
                            If Not data(i) = " " Then
                                Dim s() As String = data(i).Split(",")
                                If s.Length > 5 Then
                                    With ListView1.Items.Add(s(0))
                                        .SubItems.Add(s(1))
                                        .SubItems.Add(s(2))
                                        .SubItems.Add(s(3))
                                        .SubItems.Add(s(4))
                                        .SubItems.Add(s(5))
                                    End With
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub btnMakeDeck_Click(sender As Object, e As EventArgs) Handles btnMakeDeck.Click
        'Have a form pop up with jouken and make u able to basically make a deck from e.g. under 60% correct etc,

    End Sub
End Class