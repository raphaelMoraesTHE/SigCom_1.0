using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Model;
using BLL;

namespace GUI
{
    public partial class frm_CadastroBancos : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroBancos()
        {
            InitializeComponent();
        }

        private void frm_CadastroBancos_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarBanco.SelectedIndex = 0;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Bancos bll = new BLL_Bancos(cx);

                dgv_CadastroBanco.DataSource = bll.lista_Bancos();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroBanco.RowHeadersWidth = 24;
                dgv_CadastroBanco.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroBanco.Columns[0].HeaderText = "Código";
                dgv_CadastroBanco.Columns[0].Width = 60;
                dgv_CadastroBanco.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroBanco.Columns[1].HeaderText = "Descrição";
                dgv_CadastroBanco.Columns[1].Width = 840;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar caixa " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_NomeBanco.ReadOnly = true;            
        }

        public void habilita_Campos()
        {
            txb_NomeBanco.ReadOnly = false;            
        }

        public void limpa_Campos()
        {
            txb_NomeBanco.Clear();
            
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoBanco.Enabled = false;
            btn_AlterarBanco.Enabled = false;
            btn_PesquisarBanco.Enabled = false;
            btn_ExcluirBanco.Enabled = false;
            btn_GravarBanco.Enabled = false;
            //btn_ImprimirCaixa.Enabled     = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoBanco.Enabled = true;
                btn_PesquisarBanco.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarBanco.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarBanco.Enabled = true;
                btn_ExcluirBanco.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoBanco_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            txb_NomeBanco.Focus();

            try
            {
                BLL_Bancos bll = new BLL_Bancos(cx);
                ModeloBancos modelo = bll.informaProximoCodigo();
                txb_CodigoBanco.Text = modelo.Codigo.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Infomar o proximo código " + erro);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.limpa_Campos();
            tabControl1.SelectTab(0);
        }

        private void btn_AlterarBanco_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_GravarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloBancos obj_Bancos = new ModeloBancos();

                obj_Bancos.Nome = txb_NomeBanco.Text;

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Bancos bll = new BLL_Bancos(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_Bancos(obj_Bancos);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_Bancos.Codigo.ToString());
                }
                else
                {
                    obj_Bancos.Codigo = Convert.ToInt32(txb_CodigoBanco.Text);
                    bll.altera_Bancos(obj_Bancos);
                }

                //this.popula_Grid();
                //this.limpa_Campos();
                //this.desabilita_Campos();
                //this.altera_Botoes(1);
                this.frm_CadastroBancos_Load(sender, e);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar banco " + erro);
            }
        }

        private void btn_ExcluirBanco_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Bancos bll = new BLL_Bancos(cx);
                    bll.excluir_Bancos(Convert.ToInt32(txb_CodigoBanco.Text));

                    //this.popula_Grid();
                    //this.limpa_Campos();
                    //this.altera_Botoes(1);
                    this.frm_CadastroBancos_Load(sender, e);
                    tabControl1.SelectTab(0);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro, \nO registro está sendo utilizado em outro local.");
                this.altera_Botoes(3);
            }
        }

        private void btn_PesquisarBanco_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_Bancos bll = new BLL_Bancos(cx);
            if (cbx_PesquisarBanco.SelectedIndex == 0)
            {
                dgv_CadastroBanco.DataSource = bll.pesquisa_Bancos_Nome(txb_PesquisaBanco.Text);
            }
            if (cbx_PesquisarBanco.SelectedIndex == 1)
            {
                if (txb_PesquisaBanco.Text.Length <= 0)
                {
                    dgv_CadastroBanco.DataSource = bll.pesquisa_Bancos_Nome(txb_PesquisaBanco.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroBanco.DataSource = bll.pesquisa_Bancos_Codigo(Convert.ToInt32(txb_PesquisaBanco.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_CadastroBanco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroBanco.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Bancos bll = new BLL_Bancos(cx);
                    ModeloBancos modelo = bll.carregaModeloBancos(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoBanco.Text = modelo.Codigo.ToString();
                    txb_NomeBanco.Text = modelo.Nome;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroBanco_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroBanco.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Bancos bll = new BLL_Bancos(cx);
                    ModeloBancos modelo = bll.carregaModeloBancos(codigo);

                    txb_CodigoBanco.Text = modelo.Codigo.ToString();
                    txb_NomeBanco.Text = modelo.Nome;
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
