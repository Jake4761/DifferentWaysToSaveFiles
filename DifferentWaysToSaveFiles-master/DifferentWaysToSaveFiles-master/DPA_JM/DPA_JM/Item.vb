<Serializable()> Friend Class Item
    Dim strStockID As String
    Dim strDescription As String
    Dim sngPrice As Single
    Dim intQuantityInStock As Integer
    Dim intReorderLevel As Integer
    Dim intReorderQuantity As Integer
    Dim dteDateLastOrder As Date
    Dim blnWhetherRecieved As Boolean
    Public Property StockID() As String
        Get
            Return Me.strStockID
        End Get
        Set(ByVal value As String)
            Me.strStockID = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return Me.strDescription
        End Get
        Set(ByVal value As String)
            Me.strDescription = value
        End Set
    End Property
    Public Property Price() As Single
        Get
            Return Me.sngPrice
        End Get
        Set(ByVal value As Single)
            Me.sngPrice = value
        End Set
    End Property
    Public Property QuantityinStock() As Integer
        Get
            Return Me.intQuantityInStock
        End Get
        Set(ByVal value As Integer)
            Me.intQuantityInStock = value
        End Set
    End Property
    Public Property ReorderLevel() As Integer
        Get
            Return Me.intReorderLevel
        End Get
        Set(ByVal value As Integer)
            Me.intReorderLevel = value
        End Set
    End Property
    Public Property ReorderQuantity() As Integer
        Get
            Return Me.intReorderQuantity
        End Get
        Set(ByVal value As Integer)
            Me.intReorderQuantity = value
        End Set
    End Property
    Public Property DateLastOrder() As Date
        Get
            Return Me.dteDateLastOrder
        End Get
        Set(ByVal value As Date)
            Me.dteDateLastOrder = value
        End Set
    End Property
    Public Property WhetherRecieved() As Boolean
        Get
            Return Me.blnWhetherRecieved
        End Get
        Set(ByVal value As Boolean)
            Me.blnWhetherRecieved = value
        End Set
    End Property
End Class