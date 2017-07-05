Imports System.IO
Imports System.Text
Public Class Form3
    Private Const strFileName As String = "File1.txt"
    Private intNumRecs As Integer = 0
    Private intCurrRec As Integer = 0
    Private strRecord As String = ""
    Private intRecLen As Integer = intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen + intReorderLevelLen + intReorderQuantityLen + intDateLastOrderLen + intWhetherRecievedLen + 2
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ReadFile()
        If intNumRecs > 0 Then
            intCurrRec = 1
            ReadRecord()
        Else
            ShowPosition()
        End If
    End Sub
    Private Sub ReadFile()
        If Not File.Exists(strFileName) Then
            File.Create(strFileName)
        End If
        intNumRecs = CInt(FileLen(strFileName) / intRecLen)
    End Sub
    Private Sub ShowPosition()
        lblWhere.Text = intCurrRec & "/" & intNumRecs
    End Sub
    Private Sub ReadRecord()
        Dim FS As New FileStream(strFileName, FileMode.Open, FileAccess.Read)
        FS.Seek((intCurrRec - 1) * intRecLen, SeekOrigin.Begin)
        Dim byteArray(intRecLen) As Byte
        FS.Read(byteArray, 0, intRecLen)
        FS.Close()
        Dim enc As New UTF8Encoding
        strRecord = enc.GetString(byteArray)
        OutputRecord()
    End Sub
    Private Sub OutputRecord()
        txtStockID.Text = StrRecord.Substring(0, intStockIdLen)
        txtDescription.Text = StrRecord.Substring(intStockIdLen, intDescriptionLen).TrimEnd
        txtPrice.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen, intPriceLen)
        txtQuantityInStock.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen, intQuantityInStockLen)
        txtReorderLevel.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen, intReorderLevelLen)
        txtReorderQuantity.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen + intReorderLevelLen, intReorderQuantityLen)
        txtDateLastOrder.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen + intReorderLevelLen + intReorderQuantityLen, intDateLastOrderLen)
        txtWhetherRecieved.Text = strRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen + intReorderLevelLen + intReorderQuantityLen + intDateLastOrderLen, intWhetherRecievedLen).Trim
    End Sub
    Private Function InputRecord() As String
        Dim strStockID As String = txtStockID.Text.PadLeft(intStockIdLen, ChrW(48))
        Dim StrDescription As String = txtDescription.Text.PadRight(intDescriptionLen, ChrW(32))
        Dim strPrice As String = txtPrice.Text.PadLeft(intPriceLen, ChrW(48))
        Dim strQuantityInStock As String = txtQuantityInStock.Text.PadLeft(intQuantityInStockLen, ChrW(48))
        Dim strReorderLevel As String = txtReorderLevel.Text.PadLeft(intReorderLevelLen, ChrW(48))
        Dim strReorderQuantity As String = txtReorderQuantity.Text.PadLeft(intReorderQuantityLen, ChrW(48))
        Dim strDateLastOrder As String = txtDateLastOrder.Text.PadRight(intDateLastOrderLen, ChrW(32))
        Dim strWhetherRecived As String = txtWhetherRecieved.Text.PadRight(intWhetherRecievedLen, ChrW(32))
        Return strStockID & StrDescription & strPrice & strQuantityInStock & strReorderLevel & strReorderQuantity & strDateLastOrder & strWhetherRecived & vbCrLf
    End Function
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
            ReadRecord()
        End If
    End Sub
    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If intCurrRec <= intNumRecs And intCurrRec <> 1 Then
            intCurrRec -= 1
            ReadRecord()
        End If
    End Sub
    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        strRecord = InputRecord()
        Dim FS As New FileStream(strFileName, FileMode.Open, FileAccess.Write)
        FS.Seek(intNumRecs * intRecLen, SeekOrigin.Begin)
        Dim enc As New UTF8Encoding
        FS.Write(enc.GetBytes(strRecord), 0, intRecLen)
        FS.Close()
        intNumRecs += 1
        intCurrRec = intNumRecs
        ShowPosition()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If intCurrRec > 0 Then
            strRecord = InputRecord()
            Dim FS As New FileStream(strFileName, FileMode.Open, FileAccess.Write)
            FS.Seek((intCurrRec - 1) * intRecLen, SeekOrigin.Begin)
            Dim enc As New UTF8Encoding
            FS.Write(enc.GetBytes(strRecord), 0, intRecLen)
            FS.Close()
        End If
    End Sub
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If intNumRecs = 0 Then Exit Sub
        CopyWithDelete()
        intNumRecs -= 1
        If intNumRecs = 0 Then
            intCurrRec = 0
            clearBoxes()
            ShowPosition()
        Else
            If intCurrRec > intNumRecs Then
                intCurrRec -= 1
            End If
            ReadRecord()
        End If
    End Sub
    Private Sub CopyWithDelete()
        Dim FSOld As New FileStream(strFileName, FileMode.Open, FileAccess.Read)
        Dim FSNew As New FileStream("temp", FileMode.Create, FileAccess.Write)
        Dim byteArray(intRecLen) As Byte
        Dim intWrite As Integer = 0
        For intRead As Integer = 0 To intNumRecs - 1
            If intRead <> intCurrRec - 1 Then
                FSOld.Seek(intRead * intRecLen, SeekOrigin.Begin)
                FSOld.Read(byteArray, 0, intRecLen)
                FSNew.Seek(intWrite * intRecLen, SeekOrigin.Begin)
                FSNew.Write(byteArray, 0, intRecLen)
                intWrite += 1
            End If
        Next
        FSOld.Close()
        FSNew.Close()
        My.Computer.FileSystem.DeleteFile(strFileName)
        My.Computer.FileSystem.RenameFile("temp", strFileName)
    End Sub
End Class