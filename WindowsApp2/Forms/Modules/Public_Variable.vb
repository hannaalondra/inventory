Imports System.Data.SqlClient

Module Public_Variables
    'database
    Public server_ip, server_uid, server_password, myConnectionString, server_name, db_name, private_key, private_user, cloud_ip As String

    'database connection declarations
    Public conn As New SqlConnection
    Public mycommand As New SqlCommand
    Public myreader As SqlDataReader
    Public _isConnected As Boolean

    'newly added
    Public view_name As String
End Module
