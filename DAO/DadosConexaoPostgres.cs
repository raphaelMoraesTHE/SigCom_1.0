using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DadosConexaoPostgres
    {
        public static String ConexaoPostgres
        {
            get
            {
                return "Host=localhost;Database=sigcom;Username=postgres;Password=raphael";
            }
        }
    }
}
