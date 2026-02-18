using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace Bibliblioteca.DAO
{
    internal class Local
    {
        private const string stringConexao = "SERVER=localhost; PORT=3306; DATABASE =db_empregado;UID = root; PWD=1234";
        public int Matricula { get; set; };
        public string Cpf { get; set; };
        public string Nome { get; set; };
        public string Endereco { get; set; };
        public DataTable Pesquisar()
        {

        }
    }
}
