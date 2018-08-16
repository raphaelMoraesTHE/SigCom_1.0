using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using Model;

namespace DAO
{
    public class DAO_Documentos
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_Documentos(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_Documentos(ModeloDocumentos documentos)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO a_documentos (c_codigo, c_descricao, c_ordpag, c_inativo) VALUES (@codigo, @descricao, @ordpag, @inativo) RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@codigo", documentos.Codigo);
                cmd.Parameters.AddWithValue("@descricao", documentos.Descricao);
                cmd.Parameters.AddWithValue("@ordpag", documentos.OrdPag);
                cmd.Parameters.AddWithValue("@inativo", documentos.Inativo);

                conexao_Postgres.Conectar();
                documentos.Codigo = Convert.ToString(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao_Postgres.Desconectar();
            }
        }

        public void altera_Documentos(ModeloDocumentos documentos)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE a_documentos SET c_descricao = @descricao, c_ordpag = @ordpag, c_inativo = @inativo WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", documentos.Codigo);
                cmd.Parameters.AddWithValue("@descricao", documentos.Descricao);
                cmd.Parameters.AddWithValue("@ordpag", documentos.OrdPag);
                cmd.Parameters.AddWithValue("@inativo", documentos.Inativo);

                conexao_Postgres.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao_Postgres.Desconectar();
            }
        }

        public void excluir_Documentos(String codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_documentos WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                conexao_Postgres.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao_Postgres.Desconectar();
            }
        }

        public DataTable pesquisa_Documentos_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_ordpag FROM a_documentos WHERE c_descricao LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Documentos_Codigo(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_ordpag FROM a_documentos WHERE c_codigo = '" + pesquisa + "';", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Documentos()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_ordpag FROM a_documentos ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_TpDocumento()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_codigo || ' - ' || c_descricao as c_valcombobox FROM a_documentos ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);
                return tabela;
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        
        public ModeloDocumentos carregaModeloDocumentos(String codigo)
        {
            ModeloDocumentos modelo = new ModeloDocumentos();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_documentos WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToString(dt["c_codigo"]);
                modelo.Descricao = Convert.ToString(dt["c_descricao"]);
                modelo.OrdPag = Convert.ToBoolean(dt["c_ordpag"]);
                modelo.Inativo = Convert.ToBoolean(dt["c_inativo"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
