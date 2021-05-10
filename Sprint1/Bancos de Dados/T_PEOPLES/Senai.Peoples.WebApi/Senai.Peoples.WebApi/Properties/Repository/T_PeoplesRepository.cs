using Senai.Peoples.WebApi.Properties.Domains;
using Senai.Peoples.WebApi.Properties.Interfaces;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Repository
{
    public class T_PeoplesRepository : IT_PeoplesRepository
    {
        private string stringConexao = "Data Source=DANIEL-PC\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=1Senhasegur@";
        public void AtualizarIdCorpo(T_PeoplesDomain Nome)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                // Declara a query a ser executada
                string queryUpdateIdBody = "UPDATE Nomes SET Nome = @Nome WHERE idnome = @ID";

                // Declara o SqlCommand cmd passando a query que será executada e a conexão como parâmetros
                using (SqlCommand cmd = new SqlCommand(queryUpdateIdBody, con))
                {
                    // Passa os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@ID", Nome.idnome);
                    cmd.Parameters.AddWithValue("@Nome", Nome.Nome);

                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, T_PeoplesDomain Nome)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryUpdateIdUrl = "UPDATE Generos SET Nome = @Nome WHERE idnome = @ID";


                using (SqlCommand cmd = new SqlCommand(queryUpdateIdUrl, con))
                {

                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nome", Nome.Nome);


                    con.Open();


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public T_PeoplesDomain BuscarPorId(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectById = "SELECT idnome, Nome FROM Generos WHERE idnome = @ID";


                con.Open();


                SqlDataReader rdr;


                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {

                    cmd.Parameters.AddWithValue("@ID", id);


                    rdr = cmd.ExecuteReader();


                    if (rdr.Read())
                    {

                        T_PeoplesDomain generoBuscado = new T_PeoplesDomain
                        {
                            // Atribui à propriedade idGenero o valor da coluna "idGenero" da tabela do banco de dados
                            idnome = Convert.ToInt32(rdr["idnome"]),

                            // Atribui à propriedade nome o valor da coluna "Nome" da tabela do banco de dados
                            Nome = rdr["Nome"].ToString()
                        };

                        // Retorna o generoBuscado com os dados obtidos
                        return generoBuscado;
                    }

                    // Se não, retorna null
                    return null;
                }
            }
        }

        public void Cadastrar(T_PeoplesDomain novoNome)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryInsert = "INSERT INTO Generos(Nome) VALUES (@Nome)";


                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {

                    cmd.Parameters.AddWithValue("@Nome", novoNome.Nome);


                    con.Open();


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string queryDelete = "DELETE FROM Nomes WHERE idnome = @ID";


                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {

                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<T_PeoplesDomain> ListarTodos()
        {
            List<T_PeoplesDomain> listaNomes = new List<T_PeoplesDomain>();
            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                string querySelectAll = "SELECT idnome, Nome FROM Nomes";

                con.Open();

                SqlDataReader rdr;


                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();


                    while (rdr.Read())
                    {

                        using (SqlConnection con = new SqlConnection(stringConexao))
                        {

                            string querySelectAll = "SELECT idnome, Nome FROM Nomes";


                            con.Open();


                            SqlDataReader rdr;


                            using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                            {

                                rdr = cmd.ExecuteReader();

                                while (rdr.Read())
                                {

                                    T_PeoplesDomain nomes = new T_PeoplesDomain()
                                    {

                                        idnome = Convert.ToInt32(rdr[0]),


                                        Nome = rdr[1].ToString()
                                    };


                                    listaNomes.Add(nomes);
                                }
                            }
                        }
                        T_PeoplesDomain nomes = new T_PeoplesDomain()
                        {

                            idnome = Convert.ToInt32(rdr[0]),


                            Nome = rdr[1].ToString()
                        };


                        listaNomes.Add(nomes);
                    }
                }
                return listaNomes;
            }
        }
    }
