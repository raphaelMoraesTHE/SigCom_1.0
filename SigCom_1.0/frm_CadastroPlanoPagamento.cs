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
    public partial class frm_CadastroPlanoPagamento : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroPlanoPagamento()
        {
            InitializeComponent();
        }

        private void frm_CadastroPlanoPagamento_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();            
            cbx_PesquisarPlanosPagamento.SelectedIndex = 0;
        }

        private void preencher_Cbx_FormaPagamento()
        {            
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Documentos bll = new BLL_Documentos(cx);
                
                cbx_FormaPagamentoPlanosPagamento.DataSource = bll.lista_TpDocumento();
                cbx_FormaPagamentoPlanosPagamento.ValueMember = "c_codigo";
                cbx_FormaPagamentoPlanosPagamento.DisplayMember = "c_valcombobox";
                cbx_FormaPagamentoPlanosPagamento.SelectedItem = "";
                cbx_FormaPagamentoPlanosPagamento.Refresh();                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao consultar dados empresa." + erro);
            }
        }

        private void cbx_FormaPagamentoPlanosPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_FormaPagamentoPlanosPagamento.SelectedIndex != -1)
                {
                    DataRowView drw = ((DataRowView)cbx_FormaPagamentoPlanosPagamento.SelectedItem);
                    //txb_NomeLojaUsuario.Text = drw["c_sigla"].ToString();
                    if (drw["c_codigo"].ToString() == "AV")
                    {
                        groupBox1.Enabled = false;
                    }
                    else
                    {
                        groupBox1.Enabled = true;
                    }
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_PlanosPagamento bll = new BLL_PlanosPagamento(cx);

                dgv_CadastroPlanosPagamento.DataSource = bll.lista_PlanosPagamento();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroPlanosPagamento.RowHeadersWidth = 24;
                dgv_CadastroPlanosPagamento.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroPlanosPagamento.Columns[0].HeaderText = "Código";
                dgv_CadastroPlanosPagamento.Columns[0].Width = 60;
                dgv_CadastroPlanosPagamento.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroPlanosPagamento.Columns[1].HeaderText = "Descrição";
                dgv_CadastroPlanosPagamento.Columns[1].Width = 840;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar caixa " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_AbreviacaoPlanosPagamento.ReadOnly = true;
            txb_DescricaoPlanosPagamento.ReadOnly = true;
            txb_LimitePrimeiroVencPlanosPagamento.ReadOnly = true;
            txb_LimiteUltimoVencPlanosPagamento.ReadOnly = true;
            txb_NumMaxParcelasPlanosPagamento.ReadOnly = true;
            txb_PercComissaoPlanosPagamento.ReadOnly = true;
            txb_PercMaximoDescontoPlanosPagamento.ReadOnly = true;
            txb_PercMinimoEntradaPlanosPagamento.ReadOnly = true;
            txb_TxJurosComEntradaPlanosPagamento.ReadOnly = true;
            txb_TxJurosSemEmtradaPlanosPagamento.ReadOnly = true;
            txb_ValMinimoVendaPlanosPagamento.ReadOnly = true;
            txb_VencimentoParcelasPlanosPagamento.ReadOnly = true;
            txb_VencPrimeiraParcelaPlanosPagamento.ReadOnly = true;
            chb_AlteraQuantParcelasPlanosPagamento.Enabled = false;
            chb_AlteraValorParcelaPlanosPagamento.Enabled = false;
            chb_EntradaOrigatoriaPlanosPagamento.Enabled = false;
            chb_InativoPlanosPagamento.Enabled = false;
            chb_PermiteDescontoItemPlanosPagamento.Enabled = false;
            chb_PermiteDescontoNotaPlanosPagamento.Enabled = false;
            chb_PermitePrecoPromocaoPlanosPagamento.Enabled = false;
            chb_ValoInteiroParcelaPlanosPagamento.Enabled = false;
            cbx_FormaPagamentoPlanosPagamento.Enabled = false;
            cbx_TabFinanciamentoPlanosPagamento.Enabled = false;
            cbx_TipoComissaoPlanosPagamento.Enabled = false;            
        }

        public void habilita_Campos()
        {
            txb_AbreviacaoPlanosPagamento.ReadOnly = false;
            txb_DescricaoPlanosPagamento.ReadOnly = false;
            txb_LimitePrimeiroVencPlanosPagamento.ReadOnly = false;
            txb_LimiteUltimoVencPlanosPagamento.ReadOnly = false;
            txb_NumMaxParcelasPlanosPagamento.ReadOnly = false;
            txb_PercComissaoPlanosPagamento.ReadOnly = false;
            txb_PercMaximoDescontoPlanosPagamento.ReadOnly = false;
            txb_PercMinimoEntradaPlanosPagamento.ReadOnly = false;
            txb_TxJurosComEntradaPlanosPagamento.ReadOnly = false;
            txb_TxJurosSemEmtradaPlanosPagamento.ReadOnly = false;
            txb_ValMinimoVendaPlanosPagamento.ReadOnly = false;
            txb_VencimentoParcelasPlanosPagamento.ReadOnly = false;
            txb_VencPrimeiraParcelaPlanosPagamento.ReadOnly = false;
            chb_AlteraQuantParcelasPlanosPagamento.Enabled = true;
            chb_AlteraValorParcelaPlanosPagamento.Enabled = true;
            chb_EntradaOrigatoriaPlanosPagamento.Enabled = true;
            chb_InativoPlanosPagamento.Enabled = true;
            chb_PermiteDescontoItemPlanosPagamento.Enabled = true;
            chb_PermiteDescontoNotaPlanosPagamento.Enabled = true;
            chb_PermitePrecoPromocaoPlanosPagamento.Enabled = true;
            chb_ValoInteiroParcelaPlanosPagamento.Enabled = true;
            cbx_FormaPagamentoPlanosPagamento.Enabled = true;
            cbx_TabFinanciamentoPlanosPagamento.Enabled = true;
            cbx_TipoComissaoPlanosPagamento.Enabled = true;
        }

        public void limpa_Campos()
        {
            txb_AbreviacaoPlanosPagamento.Clear();
            txb_DescricaoPlanosPagamento.Clear();
            txb_LimitePrimeiroVencPlanosPagamento.Clear();
            txb_LimiteUltimoVencPlanosPagamento.Clear();
            txb_NumMaxParcelasPlanosPagamento.Clear();
            txb_PercComissaoPlanosPagamento.Clear();
            txb_PercMaximoDescontoPlanosPagamento.Clear();
            txb_PercMinimoEntradaPlanosPagamento.Clear();
            txb_TxJurosComEntradaPlanosPagamento.Clear();
            txb_TxJurosSemEmtradaPlanosPagamento.Clear();
            txb_ValMinimoVendaPlanosPagamento.Clear();
            txb_VencimentoParcelasPlanosPagamento.Clear();
            txb_VencPrimeiraParcelaPlanosPagamento.Clear();
            chb_AlteraQuantParcelasPlanosPagamento.Refresh();
            chb_AlteraValorParcelaPlanosPagamento.Refresh();
            chb_EntradaOrigatoriaPlanosPagamento.Refresh();
            chb_InativoPlanosPagamento.Refresh();
            chb_PermiteDescontoItemPlanosPagamento.Refresh();
            chb_PermiteDescontoNotaPlanosPagamento.Refresh();
            chb_PermitePrecoPromocaoPlanosPagamento.Refresh();
            chb_ValoInteiroParcelaPlanosPagamento.Refresh();
            cbx_FormaPagamentoPlanosPagamento.Refresh();
            cbx_TabFinanciamentoPlanosPagamento.Refresh();
            cbx_TipoComissaoPlanosPagamento.Refresh();            
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoPlanosPagamento.Enabled = false;
            btn_AlterarPlanosPagamento.Enabled = false;
            btn_PesquisarPlanosPagamento.Enabled = false;
            btn_ExcluirPlanosPagamento.Enabled = false;
            btn_GravarPlanosPagamento.Enabled = false;
            //btn_ImprimirCaixa.Enabled     = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoPlanosPagamento.Enabled = true;
                btn_PesquisarPlanosPagamento.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarPlanosPagamento.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarPlanosPagamento.Enabled = true;
                btn_ExcluirPlanosPagamento.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoPlanosPagamento_Click(object sender, EventArgs e)
        {

            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            this.preencher_Cbx_FormaPagamento();
            tabControl1.SelectTab(1);
            txb_DescricaoPlanosPagamento.Focus();

            try
            {
                BLL_PlanosPagamento bll = new BLL_PlanosPagamento(cx);
                ModeloPlanosPagamento modelo = bll.informaProximoCodigo();
                txb_CodigoPlanosPagamento.Text = modelo.Codigo.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Infomar o proximo código " + erro);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            //this.altera_Botoes(1);
            //this.limpa_Campos();
            frm_CadastroPlanoPagamento_Load(sender, e);
            tabControl1.SelectTab(0);
        }

        private void btn_AlterarPlanosPagamento_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_GravarPlanosPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloPlanosPagamento obj_PlanosPagamento = new ModeloPlanosPagamento();

                obj_PlanosPagamento.Descricao = txb_DescricaoPlanosPagamento.Text;

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_PlanosPagamento bll = new BLL_PlanosPagamento(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_PlanosPagamento(obj_PlanosPagamento);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_PlanosPagamento.Codigo.ToString());
                }
                else
                {
                    obj_PlanosPagamento.Codigo = Convert.ToInt32(txb_CodigoPlanosPagamento.Text);
                    bll.altera_PlanosPagamento(obj_PlanosPagamento);
                }

                //this.popula_Grid();
                //this.limpa_Campos();
                ////this.desabilita_Campos();
                //this.altera_Botoes(1);
                frm_CadastroPlanoPagamento_Load(sender, e);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar caixa " + erro);
            }
        }

        private void btn_ExcluirPlanosPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_PlanosPagamento bll = new BLL_PlanosPagamento(cx);
                    bll.excluir_PlanosPagamento(Convert.ToInt32(txb_CodigoPlanosPagamento.Text));

                    //this.popula_Grid();
                    //this.limpa_Campos();
                    //this.altera_Botoes(1);
                    frm_CadastroPlanoPagamento_Load(sender, e);
                    tabControl1.SelectTab(0);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro, \nO registro está sendo utilizado em outro local.");
                this.altera_Botoes(3);
            }
        }

        private void btn_PesquisarPlanosPagamento_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_PlanosPagamento bll = new BLL_PlanosPagamento(cx);
            if (cbx_PesquisarPlanosPagamento.SelectedIndex == 0)
            {
                dgv_CadastroPlanosPagamento.DataSource = bll.pesquisa_PlanosPagamento_Nome(txb_PesquisaPlanosPagamento.Text);
            }
            if (cbx_PesquisarPlanosPagamento.SelectedIndex == 1)
            {
                if (txb_PesquisaPlanosPagamento.Text.Length <= 0)
                {
                    dgv_CadastroPlanosPagamento.DataSource = bll.pesquisa_PlanosPagamento_Nome(txb_PesquisaPlanosPagamento.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroPlanosPagamento.DataSource = bll.pesquisa_PlanosPagamento_Codigo(Convert.ToInt32(txb_PesquisaPlanosPagamento.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_CadastroPlanosPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroPlanosPagamento.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_PlanosPagamento bll = new BLL_PlanosPagamento(cx);
                    ModeloPlanosPagamento modelo = bll.carregaModeloPlanosPagamento(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoPlanosPagamento.Text = modelo.Codigo.ToString();
                    txb_DescricaoPlanosPagamento.Text = modelo.Descricao;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroPlanosPagamento_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroPlanosPagamento.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_PlanosPagamento bll = new BLL_PlanosPagamento(cx);
                    ModeloPlanosPagamento modelo = bll.carregaModeloPlanosPagamento(codigo);

                    txb_CodigoPlanosPagamento.Text = modelo.Codigo.ToString();
                    txb_DescricaoPlanosPagamento.Text = modelo.Descricao;
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
