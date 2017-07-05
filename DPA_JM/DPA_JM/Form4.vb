Imports System.IO
Public Class Form4
    Private Const strFileName As String = "File4.xml"
    Private intNumRecs As Integer = 0
    Private intCurrRec As Integer = 0
    Private DT As New DataTable("Items")
    Private blnStopAuto As Boolean = False
    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
    Private Sub InitDT()
        DT.Columns.Add(New DataColumn("StockID", GetType(String)))
        DT.Columns.Add(New DataColumn("Description", GetType(String)))
        DT.Columns.Add(New DataColumn("Price", GetType(Single)))
        DT.Columns.Add(New DataColumn("QuantityInStock", GetType(Integer)))
        DT.Columns.Add(New DataColumn("ReorderLevel", GetType(Integer)))
        DT.Columns.Add(New DataColumn("ReorderQuantity", GetType(Integer)))
        DT.Columns.Add(New DataColumn("DateLastOrder", GetType(String)))
        DT.Columns.Add(New DataColumn("WhetherRecieved", GetType(Boolean)))
    End Sub
    Private Sub ReadFile()
        Dim FS As New FileStream(strFileName, FileMode.OpenOrCreate, FileAccess.Read)
        If FileLen(strFileName) > 0 Then
            DT.ReadXmlSchema(strFileName)
            DT.ReadXml(strFileName)
            intNumRecs = DT.Rows.Count
            intCurrRec = 1
            OutputRecord()
        Else
            InitDT()
        End If
        FS.Close()
        blnStopAuto = True
        DGV.DataSource = DT
        blnStopAuto = False
    End Sub
    Private Sub OutputRecord()
        txtStockID.Text = DT(intCurrRec - 1)("StockID").ToString
        txtDescription.Text = DT(intCurrRec - 1)("Description").ToString
        txtPrice.Text = DT(intCurrRec - 1)("Price").ToString
        txtQuantityInStock.Text = DT(intCurrRec - 1)("QuantityInStock").ToString
        txtReorderLevel.Text = DT(intCurrRec - 1)("ReorderLevel").ToString
        txtReorderQuantity.Text = DT(intCurrRec - 1)("ReorderQuantity").ToString
        txtDateLastOrder.Text = DT(intCurrRec - 1)("DateLastOrder").ToString
        txtWhetherRecieved.Text = DT(intCurrRec - 1)("WhetherRecieved").ToString
        ShowPosition()
    End Sub
    Private Sub InputRecord(ByRef DR As DataRow)
        DR("StockID") = txtStockID.Text
        DR("Description") = txtDescription.Text
        DR("Price") = txtPrice.Text
        DR("QuantityInStock") = CInt("0" & txtQuantityInStock.Text)
        DR("ReorderLevel") = CInt("0" & txtReorderLevel.Text)
        DR("ReorderQuantity") = CInt("0" & txtReorderQuantity.Text)
        DR("DateLastOrder") = txtDateLastOrder.Text
        DR("WhetherRecieved") = txtWhetherRecieved.Text
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
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim DR As DataRow = DT.NewRow
        InputRecord(DR)
        blnStopAuto = True
        DT.Rows.Add(DR)
        blnStopAuto = False
        intNumRecs += 1
        intCurrRec = intNumRecs
        DGV.CurrentCell = DGV.Item(0, intCurrRec - 1)
    End Sub
    Private Sub btnAmend_Click(sender As System.Object, e As System.EventArgs) Handles btnAmend.Click
        InputRecord(DT.Rows(intCurrRec - 1))
    End Sub
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If intNumRecs = 0 Then Exit Sub
        blnStopAuto = True
        DT.Rows.RemoveAt(intCurrRec - 1)
        blnStopAuto = False
        intNumRecs -= 1
        If intNumRecs = 0 Then
            intCurrRec = 0
            clearBoxes()
            ShowPosition()
        Else
            If intCurrRec > intNumRecs Then
                intCurrRec -= 1
            End If
            DGV.CurrentCell = DGV.Item(0, intCurrRec - 1)
            DGV.Item(0, intCurrRec - 1).Selected = True
            OutputRecord()
        End If
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        DT.WriteXmlSchema(strFileName)
        DT.WriteXml(strFileName)
    End Sub
End Class