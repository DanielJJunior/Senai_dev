USE Optus

INSERT INTO Artistas		(Nome)
VALUES						('Post Malone')
							,('Katy Perry')
							,('The Weekend');

INSERT INTO Estilos			(Tipo)
VALUES						('Pop')
							,('Trap')
							,('Balada')
							,('Gospel')
							,('Pop rock')
							,('Rock');

INSERT INTO					Albuns(idArtista, iDestilo, Titulo, DataLancamento, Localizacao, QtdMinutos,Ativo)
VALUES						(1, 2, 'Hollywoods Bleeding','06/09/2019','Los Angeles','51minutos', 'Ativo')
							,(2,1, 'Smile','28/08/2020','Los Angeles','2minutos 47segundos', 'Ativo')
							,(3,1, 'The Highlights','05/02/2021','Los Angeles','1hora 17minutos', 'Ativo');

INSERT INTO Usuarios		(Nome, Email,Senha, Permissao)
VALUES						('Daniel Souza','daniel@gmail.com','123456','Positivo')
							,('Valeria Dantas','valeria@gmail.com','123456','Positivo')
							,('Daielo Mendes','danilo@gmail.com','1223456','Positivo');