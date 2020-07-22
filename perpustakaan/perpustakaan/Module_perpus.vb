Imports System.Data.SqlClient
Module Module_perpus
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Dr As SqlDataReader
    Public Ds As DataSet
    Public sql As SqlCommand
    Public Mydb As String
    Public Sub Koneksi()
        Mydb = "data source = FAWWAZ\SQLEXPRESS; initial catalog = dbPerpus; integrated security = true"
        Conn = New SqlConnection(Mydb)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        Else
            Conn.Close()
        End If
    End Sub
End Module
