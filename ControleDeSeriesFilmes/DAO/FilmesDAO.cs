using ControleDeSeriesFilmes.MODEL;
using ControleDeSeriesFilmes.UTIL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeSeriesFilmes.DAO
{
    class FilmesDAO
    {
        /// <summary>
        /// Método que insere um objeto do tipo filme na base de dados.
        /// Se o retorno for 1, o objeto foi inserido com sucesso no banco de dados.
        /// </summary>
        internal int FilmeInsertDAO(Filme filme)
        {
            int retorno = 0;
            
            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("INSERT INTO FILMES(NOME,CLASSIFICACAO,DIRETOR,ESTUDIO,DURACAO) ");
                    comandoSQL.Append("VALUES (@nome,@classificacao,@diretor,@estudio,@duracao)");
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@nome", filme.Nome);
                    comando.Parameters.AddWithValue("@classificacao", filme.Classificacao);
                    comando.Parameters.AddWithValue("@diretor", filme.Diretor);
                    comando.Parameters.AddWithValue("@estudio", filme.Estudio);
                    comando.Parameters.AddWithValue("@duracao", filme.Duracao);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO INSERT DO FILME .:" + ex.Message);
                }              
                

            }

            return retorno;
        }

        internal int FilmeUpdateDAO(Filme filme)
        {
            int retorno = 0;

            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("UPDATE FILMES SET NOME=@nome,CLASSIFICACAO=@classificacao,DIRETOR=@diretor,ESTUDIO=@estudio,DURACAO=@duracao ");
                    comandoSQL.Append("WHERE ID=@id ");
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@nome", filme.Nome);
                    comando.Parameters.AddWithValue("@classificacao", filme.Classificacao);
                    comando.Parameters.AddWithValue("@diretor", filme.Diretor);
                    comando.Parameters.AddWithValue("@estudio", filme.Estudio);
                    comando.Parameters.AddWithValue("@duracao", filme.Duracao);
                    comando.Parameters.AddWithValue("@id", filme.Id);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO UPDATE DO FILME .:" + ex.Message);
                }


            }

            return retorno;
        }



        internal int FilmeDeleteDAO(int filmeCodigo)
        {
            int retorno = 0;

            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("DELETE FROM FILMES WHERE ID=@id");                    
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);                 
                    comando.Parameters.AddWithValue("@id", filmeCodigo);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO DELETE DO FILME .:" + ex.Message);
                }


            }

            return retorno;
        }

        internal List<Filme> FilmeRetrieveDAO()
        {
          List<Filme> lista = new List<Filme>();
            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("SELECT * FROM FILMES ORDER BY ID");                    
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows == false)
                    {
                        lista = null;
                    }
                    else
                    {
                     
                        while (reader.Read())
                        {
                            Filme filmeTemp = new Filme();
                            filmeTemp.Id = Convert.ToInt32(reader["id"].ToString());
                            filmeTemp.Nome = reader["nome"].ToString();
                            filmeTemp.Classificacao = reader["classificacao"].ToString();
                            filmeTemp.Diretor = reader["diretor"].ToString();
                            filmeTemp.Estudio = reader["estudio"].ToString();
                            filmeTemp.Duracao = Convert.ToInt32(reader["duracao"].ToString());

                            lista.Add(filmeTemp);

                        }
                    }
                    
                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO SELECT DO FILME .:" + ex.Message);
                }


            }



            return lista;

       }

    internal Filme FilmeRetrieveSingleDAO(int filmeCodigo)
        {
            Filme filmeTemp = new Filme();
            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("SELECT * FROM FILMES ORDER BY ID");
                    comandoSQL.Append(" WHERE ID=@id ");
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@id", filmeCodigo);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows == false)
                    {
                        filmeTemp = null;
                    }
                    else
                    {

                        while (reader.Read())
                        {
                            
                            filmeTemp.Id = Convert.ToInt32(reader["id"].ToString());
                            filmeTemp.Nome = reader["nome"].ToString();
                            filmeTemp.Classificacao = reader["classificacao"].ToString();
                            filmeTemp.Diretor = reader["diretor"].ToString();
                            filmeTemp.Estudio = reader["estudio"].ToString();
                            filmeTemp.Duracao = Convert.ToInt32(reader["duracao"].ToString());
                          

                        }
                    }

                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO SELECT DO FILME .:" + ex.Message);
                }

                
            }
            return filmeTemp;
        }
    }
}
