DROP DATABASE bd_Gravadora;

CREATE DATABASE bd_Gravadora;

use bd_Gravadora;

CREATE TABLE TBL_Gravadora( 
  idGravadora INT NOT NULL AUTO_INCREMENT,
  nome VARCHAR(50) NOT NULL,
  PRIMARY KEY(idGravadora)
);

SELECT idMusica as ID , nome as Nome, nomeAutor as Autor, idGravadora as Gravadora, idCD as CD FROM TBL_Musica;
INSERT INTO TBL_Musica VALUES(null,'Bismarck','Sabaton',1,1);
INSERT INTO TBL_Musica VALUES(NULL,'a','a',1,1);
UPDATE TBL_Musica SET nome = 'ToHellAndBack', nomeAutor = 'Sabaton', idGravadora = 1, idCD = 1 WHERE idMusica = 30;
DELETE from TBL_Musica where idMusica = 29;

CREATE TABLE TBL_CD(
  idCD INT NOT NULL AUTO_INCREMENT,
  nomeCD VARCHAR(50) NOT NULL,
  precoVenda DOUBLE NOT NULL,
  dtLancamento DATETIME NOT NULL,
  PRIMARY KEY(idCD)
);

CREATE TABLE TBL_Musica(
  idMusica INT NOT NULL AUTO_INCREMENT,
  nome VARCHAR(50) NOT NULL,
  nomeAutor VARCHAR(50),
  idGravadora INT NOT NULL,
  idCD INT NOT NULL,
  FOREIGN KEY(idGravadora) REFERENCES TBL_Gravadora(idGravadora),
  FOREIGN KEY(idCD) REFERENCES TBL_CD(idCD),
  PRIMARY KEY(idMusica)
);

drop table TBL_Musica;


INSERT INTO TBL_Gravadora VALUES(NULL, 'EMI');
INSERT INTO TBL_Gravadora VALUES(NULL, 'TESTE');
INSERT INTO TBL_Gravadora VALUES(NULL, 'SONY');

INSERT INTO TBL_CD VALUES(NULL, 'Sgt. Pepper s Lonely Hearts Club Band', 70.00, '1967/05/26');
INSERT INTO TBL_CD VALUES(NULL, 'Teste de CD', 45.00, '1990/03/07');


INSERT INTO TBL_Musica VALUES(NULL, 'Sgt. Pepper s Lonely Hearts Club Band', 'Paul McCartney', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'With a Little Help from My Friends', 'Paul McCartney', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'Lucy in the Sky with Diamonds', 'John Lennon', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'Fixing a Hole', 'Paul McCartney', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'She is Leaving Home','Paul McCartney', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'Being for the Benefit of Mr. Kite!', 'John Lennon', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'When I am Sixty-Four','Paul McCartney', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'Lovely Rita','Paul McCartney', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'Good Morning Good Morning', 'John Lennon', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'Within You Without You','George Harrison', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'A Day in the life', 'Lennon e McCartney', 1, 1);
INSERT INTO TBL_Musica VALUES(NULL, 'Musica 1', 'Cantor A', 2, 2);
INSERT INTO TBL_Musica VALUES(NULL, 'Musica 2', 'Cantor B', 2, 2);
INSERT INTO TBL_Musica VALUES(NULL, 'Musica 3', 'Cantor B', 2, 2);
INSERT INTO TBL_Musica VALUES(NULL, 'Musica 4', 'Cantor B', 3, 2);