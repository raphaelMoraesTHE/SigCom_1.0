using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Npgsql;
using System.Data;

namespace DAO
{
    public class DAO_TabMunicipio
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_TabMunicipio(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public DataTable pesquisa_Municipio_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id, u.sigla, m.nome FROM tab_municipios m JOIN tab_uf u ON (m.iduf = u.iduf) WHERE m.nome LIKE '" + pesquisa + "%' ORDER BY m.id;", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Municipio()
        {
            try
            {
                DataTable tabela = new DataTable();
                //NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_fantasia, c_sigla FROM a_empresa ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id, u.sigla, m.nome FROM tab_municipios m JOIN tab_uf u ON (m.iduf = u.iduf) ORDER BY m.id;", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloTabMunicipio carregaModeloMunicipio(int codigo)
        {
            ModeloTabMunicipio modelo = new ModeloTabMunicipio();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            //cmd.CommandText = "SELECT * FROM a_municipios WHERE id = @codigo;";
            cmd.CommandText = "SELECT m.id, u.sigla, m.nome FROM tab_municipios m JOIN tab_uf u ON (m.iduf = u.iduf) WHERE id = @codigo ORDER BY m.id;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["id"]);
                modelo.SiglaUF = Convert.ToString(dt["sigla"]);
                modelo.Nome = Convert.ToString(dt["nome"]);                               
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
