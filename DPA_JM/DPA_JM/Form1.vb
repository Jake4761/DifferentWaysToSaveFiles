Imports System.IO
Public Class Form1
    Private Const strFileName As String = "File1.txt"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReadFile()
        If ListBox1.Items.Count > 0 Then
            ListBox1.SelectedIndex = 0
        End If
    End Sub
    Private Sub ReadFile()
        Dim FS As New FileStream(strFileName, FileMode.OpenOrCreate, FileAccess.Read)
        Dim SR As New StreamReader(FS)
        Do Until SR.EndOfStream
            ListBox1.Items.Add(SR.ReadLine)
        Loop
        SR.Close()
        FS.Close()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            OutputRecord(ListBox1.SelectedItem.ToString)
        End If
    End Sub
    Private Sub OutputRecord(ByVal StrRecord As String)
        txtStockID.Text = StrRecord.Substring(0, intStockIdLen)
        txtDescription.Text = StrRecord.Substring(intStockIdLen, intDescriptionLen).TrimEnd
        txtPrice.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen, intPriceLen)
        txtQuantityInStock.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen, intQuantityInStockLen)
        txtReorderLevel.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen, intReorderLevelLen)
        txtReorderQuantity.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen + intReorderLevelLen, intReorderQuantityLen)
        txtDateLastOrder.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen + intReorderLevelLen + intReorderQuantityLen, intDateLastOrderLen)
        txtWhetherRecieved.Text = StrRecord.Substring(intStockIdLen + intDescriptionLen + intPriceLen + intQuantityInStockLen + intReorderLevelLen + intReorderQuantityLen + intDateLastOrderLen, intWhetherRecievedLen)
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
        Return strStockID & StrDescription & strPrice & strQuantityInStock & strReorderLevel & strReorderQuantity & strDateLastOrder & strWhetherRecived
    End Function
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        ListBox1.Items.Add(InputRecord)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub
    Private Sub btnAmend_Click(sender As System.Object, e As System.EventArgs) Handles btnAmend.Click
        ListBox1.Items(ListBox1.SelectedIndex) = InputRecord()
    End Sub
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim intNumRecs As Integer = ListBox1.Items.Count
        If intNumRecs > 0 Then
            Dim intSelRec As Integer = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(intSelRec)
            intNumRecs -= 1
            If intNumRecs = 0 Then
                ClearBoxes()
            Else
                If intSelRec = intNumRecs Then
                    intSelRec -= 1
                End If
                ListBox1.SelectedIndex = intSelRec
            End If
        End If
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
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SW As New StreamWriter(strFileName)
        For Each item In ListBox1.Items
            SW.WriteLine(item)
        Next
        SW.Close()
    End Sub
End Class
