
Imports DevExpress.XtraEditors
    Module Public_SQL

        Public Sub get_connected()
            'load_conf()
            _isConnected = False


            Try
                conn.ConnectionString = "Data Source=WIN-N0GGRPU90LD\;Initial Catalog=SimpleInventory;User ID=test;Password=123456"
                conn.Open()
                mycommand.Connection = conn

            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString() & "Unable to connect to any specified database server." & vbNewLine & vbNewLine & "Please contact your system administrator.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'ServerSettings._serverIP = server_ip
                'ServerSettings._dbName = db_name
                'ServerSettings.ShowDialog()
                'Exit Sub
                End
            End Try
            _isConnected = True
        End Sub

        Public Sub _refresh_db_connection()
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            _isConnected = False


            Try
                conn.ConnectionString = "Data Source=WIN-N0GGRPU90LD\;Initial Catalog=SimpleInventory;User ID=test;Password=123456"
                conn.Open()
                mycommand.Connection = conn

            Catch ex As Exception
                XtraMessageBox.Show("Unable to connect to any specified database server." & vbNewLine & vbNewLine & "Please contact your system administrator.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End
            End Try
            _isConnected = True
        End Sub

        Public Sub _restablish_db_connection()
            If conn.State = ConnectionState.Broken Or conn.State = ConnectionState.Closed Then
                get_connected()
            End If
        End Sub


        Public Sub connect2()

            _isConnected = False


            Try
                conn.ConnectionString = "Data Source=WIN-N0GGRPU90LD\;Initial Catalog=SimpleInventory;User ID=test;Password=123456"
                conn.Open()
                mycommand.Connection = conn

            Catch ex As Exception
                'XtraMessageBox.Show("ERRx006 - Error while trying to connect to database." & vbNewLine & vbNewLine & "Please check your server settings.", _Error_Message_Cannot_Proceed, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'ServerSettings._serverIP = server_ip
                'ServerSettings._dbName = db_name
                'ServerSettings.ShowDialog()
                'Exit Sub

                XtraMessageBox.Show("Unable to re-connect to any specified database server." & vbNewLine & vbNewLine & "Please contact your system administrator.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End
            End Try

            _isConnected = True
        End Sub
    End Module
