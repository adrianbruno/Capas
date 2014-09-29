create procedure sp_eliminarRegistro (@idCliente int) as 
delete from Clientes where idcliente = @idCliente

