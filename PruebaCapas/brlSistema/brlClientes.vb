Imports dtlSistema
Public Class brlClientes

    Public Sub obtenerRegistro(ByVal idcliente As Integer,
                               ByRef clientes As DataTable)
        Dim x As New dtlClientes
        x.obtenerRegistro(idcliente, clientes)

    End Sub

    Public Sub insertarRegistro(ByVal idcliente As Integer,
                                ByRef strrazonsocial As String,
                                calle As String,
                                ByRef strMail As String,
                                ByRef strWeb As String)
        Dim x As New dtlClientes
        x.insertarRegistro(idcliente, strrazonsocial, calle, strMail, strWeb)
    End Sub

    Public Function ExisteCliente(ByVal idcliente As Integer) As Boolean
        Dim x As New dtlClientes
        Dim clientes As New DataTable
        x.obtenerRegistro(idcliente, clientes)

        If clientes.Rows.Count > 0 Then
            ExisteCliente = True
        Else
            ExisteCliente = False
        End If
    End Function

    ''' <summary>
    ''' Este es un metodo que elimina un cliente dado su id
    ''' </summary>
    ''' <param name="idcliente"></param>
    ''' <remarks></remarks>
    Public Sub eliminarRegistro(ByVal idcliente As Integer)
        Dim x As New dtlClientes
        x.eliminarRegistro(idcliente)
    End Sub
End Class
