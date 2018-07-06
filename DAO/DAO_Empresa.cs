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
    public class DAO_Empresa
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_Empresa(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_Empresa(ModeloEmpresa empresa)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO" + 
                                 " a_empresa " + 
                                 "(c_nome, c_fantasia, c_sigla, c_endereco, c_endnumero, c_complemento, c_cep, c_telefone, c_celular, c_fax, c_cnpj, c_inscestadual," + 
                                  " c_inscmunicipal, c_cnae, c_codmunicipio, c_regtributario, c_natreceita, c_email, c_site, c_observacao)" + 
                                  " VALUES " +
                                  "(@nome, @fantasia, @sigla, @endereco, @endnumero, @complemento, @cep, @telefone, @celular, @fax, @cnpj, @inscestadual," +
                                  " @inscmunicipal, @cnae, @codmunicipio, @regtributario, @natreceita, @email, @site, @observacao) " + 
                                  "RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@nome", empresa.Nome);
                cmd.Parameters.AddWithValue("@fantasia", empresa.Fantasia);
                cmd.Parameters.AddWithValue("@sigla", empresa.Sigla);
                cmd.Parameters.AddWithValue("@endereco", empresa.Endereco);
                cmd.Parameters.AddWithValue("@endnumero", empresa.EndNumero);
                cmd.Parameters.AddWithValue("@complemento", empresa.Complemento);
                cmd.Parameters.AddWithValue("@bairro", empresa.Bairro);
                cmd.Parameters.AddWithValue("@cep", empresa.Cep);
                cmd.Parameters.AddWithValue("@telefone", empresa.Telefone);
                cmd.Parameters.AddWithValue("@celular", empresa.Celular);
                cmd.Parameters.AddWithValue("@fax", empresa.Fax);
                cmd.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                cmd.Parameters.AddWithValue("@inscestadual", empresa.InscEstadual);
                cmd.Parameters.AddWithValue("@inscmunicipal", empresa.InscMunicipal);
                cmd.Parameters.AddWithValue("@cnae", empresa.Cnae);
                cmd.Parameters.AddWithValue("@codmunicipio", empresa.CodMunicipio);
                cmd.Parameters.AddWithValue("@regtributario", empresa.RegTributario);
                cmd.Parameters.AddWithValue("@natreceita", empresa.NatReceita);
                cmd.Parameters.AddWithValue("@email", empresa.Email);
                cmd.Parameters.AddWithValue("@site", empresa.Site);
                cmd.Parameters.AddWithValue("@observacao", empresa.Observacao);
                
                conexao_Postgres.Conectar();
                empresa.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_Empresa(ModeloEmpresa empresa)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE " + 
                                  "a_empresa " + 
                                  "SET " +
                                  "c_nome = @nome, c_fantasia = @fantasia, c_sigla = @sigla , c_endereco = @endereco, c_endnumero = @endnumero, c_complemento = @complemento, c_bairro = @bairro, c_cep = @cep, " + 
                                  "c_telefone = @telefone, c_celular = @celular, c_fax = @fax, c_cnpj = @cnpj, c_inscestadual = @inscestadual, c_inscmunicipal = @inscmunicipal, c_cnae = @cnae, " + 
                                  "c_codmunicipio = @codmunicipio, c_regtributario = @regtributario, c_natreceita = @natreceita, c_email = @email, c_site = @site, c_observacao = @observacao " + 
                                  "WHERE " + 
                                  "c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", empresa.Codigo);
                cmd.Parameters.AddWithValue("@nome", empresa.Nome);
                cmd.Parameters.AddWithValue("@fantasia", empresa.Fantasia);
                cmd.Parameters.AddWithValue("@sigla", empresa.Sigla);
                cmd.Parameters.AddWithValue("@endereco", empresa.Endereco);
                cmd.Parameters.AddWithValue("@endnumero", empresa.EndNumero);
                cmd.Parameters.AddWithValue("@complemento", empresa.Complemento);
                cmd.Parameters.AddWithValue("@bairro", empresa.Bairro);
                cmd.Parameters.AddWithValue("@cep", empresa.Cep);
                cmd.Parameters.AddWithValue("@telefone", empresa.Telefone);
                cmd.Parameters.AddWithValue("@celular", empresa.Celular);
                cmd.Parameters.AddWithValue("@fax", empresa.Fax);
                cmd.Parameters.AddWithValue("@cnpj", empresa.Cnpj);
                cmd.Parameters.AddWithValue("@inscestadual", empresa.InscEstadual);
                cmd.Parameters.AddWithValue("@inscmunicipal", empresa.InscMunicipal);
                cmd.Parameters.AddWithValue("@cnae", empresa.Cnae);
                cmd.Parameters.AddWithValue("@codmunicipio", empresa.CodMunicipio);
                cmd.Parameters.AddWithValue("@regtributario", empresa.RegTributario);
                cmd.Parameters.AddWithValue("@natreceita", empresa.NatReceita);
                cmd.Parameters.AddWithValue("@email", empresa.Email);
                cmd.Parameters.AddWithValue("@site", empresa.Site);
                cmd.Parameters.AddWithValue("@observacao", empresa.Observacao);

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

        public void excluir_Empresa(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_empresa WHERE c_codigo = @codigo;";

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

        public DataTable pesquisa_Empresa_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_fantasia, c_sigla, c_endereco, c_bairro, c_cnpj, c_inscestadual, c_regtributario, c_natreceita FROM a_empresa WHERE c_nome LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Empresa_Codigo(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_fantasia, c_sigla, c_endereco, c_bairro, c_cnpj, c_inscestadual, c_regtributario, c_natreceita FROM a_empresa WHERE c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Empresa_Cnpj(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_fantasia, c_sigla, c_endereco, c_bairro, c_cnpj, c_inscestadual, c_regtributario, c_natreceita FROM a_empresa WHERE c_cnpj = '" + pesquisa + "';", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Empresa()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_fantasia, c_sigla, c_endereco, c_bairro, c_cnpj, c_inscestadual, c_regtributario, c_natreceita FROM a_empresa ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        
        public ModeloEmpresa informaProximoCodigo()
        {
            ModeloEmpresa modelo = new ModeloEmpresa();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_empresa_c_codigo_seq;";

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
      
        public ModeloEmpresa carregaModeloEmpresa(int codigo)
        {
            ModeloEmpresa modelo = new ModeloEmpresa();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_empresa WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo        = Convert.ToInt32(dt["c_codigo"]);
                modelo.Nome          = Convert.ToString(dt["c_nome"]);
                modelo.Fantasia      = Convert.ToString(dt["c_fantasia"]);
                modelo.Sigla         = Convert.ToString(dt["c_sigla"]);
                modelo.Endereco      = Convert.ToString(dt["c_endereco"]);
                modelo.EndNumero     = Convert.ToString(dt["c_endnumero"]);
                modelo.Complemento   = Convert.ToString(dt["c_complemento"]);
                modelo.Bairro        = Convert.ToString(dt["c_bairro"]);
                modelo.Cep           = Convert.ToString(dt["c_cep"]);
                modelo.Telefone      = Convert.ToString(dt["c_telefone"]);
                modelo.Celular       = Convert.ToString(dt["c_celular"]);
                modelo.Fax           = Convert.ToString(dt["c_fax"]);
                modelo.Cnpj          = Convert.ToString(dt["c_cnpj"]);
                modelo.InscEstadual  = Convert.ToString(dt["c_inscestadual"]);
                modelo.InscMunicipal = Convert.ToString(dt["c_inscmunicipal"]);
                modelo.Cnae          = Convert.ToString(dt["c_cnae"]);
                modelo.CodMunicipio  = Convert.ToInt32(dt["c_codmunicipio"]);
                modelo.RegTributario = Convert.ToString(dt["c_regtributario"]);
                modelo.NatReceita    = Convert.ToString(dt["c_natreceita"]);
                modelo.Email         = Convert.ToString(dt["c_email"]);
                modelo.Site          = Convert.ToString(dt["c_site"]);
                modelo.Observacao    = Convert.ToString(dt["c_observacao"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
