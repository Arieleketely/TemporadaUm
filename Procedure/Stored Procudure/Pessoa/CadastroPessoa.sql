CREATE PROCEDURE PessoaInserir
@Nome varchar(255),
@Cidade varchar(255),
@Estado varchar(255),
@Rua varchar(255),
@Numero int,
@Telefone varchar(255)
AS
BEGIN
INSERT INTO Pessoa(
nome,
cidade,
estado,
rua,
numero,
telefone
)
VALUES
(
@nome,
@cidade,
@estado,
@rua,
@numero,
@telefone
)
SELECT @@IDENTITY AS Retorno
END