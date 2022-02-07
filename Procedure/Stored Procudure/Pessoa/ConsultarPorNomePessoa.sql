CREATE PROCEDURE ConsultarPorNome
@Nome Varchar(255)

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
     nome LIKE '%' +@Nome + '%'


END