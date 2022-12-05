Public Class Inventory_List_Class

    ' Default empty constructor
    Public Sub New()

    End Sub

    ' Complete arguments constructor
    Public Sub New(ByVal sku As String,
                    ByVal name As String,
                    ByVal desc As String,
                    ByVal brand As String,
                    ByVal unit As String,
                    ByVal soh As Double,
                    ByVal price As Double)
        ' Assign Param values to Properties
        Me.SKU = sku
        Me.NAME = name
        Me.DESCRIPTION = desc
        Me.BRAND = brand
        Me.UNIT = unit
        Me.STOCK_ON_HAND = soh
        Me.PRICE = price
    End Sub

    ' Declare Properties
    Public Property SKU() As String
    Public Property NAME() As String
    Public Property DESCRIPTION() As String
    Public Property BRAND() As String
    Public Property UNIT() As String
    Public Property STOCK_ON_HAND() As Double
    Public Property PRICE() As Double
End Class
