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
    public class DAO_CargosFuncoes
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_CargosFuncoes(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_CargosFuncoes(ModeloCargosFuncoes cargosFuncoes)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO a_cargos (c_descricao, c_vendedor, c_tecnico, c_motorista, c_supervisor, c_cobrador, c_outros) " +
                                  "VALUES (@descricao, @vendedor, @tecnico, @motorista, @supervisor, @cobrador, @outros) RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@descricao", cargosFuncoes.Descricao);
                cmd.Parameters.AddWithValue("@vendedor", cargosFuncoes.Vendedor);
                cmd.Parameters.AddWithValue("@tecnico", cargosFuncoes.Tecnico);
                cmd.Parameters.AddWithValue("@motorista", cargosFuncoes.Motorista);
                cmd.Parameters.AddWithValue("@supervisor", cargosFuncoes.Supervisor);
                cmd.Parameters.AddWithValue("@cobrador", cargosFuncoes.Cobrador);
                cmd.Parameters.AddWithValue("@outros", cargosFuncoes.Outros);

                conexao_Postgres.Conectar();
                cargosFuncoes.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_CargosFuncoes(ModeloCargosFuncoes cargosFuncoes)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE a_cargos SET c_descricao = @descricao, c_vendedor = @vendedor, c_tecnico = @tecnico, c_motorista = @motorista, c_supervisor = @supervisor, c_cobrador = @cobrador, c_outros = @outros WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", cargosFuncoes.Codigo);
                cmd.Parameters.AddWithValue("@descricao", cargosFuncoes.Descricao);
                cmd.Parameters.AddWithValue("@vendedor", cargosFuncoes.Vendedor);
                cmd.Parameters.AddWithValue("@tecnico", cargosFuncoes.Tecnico);
                cmd.Parameters.AddWithValue("@motorista", cargosFuncoes.Motorista);
                cmd.Parameters.AddWithValue("@supervisor", cargosFuncoes.Supervisor);
                cmd.Parameters.AddWithValue("@cobrador", cargosFuncoes.Cobrador);
                cmd.Parameters.AddWithValue("@outros", cargosFuncoes.Outros);

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

        public void excluir_CargosFuncoes(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_cargos WHERE c_codigo = @codigo;";

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

        public DataTable pesquisa_CargosFuncoes_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_vendedor, c_tecnico, c_motorista, c_supervisor, c_cobrador, c_outros FROM a_cargos WHERE c_descricao LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CargosFuncoes_Codigo(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_vendedor, c_tecnico, c_motorista, c_supervisor, c_cobrador, c_outros FROM a_cargos WHERE c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_CargosFuncoes()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_vendedor, c_tecnico, c_motorista, c_supervisor, c_cobrador, c_outros FROM a_cargos ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCargosFuncoes informaProximoCodigo()
        {
            ModeloCargosFuncoes modelo = new ModeloCargosFuncoes();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_cargos_c_codigo_seq;";

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["proximo"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }

        public ModeloCargosFuncoes carregaModeloCargosFuncoes(int codigo)
        {
            ModeloCargosFuncoes modelo = new ModeloCargosFuncoes();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_cargos WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["c_codigo"]);
                modelo.Descricao = Convert.ToString(dt["c_descricao"]);
                modelo.Vendedor = Convert.ToBoolean(dt["c_vendedor"]);
                modelo.Tecnico = Convert.ToBoolean(dt["c_tecnico"]);
                modelo.Motorista = Convert.ToBoolean(dt["c_motorista"]);
                modelo.Supervisor = Convert.ToBoolean(dt["c_supervisor"]);
                modelo.Cobrador = Convert.ToBoolean(dt["c_cobrador"]);
                modelo.Outros = Convert.ToBoolean(dt["c_outros"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
