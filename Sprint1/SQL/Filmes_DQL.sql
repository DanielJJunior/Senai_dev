USE Filmes;

SELECT * FROM Generos;

SELECT * FROM Filmes;

SELECT Filmes.idFilmes, Filmes.Titulo,Generos.idGenero, Generos.Nome FROM Filmes
INNER JOIN Generos
ON Filmes.idGenero = Generos.idGenero;