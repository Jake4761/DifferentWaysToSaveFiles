Imports System.IO
Public Class Form2
    Private Const strFileName As String = "File2.txt"
    Private intNumRecs As Integer = 0
    Private intCurrRec As Integer = 0
    Private RecordList As New List(Of String)
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ReadFile()
        If intNumRecs > 0 Then
            intCurrRec = 1
            OutputRecord()
        Else
            ShowPosition()
        End If
    End Sub
    Private Sub ShowPosition()
        lblWhere.Text = intCurrRec & "/" & intNumRecs
    End Sub
    Private Sub ReadFile()
        Dim FS As New FileStream(strFileName, FileMode.OpenOrCreate, FileAccess.Read)
        Dim SR As New StreamReader(FS)
        Do Until SR.EndOfStream
            RecordList.Add(SR.ReadLine)
            intNumRecs += 1
        Loop
        SR.Close()
        FS.Close()
    End Sub
    Private Sub OutputRecord()
        Dim strFields() As String = RecordList(intCurrRec - 1).Split(Chr(124))
        txtStockID.Text = strFields(0)
        txtDescription.Text = strFields(1)
        txtPrice.Text = strFields(2)
        txtQuantityInStock.Text = strFields(3)
        txtReorderLevel.Text = strFields(4)
        txtReorderQuantity.Text = strFields(5)
        txtDateLastOrder.Text = strFields(6)
        txtWhetherRecieved.Text = strFields(7)
        ShowPosition()
    End Sub
    Private Function InputRecord() As String
        Dim strStockID As String = txtStockID.Text
        Dim strDescription As String = txtDescription.Text
        Dim strPrice As String = txtPrice.Text
        Dim strQuantityInStock As String = txtQuantityInStock.Text
        Dim strReorderLevel As String = txtReorderLevel.Text
        Dim strReorderQuantity As String = txtReorderQuantity.Text
        Dim strDateLastOrder As String = txtDateLastOrder.Text
        Dim strWhetherRecieved As String = txtWhetherRecieved.Text
        Return strStockID & "|" & strDescription & "|" & strPrice & "|" & strQuantityInStock & "|" & strReorderLevel & "|" & strReorderQuantity & "|" & strDateLastOrder & "|" & strWhetherRecieved
    End Function
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        RecordList.Add(InputRecord)
        intNumRecs += 1
        intCurrRec = intNumRecs
        OutputRecord()
    End Sub
    Private Sub btnAmend_Click(sender As System.Object, e As System.EventArgs) Handles btnAmend.Click
        RecordList(intCurrRec - 1) = InputRecord()
        OutputRecord()
    End Sub
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If intNumRecs = 0 Then Exit Sub
        RecordList.RemoveAt(intCurrRec - 1)
        intNumRecs -= 1
        If intNumRecs = 0 Then
            intCurrRec = 0
            ClearBoxes()
            ShowPosition()
        Else
            If intCurrRec > intNumRecs Then
                intCurrRec -= 1
            End If
            OutputRecord()
        End If
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SW As New StreamWriter(strFileName)
        For Each Item In RecordList
            SW.WriteLine(Item)
        Next
        SW.Close()
        MsgBox("Saved!")
    End Sub
    Private Sub clearBoxes()
        txtStockID.Clear()
        txtDescription.Clear()
        txtPrice.Clear()
        txtQuantityInStock.Clear()
        txtReorderLevel.Clear()
        txtReorderQuantity.Clear()
        txtDateLastOrder.Clear()
        txtWhetherRecieved.Clear()
    End Sub
    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        If intCurrRec < intNumRecs Then
            intCurrRec += 1
            OutputRecord()
        End If
    End Sub
    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If intCurrRec <= intNumRecs And intCurrRec <> 1 Then
            intCurrRec -= 1
            OutputRecord()
        End If
    End Sub
End Class