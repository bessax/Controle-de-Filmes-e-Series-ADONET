using ControleDeSeriesFilmes.DAO;
using ControleDeSeriesFilmes.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeSeriesFilmes.MODEL
{
     class Filme
    {
        private FilmesDAO filmesDAO = null;
        private int id;
        private string nome;
        private string classificacao;
        private string diretor;
        private string estudio;
        private int duracao;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Classificacao
        {
            get
            {
                return classificacao;
            }

            set
            {
                classificacao = value;
            }
        }

        public string Diretor
        {
            get
            {
                return diretor;
            }

            set
            {
                diretor = value;
            }
        }

        public string Estudio
        {
            get
            {
                return estudio;
            }

            set
            {
                estudio = value;
            }
        }

        public int Duracao
        {
            get
            {
                return duracao;
            }

            set
            {
                if (value >=60 )
                {
                    duracao = value;
                }
                else
                {
                   
                    throw new SeriesFilmesException("Duração do filme deve possuir pelo menos 60 minutos.");
                }
                
            }
        }

        

        public int FilmeInsert(Filme filme)
        {
            return filmesDAO.FilmeInsertDAO(filme);
        }

        public int FilmeUpdate(Filme filme)
        {
            return filmesDAO.FilmeUpdateDAO(filme);

        }

        public int FilmeDelete(int filmeCodigo)
        {
            return filmesDAO.FilmeDeleteDAO(filmeCodigo);

        }

        public List<Filme> FilmeRetrieve()
        {

            return filmesDAO.FilmeRetrieveDAO();
        }

        public Filme FilmeRetrieveSingle(int filmeCodigo)
        {
            return filmesDAO.FilmeRetrieveSingleDAO(filmeCodigo);

        }
    }
}