ALTER procedure clientes_insertarRegistro (@idCliente int, @razonsocial varchar, @mail varchar, @web varchar) as 
insert into Clientes (idcliente,
					razonsocial,
					mail,
					web) 
	values(@idCliente, 
			@razonsocial,
			@mail,
			@web)
