Imports System.Data.OleDb
Public Class Form7
    Private CN As OleDbConnection
    Private Sub Form7_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CN.Close()
    End Sub
    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CN = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Stock.mdb;")
        CN.Open()
        GetIDs()
        cboStockID.SelectedIndex = 0
        ReadRecord()
    End Sub
    Private Function GetIDs() As Integer
        Dim strSQL As String = "SELECT StockID FROM tblItem ORDER BY StockID"
        Dim CM As New OleDbCommand(strSQL, CN)
        Dim DR As OleDbDataReader = CM.ExecuteReader
        Dim intCountRecs As Integer = 0
        Do While DR.Read
            cboStockID.Items.Add(DR.Item("StockID"))
            intCountRecs += 1
        Loop
        Return intCountRecs
    End Function
  Private Sub ReadRecord()
        Dim strStockID As String = cboStockID.Text
        If cboStockID.Text = "" Then Exit Sub
        Dim strSQL As String = "SELECT * FROM tblItem WHERE StockID = '" & strStockID & "'"
        Dim CM As New OleDbCommand(strSQL, CN)
        Dim DR As OleDbDataReader = CM.ExecuteReader
        DR.Read()
        txtDescription.Text = DR.Item("Description").ToString
        txtPrice.Text = DR.Item("Price").ToString
        txtQuantityInStock.Text = DR.Item("QuantityInStock").ToString
        txtReorderLevel.Text = DR.Item("ReorderLevel").ToString
        txtReorderQuantity.Text = DR.Item("ReorderQuantity").ToString
        txtDateLastOrder.Text = DR.Item("DateLastOrder").ToString
        txtWhetherRecieved.Text = DR.Item("WhetherRecieved").ToString
    End Sub
    Private Sub cboStockID_SelectedIndexChanged(ByVal sender As System.Object,ByVal e As System.EventArgs) Handles cboStockID.SelectedIndexChanged
        If cboStockID.Text = "" Then
            ClearBoxes()
        Else
            ReadRecord()
        End If
    End Sub
    Private Sub clearBoxes()
        cboStockID.Items.Clear()
        txtDescription.Clear()
        txtPrice.Clear()
        txtQuantityInStock.Clear()
        txtReorderLevel.Clear()
        txtReorderQuantity.Clear()
        txtDateLastOrder.Clear()
        txtWhetherRecieved.Clear()
    End Sub
    Private Sub UpDateIDs()
        Dim intSelRow As Integer = cboStockID.SelectedIndex
        Dim strStockID As String = cboStockID.Text
        cboStockID.Items.Clear()
        Dim intCountRecs As Integer = GetIDs()
        If intCountRecs > 0 Then
            If intSelRow >= 0 Then
                If intSelRow >= cboStockID.Items.Count Then
                    intSelRow -= 1
                End If
                cboStockID.SelectedIndex = intSelRow
            Else
            End If
        Else
            clearBoxes()
        End If
    End Sub
    Private Sub btnInsert_Click(sender As System.Object, e As System.EventArgs) Handles btnInsert.Click
        Dim strStockID As String = cboStockID.Text
        If strStockID = "" Then Exit Sub
        Dim strDescription As String = txtDescription.Text
        Dim sngPrice As Single = CSng(txtPrice.Text)
        Dim intQuantityInStock As Integer = CInt("0" & txtQuantityInStock.Text)
        Dim intReorderLevel As Integer = CInt("0" & txtReorderLevel.Text)
        Dim intReorderQuantity As Integer = CInt("0" & txtReorderQuantity.Text)
        Dim strDateLastOrder As String = CDate(txtDateLastOrder.Text)
        Dim strWhetherRecieved As String = CBool(txtWhetherRecieved.Text)
        Dim strSQL As String = "INSERT INTO tblItem VALUES('" & strStockID & "','" & strDescription & "'," & sngPrice & "," & intQuantityInStock & "," & intReorderLevel & "," & intReorderQuantity & ",#" & strDateLastOrder & "#," & strWhetherRecieved & ")"
        Dim CM As New OleDbCommand(strSQL, CN)
        CM.ExecuteNonQuery()
        UpDateIDs()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim strStockID As String = cboStockID.Text
        If strStockID = "" Then Exit Sub
        Dim strDescription As String = txtDescription.Text
        Dim sngPrice As Single = CSng(txtPrice.Text)
        Dim intQuantityInStock As Integer = CInt("0" & txtQuantityInStock.Text)
        Dim intReorderLevel As Integer = CInt("0" & txtReorderLevel.Text)
        Dim intReorderQuantity As Integer = CInt("0" & txtReorderQuantity.Text)
        Dim strDateLastOrder As String = CDate(txtDateLastOrder.Text)
        Dim strWhetherRecieved As String = CBool(txtWhetherRecieved.Text)
        Dim strSQL As String = "UPDATE tblItem SET " & "Description='" & strDescription & "'," & "Price=" & sngPrice & "," & "QuantityInStock=" & intQuantityInStock & "," & "ReorderLevel=" & intReorderLevel & "," & "ReorderQuantity=" & intReorderQuantity & "," & "DateLastOrder=#" & strDateLastOrder & "#," & "WhetherRecieved=" & strWhetherRecieved & " " & "WHERE StockID = '" & strStockID & "'"
        Dim CM As New OleDbCommand(strSQL, CN)
        CM.ExecuteNonQuery()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim strStockID As String = cboStockID.Text
        If strStockID = "" Then Exit Sub
        Dim strSQL As String = "DELETE FROM tblItem " & "WHERE StockID = '" & strStockID & "'"
        Dim CM As New OleDbCommand(strSQL, CN)
        CM.ExecuteNonQuery()
        UpDateIDs()
    End Sub
End Class