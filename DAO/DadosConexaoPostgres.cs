using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DadosConexaoPostgres
    {
        public static String StringDeConexaoPostgres
        {            
            get
            {
                string connString = null;

                StreamReader sr = File.OpenText(@"C:\temp\sigcom.txt");
                string input = null;
                while((input = sr.ReadLine()) != null)
                {
                    connString = input;
                }

                return connString; //"Host=localhost;Database=sigcom;Username=postgres;Password=raphael";
            }
        }
    }
}
