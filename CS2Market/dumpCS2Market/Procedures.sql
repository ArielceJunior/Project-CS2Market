DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `consultaLogin`(usuario varchar(100), senha varchar(100))
BEGIN
Select * from usuarios where usuarios.nome = usuario and usuarios.senha = senha;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_alteraSkin`(idskins int, nome varchar(45), preco float, fk_arma int, fk_raridade int)
BEGIN
UPDATE `sql10667070`.`skins`
SET
`idskin` = idskins,
`nome` = nome,
`preco` = preco,
`fk_arma` = fk_arma,
`fk_raridade` = fk_raridade
WHERE `idskin` = idskins;

END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_insereArma`(arma varchar(45))
BEGIN
INSERT INTO `sql10667070`.`arma`
(`arma`)
VALUES
(arma);

END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_insereSkin`(nome varchar(45), preco float, fk_arma int, fk_raridade int)
BEGIN

INSERT INTO `sql10667070`.`skins`(
`nome`,
`preco`,
`fk_arma`,
`fk_raridade`)
VALUES
(nome,
preco,
fk_arma,
fk_raridade);


END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_insereUser`(in nomeU varchar (100), in senhaU varchar (100))
BEGIN
	insert into usuarios (nome,senha) values (nomeU, senhaU);
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_listaArma`()
BEGIN
	select * from arma;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_listaRaridade`()
BEGIN
	select * from raridade;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_listaSkins`()
BEGIN
select idskin,nome,preco,arma.arma, raridade.raridade from skins INNER JOIN arma on skins.fk_arma = arma.idarma INNER JOIN raridade on skins.fk_raridade = raridade.idrar ;
END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_removeArma`(idarmas int)
BEGIN

delete from arma where idarma = idarmas;

END$$
DELIMITER ;

DELIMITER $$
CREATE DEFINER=`sql10667070`@`%` PROCEDURE `sp_removeSkin`(idskins int)
BEGIN
	delete from skins where idskin = idskins ;
END$$
DELIMITER ;

