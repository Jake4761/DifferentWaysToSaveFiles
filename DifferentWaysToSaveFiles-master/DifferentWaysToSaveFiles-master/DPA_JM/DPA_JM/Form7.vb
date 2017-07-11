Imports System.Data.OleDb
Imports Word = Microsoft.Office.Interop.Word
Public Class Form7
    Private CN As OleDbConnection
    Private Sub Form7_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CN.Close()
    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub cboStockID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStockID.SelectedIndexChanged
        If cboStockID.Text = "" Then
            clearBoxes()
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
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim strStockID As String = cboStockID.Text
        If strStockID = "" Then Exit Sub
        Dim strSQL As String = "DELETE FROM tblItem " & "WHERE StockID = '" & strStockID & "'"
        Dim CM As New OleDbCommand(strSQL, CN)
        CM.ExecuteNonQuery()
        UpDateIDs()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim sngTotalHeld As Single = 0
        Dim sngTotalOnOrder As Single = 0
        Dim objWord As Word.Application
        Dim objDoc As Word.Document
        Dim objPara1, objPara2 As Word.Paragraph
        Dim objTable As Word.Table
        Dim CM As OleDbCommand
        Dim DR As OleDbDataReader
        Dim strSQL As String
        objWord = New Word.Application
        objWord.Visible = True
        objDoc = objWord.Documents.Add
        objPara1 = objDoc.Content.Paragraphs.Add
        With objPara1
            .Range.Text = "STOCK REPORT"
            .Range.Font.Bold = True
            .Format.SpaceAfter = 18
            .Range.InsertParagraphAfter()
        End With
        objTable = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, 1, 8)
        With objTable
            .AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            .Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            .Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            .Range.Font.Bold = False
            .Range.ParagraphFormat.SpaceAfter = 0
            .Cell(1, 1).Range.Text = "StockID"
            .Cell(1, 2).Range.Text = "Description"
            .Cell(1, 3).Range.Text = "Price"
            .Cell(1, 4).Range.Text = "In Stock"
            .Cell(1, 5).Range.Text = "ReO Level"
            .Cell(1, 6).Range.Text = "Ordered"
            .Cell(1, 7).Range.Text = "Quantity"
            .Cell(1, 8).Range.Text = "Days ago"
            Dim intRow As Integer = 2
            strSQL = "SELECT * FROM tblItem WHERE QuantityInStock <= ReorderLevel"
            CM = New OleDbCommand(strSQL, CN)
            DR = CM.ExecuteReader
            Do While DR.Read()
                .Rows.Add()
                .Cell(intRow, 1).Range.Text = DR.Item("StockID")
                .Cell(intRow, 2).Range.Text = DR.Item("Description")
                .Cell(intRow, 3).Range.Text = DR.Item("Price")
                .Cell(intRow, 4).Range.Text = DR.Item("QuantityInStock")
                .Cell(intRow, 5).Range.Text = DR.Item("ReorderLevel")
                If DR.Item("WhetherRecieved") = "True" Then
                    .Cell(intRow, 6).Range.Text = "No"
                Else
                    .Cell(intRow, 6).Range.Text = "Yes"
                    .Cell(intRow, 7).Range.Text = DR.Item("ReorderQuantity")
                    .Cell(intRow, 8).Range.Text = DateDiff(DateInterval.Day, CDate(DR.Item("DateLastOrder")), Today).ToString()
                    sngTotalOnOrder += CSng(DR.Item("Price")) * CInt(DR.Item("ReorderQuantity"))
                End If
                intRow += 1
            Loop
        End With
        strSQL = "SELECT SUM(Price * QuantityInStock) FROM tblItem"
        CM = New OleDbCommand(strSQL, CN)
        sngTotalHeld = CM.ExecuteScalar
        objPara2 = objDoc.Content.Paragraphs.Add(objDoc.Bookmarks.Item("\endofdoc").Range)
        With objPara2
            .Range.Text = "Total value of stock held: £" & sngTotalHeld & _
                          "   Total value of stock on order: £" & sngTotalOnOrder
            .Format.SpaceBefore = 18
            .Range.InsertParagraphAfter()
        End With
    End Sub
End Class