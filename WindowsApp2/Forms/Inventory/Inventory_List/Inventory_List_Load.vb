Imports System.ComponentModel
Imports DevExpress.XtraEditors
Module Inventory_List_Load
    Public public_glist_inventory As New BindingList(Of Inventory_List_Class)

    Public Sub public_load_inventory()
        'frmLoadingIndicator.Show()

        ' Clear previously retrieved data
        public_glist_inventory.Clear()
        ' SQL Initialize Command: StoredProcedure fetch inventory data
        mycommand.CommandText = "EXECUTE getInventoryList"

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
                        myreader("sku"),
                        myreader("name"),
                        myreader("description"), ' placeholder
                        myreader("brand"),
                        myreader("unit"),
                        myreader("soh"),
                       myreader("price")
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
