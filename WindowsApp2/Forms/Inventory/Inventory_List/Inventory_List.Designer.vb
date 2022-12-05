<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory_List
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory_List))
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnView = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ItemsTableAdapter = New WindowsApp2.SimpleInventoryDataSet2TableAdapters.itemsTableAdapter()
        Me.srchName = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.srchBrand = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.srchSku = New DevExpress.XtraEditors.TextEdit()
        Me.tblInventory = New DevExpress.XtraGrid.GridControl()
        Me.tblInventoryList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.barcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.expiration_date = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srchName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srchBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srchSku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblInventoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Delete"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        Me.BarButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAdd, Me.btnView, Me.BarButtonItem4})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAdd), New DevExpress.XtraBars.LinkPersistInfo(Me.btnView), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.Bar1.Offset = 411
        Me.Bar1.OptionsBar.DistanceBetweenItems = 10
        Me.Bar1.Text = "Tools"
        '
        'btnAdd
        '
        Me.btnAdd.Caption = "Add"
        Me.btnAdd.Id = 0
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("btnAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.ImageOptions.LargeImage = CType(resources.GetObject("btnAdd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnView
        '
        Me.btnView.Caption = "View"
        Me.btnView.Id = 1
        Me.btnView.ImageOptions.Image = CType(resources.GetObject("btnView.ImageOptions.Image"), System.Drawing.Image)
        Me.btnView.ImageOptions.LargeImage = CType(resources.GetObject("btnView.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnView.Name = "btnView"
        Me.btnView.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Delete"
        Me.BarButtonItem4.Id = 2
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        Me.BarButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(657, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 402)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(657, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 402)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(657, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 402)
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'srchName
        '
        Me.srchName.Location = New System.Drawing.Point(54, 39)
        Me.srchName.MenuManager = Me.BarManager1
        Me.srchName.Name = "srchName"
        Me.srchName.Properties.ValidateOnEnterKey = True
        Me.srchName.Size = New System.Drawing.Size(73, 20)
        Me.srchName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Name"
        '
        'btnSearch
        '
        Me.btnSearch.ImageOptions.Image = CType(resources.GetObject("btnSearch.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(367, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 26
        Me.btnSearch.Text = "Search"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(448, 38)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(134, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Brand"
        '
        'srchBrand
        '
        Me.srchBrand.Location = New System.Drawing.Point(170, 39)
        Me.srchBrand.MenuManager = Me.BarManager1
        Me.srchBrand.Name = "srchBrand"
        Me.srchBrand.Properties.ValidateOnEnterKey = True
        Me.srchBrand.Size = New System.Drawing.Size(73, 20)
        Me.srchBrand.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Sku"
        '
        'srchSku
        '
        Me.srchSku.Location = New System.Drawing.Point(277, 39)
        Me.srchSku.MenuManager = Me.BarManager1
        Me.srchSku.Name = "srchSku"
        Me.srchSku.Properties.ValidateOnEnterKey = True
        Me.srchSku.Size = New System.Drawing.Size(73, 20)
        Me.srchSku.TabIndex = 30
        '
        'tblInventory
        '
        Me.tblInventory.Location = New System.Drawing.Point(21, 78)
        Me.tblInventory.MainView = Me.tblInventoryList
        Me.tblInventory.MenuManager = Me.BarManager1
        Me.tblInventory.Name = "tblInventory"
        Me.tblInventory.Size = New System.Drawing.Size(607, 318)
        Me.tblInventory.TabIndex = 36
        Me.tblInventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tblInventoryList})
        '
        'tblInventoryList
        '
        Me.tblInventoryList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.category, Me.name, Me.description, Me.brand, Me.price, Me.quantity, Me.barcode, Me.expiration_date})
        Me.tblInventoryList.GridControl = Me.tblInventory
        Me.tblInventoryList.Name = "tblInventoryList"
        '
        'id
        '
        Me.id.Caption = "ID"
        Me.id.FieldName = "ID"
        Me.id.Name = "id"
        Me.id.Visible = True
        Me.id.VisibleIndex = 0
        '
        'category
        '
        Me.category.Caption = "Category"
        Me.category.FieldName = "CATEGORY"
        Me.category.Name = "category"
        Me.category.Visible = True
        Me.category.VisibleIndex = 1
        '
        'name
        '
        Me.name.Caption = "Name"
        Me.name.FieldName = "NAME"
        Me.name.Name = "name"
        Me.name.Visible = True
        Me.name.VisibleIndex = 2
        '
        'description
        '
        Me.description.Caption = "Description"
        Me.description.FieldName = "DESCRIPTION"
        Me.description.Name = "description"
        Me.description.Visible = True
        Me.description.VisibleIndex = 3
        '
        'brand
        '
        Me.brand.Caption = "Brand"
        Me.brand.FieldName = "BRAND"
        Me.brand.Name = "brand"
        Me.brand.Visible = True
        Me.brand.VisibleIndex = 4
        '
        'price
        '
        Me.price.Caption = "Price"
        Me.price.FieldName = "PRICE"
        Me.price.Name = "price"
        Me.price.Visible = True
        Me.price.VisibleIndex = 5
        '
        'quantity
        '
        Me.quantity.Caption = "Quantity"
        Me.quantity.FieldName = "QUANTITY"
        Me.quantity.Name = "quantity"
        Me.quantity.Visible = True
        Me.quantity.VisibleIndex = 6
        '
        'barcode
        '
        Me.barcode.Caption = "Barcode"
        Me.barcode.FieldName = "BARCODE"
        Me.barcode.Name = "barcode"
        Me.barcode.Visible = True
        Me.barcode.VisibleIndex = 7
        '
        'expiration_date
        '
        Me.expiration_date.Caption = "Expiration_Date"
        Me.expiration_date.FieldName = "EXPIRATION_DATE"
        Me.expiration_date.Name = "expiration_date"
        Me.expiration_date.Visible = True
        Me.expiration_date.VisibleIndex = 8
        '
        'Inventory_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 426)
        Me.Controls.Add(Me.tblInventory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.srchSku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.srchBrand)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.srchName)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.name = "Inventory_List"
        Me.Text = "Inventory_List"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srchName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srchBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srchSku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblInventoryList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents ItemsTableAdapter As SimpleInventoryDataSet2TableAdapters.itemsTableAdapter
    Friend WithEvents srchName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents srchSku As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents srchBrand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tblInventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents tblInventoryList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents expiration_date As DevExpress.XtraGrid.Columns.GridColumn
End Class
