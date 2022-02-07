CREATE PROCEDURE ConsultarPorId
@IdPessoa int

AS
BEGIN
  SELECT
    nome,
    cidade,
    estado,
    rua,
    numero,
    telefone
 FROM
     Pessoa
 WHERE
     id_pessoa=@IdPessoa


END