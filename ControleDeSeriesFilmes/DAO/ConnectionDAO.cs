
using MySql.Data.MySqlClient;

namespace ControleDeSeriesFilmes.DAO
{

    /// <summary>
    /// A implementação abaixo faz uso do Padrão de Projeto (Design Patterns), SINGLETON.
    /// A implementação deste padrão sugere que sempre iremos trabalhar com uma única instância de
    /// um objeto.
    /// </summary>
    sealed class ConnectionDAO
    {

        private static MySqlConnection conn = null; 

        public static MySqlConnection getConnection() {
            if (conn == null)
            {
                conn = new MySqlConnection("Server=localhost;Database=filmesseries;Uid=root;Pwd=root");
            }
            return conn;
        }
    }
}
