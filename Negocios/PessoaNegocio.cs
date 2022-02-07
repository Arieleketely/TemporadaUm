using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using AcessoDados;
using TransferenciaDTO;
using System.Data;





namespace Negocios
{
    public class PessoaNegocio
    {
        AcessoDadosSQLServer acessoDadosSqlServer = new AcessoDadosSQLServer();
       
        //Inserir
        
        public string Inserir(Pessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", pessoa.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Estado", pessoa.Estado);
                acessoDadosSqlServer.AdicionarParametros("@Rua", pessoa.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Numero", pessoa.Numero);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", pessoa.Telefone);
                string idPessoa = acessoDadosSqlServer.ExecultarManipulacao(CommandType.StoredProcedure, "PessoaInserir").ToString();

                return idPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;   
            }
        }

//Alterar

        public string Alterar(Pessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPessoa", pessoa.IdPessoa);
                acessoDadosSqlServer.AdicionarParametros("@Nome", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Cidade", pessoa.Cidade);
                acessoDadosSqlServer.AdicionarParametros("@Estado", pessoa.Estado);
                acessoDadosSqlServer.AdicionarParametros("@Rua", pessoa.Rua);
                acessoDadosSqlServer.AdicionarParametros("@Numero", pessoa.Numero);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", pessoa.Telefone);
                string idPessoa = acessoDadosSqlServer.ExecultarManipulacao(CommandType.StoredProcedure, "PessoaAlterar").ToString();

                return idPessoa;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }


        //Deletar


        public string Deletar(Pessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
         
                acessoDadosSqlServer.AdicionarParametros("@IdPessoa", pessoa.IdPessoa);
                string idPessoa = acessoDadosSqlServer.ExecultarManipulacao(CommandType.StoredProcedure, "PessoaDeletar").ToString();

                return idPessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //Consultar por id


        public PessoaColecao ConsultarPorNome(string nome)
        {
            try
            {
                //criar coleção vazia
                PessoaColecao pessoaColecao=new PessoaColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Nome",nome);
                DataTable dataTablePessoa = acessoDadosSqlServer.ExecultarConsulta(CommandType.StoredProcedure, "ConsultarPorNome");

                //Percorrer datatable e transformar em coloção de pessoas


                //não esquecer de por Rows
                foreach(DataRow linha in dataTablePessoa.Rows)
                {
                    //criar pessoa vazio e colocar os dados na linha nele e depois adicionar na coleção

                    Pessoa pessoa = new Pessoa();

                    pessoa.IdPessoa=Convert.ToInt32(linha["IdPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Cidade = Convert.ToString(linha["Cidade"]);
                    pessoa.Estado = Convert.ToString(linha["Estado"]);
                    pessoa.Rua = Convert.ToString(linha["Rua"]);
                    pessoa.Numero = Convert.ToInt32(linha["Numero"]);
                    pessoa.Telefone = Convert.ToString(linha["Telefone"]);
                    pessoaColecao.Add(pessoa);

                }
                return pessoaColecao; 
            }
            catch (Exception ex)
            {
                throw new Exception ("falha na rede ou banco" + ex.Message);
            }
        }


        //Consultar por Id

        public PessoaColecao ConsultarPorId(int idPessoa)
        {
            try
            {
                //criar coleção vazia
                PessoaColecao pessoacolecao = new PessoaColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@IdPessoa", idPessoa);
                DataTable dataTablePessoa = acessoDadosSqlServer.ExecultarConsulta(CommandType.StoredProcedure, "ConsultarPorId");

                //Percorrer datatable e transformar em coloção de pessoas


                //não esquecer de por Rows
                foreach (DataRow linha in dataTablePessoa.Rows)
                {
                    //criar pessoa vazio e colocar os dados na linha nele e depois adicionar na coleção

                    Pessoa pessoa = new Pessoa();

                    pessoa.IdPessoa = Convert.ToInt32(linha["IdPessoa"]);
                    pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pessoa.Cidade = Convert.ToString(linha["Cidade"]);
                    pessoa.Estado = Convert.ToString(linha["Estado"]);
                    pessoa.Rua = Convert.ToString(linha["Rua"]);
                    pessoa.Numero = Convert.ToInt32(linha["Numero"]);
                    pessoa.Telefone = Convert.ToString(linha["Telefone"]);
                    pessoacolecao.Add(pessoa);

                }
                return pessoacolecao;
            }
            catch (Exception exception)
            {
                throw new Exception("falha na rede ou banco" + exception.Message);
            }
        }





    }
}