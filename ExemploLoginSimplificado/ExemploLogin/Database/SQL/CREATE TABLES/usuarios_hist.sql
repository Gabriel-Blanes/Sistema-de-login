CREATE TABLE usuarios_hist (
  id_hist int(11) NOT NULL AUTO_INCREMENT,
  --
  id_usuario int(11) NOT NULL,
  nomeusuario varchar(50) NOT NULL,
  senha varchar(15) NOT NULL,
  id_categoria int(11) NOT NULL,
  id_situacao int(11) NOT NULL,
  --
  datahora_hist DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  id_usuario_hist int(11) NOT NULL,
  tipo_hist varchar(50) NOT NULL,
  justif_hist varchar(250),
  --
  PRIMARY KEY (id_hist),
  CONSTRAINT usuarios_hist_fk_usuario FOREIGN KEY (id_usuario) REFERENCES usuarios (id),
  CONSTRAINT usuarios_hist_fk_categ FOREIGN KEY (id_categoria) REFERENCES usuarios_categ (id),
  CONSTRAINT usuarios_hist_fk_sit FOREIGN KEY (id_situacao) REFERENCES usuarios_sit (id),
  CONSTRAINT usuarios_hist_fk_usuario_hist FOREIGN KEY (id_usuario_hist) REFERENCES usuarios (id)
) DEFAULT CHARSET=utf8;

DROP TABLE usuarios_hist;

SELECT * FROM usuarios_hist;
