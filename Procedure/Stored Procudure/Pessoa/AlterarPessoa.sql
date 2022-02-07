CREATE PROCEDURE PessoaAlterar
@IdPessoa int,
@Nome varchar(255),
@Cidade varchar(255),
@Estado varchar(255),
@Rua varchar(255),
@Numero int,
@Telefone varchar(255)
AS
BEGIN
UPDATE
Pessoa
SET

nome=@Nome,
cidade=@Cidade,
estado=@Estado,
rua=@Rua,
numero=@Numero,
telefone=@Telefone

WHERE
id_pessoa=@IdPessoa

SELECT @IdPessoa AS Retorno
END