Imports System.Data.SqlClient
Public Class dtlClientes

    Private Property oConn As SqlConnection



    Public Sub obtenerRegistro(ByRef idcliente As Integer, ByRef clientes As DataTable)
        'oConn = New SqlConnection("Server=NBK-DIEGO\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        'oConn = New SqlConnection("Server=NBK-DIEGO\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")
        oConn = New SqlConnection("Data Source=(localdb)\Projects;Initial Catalog=capasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()
        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión
        Adp.SelectCommand.CommandText = "Clientes_obtenerRegistro"
        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.Parameters.Add("@idCliente", SqlDbType.Int, 0)
        Adp.SelectCommand.Parameters("@idcliente").Value = idcliente
        Adp.Fill(table)
        clientes = table


    End Sub
    Public Sub insertarRegistro(ByRef intidcliente As Integer, ByRef strrazonSocial As String, calle As String)
        'oConn = New SqlConnection("Server=NBK-DIEGO\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        'oConn = New SqlConnection("Server=NBK-DIEGO\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")
        oConn = New SqlConnection("Data Source=(localdb)\Projects;Initial Catalog=capasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(1) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)
        param(1) = New SqlParameter("@razonsocial", strrazonSocial)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "clientes_insertarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarRegistro(ByRef intidcliente As Integer)
        'oConn = New SqlConnection("Server=NBK-DIEGO\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        'oConn = New SqlConnection("Server=NBK-DIEGO\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")
        oConn = New SqlConnection("Data Source=(localdb)\Projects;Initial Catalog=capasDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@idcliente", intidcliente)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "sp_eliminarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub
End Class
