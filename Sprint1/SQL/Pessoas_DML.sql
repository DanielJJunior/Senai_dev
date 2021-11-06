INSERT INTO Pessoas (Nome, CNH)
VALUES				('Daniel','851.698.365.01')
					,('Pedro', '569.741.252.55');

INSERT INTO Telefone(Numero, idPessoa)
VALUES				('11 98888-8888', 2)
					,('11 96666-666', 1);

INSERT INTO Email	(Endereço,idPessoa)
VALUES				('daniel@gmail.com', 1)
					,('pedro2@gmail.com',2)