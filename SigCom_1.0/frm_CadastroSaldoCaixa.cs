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
    public partial class frm_CadastroSaldoCaixa : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroSaldoCaixa()
        {
            InitializeComponent();
        }

        private void frm_CadastroSaldoCaixa_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarSaldoCaixa.SelectedIndex = 0;
        }

        public string ValorCategoria()
        {
            string valorCat = null;

            if (rbt_BancoSaldoCaixa.Checked)
                valorCat = rbt_BancoSaldoCaixa.Tag.ToString();
            if (rbt_CartaoSaldoCaixa.Checked)
                valorCat = rbt_CartaoSaldoCaixa.Tag.ToString();
            if (rbt_CelularSaldoCaixa.Checked)
                valorCat = rbt_CelularSaldoCaixa.Tag.ToString();
            if (rbt_ChequeSaldoCaixa.Checked)
                valorCat = rbt_ChequeSaldoCaixa.Tag.ToString();
            if (rbt_CreditoSaldoCaixa.Checked)
                valorCat = rbt_CreditoSaldoCaixa.Tag.ToString();
            if (rbt_DinheiroSaldoCaixa.Checked)
                valorCat = rbt_DinheiroSaldoCaixa.Tag.ToString();
            if (rbt_DocumentoSaldoCaixa.Checked)
                valorCat = rbt_DocumentoSaldoCaixa.Tag.ToString();
            if (rbt_NotasSaldoCaixa.Checked)
                valorCat = rbt_NotasSaldoCaixa.Tag.ToString();
            if (rbt_OutrosSaldoCaixa.Checked)
                valorCat = rbt_OutrosSaldoCaixa.Tag.ToString();
            if (rbt_TicketSaldoCaixa.Checked)
                valorCat = rbt_TicketSaldoCaixa.Tag.ToString();
            if (rbt_ValesSaldoCaixa.Checked)
                valorCat = rbt_ValesSaldoCaixa.Tag.ToString();
            if (rbt_VoucherSaldoCaixa.Checked)
                valorCat = rbt_VoucherSaldoCaixa.Tag.ToString();            

            return valorCat;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_SaldoCaixa bll = new BLL_SaldoCaixa(cx);

                dgv_CadastroSaldoCaixa.DataSource = bll.lista_SaldoCaixa();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroSaldoCaixa.RowHeadersWidth = 24;
                dgv_CadastroSaldoCaixa.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroSaldoCaixa.Columns[0].HeaderText = "Código";
                dgv_CadastroSaldoCaixa.Columns[0].Width = 60;
                dgv_CadastroSaldoCaixa.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroSaldoCaixa.Columns[1].HeaderText = "Descrição";
                dgv_CadastroSaldoCaixa.Columns[1].Width = 600;
                dgv_CadastroSaldoCaixa.Columns[2].HeaderText = "Tipo";
                dgv_CadastroSaldoCaixa.Columns[2].Width = 60;
                dgv_CadastroSaldoCaixa.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroSaldoCaixa.Columns[3].HeaderText = "TEF";
                dgv_CadastroSaldoCaixa.Columns[3].Width = 60;
                dgv_CadastroSaldoCaixa.Columns[4].HeaderText = "Prazo";
                dgv_CadastroSaldoCaixa.Columns[4].Width = 60;
                dgv_CadastroSaldoCaixa.Columns[5].HeaderText = "Inativo";
                dgv_CadastroSaldoCaixa.Columns[5].Width = 60;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar caixa " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_DescricaoSaldoCaixa.ReadOnly = true;
            chb_AtivoInativoSaldoCaixa.Enabled = false;
            chb_PrazoSaldoCaixa.Enabled = false;
            chb_TEFSaldoCaixa.Enabled = false;
            //groupBox1.Enabled = false;
            rbt_BancoSaldoCaixa.Enabled = false;
            rbt_CartaoSaldoCaixa.Enabled = false;
            rbt_CelularSaldoCaixa.Enabled = false;
            rbt_ChequeSaldoCaixa.Enabled = false;
            rbt_CreditoSaldoCaixa.Enabled = false;
            rbt_DinheiroSaldoCaixa.Enabled = false;
            rbt_DocumentoSaldoCaixa.Enabled = false;
            rbt_NotasSaldoCaixa.Enabled = false;
            rbt_OutrosSaldoCaixa.Enabled = false;
            rbt_TicketSaldoCaixa.Enabled = false;
            rbt_ValesSaldoCaixa.Enabled = false;
            rbt_VoucherSaldoCaixa.Enabled = false;
        }

        public void habilita_Campos()
        {
            txb_DescricaoSaldoCaixa.ReadOnly = false;
            chb_AtivoInativoSaldoCaixa.Enabled = true;
            chb_PrazoSaldoCaixa.Enabled = true;
            chb_TEFSaldoCaixa.Enabled = true;
            //groupBox1.Enabled = true;
            rbt_BancoSaldoCaixa.Enabled = true;
            rbt_CartaoSaldoCaixa.Enabled = true;
            rbt_CelularSaldoCaixa.Enabled = true;
            rbt_ChequeSaldoCaixa.Enabled = true;
            rbt_CreditoSaldoCaixa.Enabled = true;
            rbt_DinheiroSaldoCaixa.Enabled = true;
            rbt_DocumentoSaldoCaixa.Enabled = true;
            rbt_NotasSaldoCaixa.Enabled = true;
            rbt_OutrosSaldoCaixa.Enabled = true;
            rbt_TicketSaldoCaixa.Enabled = true;
            rbt_ValesSaldoCaixa.Enabled = true;
            rbt_VoucherSaldoCaixa.Enabled = true;
        }

        public void limpa_Campos()
        {
            txb_DescricaoSaldoCaixa.Clear();
            chb_AtivoInativoSaldoCaixa.Refresh();
            chb_PrazoSaldoCaixa.Refresh();
            chb_TEFSaldoCaixa.Refresh();
            //groupBox1.Refresh();
            rbt_BancoSaldoCaixa.Checked = false;
            rbt_CartaoSaldoCaixa.Checked = false;
            rbt_CelularSaldoCaixa.Checked = false;
            rbt_ChequeSaldoCaixa.Checked = false;
            rbt_CreditoSaldoCaixa.Checked = false;
            rbt_DinheiroSaldoCaixa.Checked = false;
            rbt_DocumentoSaldoCaixa.Checked = false;
            rbt_NotasSaldoCaixa.Checked = false;
            rbt_OutrosSaldoCaixa.Checked = false;
            rbt_TicketSaldoCaixa.Checked = false;
            rbt_ValesSaldoCaixa.Checked = false;
            rbt_VoucherSaldoCaixa.Checked = false;
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoSaldoCaixa.Enabled = false;
            btn_AlterarSaldoCaixa.Enabled = false;
            btn_PesquisarSaldoCaixa.Enabled = false;
            btn_ExcluirSaldoCaixa.Enabled = false;
            btn_GravarSaldoCaixa.Enabled = false;
            btn_ImprimirSaldoCaixa.Enabled     = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoSaldoCaixa.Enabled = true;
                btn_PesquisarSaldoCaixa.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarSaldoCaixa.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarSaldoCaixa.Enabled = true;
                btn_ExcluirSaldoCaixa.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoSaldoCaixa_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            txb_DescricaoSaldoCaixa.Focus();

            try
            {
                BLL_SaldoCaixa bll = new BLL_SaldoCaixa(cx);
                ModeloSaldoCaixa modelo = bll.informaProximoCodigo();
                txb_CodigoSaldoCaixa.Text = modelo.Codigo.ToString();
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

        private void btn_AlterarSaldoCaixa_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_GravarSaldoCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloSaldoCaixa obj_SaldoCaixa = new ModeloSaldoCaixa();

                obj_SaldoCaixa.Descricao = txb_DescricaoSaldoCaixa.Text;
                obj_SaldoCaixa.TipoSaldo = ValorCategoria();
                obj_SaldoCaixa.Inativo = chb_AtivoInativoSaldoCaixa.Checked;
                obj_SaldoCaixa.Prazo = chb_PrazoSaldoCaixa.Checked;
                obj_SaldoCaixa.Tef = chb_TEFSaldoCaixa.Checked;

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_SaldoCaixa bll = new BLL_SaldoCaixa(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_SaldoCaixa(obj_SaldoCaixa);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_SaldoCaixa.Codigo.ToString());
                }
                else
                {
                    obj_SaldoCaixa.Codigo = Convert.ToInt32(txb_CodigoSaldoCaixa.Text);
                    bll.altera_SaldoCaixa(obj_SaldoCaixa);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar saldo de caixa " + erro);
            }
        }

        private void btn_ExcluirSaldoCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_SaldoCaixa bll = new BLL_SaldoCaixa(cx);
                    bll.excluir_SaldoCaixa(Convert.ToInt32(txb_CodigoSaldoCaixa.Text));

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

        private void btn_PesquisarSaldoCaixa_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_SaldoCaixa bll = new BLL_SaldoCaixa(cx);
            if (cbx_PesquisarSaldoCaixa.SelectedIndex == 0)
            {
                dgv_CadastroSaldoCaixa.DataSource = bll.pesquisa_SaldoCaixa_Nome(txb_PesquisaSaldoCaixa.Text);
            }
            if (cbx_PesquisarSaldoCaixa.SelectedIndex == 1)
            {
                if (txb_PesquisaSaldoCaixa.Text.Length <= 0)
                {
                    dgv_CadastroSaldoCaixa.DataSource = bll.pesquisa_SaldoCaixa_Nome(txb_PesquisaSaldoCaixa.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroSaldoCaixa.DataSource = bll.pesquisa_SaldoCaixa_Codigo(Convert.ToInt32(txb_PesquisaSaldoCaixa.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_CadastroSaldoCaixa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroSaldoCaixa.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_SaldoCaixa bll = new BLL_SaldoCaixa(cx);
                    ModeloSaldoCaixa modelo = bll.carregaModeloSaldoCaixa(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoSaldoCaixa.Text = modelo.Codigo.ToString();
                    txb_DescricaoSaldoCaixa.Text = modelo.Descricao;
                    chb_AtivoInativoSaldoCaixa.Checked = modelo.Inativo;
                    chb_PrazoSaldoCaixa.Checked = modelo.Prazo;
                    chb_TEFSaldoCaixa.Checked = modelo.Tef;

                    string valorCategoria = modelo.TipoSaldo;
                    if (valorCategoria == "01")
                        rbt_DinheiroSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "02")
                        rbt_ChequeSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "03")
                        rbt_CartaoSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "04")
                        rbt_BancoSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "05")
                        rbt_ValesSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "06")
                        rbt_NotasSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "07")
                        rbt_VoucherSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "08")
                        rbt_TicketSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "09")
                        rbt_CreditoSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "10")
                        rbt_CelularSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "11")
                        rbt_DocumentoSaldoCaixa.Checked = true;                        
                    if (valorCategoria == "12")
                        rbt_OutrosSaldoCaixa.Checked = true;                        

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }
        
        private void dgv_CadastroSaldoCaixa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroSaldoCaixa.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_SaldoCaixa bll = new BLL_SaldoCaixa(cx);
                    ModeloSaldoCaixa modelo = bll.carregaModeloSaldoCaixa(codigo);

                    txb_CodigoSaldoCaixa.Text = modelo.Codigo.ToString();
                    txb_DescricaoSaldoCaixa.Text = modelo.Descricao;
                    chb_AtivoInativoSaldoCaixa.Checked = modelo.Inativo;
                    chb_PrazoSaldoCaixa.Checked = modelo.Prazo;
                    chb_TEFSaldoCaixa.Checked = modelo.Tef;

                    string valorCategoria = modelo.TipoSaldo;
                    if (valorCategoria == "01")
                        rbt_DinheiroSaldoCaixa.Checked = true;
                    if (valorCategoria == "02")
                        rbt_ChequeSaldoCaixa.Checked = true;
                    if (valorCategoria == "03")
                        rbt_CartaoSaldoCaixa.Checked = true;
                    if (valorCategoria == "04")
                        rbt_BancoSaldoCaixa.Checked = true;
                    if (valorCategoria == "05")
                        rbt_ValesSaldoCaixa.Checked = true;
                    if (valorCategoria == "06")
                        rbt_NotasSaldoCaixa.Checked = true;
                    if (valorCategoria == "07")
                        rbt_VoucherSaldoCaixa.Checked = true;
                    if (valorCategoria == "08")
                        rbt_TicketSaldoCaixa.Checked = true;
                    if (valorCategoria == "09")
                        rbt_CreditoSaldoCaixa.Checked = true;
                    if (valorCategoria == "10")
                        rbt_CelularSaldoCaixa.Checked = true;
                    if (valorCategoria == "11")
                        rbt_DocumentoSaldoCaixa.Checked = true;
                    if (valorCategoria == "12")
                        rbt_OutrosSaldoCaixa.Checked = true;
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
