USE Locadora

INSERT INTO Empresas	(Nome)
VALUES					('CarDan');

INSERT INTO Marcas		(Marca)
VALUES					('Chevrolet')
						,('Renault');

INSERT INTO Modelos		(Modelo, idMarca)
VALUES					('Onix', 1)
						,('Duster', 2);

INSERT INTO Veiculos	(Placa, idModelo, idEmpresa)
VALUES					('ACD 2244', 1, 1)
						,('DSX 3322', 2 ,1);
						
INSERT INTO Clientes	(Nome, CPF)
VALUES					('Daniel','51883691001')
						,('Andre','25436515601');

						
INSERT INTO Alugueis	(idCliente, idVeiculo, DataInicio, DataFim)
VALUES					(1, 2, '15/02/2021','15/08/2021')
						,(2, 1, '30/01/2021','10/01/2022');
