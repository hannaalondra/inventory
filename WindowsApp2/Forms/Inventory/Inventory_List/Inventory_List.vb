Public Class Inventory_List
    Private Sub Inventory_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maintain DB Connection
        _restablish_db_connection()
        ' Retrieve data
        public_load_inventory()
        Debug.WriteLine("display")
        ' Set UI DataSource to BindingList
        Me.tblInventoryList.DataSource = public_glist_inventory
        ' UI Optimization
        tblInventory.BestFitColumns()
    End Sub

    Private Sub tblInventoryList_Click(sender As Object, e As EventArgs) Handles tblInventoryList.Click

    End Sub

    Private Sub srchName_EditValueChanged(sender As Object, e As EventArgs) Handles srchName.EditValueChanged

    End Sub

    Private Sub srchBrand_EditValueChanged(sender As Object, e As EventArgs) Handles srchBrand.EditValueChanged

    End Sub

    Private Sub srchSku_EditValueChanged(sender As Object, e As EventArgs) Handles srchSku.EditValueChanged

    End Sub

    Private Sub btnAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAdd.ItemClick

    End Sub

    Private Sub btnView_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnView.ItemClick

    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class