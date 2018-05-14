using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using DAO;
using Model;
using BLL;

namespace GUI
{
    public partial class frm_CadastroUsuario : Form
    {
        public frm_CadastroUsuario()
        {
            InitializeComponent();
        }
        
        private void frm_CadastroUsuario_Load(object sender, EventArgs e)
        {
            desabilita_Campos();
            popula_Grid();                        
        }

        public void popula_Grid()
        {
            try
            {
                DAO_Usuario usuario_BLL = new DAO_Usuario();
                dgv_Usuario.DataSource = usuario_BLL.lista_Usuario();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao listar usuário " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_NomeUsuario.ReadOnly = true;
            txb_SenhaUsuario.ReadOnly = true;
            txb_ConfirmaSenhaUsuario.ReadOnly = true;
            txb_SenhaAtualUsuario.ReadOnly = true;
            txb_EmailUsuario.ReadOnly = true;
            cbx_CaixaUsuario.Enabled = false;
            cbx_LojaUsuario.Enabled = false;
            cbx_PerfilAcessoUsuario.Enabled = false;
            cbx_CaixaUsuario.Enabled = false;
            cbx_LojaAutorizadasUsuario.Enabled = false;
        }

        public void habilita_Campos()
        {
            txb_NomeUsuario.ReadOnly = false;
            txb_SenhaUsuario.ReadOnly = false;
            txb_ConfirmaSenhaUsuario.ReadOnly = false;
            txb_SenhaAtualUsuario.ReadOnly = false;
            txb_EmailUsuario.ReadOnly = false;
            cbx_CaixaUsuario.Enabled = true;            
            cbx_LojaUsuario.Enabled = true;            
            cbx_PerfilAcessoUsuario.Enabled = true;
            cbx_CaixaUsuario.Enabled = true;            
        }

        public void limpa_Campos()
        {
            txb_NomeUsuario.Text = "";
            txb_SenhaUsuario.Text = "";
            txb_ConfirmaSenhaUsuario.Text = "";
            txb_SenhaAtualUsuario.Text = "";
            txb_EmailUsuario.Text = "";
        }

        //Acões e comportamentos dos controles combobox no formulário de cadastro de usuário
        #region Controles de comboBox do formulário

        //Este método preenche o campo de texto com a informação referente ao iten selecionado no comboBox
        private void cbx_LojaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            String conexao_Postgres = @"Server = localhost; Port = 5432; Database = sigcom; User Id = postgres; Password = raphael;";
            NpgsqlConnection conexao = null;

            try
            {
                conexao = new NpgsqlConnection(conexao_Postgres);

                if (cbx_LojaUsuario.SelectedIndex >= 0)
                {
                    int valor = Convert.ToInt32(cbx_LojaUsuario.SelectedValue);
                    txb_NomeLojaUsuario.Text = valor.ToString();//Convert.ToString(valor);

                    if (conexao.State == 0)
                        conexao.Open();

                    NpgsqlCommand sql = new NpgsqlCommand("select c_sigla from a_empresa where c_codigo = @cod_empresa", conexao);
                    sql.Parameters.Add("@cod_empresa", NpgsqlTypes.NpgsqlDbType.Integer).Value = Convert.ToInt32(txb_NomeLojaUsuario.Text);

                    NpgsqlDataReader lerDados;
                    lerDados = sql.ExecuteReader();

                    if (lerDados.Read())
                    {
                        txb_NomeLojaUsuario.Text = lerDados["c_sigla"].ToString();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao exibir o nome da filial! " + erro);
            }
            finally
            {
                conexao.Close();
            }
        }//Fim do método preenche textBom utilizando seleção de comboBox

        //Preenche comboBox com valores da tabela de Empresas
        private void preencher_Cbx_LojaUsuario()
        {
            String conexao_Postgres = @"Server = localhost; Port = 5432; Database = sigcom; User Id = postgres; Password = raphael;";
            NpgsqlConnection conexao = null;
            
            try
            {
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("select * from a_empresa order by c_codigo", conexao);

                conexao.Open();

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = sql;
                DataTable dtUsuario = new DataTable();
                dtUsuario.Clear();
                dataAdapter.Fill(dtUsuario);

                cbx_LojaUsuario.DataSource = dtUsuario;
                cbx_LojaUsuario.ValueMember = "c_codigo";
                cbx_LojaUsuario.DisplayMember = "c_codigo";
                cbx_LojaUsuario.SelectedItem = "";
                cbx_LojaUsuario.Refresh();               

            }
            catch(Exception erro)
            {
                MessageBox.Show("Falha ao consultar dados empresa." + erro);
            }
            finally
            {
                conexao.Close();
            }
        }// Fim do métoldo preenche comboBox        
        #endregion

        //Ações referente aos Eventos de botão Novo do formulário de cadastro de usuários
        #region Novo usuário
        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            limpa_Campos();
            habilita_Campos();
            preencher_Cbx_LojaUsuario();
        }
        #endregion
        
        //Ações referente ao cadastro e inclusão de novo usuário no sistema
        #region Cadastro de usuários
        private void btn_GravarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if(txb_NomeUsuario.Text.Length < 1 || txb_SenhaUsuario.Text.Length < 1)
                {
                    MessageBox.Show("Não é possivel gravar com dados em branco", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Confirma novo registro?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                else
                {
                    ModeloUsuario obj_Usuario = new ModeloUsuario();
                    obj_Usuario.Nome = txb_NomeUsuario.Text;
                    obj_Usuario.Senha = txb_SenhaUsuario.Text;

                    BLL_Usuario usuario_bll = new BLL_Usuario();
                    usuario_bll.dao_grava_usuario(obj_Usuario);

                    MessageBox.Show("Registro gravado com sucesso!");
                }                            

                popula_Grid();
                limpa_Campos();
                desabilita_Campos();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar usuário " + erro);
            }
        }


        #endregion

        private void cbx_CaixaUsuario_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida();
            frmConsultaRapida.ShowDialog();
        }

        private void buttonEditChildButton1_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida();
            frmConsultaRapida.ShowDialog();
        }
    }
}
