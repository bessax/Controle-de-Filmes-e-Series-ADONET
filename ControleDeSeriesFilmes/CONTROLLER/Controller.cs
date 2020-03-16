using ControleDeSeriesFilmes.DAO;
using ControleDeSeriesFilmes.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeSeriesFilmes.CONTROLLER
{
    static class Controller
    {
        static FilmesDAO daofilmes = new FilmesDAO();

        static public List<Filme> GetFilmes() {
            return daofilmes.FilmeRetrieveDAO();            
        }

        static public Filme GetFilme(int codigoFilme)
        {
            return daofilmes.FilmeRetrieveSingleDAO(codigoFilme);
        }

        static public int InsertFilme(Filme filme)
        {

            return daofilmes.FilmeInsertDAO(filme);
        }

        static public int InsertFilme(string nome,string diretor,int duracao,string classificacao,string estudio)
        {
            Filme filme = new Filme();
            filme.Diretor = diretor;
            filme.Duracao = duracao;
            filme.Classificacao = classificacao;
            filme.Nome = nome;
            filme.Estudio = estudio;
            return daofilmes.FilmeInsertDAO(filme);
        }

        static public int UpdateFilme(Filme filme)
        {
            return daofilmes.FilmeUpdateDAO(filme);
        }

        static public int UpdateFilme(int codigo,string nome, string diretor, int duracao, string classificacao, string estudio)
        {
            Filme filme = new Filme();
            filme.Id = codigo;
            filme.Diretor = diretor;
            filme.Duracao = duracao;
            filme.Classificacao = classificacao;
            filme.Nome = nome;
            filme.Estudio = estudio;
            return daofilmes.FilmeUpdateDAO(filme);
        }

        static public int DeleteFilme(int codigoFilme)
        {
            return daofilmes.FilmeDeleteDAO(codigoFilme);
        }



    }
}
