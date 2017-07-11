<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWhere = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.LblWhetherRecieved = New System.Windows.Forms.Label()
        Me.lblQuantityInStock = New System.Windows.Forms.Label()
        Me.lblDateLastOrder = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblReorderQuantity = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblReorderLvl = New System.Windows.Forms.Label()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAmend = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.txtWhetherRecieved = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDateLastOrder = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtReorderQuantity = New System.Windows.Forms.TextBox()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnReport = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWhere
        '
        Me.lblWhere.BackColor = System.Drawing.Color.White
        Me.lblWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhere.Location = New System.Drawing.Point(110, 264)
        Me.lblWhere.Name = "lblWhere"
        Me.lblWhere.Size = New System.Drawing.Size(100, 30)
        Me.lblWhere.TabIndex = 67
        Me.lblWhere.Text = "     "
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(59, 264)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(30, 30)
        Me.btnNext.TabIndex = 66
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(20, 264)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnPrevious.TabIndex = 65
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'LblWhetherRecieved
        '
        Me.LblWhetherRecieved.AutoSize = True
        Me.LblWhetherRecieved.Location = New System.Drawing.Point(227, 211)
        Me.LblWhetherRecieved.Name = "LblWhetherRecieved"
        Me.LblWhetherRecieved.Size = New System.Drawing.Size(97, 13)
        Me.LblWhetherRecieved.TabIndex = 64
        Me.LblWhetherRecieved.Text = "Whether Recieved"
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.Location = New System.Drawing.Point(17, 211)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantityInStock.TabIndex = 63
        Me.lblQuantityInStock.Text = "Quantity In Stock"
        '
        'lblDateLastOrder
        '
        Me.lblDateLastOrder.AutoSize = True
        Me.lblDateLastOrder.Location = New System.Drawing.Point(227, 149)
        Me.lblDateLastOrder.Name = "lblDateLastOrder"
        Me.lblDateLastOrder.Size = New System.Drawing.Size(96, 13)
        Me.lblDateLastOrder.TabIndex = 62
        Me.lblDateLastOrder.Text = "Date Of Last Order"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(17, 149)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 61
        Me.lblPrice.Text = "Price"
        '
        'lblReorderQuantity
        '
        Me.lblReorderQuantity.AutoSize = True
        Me.lblReorderQuantity.Location = New System.Drawing.Point(227, 88)
        Me.lblReorderQuantity.Name = "lblReorderQuantity"
        Me.lblReorderQuantity.Size = New System.Drawing.Size(87, 13)
        Me.lblReorderQuantity.TabIndex = 60
        Me.lblReorderQuantity.Text = "Reorder Quantity"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(17, 88)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 59
        Me.lblDescription.Text = "Description"
        '
        'lblReorderLvl
        '
        Me.lblReorderLvl.AutoSize = True
        Me.lblReorderLvl.Location = New System.Drawing.Point(227, 23)
        Me.lblReorderLvl.Name = "lblReorderLvl"
        Me.lblReorderLvl.Size = New System.Drawing.Size(74, 13)
        Me.lblReorderLvl.TabIndex = 58
        Me.lblReorderLvl.Text = "Reorder Level"
        '
        'lblStockID
        '
        Me.lblStockID.AutoSize = True
        Me.lblStockID.Location = New System.Drawing.Point(17, 23)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(49, 13)
        Me.lblStockID.TabIndex = 57
        Me.lblStockID.Text = "Stock ID"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(457, 154)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 56
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(457, 118)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 55
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAmend
        '
        Me.btnAmend.Location = New System.Drawing.Point(457, 83)
        Me.btnAmend.Name = "btnAmend"
        Me.btnAmend.Size = New System.Drawing.Size(75, 23)
        Me.btnAmend.TabIndex = 54
        Me.btnAmend.Text = "Amend"
        Me.btnAmend.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(457, 47)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 53
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(20, 227)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityInStock.TabIndex = 51
        '
        'txtWhetherRecieved
        '
        Me.txtWhetherRecieved.Location = New System.Drawing.Point(230, 227)
        Me.txtWhetherRecieved.Name = "txtWhetherRecieved"
        Me.txtWhetherRecieved.Size = New System.Drawing.Size(100, 20)
        Me.txtWhetherRecieved.TabIndex = 52
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(20, 168)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 49
        '
        'txtDateLastOrder
        '
        Me.txtDateLastOrder.Location = New System.Drawing.Point(230, 168)
        Me.txtDateLastOrder.Name = "txtDateLastOrder"
        Me.txtDateLastOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtDateLastOrder.TabIndex = 50
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(20, 106)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 47
        '
        'txtReorderQuantity
        '
        Me.txtReorderQuantity.Location = New System.Drawing.Point(230, 107)
        Me.txtReorderQuantity.Name = "txtReorderQuantity"
        Me.txtReorderQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderQuantity.TabIndex = 48
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(20, 49)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(100, 20)
        Me.txtStockID.TabIndex = 45
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.Location = New System.Drawing.Point(230, 47)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderLevel.TabIndex = 46
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(20, 324)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(566, 322)
        Me.DGV.TabIndex = 68
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(457, 192)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 69
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 687)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.lblWhere)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.LblWhetherRecieved)
        Me.Controls.Add(Me.lblQuantityInStock)
        Me.Controls.Add(Me.lblDateLastOrder)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblReorderQuantity)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblReorderLvl)
        Me.Controls.Add(Me.lblStockID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAmend)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtQuantityInStock)
        Me.Controls.Add(Me.txtWhetherRecieved)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDateLastOrder)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtReorderQuantity)
        Me.Controls.Add(Me.txtStockID)
        Me.Controls.Add(Me.txtReorderLevel)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWhere As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents LblWhetherRecieved As System.Windows.Forms.Label
    Friend WithEvents lblQuantityInStock As System.Windows.Forms.Label
    Friend WithEvents lblDateLastOrder As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblReorderQuantity As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblReorderLvl As System.Windows.Forms.Label
    Friend WithEvents lblStockID As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAmend As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtQuantityInStock As System.Windows.Forms.TextBox
    Friend WithEvents txtWhetherRecieved As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDateLastOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents btnReport As System.Windows.Forms.Button
End Class
