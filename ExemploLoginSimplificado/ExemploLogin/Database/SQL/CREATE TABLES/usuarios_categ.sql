CREATE TABLE usuarios_categ (
  id int(11) NOT NULL AUTO_INCREMENT,
  descricao varchar(50) NOT NULL,
  PRIMARY KEY (id)
) DEFAULT CHARSET=utf8;

SELECT * FROM usuarios_categ;

/*--------------------------*/

INSERT INTO usuarios_categ ( descricao )
VALUES ( 'ADMIN' );

INSERT INTO usuarios_categ ( descricao )
VALUES ( 'NORMAL' );

/*--------------------------*/

