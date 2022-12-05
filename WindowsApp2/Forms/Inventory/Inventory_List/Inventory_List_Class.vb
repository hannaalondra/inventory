Public Class Inventory_List_Class

    ' Default empty constructor
    Public Sub New()
    End Sub

    ' Declare Properties
    Public Property ID() As Integer
    Public Property CATEGORY_NAME() As String
    Public Property NAME() As String
    Public Property DESCRIPTION() As String
    Public Property BRAND() As String
    Public Property PRICE() As Double
    Public Property QUANTITY() As Integer
    Public Property BARCODE() As String
    Public Property EXPIRATION_DATE() As Date?

    ' Complete arguments constructor
    Public Sub New(
        ByVal id As Integer,
        ByVal category_name As String,
        ByVal name As String,
        ByVal description As String,
        ByVal brand As String,
        ByVal price As Double,
        ByVal quantity As Integer,
        ByVal barcode As String,
        ByVal expiration_date As Date?
    )
        ' Assign Param values to Properties
        Me.ID = id
        Me.CATEGORY_NAME = category_name
        Me.NAME = name
        Me.DESCRIPTION = description
        Me.BRAND = brand
        Me.PRICE = price
        Me.QUANTITY = quantity
        Me.BARCODE = barcode
        Me.EXPIRATION_DATE = expiration_date
    End Sub
End Class
