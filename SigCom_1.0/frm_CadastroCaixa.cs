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
    public partial class frm_CadastroCaixa : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroCaixa()
        {
            InitializeComponent();
        }

        private void frm_CadastroCaixa_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarCaixa.SelectedIndex = 0;
        }

        public void chamaConsulta()
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("contafin");
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

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Caixa bll = new BLL_Caixa(cx);

                dgv_CadastroCaixas.DataSource = bll.lista_Caixa();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroCaixas.RowHeadersWidth = 24;
                dgv_CadastroCaixas.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroCaixas.Columns[0].HeaderText = "Código";
                dgv_CadastroCaixas.Columns[0].Width = 60;
                dgv_CadastroCaixas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroCaixas.Columns[1].HeaderText = "Descrição";
                dgv_CadastroCaixas.Columns[1].Width = 840;                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar caixa " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_DescricaoCaixa.ReadOnly        = true;
            chb_AtivoInativoCaixa.Enabled      = false;
            chb_TransportaSaldoCaixa.Enabled   = false;
            bte_CaixaContaPagamentos.Enabled   = false;
            bte_CaixaContaPagJuros.Enabled     = false;
            bte_CaixaContaRecCelular.Enabled   = false;
            bte_CaixaContaRecebimento.Enabled  = false;
            bte_CaixaContaRecJuro.Enabled      = false;
            bte_CaixaContaSangria.Enabled      = false;
            bte_CaixaContaServico.Enabled      = false;
            bte_CaixaContaSuprimento.Enabled   = false;
            bte_CaixaContaVenda.Enabled        = false;  
        }

        public void habilita_Campos()
        {
            txb_DescricaoCaixa.ReadOnly         = false;
            chb_AtivoInativoCaixa.Enabled       = true;
            chb_TransportaSaldoCaixa.Enabled    = true;
            bte_CaixaContaPagamentos.Enabled    = true;
            bte_CaixaContaPagJuros.Enabled      = true;
            bte_CaixaContaRecCelular.Enabled    = true;
            bte_CaixaContaRecebimento.Enabled   = true;
            bte_CaixaContaRecJuro.Enabled       = true;
            bte_CaixaContaSangria.Enabled       = true;
            bte_CaixaContaServico.Enabled       = true;
            bte_CaixaContaSuprimento.Enabled    = true;
            bte_CaixaContaVenda.Enabled         = true;            
        }

        public void limpa_Campos()
        {
            txb_DescricaoCaixa.Clear();
            chb_AtivoInativoCaixa.Refresh();
            chb_TransportaSaldoCaixa.Refresh();
            bte_CaixaContaPagamentos.ResetText();            
            bte_CaixaContaPagJuros.ResetText();
            bte_CaixaContaRecCelular.ResetText();
            bte_CaixaContaRecebimento.ResetText();
            bte_CaixaContaRecJuro.ResetText();
            bte_CaixaContaSangria.ResetText();
            bte_CaixaContaServico.ResetText();
            bte_CaixaContaSuprimento.ResetText();
            bte_CaixaContaVenda.ResetText();
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoCaixa.Enabled         = false;
            btn_AlterarCaixa.Enabled      = false;
            btn_PesquisarCaixa.Enabled    = false;
            btn_ExcluirCaixa.Enabled      = false;
            btn_GravarCaixa.Enabled       = false;
            btn_ImprimirCaixa.Enabled     = false;
            btn_Cancelar.Enabled          = false;

            if (op == 1)
            {
                btn_NovoCaixa.Enabled      = true;
                btn_PesquisarCaixa.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarCaixa.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarCaixa.Enabled   = true;
                btn_ExcluirCaixa.Enabled   = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoCaixa_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            txb_DescricaoCaixa.Focus();

            try
            {
                BLL_Caixa bll = new BLL_Caixa(cx);
                ModeloCaixa modelo = bll.informaProximoCodigo();
                txb_CodigoCaixa.Text = modelo.Codigo.ToString();
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

        private void btn_AlterarCaixa_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_GravarCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloCaixa obj_Caixa = new ModeloCaixa();

                obj_Caixa.Descricao = txb_DescricaoCaixa.Text;
                
                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Caixa bll = new BLL_Caixa(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_Caixa(obj_Caixa);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_Caixa.Codigo.ToString());
                }
                else
                {
                    obj_Caixa.Codigo = Convert.ToInt32(txb_CodigoCaixa.Text);
                    bll.altera_Caixa(obj_Caixa);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar caixa " + erro);
            }
        }

        private void btn_ExcluirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Caixa bll = new BLL_Caixa(cx);
                    bll.excluir_Caixa(Convert.ToInt32(txb_CodigoCaixa.Text));

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

        private void btn_PesquisarCaixa_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_Caixa bll = new BLL_Caixa(cx);
            if (cbx_PesquisarCaixa.SelectedIndex == 0)
            {
                dgv_CadastroCaixas.DataSource = bll.pesquisa_Caixa_Nome(txb_PesquisaCaixa.Text);
            }
            if (cbx_PesquisarCaixa.SelectedIndex == 1)
            {
                if (txb_PesquisaCaixa.Text.Length <= 0)
                {
                    dgv_CadastroCaixas.DataSource = bll.pesquisa_Caixa_Nome(txb_PesquisaCaixa.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroCaixas.DataSource = bll.pesquisa_Caixa_Codigo(Convert.ToInt32(txb_PesquisaCaixa.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_CadastroCaixas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroCaixas.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Caixa bll = new BLL_Caixa(cx);
                    ModeloCaixa modelo = bll.carregaModeloCaixa(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoCaixa.Text = modelo.Codigo.ToString();
                    txb_DescricaoCaixa.Text = modelo.Descricao;
                    
                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroCaixas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroCaixas.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Caixa bll = new BLL_Caixa(cx);
                    ModeloCaixa modelo = bll.carregaModeloCaixa(codigo);

                    txb_CodigoCaixa.Text = modelo.Codigo.ToString();
                    txb_DescricaoCaixa.Text = modelo.Descricao;                    
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void btn_CaixaContaVenda_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaPagamento_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaPagJuro_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaRecebimento_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaRecJuro_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaSuprimento_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaSangria_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaServico_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }

        private void btn_CaixaContaRecCelular_Click(object sender, EventArgs e)
        {
            chamaConsulta();
        }
        
    }
}
