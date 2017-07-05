<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.txtStockID = New System.Windows.Forms.TextBox()
        Me.txtReorderQuantity = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtDateLastOrder = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtWhetherRecieved = New System.Windows.Forms.TextBox()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAmend = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.lblReorderLvl = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblReorderQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDateLastOrder = New System.Windows.Forms.Label()
        Me.lblQuantityInStock = New System.Windows.Forms.Label()
        Me.LblWhetherRecieved = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.Location = New System.Drawing.Point(225, 33)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderLevel.TabIndex = 1
        '
        'txtStockID
        '
        Me.txtStockID.Location = New System.Drawing.Point(15, 35)
        Me.txtStockID.Name = "txtStockID"
        Me.txtStockID.Size = New System.Drawing.Size(100, 20)
        Me.txtStockID.TabIndex = 0
        '
        'txtReorderQuantity
        '
        Me.txtReorderQuantity.Location = New System.Drawing.Point(225, 93)
        Me.txtReorderQuantity.Name = "txtReorderQuantity"
        Me.txtReorderQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtReorderQuantity.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(15, 92)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 2
        '
        'txtDateLastOrder
        '
        Me.txtDateLastOrder.Location = New System.Drawing.Point(225, 154)
        Me.txtDateLastOrder.Name = "txtDateLastOrder"
        Me.txtDateLastOrder.Size = New System.Drawing.Size(100, 20)
        Me.txtDateLastOrder.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(15, 154)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 4
        '
        'txtWhetherRecieved
        '
        Me.txtWhetherRecieved.Location = New System.Drawing.Point(225, 213)
        Me.txtWhetherRecieved.Name = "txtWhetherRecieved"
        Me.txtWhetherRecieved.Size = New System.Drawing.Size(100, 20)
        Me.txtWhetherRecieved.TabIndex = 7
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(15, 213)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantityInStock.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(452, 33)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAmend
        '
        Me.btnAmend.Location = New System.Drawing.Point(452, 90)
        Me.btnAmend.Name = "btnAmend"
        Me.btnAmend.Size = New System.Drawing.Size(75, 23)
        Me.btnAmend.TabIndex = 9
        Me.btnAmend.Text = "Amend"
        Me.btnAmend.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(452, 151)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 10
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(452, 210)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 254)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(533, 290)
        Me.ListBox1.TabIndex = 12
        '
        'lblStockID
        '
        Me.lblStockID.AutoSize = True
        Me.lblStockID.Location = New System.Drawing.Point(12, 9)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(49, 13)
        Me.lblStockID.TabIndex = 13
        Me.lblStockID.Text = "Stock ID"
        '
        'lblReorderLvl
        '
        Me.lblReorderLvl.AutoSize = True
        Me.lblReorderLvl.Location = New System.Drawing.Point(222, 9)
        Me.lblReorderLvl.Name = "lblReorderLvl"
        Me.lblReorderLvl.Size = New System.Drawing.Size(74, 13)
        Me.lblReorderLvl.TabIndex = 14
        Me.lblReorderLvl.Text = "Reorder Level"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 74)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 15
        Me.lblDescription.Text = "Description"
        '
        'lblReorderQuantity
        '
        Me.lblReorderQuantity.AutoSize = True
        Me.lblReorderQuantity.Location = New System.Drawing.Point(222, 74)
        Me.lblReorderQuantity.Name = "lblReorderQuantity"
        Me.lblReorderQuantity.Size = New System.Drawing.Size(87, 13)
        Me.lblReorderQuantity.TabIndex = 16
        Me.lblReorderQuantity.Text = "Reorder Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(12, 135)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 17
        Me.lblPrice.Text = "Price"
        '
        'lblDateLastOrder
        '
        Me.lblDateLastOrder.AutoSize = True
        Me.lblDateLastOrder.Location = New System.Drawing.Point(222, 135)
        Me.lblDateLastOrder.Name = "lblDateLastOrder"
        Me.lblDateLastOrder.Size = New System.Drawing.Size(96, 13)
        Me.lblDateLastOrder.TabIndex = 18
        Me.lblDateLastOrder.Text = "Date Of Last Order"
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.Location = New System.Drawing.Point(12, 197)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantityInStock.TabIndex = 19
        Me.lblQuantityInStock.Text = "Quantity In Stock"
        '
        'LblWhetherRecieved
        '
        Me.LblWhetherRecieved.AutoSize = True
        Me.LblWhetherRecieved.Location = New System.Drawing.Point(222, 197)
        Me.LblWhetherRecieved.Name = "LblWhetherRecieved"
        Me.LblWhetherRecieved.Size = New System.Drawing.Size(97, 13)
        Me.LblWhetherRecieved.TabIndex = 20
        Me.LblWhetherRecieved.Text = "Whether Recieved"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 556)
        Me.Controls.Add(Me.LblWhetherRecieved)
        Me.Controls.Add(Me.lblQuantityInStock)
        Me.Controls.Add(Me.lblDateLastOrder)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblReorderQuantity)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblReorderLvl)
        Me.Controls.Add(Me.lblStockID)
        Me.Controls.Add(Me.ListBox1)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtStockID As System.Windows.Forms.TextBox
    Friend WithEvents txtReorderQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtDateLastOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtWhetherRecieved As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantityInStock As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnAmend As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblStockID As System.Windows.Forms.Label
    Friend WithEvents lblReorderLvl As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblReorderQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblDateLastOrder As System.Windows.Forms.Label
    Friend WithEvents lblQuantityInStock As System.Windows.Forms.Label
    Friend WithEvents LblWhetherRecieved As System.Windows.Forms.Label

End Class
