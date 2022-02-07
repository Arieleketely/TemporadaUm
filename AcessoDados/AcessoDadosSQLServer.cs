using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using AcessoDados.Properties;
namespace AcessoDados
{
    public class AcessoDadosSQLServer
    {
        //criando a conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }


        //Parametros que vão para o banco

        private SqlParameterCollection SqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            SqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            SqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));

        }


        //Persistir fazendo consulta,insersão e exclusão de dados


        public object ExecultarManipulacao(CommandType commandType, string nomeStringProcedureOuTextoSql)
        {
            try
            {

                //criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir conexao
                sqlConnection.Open();
                //criar o comando que leva informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStringProcedureOuTextoSql;
                //depois de duas horas fecha conexão - 7200 = 2 horas
                sqlCommand.CommandTimeout = 7200;


                //Adicionar os parametros 

                foreach (SqlParameter sqlParameter in SqlParameterCollection)
                {

                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }




            //Consultar requistros do banco de dados
        }

        public DataTable ExecultarConsulta(CommandType commandType, string nomeStringProcedureOuTextoSql)
        {
            try
            {

                //criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir conexao
                sqlConnection.Open();
                //criar o comando que leva informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStringProcedureOuTextoSql;
                //depois de duas horas fecha conexão - 7200 = 2 horas
                sqlCommand.CommandTimeout = 7200;


                //Adicionar os parametros 

                foreach (SqlParameter sqlParameter in SqlParameterCollection)
                {

                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }
                //criando adaptador
             
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //data table vazia onde vai colocar as informações guardados em sqlCommand
                //como tempo de exculção e a procedure que vai ser execulda

                DataTable dataTable = new DataTable();

                //mandar ir no banco e buscar os dados e preencher o adaptador

                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
