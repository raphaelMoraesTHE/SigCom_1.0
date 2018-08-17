using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
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
            this.preencher_Cbx_TipoComissao();
            this.preencher_Cbx_FormaPagamento();
            cbx_PesquisarPlanosPagamento.SelectedIndex = 0;
        }

        private void preencher_Cbx_TipoComissao()
        {
            try
            {
                ArrayList arr = new ArrayList();
                arr.Add(new drop("V - VENDAS", "V"));
                arr.Add(new drop("R - RECEBIMENTOS", "R"));

                cbx_TipoComissaoPlanosPagamento.DataSource = arr;
                cbx_TipoComissaoPlanosPagamento.DisplayMember = "nome";
                cbx_TipoComissaoPlanosPagamento.ValueMember = "valor";
                cbx_TipoComissaoPlanosPagamento.SelectedValue = "R";
                cbx_TipoComissaoPlanosPagamento.Refresh();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao exibir dados tipo de comissão." + erro);
            }
            
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
                cbx_TipoComissaoPlanosPagamento.SelectedValue = "AV";
                cbx_FormaPagamentoPlanosPagamento.Refresh();                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao consultar dados forma de pagamento." + erro);
            }
        }

        private void cbx_FormaPagamentoPlanosPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbx_FormaPagamentoPlanosPagamento.SelectedIndex != -1)
                {
                    DataRowView drw = ((DataRowView)cbx_FormaPagamentoPlanosPagamento.SelectedItem);
                    
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

        public string ValorTipoVencimento()
        {
            string valorTpVenc = null;

            if (rbt_VencDiasPlanosPagamento.Checked)
                valorTpVenc = rbt_VencDiasPlanosPagamento.Tag.ToString();
            if (rbt_VencMesesPlanosPagamento.Checked)
                valorTpVenc = rbt_VencMesesPlanosPagamento.Tag.ToString();
            
            return valorTpVenc;
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
                dgv_CadastroPlanosPagamento.Columns[1].Width = 210;
                dgv_CadastroPlanosPagamento.Columns[2].HeaderText = "Tipo Pagamento";
                dgv_CadastroPlanosPagamento.Columns[2].Width = 80;
                dgv_CadastroPlanosPagamento.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroPlanosPagamento.Columns[3].HeaderText = "Abreviação";
                dgv_CadastroPlanosPagamento.Columns[3].Width = 100;
                dgv_CadastroPlanosPagamento.Columns[4].HeaderText = "% Comissão";
                dgv_CadastroPlanosPagamento.Columns[4].Width = 80;
                dgv_CadastroPlanosPagamento.Columns[4].DefaultCellStyle.Format = "N2";
                dgv_CadastroPlanosPagamento.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;                
                dgv_CadastroPlanosPagamento.Columns[5].HeaderText = "Valor Min.Venda";
                dgv_CadastroPlanosPagamento.Columns[5].Width = 80;
                dgv_CadastroPlanosPagamento.Columns[5].DefaultCellStyle.Format = "N2";
                dgv_CadastroPlanosPagamento.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroPlanosPagamento.Columns[6].HeaderText = "% Max.Desc.";
                dgv_CadastroPlanosPagamento.Columns[6].Width = 80;
                dgv_CadastroPlanosPagamento.Columns[6].DefaultCellStyle.Format = "N2";
                dgv_CadastroPlanosPagamento.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroPlanosPagamento.Columns[7].HeaderText = "Desconto Nota";
                dgv_CadastroPlanosPagamento.Columns[7].Width = 80;
                dgv_CadastroPlanosPagamento.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroPlanosPagamento.Columns[8].HeaderText = "Desconto Item";
                dgv_CadastroPlanosPagamento.Columns[8].Width = 80;
                dgv_CadastroPlanosPagamento.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroPlanosPagamento.Columns[9].HeaderText = "Preço Promoção";
                dgv_CadastroPlanosPagamento.Columns[9].Width = 80;
                dgv_CadastroPlanosPagamento.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroPlanosPagamento.Columns[10].HeaderText = "% Jur.Fin.C.Ent.";
                dgv_CadastroPlanosPagamento.Columns[10].Width = 100;
                dgv_CadastroPlanosPagamento.Columns[10].DefaultCellStyle.Format = "N2";
                dgv_CadastroPlanosPagamento.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroPlanosPagamento.Columns[11].HeaderText = "% Jur.Fin.S.Ent.";
                dgv_CadastroPlanosPagamento.Columns[11].Width = 100;
                dgv_CadastroPlanosPagamento.Columns[11].DefaultCellStyle.Format = "N2";
                dgv_CadastroPlanosPagamento.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar planos de pagamento " + erro);
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
            txb_LimitePrimeiroVencPlanosPagamento.Text = "0";
            txb_LimiteUltimoVencPlanosPagamento.Text = "0";
            txb_NumMaxParcelasPlanosPagamento.Text = "0";
            txb_PercComissaoPlanosPagamento.Text = "0,00";
            txb_PercMaximoDescontoPlanosPagamento.Text = "0,00";
            txb_PercMinimoEntradaPlanosPagamento.Text = "0,00";
            txb_TxJurosComEntradaPlanosPagamento.Text = "0,00";
            txb_TxJurosSemEmtradaPlanosPagamento.Text = "0,00";
            txb_ValMinimoVendaPlanosPagamento.Text = "0,00";
            txb_VencimentoParcelasPlanosPagamento.Text = "0";
            txb_VencPrimeiraParcelaPlanosPagamento.Text = "0";
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
            this.altera_Botoes(1);
            this.limpa_Campos();
            tabControl1.SelectTab(0);
        }

        private void btn_AlterarPlanosPagamento_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);            
        }

        private void btn_GravarPlanosPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloPlanosPagamento obj_PlanosPagamento = new ModeloPlanosPagamento();

                obj_PlanosPagamento.Descricao = txb_DescricaoPlanosPagamento.Text;
                obj_PlanosPagamento.Abreviacao = txb_AbreviacaoPlanosPagamento.Text;
                obj_PlanosPagamento.Comissao = Convert.ToDouble(txb_PercComissaoPlanosPagamento.Text);
                obj_PlanosPagamento.JurosFincomEntrada = Convert.ToDouble(txb_TxJurosComEntradaPlanosPagamento.Text);
                obj_PlanosPagamento.JurosFinsemEmtrada = Convert.ToDouble(txb_TxJurosSemEmtradaPlanosPagamento.Text);
                obj_PlanosPagamento.LimitePrimeiroVenc = Convert.ToInt32(txb_LimitePrimeiroVencPlanosPagamento.Text);
                obj_PlanosPagamento.LimiteUltimoVenc = Convert.ToInt32(txb_LimiteUltimoVencPlanosPagamento.Text);
                obj_PlanosPagamento.MaxDesconto = Convert.ToDouble(txb_PercMaximoDescontoPlanosPagamento.Text);
                obj_PlanosPagamento.MaxParcelas = Convert.ToInt32(txb_NumMaxParcelasPlanosPagamento.Text);
                obj_PlanosPagamento.MinEntrada = Convert.ToDouble(txb_PercMinimoEntradaPlanosPagamento.Text);
                obj_PlanosPagamento.ValMinVenda = Convert.ToDouble(txb_ValMinimoVendaPlanosPagamento.Text);
                obj_PlanosPagamento.VencParcelas = Convert.ToInt32(txb_VencimentoParcelasPlanosPagamento.Text);
                obj_PlanosPagamento.PrimeiroVenc = Convert.ToInt32(txb_VencPrimeiraParcelaPlanosPagamento.Text);

                obj_PlanosPagamento.Pagamento = cbx_FormaPagamentoPlanosPagamento.SelectedValue.ToString();
                obj_PlanosPagamento.TpComissao = cbx_TipoComissaoPlanosPagamento.SelectedValue.ToString();
                
                obj_PlanosPagamento.AltQuantParc = chb_AlteraQuantParcelasPlanosPagamento.Checked;
                obj_PlanosPagamento.AltValParc = chb_AlteraValorParcelaPlanosPagamento.Checked;
                obj_PlanosPagamento.DescItem = chb_PermiteDescontoItemPlanosPagamento.Checked;
                obj_PlanosPagamento.DescNota = chb_PermiteDescontoNotaPlanosPagamento.Checked;
                obj_PlanosPagamento.EntrObrigatoria = chb_EntradaOrigatoriaPlanosPagamento.Checked;
                obj_PlanosPagamento.ValIntParc = chb_ValoInteiroParcelaPlanosPagamento.Checked;
                obj_PlanosPagamento.PrecoProm = chb_PermitePrecoPromocaoPlanosPagamento.Checked;

                obj_PlanosPagamento.TpVencimento = ValorTipoVencimento();

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
                    txb_AbreviacaoPlanosPagamento.Text = modelo.Abreviacao;
                    txb_PercComissaoPlanosPagamento.Text = modelo.Comissao.ToString();
                    txb_TxJurosComEntradaPlanosPagamento.Text = modelo.JurosFincomEntrada.ToString();
                    txb_TxJurosSemEmtradaPlanosPagamento.Text = modelo.JurosFinsemEmtrada.ToString();
                    txb_LimitePrimeiroVencPlanosPagamento.Text = modelo.LimitePrimeiroVenc.ToString();
                    txb_LimiteUltimoVencPlanosPagamento.Text = modelo.LimiteUltimoVenc.ToString();
                    txb_PercMaximoDescontoPlanosPagamento.Text = modelo.MaxDesconto.ToString();
                    txb_NumMaxParcelasPlanosPagamento.Text = modelo.MaxParcelas.ToString();
                    txb_PercMinimoEntradaPlanosPagamento.Text = modelo.MinEntrada.ToString();
                    txb_ValMinimoVendaPlanosPagamento.Text = modelo.ValMinVenda.ToString();
                    txb_VencimentoParcelasPlanosPagamento.Text = modelo.VencParcelas.ToString();
                    txb_VencPrimeiraParcelaPlanosPagamento.Text = modelo.PrimeiroVenc.ToString();

                    cbx_FormaPagamentoPlanosPagamento.SelectedValue = modelo.Pagamento;
                    cbx_TipoComissaoPlanosPagamento.SelectedValue = modelo.TpComissao;

                    chb_AlteraQuantParcelasPlanosPagamento.Checked = modelo.AltQuantParc;
                    chb_AlteraValorParcelaPlanosPagamento.Checked = modelo.AltValParc;
                    chb_PermiteDescontoItemPlanosPagamento.Checked = modelo.DescItem;
                    chb_PermiteDescontoNotaPlanosPagamento.Checked = modelo.DescNota;
                    chb_EntradaOrigatoriaPlanosPagamento.Checked = modelo.EntrObrigatoria;
                    chb_ValoInteiroParcelaPlanosPagamento.Checked = modelo.ValIntParc;
                    chb_PermitePrecoPromocaoPlanosPagamento.Checked = modelo.PrecoProm;

                    string valorTpVenc = modelo.TpVencimento;
                    if (valorTpVenc == "D")
                        rbt_VencDiasPlanosPagamento.Checked = true;
                    if (valorTpVenc == "M")
                        rbt_VencMesesPlanosPagamento.Checked = true;
                    
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
                    txb_AbreviacaoPlanosPagamento.Text = modelo.Abreviacao;
                    txb_PercComissaoPlanosPagamento.Text = modelo.Comissao.ToString();
                    txb_TxJurosComEntradaPlanosPagamento.Text = modelo.JurosFincomEntrada.ToString();
                    txb_TxJurosSemEmtradaPlanosPagamento.Text = modelo.JurosFinsemEmtrada.ToString();
                    txb_LimitePrimeiroVencPlanosPagamento.Text = modelo.LimitePrimeiroVenc.ToString();
                    txb_LimiteUltimoVencPlanosPagamento.Text = modelo.LimiteUltimoVenc.ToString();
                    txb_PercMaximoDescontoPlanosPagamento.Text = modelo.MaxDesconto.ToString();
                    txb_NumMaxParcelasPlanosPagamento.Text = modelo.MaxParcelas.ToString();
                    txb_PercMinimoEntradaPlanosPagamento.Text = modelo.MinEntrada.ToString();
                    txb_ValMinimoVendaPlanosPagamento.Text = modelo.ValMinVenda.ToString();
                    txb_VencimentoParcelasPlanosPagamento.Text = modelo.VencParcelas.ToString();
                    txb_VencPrimeiraParcelaPlanosPagamento.Text = modelo.PrimeiroVenc.ToString();

                    cbx_FormaPagamentoPlanosPagamento.SelectedValue = modelo.Pagamento;
                    cbx_TipoComissaoPlanosPagamento.SelectedValue = modelo.TpComissao;

                    chb_AlteraQuantParcelasPlanosPagamento.Checked = modelo.AltQuantParc;
                    chb_AlteraValorParcelaPlanosPagamento.Checked = modelo.AltValParc;
                    chb_PermiteDescontoItemPlanosPagamento.Checked = modelo.DescItem;
                    chb_PermiteDescontoNotaPlanosPagamento.Checked = modelo.DescNota;
                    chb_EntradaOrigatoriaPlanosPagamento.Checked = modelo.EntrObrigatoria;
                    chb_ValoInteiroParcelaPlanosPagamento.Checked = modelo.ValIntParc;
                    chb_PermitePrecoPromocaoPlanosPagamento.Checked = modelo.PrecoProm;

                    string valorTpVenc = modelo.TpVencimento;
                    if (valorTpVenc == "D")
                        rbt_VencDiasPlanosPagamento.Checked = true;
                    if (valorTpVenc == "M")
                        rbt_VencMesesPlanosPagamento.Checked = true;
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }        
    }

    public class drop
    {
        public drop(string nome, string valor)
        {
            Nome = nome;
            Valor = valor;
        }

        string _nome;
        string _valor;
        public string Valor{ get => _valor; set => _valor = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}
