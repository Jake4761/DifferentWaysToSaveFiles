Imports System.Data.OleDb
Public Class Form6
    Private CN As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Stock.mdb;")
    Private DA As OleDbDataAdapter
    Private DT As New DataTable
    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitDGV()
        ReadDB()
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
    Private Sub ReadDB()
        DA = New OleDbDataAdapter("SELECT * FROM tblItem", CN)
        DA.Fill(DT)
        DGV.DataSource = DT
    End Sub
    Private Sub DGV_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.RowEnter
        txtStockID.Text = DGV.Item("StockID", e.RowIndex).Value.ToString
        txtDescription.Text = DGV.Item("Description", e.RowIndex).Value.ToString
        txtPrice.Text = DGV.Item("Price", e.RowIndex).Value.ToString
        txtQuantityInStock.Text = DGV.Item("QuantityInStock", e.RowIndex).Value.ToString
        txtReorderLevel.Text = DGV.Item("ReorderLevel", e.RowIndex).Value.ToString
        txtReorderQuantity.Text = DGV.Item("ReorderQuantity", e.RowIndex).Value.ToString
        txtDateLastOrder.Text = DGV.Item("DateLastOrder", e.RowIndex).Value.ToString
        txtWhetherRecieved.Text = DGV.Item("WhetherRecieved", e.RowIndex).Value.ToString
    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim DR As DataRow = DT.NewRow
        DR("StockID") = txtStockID.Text
        DR("Description") = txtDescription.Text
        DR("Price") = CSng(txtPrice.Text)
        DR("QuantityInStock") = CInt("0" & txtQuantityInStock.Text)
        DR("ReorderLevel") = CInt("0" & txtReorderLevel.Text)
        DR("ReorderQuantity") = CInt("0" & txtReorderQuantity.Text)
        DR("DateLastOrder") = CDate(txtDateLastOrder.Text)
        DR("WhetherRecieved") = CBool(txtWhetherRecieved.Text)
        DT.Rows.Add(DR)
        DGV.CurrentCell = DGV.Item(0, DGV.RowCount - 1)
    End Sub
    Private Sub btnAmend_Click(sender As System.Object, e As System.EventArgs) Handles btnAmend.Click
        DGV.Item("StockID", DGV.CurrentRow.Index).Value = txtStockID.Text
        DGV.Item("Description", DGV.CurrentRow.Index).Value = txtDescription.Text
        DGV.Item("Price", DGV.CurrentRow.Index).Value = CStr(txtPrice.Text)
        DGV.Item("QuantityInStock", DGV.CurrentRow.Index).Value = CInt("0" & txtQuantityInStock.Text)
        DGV.Item("ReorderLevel", DGV.CurrentRow.Index).Value = CInt("0" & txtReorderLevel.Text)
        DGV.Item("ReorderQuantity", DGV.CurrentRow.Index).Value = CInt("0" & txtReorderQuantity.Text)
        DGV.Item("DateLastOrder", DGV.CurrentRow.Index).Value = CDate(txtDateLastOrder.Text)
        DGV.Item("WhetherRecieved", DGV.CurrentRow.Index).Value = CBool(txtWhetherRecieved.Text)
        DGV.BindingContext(DT).EndCurrentEdit()
    End Sub
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        If DGV.RowCount = 0 Then Exit Sub
        Dim intSelRow = DGV.CurrentRow.Index
        DGV.Rows.RemoveAt(intSelRow)
        If DGV.RowCount = 0 Then
            clearBoxes()
        Else
            If intSelRow = DGV.RowCount Then
                intSelRow -= 1
            End If
            DGV.CurrentCell = DGV.Item(0, intSelRow)
            DGV.Item(0, intSelRow).Selected = True
        End If
    End Sub
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim CB As OleDbCommandBuilder = New OleDbCommandBuilder(DA)
        DA.Update(DT)
    End Sub
End Class