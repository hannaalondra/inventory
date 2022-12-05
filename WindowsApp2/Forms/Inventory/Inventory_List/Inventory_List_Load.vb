Imports System.ComponentModel
Imports DevExpress.XtraEditors
Module Inventory_List_Load
    Public public_glist_inventory As New BindingList(Of Inventory_List_Class)

    Public Sub public_load_inventory()
        'frmLoadingIndicator.Show()

        ' Clear previously retrieved data
        public_glist_inventory.Clear()
        ' SQL Initialize Command: StoredProcedure fetch inventory data
        view_name = "viewInventoryList"
        mycommand.CommandText = "EXECUTE " & view_name

        Try
            ' SQL Execute Command
            myreader = mycommand.ExecuteReader
            While myreader.Read
                ' SQL Read Every Record
                Debug.WriteLine(myreader("name"))
                ' FIRST Construct Inventory_List Object
                ' THEN  Add to BindingList inventory
                public_glist_inventory.Add(
                    New Inventory_List_Class(
                        myreader("id"),
                        myreader("category_name"),
                        myreader("name"),
                        myreader("description"),
                        myreader("brand"),
                        myreader("price"),
                        myreader("quantity"),
                        myreader("barcode"),
                        myreader("expiration_date").ToString
                    )
                )
            End While

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            myreader.Close()
        End Try
        'frmLoadingIndicator.Close()

    End Sub
End Module
