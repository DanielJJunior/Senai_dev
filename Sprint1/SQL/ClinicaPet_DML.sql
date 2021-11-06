USE ClinicaPet

INSERT INTO Clinicas	(RazaoSocial, Endereco)
VALUES					('PetSave', 'Rua Crismopolitan 1554');

INSERT INTO TiposPets	(Descricao)
VALUES					('Cachorro')
						,('Gato')
						,('Passaro');

INSERT INTO Veterinarios(idClinica, Nome, CRMV)
VALUES					(1, 'Marcos dos Anjos','256.254.254.07')
						,(1, 'Marcela Alves','456.456.45.02')
						,(1,  'Thiago Nunes', '789.789.123.05');

INSERT INTO Donos		(Nome)
VALUES					('Amelia Santos')
						,('Andreia Gomes')
						,('Luiz Neves');

INSERT INTO Racas		(idTipoPet, Descricao)
VALUES					(1,'Labrador')
						,(2,'Persa')
						,(3,'Papagaio');

INSERT INTO Pets		(idRaca, idDono, Nome, DataNascimento)
VALUES					(1,1,'Gragolandia','11/07/2014')
						,(2,2,'Doritos','05/12/2016')
						,(3,3,'Papagas','09/04/2006')

INSERT INTO Atendimentos(idVeterinario, idPets, Descricao, DataAtendimento)
VALUES					(1,2,'Cirurgia nasal','22/02/2021')
						,(2,3,'Castração','17/02/2021')
						,(3,1,'Arrumar bico quebrado','20/02/2021');