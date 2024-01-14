
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Module utils
    Public Function connectdb() As Array
        Dim con As New sqlconnection
        Dim cmd As New SqlCommand

        con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\kelvi\OneDrive\Documents\Visual Studio 2012\Projects\i campus trail\i campus trail\icampus.mdf;Integrated Security=True"
        con.Open()
        cmd.connection = con
        Return {con, cmd}
    End Function



End Module
