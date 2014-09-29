create procedure Clientes_obtenerRegistro (@idCliente int) as 
select * from Clientes where idcliente = @idCliente