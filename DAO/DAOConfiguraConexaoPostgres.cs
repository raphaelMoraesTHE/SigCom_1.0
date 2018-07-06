using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;


namespace DAO
{
    public class DAOConfiguraConexaoPostgres
    {
        private String _stringConexao;
        private NpgsqlConnection _conexao;

        public DAOConfiguraConexaoPostgres(String dadosConexao)
        {
            this._conexao = new NpgsqlConnection();
            this.StringDeConexaoPostgres = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }

        public String StringDeConexaoPostgres
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public NpgsqlConnection ObjetoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public void Conectar()
        {
            if (_conexao.State == ConnectionState.Closed)
            {
                this._conexao.Open();
                return;
            }
        }

        public void Desconectar()
        {
            if (_conexao.State == ConnectionState.Open)
            {
                this._conexao.Close();
                return;
            }
        }

    }
}
