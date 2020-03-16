using ControleDeSeriesFilmes.UTIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeSeriesFilmes.MODEL
{
    class Serie:Filme
    {
        private int temporadas;

        public int Temporadas
        {
            get
            {
                return temporadas;
            }

            set
            {
                if (value < 1)
                {
                    throw new SeriesFilmesException("Série deve possuir ao menos 1 temporada.");
                }
                else
                {
                   temporadas = value;
                }
                
            }
        }
    }
}
