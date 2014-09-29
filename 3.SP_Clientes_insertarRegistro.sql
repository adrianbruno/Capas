create procedure clientes_insertarRegistro (@idCliente int, @razonsocial varchar) as 
insert into Clientes (idcliente,razonsocial) values(@idCliente, @razonsocial)
