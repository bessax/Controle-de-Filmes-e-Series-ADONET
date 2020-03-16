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
    class SeriesDAO
    {

        internal int SerieInsertDAO(Serie serie)
        {
            int retorno = 0;

            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("INSERT INTO SERIES(NOME,CLASSIFICACAO,DIRETOR,ESTUDIO,DURACAO,TEMPORADAS) ");
                    comandoSQL.Append("VALUES (@nome,@classificacao,@diretor,@estudio,@duracao,@temporadas)");
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@nome", serie.Nome);
                    comando.Parameters.AddWithValue("@classificacao", serie.Classificacao);
                    comando.Parameters.AddWithValue("@diretor", serie.Diretor);
                    comando.Parameters.AddWithValue("@estudio", serie.Estudio);
                    comando.Parameters.AddWithValue("@duracao", serie.Duracao);
                    comando.Parameters.AddWithValue("@temporada", serie.Temporadas);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO INSERT DO SÉRIE .:" + ex.Message);
                }


            }

            return retorno;
        }

        internal int SerieUpdateDAO(Serie serie)
        {
            int retorno = 0;

            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("UPDATE SERIES SET NOME=@nome,CLASSIFICACAO=@classificacao,DIRETOR=@diretor,ESTUDIO=@estudio,DURACAO=@duracao,TEMPORADAS=@temporadas ");
                    comandoSQL.Append(" WHERE ID=@id ");
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@nome", serie.Nome);
                    comando.Parameters.AddWithValue("@classificacao", serie.Classificacao);
                    comando.Parameters.AddWithValue("@diretor", serie.Diretor);
                    comando.Parameters.AddWithValue("@estudio", serie.Estudio);
                    comando.Parameters.AddWithValue("@duracao", serie.Duracao);
                    comando.Parameters.AddWithValue("@temporada", serie.Temporadas);
                    comando.Parameters.AddWithValue("@id", serie.Id);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO UPDATE DO SÉRIE .:" + ex.Message);
                }


            }

            return retorno;
        }



        internal int SerieDeleteDAO(int serieCodigo)
        {
            int retorno = 0;

            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("DELETE FROM SERIES WHERE ID=@id");
                    comandoSQL.Append(" WHERE ID=@id ");
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@id", serieCodigo);
                    retorno = comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO DELETE DO SÉRIE .:" + ex.Message);
                }


            }

            return retorno;
        }

        internal List<Serie> SerieRetrieveDAO()
        {
            List<Serie> lista = new List<Serie>();

            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("SELECT * FROM SERIES ");
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
                            Serie serieTemp = new Serie();
                            serieTemp.Id = Convert.ToInt32(reader["id"].ToString());
                            serieTemp.Nome = reader["nome"].ToString();
                            serieTemp.Classificacao = reader["classificacao"].ToString();
                            serieTemp.Diretor = reader["diretor"].ToString();
                            serieTemp.Estudio = reader["estudio"].ToString();
                            serieTemp.Duracao = Convert.ToInt32(reader["duracao"].ToString());
                            serieTemp.Temporadas = Convert.ToInt32(reader["temporadas"].ToString());

                            lista.Add(serieTemp);

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

        internal Serie SerieRetrieveSingleDAO(int filmeCodigo)
        {
            Serie serieTemp = new Serie();
            using (var conn = ConnectionDAO.getConnection())
            {
                try
                {
                    conn.Open();
                    var comandoSQL = new StringBuilder();
                    comandoSQL.Append("SELECT * FROM SERIES");
                    comandoSQL.Append(" WHERE ID=@id ");
                    MySqlCommand comando = new MySqlCommand(comandoSQL.ToString(), conn);
                    comando.Parameters.AddWithValue("@id", filmeCodigo);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows == false)
                    {
                        serieTemp = null;
                    }
                    else
                    {

                        while (reader.Read())
                        {

                            serieTemp.Id = Convert.ToInt32(reader["id"].ToString());
                            serieTemp.Nome = reader["nome"].ToString();
                            serieTemp.Classificacao = reader["classificacao"].ToString();
                            serieTemp.Diretor = reader["diretor"].ToString();
                            serieTemp.Estudio = reader["estudio"].ToString();
                            serieTemp.Duracao = Convert.ToInt32(reader["duracao"].ToString());
                            serieTemp.Temporadas = Convert.ToInt32(reader["temporadas"].ToString());


                        }
                    }

                }
                catch (Exception ex)
                {

                    throw new SeriesFilmesException(" EXCEÇÃO NO SELECT DO FILME .:" + ex.Message);
                }


            }
            return serieTemp;
        }
    }
}
