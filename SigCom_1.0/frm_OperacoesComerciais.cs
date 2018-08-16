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
    public partial class frm_OperacoesComerciais : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_OperacoesComerciais()
        {
            InitializeComponent();
        }

        private void frm_OperacoesComerciais_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            this.preencher_Cbx_CtCustos();
            cbx_PesquisarOpComercial.SelectedIndex = 0;
        }

        private void preencher_Cbx_CtCustos()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_CentroCustos bll = new BLL_CentroCustos(cx);

                cbx_TipoCentroCustosOpcomercial.DataSource = bll.lista_CentroCustos();
                cbx_TipoCentroCustosOpcomercial.ValueMember = "c_descricao";
                cbx_TipoCentroCustosOpcomercial.DisplayMember = "c_descricao";
                cbx_TipoCentroCustosOpcomercial.SelectedItem = "";
                cbx_TipoCentroCustosOpcomercial.Refresh();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao consultar dados empresa." + erro);
            }
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_OpComercial bll = new BLL_OpComercial(cx);

                dgv_CadastroOpComercial.DataSource = bll.lista_OpComercial();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroOpComercial.RowHeadersWidth = 24;
                dgv_CadastroOpComercial.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroOpComercial.Columns[0].HeaderText = "Código";
                dgv_CadastroOpComercial.Columns[0].Width = 60;
                dgv_CadastroOpComercial.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroOpComercial.Columns[1].HeaderText = "Descrição";
                dgv_CadastroOpComercial.Columns[1].Width = 400;
                dgv_CadastroOpComercial.Columns[2].HeaderText = "Abreviação";
                dgv_CadastroOpComercial.Columns[2].Width = 180;
                dgv_CadastroOpComercial.Columns[3].HeaderText = "CFOP Dentro";
                dgv_CadastroOpComercial.Columns[3].Width = 60;
                dgv_CadastroOpComercial.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroOpComercial.Columns[4].HeaderText = "CFOP Fora";
                dgv_CadastroOpComercial.Columns[4].Width = 60;
                dgv_CadastroOpComercial.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroOpComercial.Columns[5].HeaderText = "Série NF/NFC";
                dgv_CadastroOpComercial.Columns[5].Width = 60;
                dgv_CadastroOpComercial.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroOpComercial.Columns[6].HeaderText = "% Desc.Item";
                dgv_CadastroOpComercial.Columns[6].Width = 80;
                dgv_CadastroOpComercial.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroOpComercial.Columns[7].HeaderText = "% Desc.Nota";
                dgv_CadastroOpComercial.Columns[7].Width = 80;
                dgv_CadastroOpComercial.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroOpComercial.Columns[8].HeaderText = "Tipo Movimento";
                dgv_CadastroOpComercial.Columns[8].Width = 80;
                dgv_CadastroOpComercial.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroOpComercial.Columns[9].HeaderText = "Centro Custos";
                dgv_CadastroOpComercial.Columns[9].Width = 80;
                dgv_CadastroOpComercial.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroOpComercial.Columns[10].HeaderText = "Movimenta Estoque";
                dgv_CadastroOpComercial.Columns[11].HeaderText = "Documento Fiscal";
                dgv_CadastroOpComercial.Columns[12].HeaderText = "Calcula Impostos";
                dgv_CadastroOpComercial.Columns[13].HeaderText = "Estoque Negativo";
                dgv_CadastroOpComercial.Columns[14].HeaderText = "Não Alt.Preços";
                dgv_CadastroOpComercial.Columns[15].HeaderText = "Númeração Automática";
                dgv_CadastroOpComercial.Columns[16].HeaderText = "Estoque Depósito";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar operação comercial " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_DescricaoOpComercial.ReadOnly = true;
            txb_AbreviacaoOpComercial.ReadOnly = true;
            txb_MaxDescItemOpComercial.ReadOnly = true;
            txb_MaxDescNotaOpComercial.ReadOnly = true;
            txb_MaxProdOpComercial.ReadOnly = true;
            txb_MaxServOpComercial.ReadOnly = true;
            txb_SerieNFOpComercial.ReadOnly = true;
            chb_CalculaImpostosOpComercial.Enabled = false;
            chb_ControlaEstoqueOpComercial.Enabled = false;
            chb_EmiteDocFiscalOpComercial.Enabled = false;
            chb_InativoOpComercial.Enabled = false;
            chb_MovEstoqueDepositoOpComercial.Enabled = false;
            chb_NaoAlteraPrecosOpComercial.Enabled = false;
            chb_NumAutomaticaOpComercial.Enabled = false;
            chb_PermiteEstNegativoOpComercial.Enabled = false;
            cbx_AtualizaPrecoCompraOpcomercial.Enabled = false;
            cbx_ItensRepetidosOpcomercial.Enabled = false;
            cbx_TabPrecoContribOpcomercial.Enabled = false;
            cbx_TabPrecoNaoContriOpcomercial.Enabled = false;
            cbx_TipoCentroCustosOpcomercial.Enabled = false;
            cbx_TipoDevolucaoOpcomercial.Enabled = false;
            cbx_TipoDocFiscalOpcomercial.Enabled = false;
            cbx_TipoMovimentacaoOpcomercial.Enabled = false;
            cbx_TipoPrecoOpcomercial.Enabled = false;
            bte_CFOPDentroOpComercial.Enabled = false;
            bte_CFOPForaOpComercial.Enabled = false;            
        }

        public void habilita_Campos()
        {
            txb_DescricaoOpComercial.ReadOnly = false;
            txb_AbreviacaoOpComercial.ReadOnly = false;
            txb_MaxDescItemOpComercial.ReadOnly = false;
            txb_MaxDescNotaOpComercial.ReadOnly = false;
            txb_MaxProdOpComercial.ReadOnly = false;
            txb_MaxServOpComercial.ReadOnly = false;
            txb_SerieNFOpComercial.ReadOnly = false;
            chb_CalculaImpostosOpComercial.Enabled = true;
            chb_ControlaEstoqueOpComercial.Enabled = true;
            chb_EmiteDocFiscalOpComercial.Enabled = true;
            chb_InativoOpComercial.Enabled = true;
            chb_MovEstoqueDepositoOpComercial.Enabled = true;
            chb_NaoAlteraPrecosOpComercial.Enabled = true;
            chb_NumAutomaticaOpComercial.Enabled = true;
            chb_PermiteEstNegativoOpComercial.Enabled = true;
            cbx_AtualizaPrecoCompraOpcomercial.Enabled = true;
            cbx_ItensRepetidosOpcomercial.Enabled = true;
            cbx_TabPrecoContribOpcomercial.Enabled = true;
            cbx_TabPrecoNaoContriOpcomercial.Enabled = true;
            cbx_TipoCentroCustosOpcomercial.Enabled = true;
            cbx_TipoDevolucaoOpcomercial.Enabled = true;
            cbx_TipoDocFiscalOpcomercial.Enabled = true;
            cbx_TipoMovimentacaoOpcomercial.Enabled = true;
            cbx_TipoPrecoOpcomercial.Enabled = true;
            bte_CFOPDentroOpComercial.Enabled = true;
            bte_CFOPForaOpComercial.Enabled = true;
        }

        public void limpa_Campos()
        {
            txb_DescricaoOpComercial.Clear();
            txb_AbreviacaoOpComercial.Clear();            
            txb_SerieNFOpComercial.Clear();
            chb_CalculaImpostosOpComercial.Refresh();
            chb_ControlaEstoqueOpComercial.Refresh();
            chb_EmiteDocFiscalOpComercial.Refresh();
            chb_InativoOpComercial.Refresh();
            chb_MovEstoqueDepositoOpComercial.Refresh();
            chb_NaoAlteraPrecosOpComercial.Refresh();
            chb_NumAutomaticaOpComercial.Refresh();
            chb_PermiteEstNegativoOpComercial.Refresh();
            cbx_AtualizaPrecoCompraOpcomercial.Refresh();
            cbx_ItensRepetidosOpcomercial.Refresh();
            cbx_TabPrecoContribOpcomercial.Refresh();
            cbx_TabPrecoNaoContriOpcomercial.Refresh();
            cbx_TipoCentroCustosOpcomercial.Refresh();
            cbx_TipoDevolucaoOpcomercial.Refresh();
            cbx_TipoDocFiscalOpcomercial.Refresh();
            cbx_TipoMovimentacaoOpcomercial.Refresh();
            cbx_TipoPrecoOpcomercial.Refresh();
            bte_CFOPDentroOpComercial.ResetText();
            bte_CFOPForaOpComercial.ResetText();            
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoOpComercial.Enabled = false;
            btn_AlterarOpComercial.Enabled = false;
            btn_PesquisarOpComercial.Enabled = false;
            btn_ExcluirOpComercial.Enabled = false;
            btn_GravarOpComercial.Enabled = false;
            //btn_ImprimirOpComercial.Enabled     = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoOpComercial.Enabled = true;
                btn_PesquisarOpComercial.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarOpComercial.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarOpComercial.Enabled = true;
                btn_ExcluirOpComercial.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoOpComercial_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            txb_DescricaoOpComercial.Focus();

            try
            {
                BLL_OpComercial bll = new BLL_OpComercial(cx);
                ModeloOpComerciais modelo = bll.informaProximoCodigo();
                txb_CodigoOpComercial.Text = modelo.Codigo.ToString();
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

        private void btn_AlterarOpComercial_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_GravarOpComercial_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloOpComerciais obj_OpComercial = new ModeloOpComerciais();

                obj_OpComercial.Descricao = txb_DescricaoOpComercial.Text;                
                obj_OpComercial.Abreviacao = txb_AbreviacaoOpComercial.Text;
                obj_OpComercial.CfopD = bte_CFOPDentroOpComercial.Text;
                obj_OpComercial.CfopF = bte_CFOPForaOpComercial.Text;
                obj_OpComercial.SerieNF = txb_SerieNFOpComercial.Text;
                obj_OpComercial.MaxProd = Convert.ToInt32(txb_MaxProdOpComercial.Text);
                obj_OpComercial.MaxServ = Convert.ToInt32(txb_MaxServOpComercial.Text);
                obj_OpComercial.DescMaxItem = Convert.ToDouble(txb_MaxDescItemOpComercial.Text);
                obj_OpComercial.DescMaxNota = Convert.ToDouble(txb_MaxDescNotaOpComercial.Text);
                obj_OpComercial.TpMoviment = Convert.ToString(cbx_TipoMovimentacaoOpcomercial.SelectedIndex + 1);
                obj_OpComercial.TpDevol = Convert.ToString(cbx_TipoDevolucaoOpcomercial.SelectedIndex + 1);
                obj_OpComercial.TpDocFiscal = Convert.ToString(cbx_TipoDocFiscalOpcomercial.SelectedIndex + 1);
                obj_OpComercial.Repetidos = Convert.ToString(cbx_ItensRepetidosOpcomercial.SelectedIndex + 1);
                obj_OpComercial.Preco = Convert.ToString(cbx_TipoPrecoOpcomercial.SelectedIndex + 1);
                obj_OpComercial.AtualizaCompra = Convert.ToString(cbx_AtualizaPrecoCompraOpcomercial.SelectedIndex + 1);                
                obj_OpComercial.MovEstoque = Convert.ToBoolean(chb_ControlaEstoqueOpComercial.Checked);
                obj_OpComercial.DocFiscal = Convert.ToBoolean(chb_EmiteDocFiscalOpComercial.Checked);
                obj_OpComercial.CalcImposto = Convert.ToBoolean(chb_CalculaImpostosOpComercial.Checked);
                obj_OpComercial.EstNegativo = Convert.ToBoolean(chb_PermiteEstNegativoOpComercial.Checked);
                obj_OpComercial.NaoAltPreco = Convert.ToBoolean(chb_NaoAlteraPrecosOpComercial.Checked);
                obj_OpComercial.NumAutomatico = Convert.ToBoolean(chb_NumAutomaticaOpComercial.Checked);
                obj_OpComercial.MovDeposito = Convert.ToBoolean(chb_MovEstoqueDepositoOpComercial.Checked);
                obj_OpComercial.Inativo = Convert.ToBoolean(chb_InativoOpComercial.Checked);
                obj_OpComercial.IdCustos = Convert.ToInt32(cbx_TipoCentroCustosOpcomercial.SelectedIndex + 1);

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_OpComercial bll = new BLL_OpComercial(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_OpComercial(obj_OpComercial);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_OpComercial.Codigo.ToString());
                }
                else
                {
                    obj_OpComercial.Codigo = Convert.ToInt32(txb_CodigoOpComercial.Text);
                    bll.altera_OpComercial(obj_OpComercial);
                }

                //this.popula_Grid();
                //this.limpa_Campos();
                //this.desabilita_Campos();
                //this.altera_Botoes(1);
                this.frm_OperacoesComerciais_Load(sender, e);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar operação comercial " + erro);
            }
        }

        private void btn_ExcluirOpComercial_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_OpComercial bll = new BLL_OpComercial(cx);
                    bll.excluir_OpComercial(Convert.ToInt32(txb_CodigoOpComercial.Text));

                    //this.popula_Grid();
                    //this.limpa_Campos();
                    //this.altera_Botoes(1);
                    this.frm_OperacoesComerciais_Load(sender, e);
                    tabControl1.SelectTab(0);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro, \nO registro está sendo utilizado em outro local.");
                this.altera_Botoes(3);
            }
        }

        private void btn_PesquisarOpComercial_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_OpComercial bll = new BLL_OpComercial(cx);
            if (cbx_PesquisarOpComercial.SelectedIndex == 0)
            {
                dgv_CadastroOpComercial.DataSource = bll.pesquisa_OpComercial_Nome(txb_PesquisaOpComercial.Text);
            }
            if (cbx_PesquisarOpComercial.SelectedIndex == 1)
            {
                if (txb_PesquisaOpComercial.Text.Length <= 0)
                {
                    dgv_CadastroOpComercial.DataSource = bll.pesquisa_OpComercial_Nome(txb_PesquisaOpComercial.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroOpComercial.DataSource = bll.pesquisa_OpComercial_Codigo(Convert.ToInt32(txb_PesquisaOpComercial.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_CadastroOpComercial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroOpComercial.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_OpComercial bll = new BLL_OpComercial(cx);
                    ModeloOpComerciais modelo = bll.carregaModeloOpComercial(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoOpComercial.Text = modelo.Codigo.ToString();
                    txb_DescricaoOpComercial.Text = modelo.Descricao;
                    txb_AbreviacaoOpComercial.Text = modelo.Abreviacao;
                    bte_CFOPDentroOpComercial.Text = modelo.CfopD;
                    bte_CFOPForaOpComercial.Text = modelo.CfopF;
                    txb_SerieNFOpComercial.Text = modelo.SerieNF;
                    txb_MaxProdOpComercial.Text = modelo.MaxProd.ToString();
                    txb_MaxServOpComercial.Text = modelo.MaxServ.ToString();
                    txb_MaxDescItemOpComercial.Text = modelo.DescMaxItem.ToString();
                    txb_MaxDescNotaOpComercial.Text = modelo.DescMaxNota.ToString();
                    cbx_TipoMovimentacaoOpcomercial.SelectedIndex = Convert.ToInt32(modelo.TpMoviment) - 1;
                    cbx_TipoDevolucaoOpcomercial.SelectedIndex = Convert.ToInt32(modelo.TpDevol) - 1;
                    cbx_TipoDocFiscalOpcomercial.SelectedIndex = Convert.ToInt32(modelo.TpDocFiscal) - 1;
                    cbx_ItensRepetidosOpcomercial.SelectedIndex = Convert.ToInt32(modelo.Repetidos) - 1;
                    cbx_TipoPrecoOpcomercial.SelectedIndex = Convert.ToInt32(modelo.Preco) - 1;
                    cbx_AtualizaPrecoCompraOpcomercial.SelectedIndex = Convert.ToInt32(modelo.AtualizaCompra) - 1;
                    chb_ControlaEstoqueOpComercial.Checked = modelo.MovEstoque;
                    chb_EmiteDocFiscalOpComercial.Checked = modelo.DocFiscal;
                    chb_CalculaImpostosOpComercial.Checked = modelo.CalcImposto;
                    chb_PermiteEstNegativoOpComercial.Checked = modelo.EstNegativo;
                    chb_NaoAlteraPrecosOpComercial.Checked = modelo.NaoAltPreco;
                    chb_NumAutomaticaOpComercial.Checked = modelo.NumAutomatico;
                    chb_MovEstoqueDepositoOpComercial.Checked = modelo.MovDeposito;
                    chb_InativoOpComercial.Checked = modelo.Inativo;
                    cbx_TipoCentroCustosOpcomercial.SelectedIndex = Convert.ToInt32(modelo.IdCustos) - 1;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroOpComercial_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroOpComercial.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_OpComercial bll = new BLL_OpComercial(cx);
                    ModeloOpComerciais modelo = bll.carregaModeloOpComercial(codigo);

                    txb_CodigoOpComercial.Text = modelo.Codigo.ToString();
                    txb_DescricaoOpComercial.Text = modelo.Descricao;
                    txb_AbreviacaoOpComercial.Text = modelo.Abreviacao;
                    bte_CFOPDentroOpComercial.Text = modelo.CfopD;
                    bte_CFOPForaOpComercial.Text = modelo.CfopF;
                    txb_SerieNFOpComercial.Text = modelo.SerieNF;
                    txb_MaxProdOpComercial.Text = modelo.MaxProd.ToString();
                    txb_MaxServOpComercial.Text = modelo.MaxServ.ToString();
                    txb_MaxDescItemOpComercial.Text = modelo.DescMaxItem.ToString();
                    txb_MaxDescNotaOpComercial.Text = modelo.DescMaxNota.ToString();
                    cbx_TipoMovimentacaoOpcomercial.SelectedIndex = Convert.ToInt32(modelo.TpMoviment) - 1;
                    cbx_TipoDevolucaoOpcomercial.SelectedIndex = Convert.ToInt32(modelo.TpDevol) - 1;
                    cbx_TipoDocFiscalOpcomercial.SelectedIndex = Convert.ToInt32(modelo.TpDocFiscal) - 1;
                    cbx_ItensRepetidosOpcomercial.SelectedIndex = Convert.ToInt32(modelo.Repetidos) - 1;
                    cbx_TipoPrecoOpcomercial.SelectedIndex = Convert.ToInt32(modelo.Preco) - 1;
                    cbx_AtualizaPrecoCompraOpcomercial.SelectedIndex = Convert.ToInt32(modelo.AtualizaCompra) - 1;
                    chb_ControlaEstoqueOpComercial.Checked = modelo.MovEstoque;
                    chb_EmiteDocFiscalOpComercial.Checked = modelo.DocFiscal;
                    chb_CalculaImpostosOpComercial.Checked = modelo.CalcImposto;
                    chb_PermiteEstNegativoOpComercial.Checked = modelo.EstNegativo;
                    chb_NaoAlteraPrecosOpComercial.Checked = modelo.NaoAltPreco;
                    chb_NumAutomaticaOpComercial.Checked = modelo.NumAutomatico;
                    chb_MovEstoqueDepositoOpComercial.Checked = modelo.MovDeposito;
                    chb_InativoOpComercial.Checked = modelo.Inativo;
                    cbx_TipoCentroCustosOpcomercial.SelectedIndex = Convert.ToInt32(modelo.IdCustos) - 1;
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void btn_CFOPDentroOpComercial_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("cfop");
            frmConsultaRapida.ShowDialog();

            if (frmConsultaRapida.valor != "")
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_TabCFOP bll = new BLL_TabCFOP(cx);
                ModeloTabCFOP modelo = bll.carregaModeloTabCFOP(Convert.ToString(frmConsultaRapida.valor));
                bte_CFOPDentroOpComercial.TextBox.Text = modelo.Natureza.ToString();
            }
            frmConsultaRapida.Dispose();
        }

        private void btn_CFOPForaOpComercial_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("cfop");
            frmConsultaRapida.ShowDialog();

            if (frmConsultaRapida.valor != "")
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_TabCFOP bll = new BLL_TabCFOP(cx);
                ModeloTabCFOP modelo = bll.carregaModeloTabCFOP(Convert.ToString(frmConsultaRapida.valor));
                bte_CFOPForaOpComercial.TextBox.Text = modelo.Natureza.ToString();
            }
            frmConsultaRapida.Dispose();
        }
    }
}
