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
        Me.SimpleInventoryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleInventoryDataSet = New WindowsApp2.SimpleInventoryDataSet()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.SimpleInventoryDataSet1 = New WindowsApp2.SimpleInventoryDataSet1()
        Me.SimpleInventoryDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnView = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.tblInventoryList = New DevExpress.XtraGrid.GridControl()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleInventoryDataSet2 = New WindowsApp2.SimpleInventoryDataSet2()
        Me.tblInventory = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsku = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colunit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsoh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemsTableAdapter = New WindowsApp2.SimpleInventoryDataSet2TableAdapters.itemsTableAdapter()
        Me.srchName = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.srchBrand = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.srchSku = New DevExpress.XtraEditors.TextEdit()
        CType(Me.SimpleInventoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleInventoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleInventoryDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleInventoryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblInventoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleInventoryDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srchName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srchBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srchSku.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleInventoryDataSetBindingSource
        '
        Me.SimpleInventoryDataSetBindingSource.DataSource = Me.SimpleInventoryDataSet
        Me.SimpleInventoryDataSetBindingSource.Position = 0
        '
        'SimpleInventoryDataSet
        '
        Me.SimpleInventoryDataSet.DataSetName = "SimpleInventoryDataSet"
        Me.SimpleInventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'SimpleInventoryDataSet1
        '
        Me.SimpleInventoryDataSet1.DataSetName = "SimpleInventoryDataSet1"
        Me.SimpleInventoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleInventoryDataSet1BindingSource
        '
        Me.SimpleInventoryDataSet1BindingSource.DataSource = Me.SimpleInventoryDataSet1
        Me.SimpleInventoryDataSet1BindingSource.Position = 0
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
        'tblInventoryList
        '
        Me.tblInventoryList.DataSource = Me.ItemsBindingSource
        Me.tblInventoryList.Location = New System.Drawing.Point(8, 66)
        Me.tblInventoryList.MainView = Me.tblInventory
        Me.tblInventoryList.Name = "tblInventoryList"
        Me.tblInventoryList.Size = New System.Drawing.Size(643, 328)
        Me.tblInventoryList.TabIndex = 4
        Me.tblInventoryList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tblInventory})
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "items"
        Me.ItemsBindingSource.DataSource = Me.SimpleInventoryDataSet2
        '
        'SimpleInventoryDataSet2
        '
        Me.SimpleInventoryDataSet2.DataSetName = "SimpleInventoryDataSet2"
        Me.SimpleInventoryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tblInventory
        '
        Me.tblInventory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsku, Me.colname, Me.coldescription, Me.colbrand, Me.colunit, Me.colsoh, Me.colprice})
        Me.tblInventory.GridControl = Me.tblInventoryList
        Me.tblInventory.Name = "tblInventory"
        Me.tblInventory.OptionsFind.ShowSearchNavButtons = False
        '
        'colsku
        '
        Me.colsku.FieldName = "SKU"
        Me.colsku.Name = "colsku"
        Me.colsku.Visible = True
        Me.colsku.VisibleIndex = 0
        '
        'colname
        '
        Me.colname.FieldName = "NAME"
        Me.colname.Name = "colname"
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 1
        '
        'coldescription
        '
        Me.coldescription.FieldName = "DESCRIPTION"
        Me.coldescription.Name = "coldescription"
        Me.coldescription.Visible = True
        Me.coldescription.VisibleIndex = 2
        '
        'colbrand
        '
        Me.colbrand.FieldName = "BRAND"
        Me.colbrand.Name = "colbrand"
        Me.colbrand.Visible = True
        Me.colbrand.VisibleIndex = 3
        '
        'colunit
        '
        Me.colunit.FieldName = "UNIT"
        Me.colunit.Name = "colunit"
        Me.colunit.Visible = True
        Me.colunit.VisibleIndex = 4
        '
        'colsoh
        '
        Me.colsoh.FieldName = "SOH"
        Me.colsoh.Name = "colsoh"
        Me.colsoh.Visible = True
        Me.colsoh.VisibleIndex = 5
        '
        'colprice
        '
        Me.colprice.FieldName = "PRICE"
        Me.colprice.Name = "colprice"
        Me.colprice.Visible = True
        Me.colprice.VisibleIndex = 6
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
        'Inventory_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 426)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.srchSku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.srchBrand)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblInventoryList)
        Me.Controls.Add(Me.srchName)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "Inventory_List"
        Me.Text = "Inventory_List"
        CType(Me.SimpleInventoryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleInventoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleInventoryDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleInventoryDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblInventoryList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleInventoryDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srchName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srchBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srchSku.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleInventoryDataSetBindingSource As BindingSource
    Friend WithEvents SimpleInventoryDataSet As SimpleInventoryDataSet
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleInventoryDataSet1BindingSource As BindingSource
    Friend WithEvents SimpleInventoryDataSet1 As SimpleInventoryDataSet1
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents tblInventoryList As DevExpress.XtraGrid.GridControl
    Friend WithEvents tblInventory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleInventoryDataSet2 As SimpleInventoryDataSet2
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As SimpleInventoryDataSet2TableAdapters.itemsTableAdapter
    Friend WithEvents colsku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colunit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsoh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents srchName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents srchSku As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents srchBrand As DevExpress.XtraEditors.TextEdit
End Class
