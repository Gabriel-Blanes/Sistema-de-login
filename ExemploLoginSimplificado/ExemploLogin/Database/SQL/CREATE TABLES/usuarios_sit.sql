CREATE TABLE usuarios_sit (
  id int(11) NOT NULL AUTO_INCREMENT,
  descricao varchar(50) NOT NULL,
  PRIMARY KEY (id)
) DEFAULT CHARSET=utf8;

SELECT * FROM usuarios_sit;

/*--------------------------*/

INSERT INTO usuarios_sit ( descricao )
VALUES ( 'ATIVO' );

INSERT INTO usuarios_sit ( descricao )
VALUES ( 'DESATIVADO' );

/*--------------------------*/
