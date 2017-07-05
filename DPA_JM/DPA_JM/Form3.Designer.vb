<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblReorderQuantity = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblReorderLvl = New System.Windows.Forms.Label()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.txtWhetherRecieved = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDateLastOrder = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtReorderQuantity = New System.Windows.Forms.TextBox()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblWhere
        '
        Me.lblWhere.BackColor = System.Drawing.Color.White
        Me.lblWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWhere.Location = New System.Drawing.Point(132, 306)
        Me.lblWhere.Name = "lblWhere"
        Me.lblWhere.Size = New System.Drawing.Size(100, 30)
        Me.lblWhere.TabIndex = 66
        Me.lblWhere.Text = "     "
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(81, 306)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(30, 30)
        Me.btnNext.TabIndex = 65
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(42, 306)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(30, 30)
        Me.btnPrevious.TabIndex = 64
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'LblWhetherRecieved
        '
        Me.LblWhetherRecieved.AutoSize = True
        Me.LblWhetherRecieved.Location = New System.Drawing.Point(222, 207)
        Me.LblWhetherRecieved.Name = "LblWhetherRecieved"
        Me.LblWhetherRecieved.Size = New System.Drawing.Size(97, 13)
        Me.LblWhetherRecieved.TabIndex = 63
        Me.LblWhetherRecieved.Text = "Whether Recieved"
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.Location = New System.Drawing.Point(12, 207)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantityInStock.TabIndex = 62
        Me.lblQuantityInStock.Text = "Quantity In Stock"
        '
        'lblDateLastOrder
        '
        Me.lblDateLastOrder.AutoSize = True
        Me.lblDateLastOrder.Location = New System.Drawing.Point(222, 145)
        Me.lblDateLastOrder.Name = "lblDateLastOrder"
        Me.lblDateLastOrder.Size = New System.Drawing.Size(96, 13)
        Me.lblDateLastOrder.TabIndex = 61
        Me.lblDateLastOrder.Text = "Date Of Last Order"
        '
        'lblReorderQuantity
        '
        Me.lblReorderQuantity.AutoSize = True
        Me.lblReorderQuantity.Location = New System.Drawing.Point(222, 84)
        Me.lblReorderQuantity.Name = "lblReorderQuantity"
        Me.lblReorderQuantity.Size = New System.Drawing.Size(87, 13)
        Me.lblReorderQuantity.TabIndex = 60
        Me.lblReorderQuantity.Text = "Reorder Quantity"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 84)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 59
        Me.lblDescription.Text = "Description"
        '
        'lblReorderLvl
        '
        Me.lblReorderLvl.AutoSize = True
        Me.lblReorderLvl.Location = New System.Drawing.Point(222, 19)
        Me.lblReorderLvl.Name = "lblReorderLvl"
        Me.lblReorderLvl.Size = New System.Drawing.Size(74, 13)
        Me.lblReorderLvl.TabIndex = 58
        Me.lblReorderLvl.Text = "Reorder Level"
        '
        'lblStockID
        '
        Me.lblStockID.AutoSize = True
        Me.lblStockID.Location = New System.Drawing.Point(12, 19)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(49, 13)
        Me.lblStockID.TabIndex = 57
        Me.lblStockID.Text = "Stock ID"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(452, 161)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 55
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(452, 100)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 54
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(452, 43)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 53
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(15, 223)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityInStock.TabIndex = 51
        '
        'txtWhetherRecieved
        '
        Me.txtWhetherRecieved.Location = New System.Drawing.Point(225, 223)
        Me.txtWhetherRecieved.Name = "txtWhetherRecieved"
        Me.txtWhetherRecieved.Size = New System.Drawing.Size(100, 20)
        Me.txtWhetherRecieved.TabIndex = 52
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(15, 164)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 49
        '
        'txtDateLastOrder
        '
        Me.txtDateLastOrder.Location = New System.Drawing.Point(225, 164)
        Me.txtDateLastOrder.Name = "txtDateLastOrder"
        Me.txtDateLastOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtDateLastOrder.TabIndex = 50
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(15, 102)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 47
        '
        'txtReorderQuantity
        '
        Me.txtReorderQuantity.Location = New System.Drawing.Point(225, 103)
        Me.txtReorderQuantity.Name = "txtReorderQuantity"
        Me.txtReorderQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderQuantity.TabIndex = 48
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(15, 45)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(100, 20)
        Me.txtStockID.TabIndex = 45
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.Location = New System.Drawing.Point(225, 43)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderLevel.TabIndex = 46
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 352)
        Me.Controls.Add(Me.lblWhere)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.LblWhetherRecieved)
        Me.Controls.Add(Me.lblQuantityInStock)
        Me.Controls.Add(Me.lblDateLastOrder)
        Me.Controls.Add(Me.lblReorderQuantity)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblReorderLvl)
        Me.Controls.Add(Me.lblStockID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtQuantityInStock)
        Me.Controls.Add(Me.txtWhetherRecieved)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDateLastOrder)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtReorderQuantity)
        Me.Controls.Add(Me.txtStockID)
        Me.Controls.Add(Me.txtReorderLevel)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWhere As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents LblWhetherRecieved As System.Windows.Forms.Label
    Friend WithEvents lblQuantityInStock As System.Windows.Forms.Label
    Friend WithEvents lblDateLastOrder As System.Windows.Forms.Label
    Friend WithEvents lblReorderQuantity As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblReorderLvl As System.Windows.Forms.Label
    Friend WithEvents lblStockID As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtQuantityInStock As System.Windows.Forms.TextBox
    Friend WithEvents txtWhetherRecieved As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDateLastOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
End Class
