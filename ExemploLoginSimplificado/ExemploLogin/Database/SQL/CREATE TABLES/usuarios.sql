CREATE TABLE usuarios (
  id int(11) NOT NULL AUTO_INCREMENT,
  nomeusuario varchar(50) NOT NULL,
  senha varchar(15) NOT NULL,
  id_categoria int(11) NOT NULL,
  id_situacao int(11) NOT NULL,
  PRIMARY KEY (id),
  CONSTRAINT usuarios_fk_categ FOREIGN KEY (id_categoria) REFERENCES usuarios_categ (id),
  CONSTRAINT usuarios_fk_sit FOREIGN KEY (id_situacao) REFERENCES usuarios_sit (id)
) DEFAULT CHARSET=utf8;

-- DROP TABLE usuarios;

SELECT * FROM usuarios;


INSERT INTO usuarios
( nomeusuario, senha, id_categoria, id_situacao )
VALUES
( 'ADMIN', 'admin', 1, 1 );