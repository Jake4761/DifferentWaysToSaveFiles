<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.cboStockID = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblWhetherRecieved
        '
        Me.LblWhetherRecieved.AutoSize = True
        Me.LblWhetherRecieved.Location = New System.Drawing.Point(223, 213)
        Me.LblWhetherRecieved.Name = "LblWhetherRecieved"
        Me.LblWhetherRecieved.Size = New System.Drawing.Size(97, 13)
        Me.LblWhetherRecieved.TabIndex = 84
        Me.LblWhetherRecieved.Text = "Whether Recieved"
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.Location = New System.Drawing.Point(13, 213)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantityInStock.TabIndex = 83
        Me.lblQuantityInStock.Text = "Quantity In Stock"
        '
        'lblDateLastOrder
        '
        Me.lblDateLastOrder.AutoSize = True
        Me.lblDateLastOrder.Location = New System.Drawing.Point(223, 151)
        Me.lblDateLastOrder.Name = "lblDateLastOrder"
        Me.lblDateLastOrder.Size = New System.Drawing.Size(96, 13)
        Me.lblDateLastOrder.TabIndex = 82
        Me.lblDateLastOrder.Text = "Date Of Last Order"
        '
        'lblReorderQuantity
        '
        Me.lblReorderQuantity.AutoSize = True
        Me.lblReorderQuantity.Location = New System.Drawing.Point(223, 90)
        Me.lblReorderQuantity.Name = "lblReorderQuantity"
        Me.lblReorderQuantity.Size = New System.Drawing.Size(87, 13)
        Me.lblReorderQuantity.TabIndex = 81
        Me.lblReorderQuantity.Text = "Reorder Quantity"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 90)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 80
        Me.lblDescription.Text = "Description"
        '
        'lblReorderLvl
        '
        Me.lblReorderLvl.AutoSize = True
        Me.lblReorderLvl.Location = New System.Drawing.Point(223, 25)
        Me.lblReorderLvl.Name = "lblReorderLvl"
        Me.lblReorderLvl.Size = New System.Drawing.Size(74, 13)
        Me.lblReorderLvl.TabIndex = 79
        Me.lblReorderLvl.Text = "Reorder Level"
        '
        'lblStockID
        '
        Me.lblStockID.AutoSize = True
        Me.lblStockID.Location = New System.Drawing.Point(13, 25)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(49, 13)
        Me.lblStockID.TabIndex = 78
        Me.lblStockID.Text = "Stock ID"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(453, 167)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 77
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(453, 106)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 76
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(453, 49)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 75
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(16, 229)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityInStock.TabIndex = 73
        '
        'txtWhetherRecieved
        '
        Me.txtWhetherRecieved.Location = New System.Drawing.Point(226, 229)
        Me.txtWhetherRecieved.Name = "txtWhetherRecieved"
        Me.txtWhetherRecieved.Size = New System.Drawing.Size(100, 20)
        Me.txtWhetherRecieved.TabIndex = 74
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(16, 170)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 71
        '
        'txtDateLastOrder
        '
        Me.txtDateLastOrder.Location = New System.Drawing.Point(226, 170)
        Me.txtDateLastOrder.Name = "txtDateLastOrder"
        Me.txtDateLastOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtDateLastOrder.TabIndex = 72
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(16, 108)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 69
        '
        'txtReorderQuantity
        '
        Me.txtReorderQuantity.Location = New System.Drawing.Point(226, 109)
        Me.txtReorderQuantity.Name = "txtReorderQuantity"
        Me.txtReorderQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderQuantity.TabIndex = 70
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.Location = New System.Drawing.Point(226, 49)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderLevel.TabIndex = 68
        '
        'cboStockID
        '
        Me.cboStockID.FormattingEnabled = True
        Me.cboStockID.Location = New System.Drawing.Point(16, 51)
        Me.cboStockID.Name = "cboStockID"
        Me.cboStockID.Size = New System.Drawing.Size(121, 21)
        Me.cboStockID.TabIndex = 85
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(13, 142)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 86
        Me.lblPrice.Text = "Price"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(453, 213)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 87
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 291)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.cboStockID)
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
        Me.Controls.Add(Me.txtReorderLevel)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents cboStockID As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
End Class
