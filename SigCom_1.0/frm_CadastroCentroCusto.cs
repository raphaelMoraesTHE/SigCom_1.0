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
    public partial class frm_CadastroCentroCusto : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroCentroCusto()
        {
            InitializeComponent();
        }

        private void frm_CadastroCentroCusto_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarCentroCustos.SelectedIndex = 0;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_CentroCustos bll = new BLL_CentroCustos(cx);

                dgv_CadastroCentroCustos.DataSource = bll.lista_CentroCustos();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroCentroCustos.RowHeadersWidth = 24;
                dgv_CadastroCentroCustos.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroCentroCustos.Columns[0].HeaderText = "Código";
                dgv_CadastroCentroCustos.Columns[0].Width = 60;
                dgv_CadastroCentroCustos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroCentroCustos.Columns[1].HeaderText = "Descrição";
                dgv_CadastroCentroCustos.Columns[1].Width = 840;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar caixa " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_DescricaoCentroCustos.ReadOnly = true;            
        }

        public void habilita_Campos()
        {
            txb_DescricaoCentroCustos.ReadOnly = false;            
        }

        public void limpa_Campos()
        {
            txb_DescricaoCentroCustos.Clear();            
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoCentroCustos.Enabled = false;
            btn_AlterarCentroCustos.Enabled = false;
            btn_PesquisarCentroCustos.Enabled = false;
            btn_ExcluirCentroCustos.Enabled = false;
            btn_GravarCentroCustos.Enabled = false;
            //btn_ImprimirCaixa.Enabled     = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoCentroCustos.Enabled = true;
                btn_PesquisarCentroCustos.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarCentroCustos.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarCentroCustos.Enabled = true;
                btn_ExcluirCentroCustos.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoCentroCustos_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            txb_DescricaoCentroCustos.Focus();

            try
            {
                BLL_CentroCustos bll = new BLL_CentroCustos(cx);
                ModeloCentroCustos modelo = bll.informaProximoCodigo();
                txb_CodigoCentroCustos.Text = modelo.Codigo.ToString();
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

        private void btn_AlterarCentroCustos_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_GravarCentroCustos_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloCentroCustos obj_CentroCustos = new ModeloCentroCustos();

                obj_CentroCustos.Descricao = txb_DescricaoCentroCustos.Text;

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_CentroCustos bll = new BLL_CentroCustos(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_CentroCustos(obj_CentroCustos);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_CentroCustos.Codigo.ToString());
                }
                else
                {
                    obj_CentroCustos.Codigo = Convert.ToInt32(txb_CodigoCentroCustos.Text);
                    bll.altera_CentroCustos(obj_CentroCustos);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar centro de custos " + erro);
            }
        }

        private void btn_ExcluirCentroCustos_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_CentroCustos bll = new BLL_CentroCustos(cx);
                    bll.excluir_CentroCustos(Convert.ToInt32(txb_CodigoCentroCustos.Text));

                    this.popula_Grid();
                    this.limpa_Campos();
                    this.altera_Botoes(1);
                    tabControl1.SelectTab(0);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro, \nO registro está sendo utilizado em outro local.");
                this.altera_Botoes(3);
            }
        }

        private void btn_PesquisarCentroCustos_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_CentroCustos bll = new BLL_CentroCustos(cx);
            if (cbx_PesquisarCentroCustos.SelectedIndex == 0)
            {
                dgv_CadastroCentroCustos.DataSource = bll.pesquisa_CentroCustos_Nome(txb_PesquisaCentroCustos.Text);
            }
            if (cbx_PesquisarCentroCustos.SelectedIndex == 1)
            {
                if (txb_PesquisaCentroCustos.Text.Length <= 0)
                {
                    dgv_CadastroCentroCustos.DataSource = bll.pesquisa_CentroCustos_Nome(txb_PesquisaCentroCustos.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroCentroCustos.DataSource = bll.pesquisa_CentroCustos_Codigo(Convert.ToInt32(txb_PesquisaCentroCustos.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_CadastroCentroCustos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroCentroCustos.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_CentroCustos bll = new BLL_CentroCustos(cx);
                    ModeloCentroCustos modelo = bll.carregaModeloCentroCustos(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoCentroCustos.Text = modelo.Codigo.ToString();
                    txb_DescricaoCentroCustos.Text = modelo.Descricao;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroCentroCustos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroCentroCustos.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_CentroCustos bll = new BLL_CentroCustos(cx);
                    ModeloCentroCustos modelo = bll.carregaModeloCentroCustos(codigo);

                    txb_CodigoCentroCustos.Text = modelo.Codigo.ToString();
                    txb_DescricaoCentroCustos.Text = modelo.Descricao;
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
