Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class Form5
    Private Const strFileName As String = "File5.bin"
    Private intNumRecs As Integer = 0
    Private intCurrRec As Integer = 0
    Private ItemList As New List(Of Item)
    Private blnStopAuto As Boolean = False
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitDGV()
        ReadFile()
        ShowPosition()
    End Sub
    Private Sub ShowPosition()
        lblWhere.Text = intCurrRec & "/" & intNumRecs
    End Sub
    Private Sub InitDGV()
        DGV.Font = New Font("Microsoft Sans Serif", 11, FontStyle.Regular)
        DGV.RowHeadersVisible = False
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DGV.ReadOnly = True
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
            DGV.CurrentCell = DGV.Item(0, intCurrRec - 1)
        End If
    End Sub
    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        If intCurrRec <= intNumRecs And intCurrRec <> 0 Then
            intCurrRec -= 1
            DGV.CurrentCell = DGV.Item(0, intCurrRec - 1)
        End If
    End Sub
    Private Sub DGV_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.RowEnter
        If Not blnStopAuto Then
            intCurrRec = e.RowIndex + 1
            OutputRecord()
        End If
    End Sub
    Private Sub ReadFile()
        Dim FS As New FileStream(strFileName, FileMode.OpenOrCreate, FileAccess.Read)
        If FileLen(strFileName) > 0 Then
            Dim BF As New BinaryFormatter
            ItemList = DirectCast(BF.Deserialize(FS), List(Of Item))
            intNumRecs = ItemList.Count
            intCurrRec = 1
            UpdateDGV()
            OutputRecord()
        End If
        FS.Close()
    End Sub
    Private Sub UpdateDGV()
        blnStopAuto = True
        DGV.DataSource = Nothing
            If ItemList.Count > 0 Then
            DGV.DataSource = ItemList
            DGV.CurrentCell = DGV.Item(0, intCurrRec - 1)
            End If
        blnStopAuto = False
    End Sub
    Private Sub OutputRecord()
        txtStockID.Text = ItemList(intCurrRec - 1).StockID
        txtDescription.Text = ItemList(intCurrRec - 1).Description
        txtPrice.Text = ItemList(intCurrRec - 1).Price.ToString
        txtQuantityInStock.Text = ItemList(intCurrRec - 1).QuantityinStock.ToString
        txtReorderLevel.Text = ItemList(intCurrRec - 1).ReorderLevel.ToString
        txtReorderQuantity.Text = ItemList(intCurrRec - 1).ReorderQuantity.ToString
        txtDateLastOrder.Text = ItemList(intCurrRec - 1).DateLastOrder.ToString
        txtWhetherRecieved.Text = ItemList(intCurrRec - 1).WhetherRecieved.ToString
        ShowPosition()
    End Sub
    Private Function InputRecord() As Item
        Dim AnItem As New Item
        AnItem.StockID = txtStockID.Text
        AnItem.Description = txtDescription.Text
        AnItem.Price = CSng(txtPrice.Text)
        AnItem.QuantityinStock = CInt("0" & txtQuantityInStock.Text)
        AnItem.ReorderLevel = CInt("0" & txtReorderLevel.Text)
        AnItem.ReorderQuantity = CInt("0" & txtReorderQuantity.Text)
        AnItem.DateLastOrder = CDate(txtDateLastOrder.Text)
        AnItem.WhetherRecieved = CBool(txtWhetherRecieved.Text)
        Return AnItem
    End Function
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        ItemList.Add(InputRecord)
        intNumRecs += 1
        intCurrRec = intNumRecs
        UpdateDGV()
        OutputRecord()
    End Sub
    Private Sub btnAmend_Click(sender As System.Object, e As System.EventArgs) Handles btnAmend.Click
        ItemList(intCurrRec - 1) = InputRecord()
        UpdateDGV()
        OutputRecord()
    End Sub
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If intNumRecs = 0 Then Exit Sub
        ItemList.RemoveAt(intCurrRec - 1)
        intNumRecs -= 1
        If intNumRecs = 0 Then
            intCurrRec = 0
            clearBoxes()
            ShowPosition()
        Else
            If intCurrRec > intNumRecs Then
                intCurrRec -= 1
            End If
            OutputRecord()
        End If
        UpdateDGV()
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim FS As New FileStream(strFileName, FileMode.Create)
        Dim BF As New BinaryFormatter
        BF.Serialize(FS, ItemList)
        FS.Close()
    End Sub
End Class