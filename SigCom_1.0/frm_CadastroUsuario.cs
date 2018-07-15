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
        DAOConfiguraConexaoPostgres cx = null;
        BLL_Usuario bll = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void frm_CadastroUsuario_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            desabilita_Campos();
            popula_Grid();
            cbx_PesquisarUsuario.SelectedIndex = 0;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                bll = new BLL_Usuario(cx);

                dgv_Usuario.DataSource = bll.lista_Usuario();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_Usuario.RowHeadersWidth = 24;
                dgv_Usuario.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_Usuario.Columns[0].HeaderText = "Cód.";
                dgv_Usuario.Columns[0].Width = 45;
                dgv_Usuario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Usuario.Columns[1].HeaderText = "Dt.Cad.";
                dgv_Usuario.Columns[1].Width = 80;
                dgv_Usuario.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_Usuario.Columns[2].HeaderText = "Filial";
                dgv_Usuario.Columns[2].Width = 45;
                dgv_Usuario.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Usuario.Columns[3].HeaderText = "Caixa";
                dgv_Usuario.Columns[3].Width = 45;
                dgv_Usuario.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_Usuario.Columns[4].HeaderText = "Nome";
                dgv_Usuario.Columns[4].Width = 480;
                dgv_Usuario.Columns[5].HeaderText = "Email";
                dgv_Usuario.Columns[5].Width = 150;
                dgv_Usuario.Columns[6].HeaderText = "Senha";
                dgv_Usuario.Columns[6].Width = 60;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar usuário " + erro);
            }
        }

        //Preenche comboBox com valores da tabela de Empresas
        private void preencher_Cbx_LojaUsuario()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Empresa bll = new BLL_Empresa(cx);

                cbx_LojaUsuario.DataSource = bll.lista_Empresa();
                cbx_LojaUsuario.ValueMember = "c_codigo";
                cbx_LojaUsuario.DisplayMember = "c_codigo";
                cbx_LojaUsuario.SelectedItem = "";
                cbx_LojaUsuario.Refresh();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao consultar dados empresa." + erro);
            }

        }// Fim do métoldo preenche comboBox        

        //Este método preenche o campo de texto com a informação referente ao iten selecionado no comboBox
        private void cbx_LojaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_LojaUsuario.SelectedIndex != -1)
                {
                    DataRowView drw = ((DataRowView)cbx_LojaUsuario.SelectedItem);
                    txb_NomeLojaUsuario.Text = drw["c_sigla"].ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao exibir o nome da filial! " + erro);
            }

        }//Fim do método preenche textBom utilizando seleção de comboBox        

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
            txb_CodigoUsuario.Clear();
            txb_NomeUsuario.Clear();
            txb_SenhaUsuario.Clear();
            txb_ConfirmaSenhaUsuario.Clear();
            txb_SenhaAtualUsuario.Clear();
            txb_EmailUsuario.Clear();
            txb_DataCadastroUsuario.Clear();
            txb_NomeLojaUsuario.Clear();
            tbx_NomeCaixaUsuario.Clear();
            buttonEdit1.ResetText();
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoUsuario.Enabled = false;
            btn_AlterarUsuario.Enabled = false;
            btn_PesquisarUsuario.Enabled = false;
            btn_ExcluirUsuario.Enabled = false;
            btn_GravarUsuario.Enabled = false;
            btn_ImprimirUsuario.Enabled = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoUsuario.Enabled = true;
                btn_PesquisarUsuario.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarUsuario.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarUsuario.Enabled = true;
                btn_ExcluirUsuario.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            limpa_Campos();
            //habilita_Campos();
            txb_DataCadastroUsuario.Text = DateTime.Now.ToShortDateString();
            preencher_Cbx_LojaUsuario();

            try
            {
                BLL_Usuario bll = new BLL_Usuario(cx);
                ModeloUsuario modelo = bll.informaProximoCodigo();
                txb_CodigoUsuario.Text = modelo.Codigo.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Infomar o proximo código " + erro);
            }
        }

        private void btn_AlterarUsuario_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_ExcluirUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    bll = new BLL_Usuario(cx);
                    bll.excluir_Usuario(Convert.ToInt32(txb_CodigoUsuario.Text));

                    this.popula_Grid();
                    this.limpa_Campos();
                    this.altera_Botoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro, \nO registro está sendo utilizado em outro local.");
                this.altera_Botoes(3);
            }
        }

        private void btn_GravarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloUsuario obj_Usuario = new ModeloUsuario();

                obj_Usuario.Nome = txb_NomeUsuario.Text;
                obj_Usuario.Senha = txb_SenhaUsuario.Text;
                obj_Usuario.Filial = Convert.ToInt32(cbx_LojaUsuario.Text);
                obj_Usuario.Caixa = Convert.ToInt32(buttonEdit1.Text);
                obj_Usuario.DataCad = Convert.ToDateTime(txb_DataCadastroUsuario.Text);
                obj_Usuario.Email = txb_EmailUsuario.Text;

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                bll = new BLL_Usuario(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_Usuario(obj_Usuario);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_Usuario.Codigo.ToString());
                }
                else
                {
                    obj_Usuario.Codigo = Convert.ToInt32(txb_CodigoUsuario.Text);
                    bll.alterar_Usuario(obj_Usuario);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar usuário " + erro);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.limpa_Campos();
        }

        private void cbx_CaixaUsuario_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("caixa");
            frmConsultaRapida.ShowDialog();

            if (frmConsultaRapida.codigo != 0)
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Caixa bll = new BLL_Caixa(cx);
                ModeloCaixa modelo = bll.carregaModeloCaixa(frmConsultaRapida.codigo);
                buttonEdit1.TextBox.Text = modelo.Codigo.ToString();
                tbx_NomeCaixaUsuario.Text = modelo.Descricao;
            }
            frmConsultaRapida.Dispose();
        }

        private void cbx_PerfildeAcesso_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("perfil");
            frmConsultaRapida.ShowDialog();

            //if (frmConsultaRapida.codigo != 0)
            //{
            //    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            //    BLL_Caixa bll = new BLL_Caixa(cx);
            //    ModeloCaixa modelo = bll.carregaModeloCaixa(frmConsultaRapida.codigo);
            //    buttonEdit1.TextBox.Text = modelo.Codigo.ToString();
            //    tbx_NomeCaixaUsuario.Text = modelo.Descricao;
            //}
            //frmConsultaRapida.Dispose();
        }

        private void btn_PesquisarUsuario_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            bll = new BLL_Usuario(cx);
            if (cbx_PesquisarUsuario.SelectedIndex == 0)
            {
                dgv_Usuario.DataSource = bll.pesquisa_Usuario_Nome(txb_PesquisaUsuario.Text);
            }
            if (cbx_PesquisarUsuario.SelectedIndex == 1)
            {
                if (txb_PesquisaUsuario.Text.Length <= 0)
                {
                    dgv_Usuario.DataSource = bll.pesquisa_Usuario_Nome(txb_PesquisaUsuario.Text);
                }
                else
                {
                    try
                    {
                        dgv_Usuario.DataSource = bll.pesquisa_Usuario_Codigo(Convert.ToInt32(txb_PesquisaUsuario.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_Usuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_Usuario.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                preencher_Cbx_LojaUsuario();

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    bll = new BLL_Usuario(cx);
                    ModeloUsuario modelo = bll.carregaModeloUsuario(codigo);

                    txb_CodigoUsuario.Text = modelo.Codigo.ToString();
                    txb_NomeUsuario.Text = modelo.Nome;
                    txb_SenhaUsuario.Text = modelo.Senha;
                    txb_DataCadastroUsuario.Text = modelo.DataCad.ToShortDateString();
                    txb_EmailUsuario.Text = modelo.Email;
                    cbx_LojaUsuario.Text = modelo.Filial.ToString();
                    buttonEdit1.Text = modelo.Caixa.ToString();

                    //Aqui preenche o textbox caixa usuario conforme o valor definido no campo referente ao numero do caixa
                    BLL_Caixa bll_cx = new BLL_Caixa(cx);
                    ModeloCaixa modelo_cx = bll_cx.carregaModeloCaixa(Convert.ToInt32(buttonEdit1.Text));
                    tbx_NomeCaixaUsuario.Text = modelo_cx.Descricao;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_Usuario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_Usuario.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Usuario bll = new BLL_Usuario(cx);
                    ModeloUsuario modelo = bll.carregaModeloUsuario(codigo);

                    txb_CodigoUsuario.Text = modelo.Codigo.ToString();
                    txb_NomeUsuario.Text = modelo.Nome;
                    txb_SenhaUsuario.Text = modelo.Senha;
                    txb_DataCadastroUsuario.Text = modelo.DataCad.ToShortDateString();
                    txb_EmailUsuario.Text = modelo.Email;
                    cbx_LojaUsuario.Text = modelo.Filial.ToString();
                    buttonEdit1.Text = modelo.Caixa.ToString();

                    //Aqui preenche o textbox caixa usuario conforme o valor definido no campo referente ao numero do caixa
                    BLL_Caixa bll_cx = new BLL_Caixa(cx);
                    ModeloCaixa modelo_cx = bll_cx.carregaModeloCaixa(Convert.ToInt32(buttonEdit1.Text));
                    tbx_NomeCaixaUsuario.Text = modelo_cx.Descricao;
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }
    }
}
