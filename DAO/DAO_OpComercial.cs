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
    public class DAO_OpComercial
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_OpComercial(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_OpComercial(ModeloOpComerciais opComerciais)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO a_opcomerc (c_descricao, c_abreviacao, c_cfopd, c_cfopf, c_serienf, c_maxprod, c_maxserv, c_descmaxitem, c_descmaxnota, c_tpmoviment," +
                                                          "c_tpdevol, c_tpdocfiscal, c_repetidos, c_preco, c_atualizacompra, c_idctcustos, c_movestoque, c_docfiscal, c_calcimposto," +
                                                          "c_estnegativo, c_naoaltpreco, c_numautomatico, c_movdeposito, c_inativo)" +
                                                          "VALUES " +
                                                          "(@descricao, @abreviacao, @cfopd, @cfopf, @serienf, @maxprod, @maxserv, @descmaxitem, @descmaxnota, @tpmoviment," +
                                                          "@tpdevol, @tpdocfiscal, @repetidos, @preco, @atualizacompra, @idctcustos, @movestoque, @docfiscal, @calcimposto," +
                                                          "@estnegativo, @naoaltpreco, @numautomatico, @movdeposito, @inativo) RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@descricao", opComerciais.Descricao);
                cmd.Parameters.AddWithValue("@abreviacao", opComerciais.Abreviacao);
                cmd.Parameters.AddWithValue("@cfopd", opComerciais.CfopD);
                cmd.Parameters.AddWithValue("@cfopf", opComerciais.CfopF);
                cmd.Parameters.AddWithValue("@serienf", opComerciais.SerieNF);
                cmd.Parameters.AddWithValue("@maxprod", opComerciais.MaxProd);
                cmd.Parameters.AddWithValue("@maxserv", opComerciais.MaxServ);
                cmd.Parameters.AddWithValue("@descmaxitem", opComerciais.DescMaxItem);
                cmd.Parameters.AddWithValue("@descmaxnota", opComerciais.DescMaxNota);
                cmd.Parameters.AddWithValue("@tpmoviment", opComerciais.TpMoviment);
                cmd.Parameters.AddWithValue("@tpdevol", opComerciais.TpDevol);
                cmd.Parameters.AddWithValue("@tpdocfiscal", opComerciais.TpDocFiscal);
                cmd.Parameters.AddWithValue("@repetidos", opComerciais.Repetidos);
                cmd.Parameters.AddWithValue("@preco", opComerciais.Preco);
                cmd.Parameters.AddWithValue("@atualizacompra", opComerciais.AtualizaCompra);
                cmd.Parameters.AddWithValue("@idctcustos", opComerciais.IdCustos);
                cmd.Parameters.AddWithValue("@movestoque", opComerciais.MovEstoque);
                cmd.Parameters.AddWithValue("@docfiscal", opComerciais.DocFiscal);
                cmd.Parameters.AddWithValue("@calcimposto", opComerciais.CalcImposto);
                cmd.Parameters.AddWithValue("@estnegativo", opComerciais.EstNegativo);
                cmd.Parameters.AddWithValue("@naoaltpreco", opComerciais.NaoAltPreco);
                cmd.Parameters.AddWithValue("@numautomatico", opComerciais.NumAutomatico);
                cmd.Parameters.AddWithValue("@movdeposito", opComerciais.MovDeposito);
                cmd.Parameters.AddWithValue("@inativo", opComerciais.Inativo);

                conexao_Postgres.Conectar();
                opComerciais.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_OpComercial(ModeloOpComerciais opComerciais)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE a_opcomerc SET c_descricao = @descricao, c_abreviacao = @abreviacao, c_cfopd = @cfopd, c_cfopf = @cfopf, c_serienf = @serienf, c_maxprod = @maxprod," +
                                                        "c_maxserv = @maxserv, c_descmaxitem = @descmaxitem, c_descmaxnota = @descmaxnota, c_tpmoviment = @tpmoviment, c_tpdevol = @tpdevol," + 
                                                        "c_tpdocfiscal = @tpdocfiscal, c_repetidos = @repetidos, c_preco = @preco, c_atualizacompra = @atualizacompra, c_idctcustos = @idctcustos," +
                                                        "c_movestoque = @movestoque, c_docfiscal = @docfiscal, c_calcimposto = @calcimposto, c_estnegativo = @estnegativo, c_naoaltpreco = @naoaltpreco," +
                                                        "c_numautomatico = @numautomatico, c_movdeposito = @movdeposito, c_inativo = @inativo WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", opComerciais.Codigo);
                cmd.Parameters.AddWithValue("@descricao", opComerciais.Descricao);
                cmd.Parameters.AddWithValue("@abreviacao", opComerciais.Abreviacao);
                cmd.Parameters.AddWithValue("@cfopd", opComerciais.CfopD);
                cmd.Parameters.AddWithValue("@cfopf", opComerciais.CfopF);
                cmd.Parameters.AddWithValue("@serienf", opComerciais.SerieNF);
                cmd.Parameters.AddWithValue("@maxprod", opComerciais.MaxProd);
                cmd.Parameters.AddWithValue("@maxserv", opComerciais.MaxServ);
                cmd.Parameters.AddWithValue("@descmaxitem", opComerciais.DescMaxItem);
                cmd.Parameters.AddWithValue("@descmaxnota", opComerciais.DescMaxNota);
                cmd.Parameters.AddWithValue("@tpmoviment", opComerciais.TpMoviment);
                cmd.Parameters.AddWithValue("@tpdevol", opComerciais.TpDevol);
                cmd.Parameters.AddWithValue("@tpdocfiscal", opComerciais.TpDocFiscal);
                cmd.Parameters.AddWithValue("@repetidos", opComerciais.Repetidos);
                cmd.Parameters.AddWithValue("@preco", opComerciais.Preco);
                cmd.Parameters.AddWithValue("@atualizacompra", opComerciais.AtualizaCompra);
                cmd.Parameters.AddWithValue("@idctcustos", opComerciais.IdCustos);
                cmd.Parameters.AddWithValue("@movestoque", opComerciais.MovEstoque);
                cmd.Parameters.AddWithValue("@docfiscal", opComerciais.DocFiscal);
                cmd.Parameters.AddWithValue("@calcimposto", opComerciais.CalcImposto);
                cmd.Parameters.AddWithValue("@estnegativo", opComerciais.EstNegativo);
                cmd.Parameters.AddWithValue("@naoaltpreco", opComerciais.NaoAltPreco);
                cmd.Parameters.AddWithValue("@numautomatico", opComerciais.NumAutomatico);
                cmd.Parameters.AddWithValue("@movdeposito", opComerciais.MovDeposito);
                cmd.Parameters.AddWithValue("@inativo", opComerciais.Inativo);

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

        public void excluir_OpComercial(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_opcomerc WHERE c_codigo = @codigo;";

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

        public DataTable pesquisa_OpComercial_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_decricao, c_abreviacao, c_cfopd, c_cfopf, c_serienf, c_descmaxitem, c_descmaxnota, c_tpmoviment," + 
                                                                    "c_idctcustos, c_movestoque, c_docfiscal, c_calcimposto, c_estnegativo, c_naoaltpreco, c_numautomatico, c_movdeposito " + 
                                                                    "FROM a_opcomerc WHERE c_descricao LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_OpComercial_Codigo(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_decricao, c_abreviacao, c_cfopd, c_cfopf, c_serienf, c_descmaxitem, c_descmaxnota, c_tpmoviment," +
                                                                    "c_idctcustos, c_movestoque, c_docfiscal, c_calcimposto, c_estnegativo, c_naoaltpreco, c_numautomatico, c_movdeposito " +
                                                                    "FROM a_opcomerc WHERE c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_OpComercial()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_abreviacao, c_cfopd, c_cfopf, c_serienf, c_descmaxitem, c_descmaxnota, c_tpmoviment," +
                                                                    "c_idctcustos, c_movestoque, c_docfiscal, c_calcimposto, c_estnegativo, c_naoaltpreco, c_numautomatico, c_movdeposito " +
                                                                    "FROM a_opcomerc ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloOpComerciais informaProximoCodigo()
        {
            ModeloOpComerciais modelo = new ModeloOpComerciais();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_opcomerc_c_codigo_seq;";

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

        public ModeloOpComerciais carregaModeloOpComercial(int codigo)
        {
            ModeloOpComerciais modelo = new ModeloOpComerciais();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_opcomerc WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["c_codigo"]);
                modelo.Descricao = Convert.ToString(dt["c_descricao"]);
                modelo.Abreviacao = Convert.ToString(dt["c_abreviacao"]);
                modelo.CfopD = Convert.ToString(dt["c_cfopd"]);
                modelo.CfopF = Convert.ToString(dt["c_cfopf"]);
                modelo.SerieNF = Convert.ToString(dt["c_serienf"]);
                modelo.MaxProd = Convert.ToInt32(dt["c_maxprod"]);
                modelo.MaxServ = Convert.ToInt32(dt["c_maxserv"]);
                modelo.DescMaxItem = Convert.ToDouble(dt["c_descmaxitem"]);
                modelo.DescMaxNota = Convert.ToDouble(dt["c_descmaxnota"]);
                modelo.TpMoviment = Convert.ToString(dt["c_tpmoviment"]);
                modelo.TpDevol = Convert.ToString(dt["c_tpdevol"]);
                modelo.TpDocFiscal = Convert.ToString(dt["c_tpdocfiscal"]);
                modelo.Repetidos = Convert.ToString(dt["c_repetidos"]);
                modelo.Preco = Convert.ToString(dt["c_preco"]);
                modelo.AtualizaCompra = Convert.ToString(dt["c_atualizacompra"]);
                modelo.IdCustos = Convert.ToInt32(dt["c_idctcustos"]);
                modelo.MovEstoque = Convert.ToBoolean(dt["c_movestoque"]);
                modelo.DocFiscal = Convert.ToBoolean(dt["c_movestoque"]);
                modelo.CalcImposto = Convert.ToBoolean(dt["c_calcimposto"]);
                modelo.EstNegativo = Convert.ToBoolean(dt["c_estnegativo"]);
                modelo.NaoAltPreco = Convert.ToBoolean(dt["c_naoaltpreco"]);
                modelo.NumAutomatico = Convert.ToBoolean(dt["c_numautomatico"]);
                modelo.MovDeposito = Convert.ToBoolean(dt["c_movdeposito"]);
                modelo.Inativo = Convert.ToBoolean(dt["c_inativo"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
