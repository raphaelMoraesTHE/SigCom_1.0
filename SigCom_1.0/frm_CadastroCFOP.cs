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
    public partial class frm_CadastroCFOP : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public string codigo = "";

        public frm_CadastroCFOP()
        {
            InitializeComponent();
        }

        private void frm_CadastroCFOP_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarCFOP.SelectedIndex = 0;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_TabCFOP bll = new BLL_TabCFOP(cx);

                dgv_CadastroCFOP.DataSource = bll.lista_CFOP();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroCFOP.RowHeadersWidth = 24;
                dgv_CadastroCFOP.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroCFOP.Columns[0].HeaderText = "Código";
                dgv_CadastroCFOP.Columns[0].Width = 60;
                dgv_CadastroCFOP.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroCFOP.Columns[1].HeaderText = "Descrição";
                dgv_CadastroCFOP.Columns[1].Width = 840;
                dgv_CadastroCFOP.Columns[2].HeaderText = "Ent/Sai";
                dgv_CadastroCFOP.Columns[2].Width = 60;
                dgv_CadastroCFOP.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroCFOP.Columns[3].HeaderText = "Dentro";
                dgv_CadastroCFOP.Columns[3].Width = 60;
                dgv_CadastroCFOP.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_CadastroCFOP.Columns[4].HeaderText = "Complemeto";
                dgv_CadastroCFOP.Columns[4].Width = 200;                
                dgv_CadastroCFOP.Columns[5].HeaderText = "Imobil.";
                dgv_CadastroCFOP.Columns[5].Width = 60;
                dgv_CadastroCFOP.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar CFOP " + erro);
            }
        }

        public void desabilita_Campos()
        {
            mtb_NaturezaCFOP.ReadOnly = true;
            txb_DescricaoCFOP.ReadOnly = true;
            txb_ComplementoCFOP.ReadOnly = true;
            cbx_EntradaSaidaCFOP.Enabled = false;
            chb_AtivoImobilizadoCFOP.Enabled = false;
            chb_DentroEstadoCFOP.Enabled = false;            
        }

        public void habilita_Campos()
        {
            mtb_NaturezaCFOP.ReadOnly = false;
            txb_DescricaoCFOP.ReadOnly = false;
            txb_ComplementoCFOP.ReadOnly = false;
            cbx_EntradaSaidaCFOP.Enabled = true;
            chb_AtivoImobilizadoCFOP.Enabled = true;
            chb_DentroEstadoCFOP.Enabled = true;
        }

        public void limpa_Campos()
        {
            mtb_NaturezaCFOP.Clear();
            txb_DescricaoCFOP.Clear();
            txb_ComplementoCFOP.Clear();
            cbx_EntradaSaidaCFOP.Refresh(); ;
            chb_AtivoImobilizadoCFOP.Refresh();
            chb_DentroEstadoCFOP.Refresh();
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoCFOP.Enabled = false;
            btn_AlterarCFOP.Enabled = false;
            btn_PesquisarCFOP.Enabled = false;
            btn_ExcluirCFOP.Enabled = false;
            btn_GravarCFOP.Enabled = false;
            //btn_ImprimirCaixa.Enabled     = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoCFOP.Enabled = true;
                btn_PesquisarCFOP.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarCFOP.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarCFOP.Enabled = true;
                btn_ExcluirCFOP.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoCFOP_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            mtb_NaturezaCFOP.Focus();            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.limpa_Campos();
            tabControl1.SelectTab(0);
        }

        private void btn_AlterarCFOP_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
            mtb_NaturezaCFOP.ReadOnly = true;
        }

        private void btn_GravarCFOP_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloTabCFOP obj_CFOP = new ModeloTabCFOP();

                obj_CFOP.Natureza = mtb_NaturezaCFOP.Text;
                obj_CFOP.Descricao = txb_DescricaoCFOP.Text;
                obj_CFOP.Complemento = txb_ComplementoCFOP.Text;

                string valorES = cbx_EntradaSaidaCFOP.SelectedIndex.ToString();
                if (valorES == "0")
                    obj_CFOP.ES = "E";
                if (valorES == "1")
                    obj_CFOP.ES = "S";

                string valorDentro = chb_DentroEstadoCFOP.Checked.ToString();
                if (valorDentro == "True")
                    obj_CFOP.Dentro = "S";
                else
                    obj_CFOP.Dentro = "N";

                string valorImobilizado = chb_AtivoImobilizadoCFOP.Checked.ToString();
                if (valorImobilizado == "True")
                    obj_CFOP.Imobilizado = "S";
                else
                    obj_CFOP.Imobilizado = "N";

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_TabCFOP bll = new BLL_TabCFOP(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_CFOP(obj_CFOP);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_CFOP.Natureza.ToString());
                }
                else
                {
                    obj_CFOP.Natureza = mtb_NaturezaCFOP.Text;
                    bll.altera_CFOP(obj_CFOP);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar CFOP " + erro);
            }
        }

        private void btn_ExcluirCFOP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_TabCFOP bll = new BLL_TabCFOP(cx);
                    bll.excluir_CFOP(Convert.ToString(mtb_NaturezaCFOP.Text));

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

        private void btn_PesquisarCFOP_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_TabCFOP bll = new BLL_TabCFOP(cx);
            if (cbx_PesquisarCFOP.SelectedIndex == 0)
            {
                dgv_CadastroCFOP.DataSource = bll.pesquisa_CFOP_Descricao(txb_PesquisaCFOP.Text);
            }
            if (cbx_PesquisarCFOP.SelectedIndex == 1)
            {
                dgv_CadastroCFOP.DataSource = bll.pesquisa_CFOP_Natureza(mtb_PesquisaCFOP.Text);                
            }
        }

        private void dgv_CadastroCFOP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToString(dgv_CadastroCFOP.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != "")
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_TabCFOP bll = new BLL_TabCFOP(cx);
                    ModeloTabCFOP modelo = bll.carregaModeloTabCFOP(codigo);

                    tabControl1.SelectTab(1);

                    mtb_NaturezaCFOP.Text = modelo.Natureza;
                    txb_DescricaoCFOP.Text = modelo.Descricao;
                    txb_ComplementoCFOP.Text = modelo.Complemento;

                    string es = modelo.ES;
                    if (es == "E")
                        cbx_EntradaSaidaCFOP.SelectedIndex = 0;
                    if (es == "S")
                        cbx_EntradaSaidaCFOP.SelectedIndex = 1;

                    string dentro = modelo.Dentro;
                    if (dentro == "S")
                        chb_DentroEstadoCFOP.Checked = true;
                    else
                        chb_DentroEstadoCFOP.Checked = false;

                    string imobilizado = modelo.Imobilizado;
                    if (imobilizado == "S")
                        chb_AtivoImobilizadoCFOP.Checked = true;
                    else
                        chb_AtivoImobilizadoCFOP.Checked = false;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroCFOP_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToString(dgv_CadastroCFOP.Rows[e.RowIndex].Cells[0].Value);
                
                if (codigo != "")
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_TabCFOP bll = new BLL_TabCFOP(cx);
                    ModeloTabCFOP modelo = bll.carregaModeloTabCFOP(codigo);

                    mtb_NaturezaCFOP.Text = modelo.Natureza;
                    txb_DescricaoCFOP.Text = modelo.Descricao;
                    txb_ComplementoCFOP.Text = modelo.Complemento;

                    string es = modelo.ES;
                    if (es == "E")
                        cbx_EntradaSaidaCFOP.SelectedIndex = 0;
                    if (es == "S")
                        cbx_EntradaSaidaCFOP.SelectedIndex = 1;

                    string dentro = modelo.Dentro;
                    if (dentro == "S")
                        chb_DentroEstadoCFOP.Checked = true;
                    else
                        chb_DentroEstadoCFOP.Checked = false;

                    string imobilizado = modelo.Imobilizado;
                    if (imobilizado == "S")
                        chb_AtivoImobilizadoCFOP.Checked = true;
                    else
                        chb_AtivoImobilizadoCFOP.Checked = false;
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void cbx_PesquisarCFOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_PesquisarCFOP.SelectedIndex == 1)
            {
                txb_PesquisaCFOP.Visible = false;
                txb_PesquisaCFOP.Clear();
                mtb_PesquisaCFOP.Visible = true;
                mtb_PesquisaCFOP.Mask = "9,999";
                mtb_PesquisaCFOP.TabIndex = 2;
            }
            else
            {
                txb_PesquisaCFOP.Visible = true;
                mtb_PesquisaCFOP.Visible = false;
                mtb_PesquisaCFOP.Clear();
                txb_PesquisaCFOP.TabIndex = 2;
            }
        }
    }    
}
