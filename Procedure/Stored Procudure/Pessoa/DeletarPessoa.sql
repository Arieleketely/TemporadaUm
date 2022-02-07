CREATE PROCEDURE PessoaDeletar
@IdPessoa int

AS
BEGIN

DELETE FROM
Pessoa

WHERE
id_pessoa=@IdPessoa

SELECT @IdPessoa AS Retorno
END