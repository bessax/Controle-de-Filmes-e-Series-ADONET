using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeSeriesFilmes.UTIL
{
    class SeriesFilmesException:Exception
    {
        public SeriesFilmesException(){ }
        public SeriesFilmesException(string mensagem):base(mensagem) { }
        public SeriesFilmesException(string mensagem,Exception ex) : base(mensagem,ex) { }
    }
}
