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
using BLL;

namespace GUI
{
    public partial class frm_ConsultaRapida : Form
    {
        public int codigo = 0;

        public frm_ConsultaRapida()
        {
            InitializeComponent();
        }

        public frm_ConsultaRapida(String valor)
        {
            InitializeComponent();

            if (valor == "caixa")
            {
                this.Text = "Consulta Rápida - Caixa";

                try
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Caixa caixa_bll = new BLL_Caixa(cx);

                    dgv_PesquisaRapida.DataSource = caixa_bll.lista_Caixa();

                    //Definição de layout das colunas e cabeçalho do dataGrid.
                    dgv_PesquisaRapida.RowHeadersWidth = 24;
                    dgv_PesquisaRapida.Columns[0].HeaderText = "Código";
                    dgv_PesquisaRapida.Columns[0].Width = 60;
                    dgv_PesquisaRapida.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_PesquisaRapida.Columns[1].HeaderText = "Descrição";
                    dgv_PesquisaRapida.Columns[1].Width = 1000;                    
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao listar caixa " + erro);
                }
            }

            if (valor == "perfil")
            {
                this.Text = "Consulta Rápida - Perfil de Acesso";

                MessageBox.Show("Estamos implementando esta funcionalidade", "Atenção!", MessageBoxButtons.OK);
            }

            if (valor == "contafin")
            {
                this.Text = "Consulta Rápida - Conta Financeira";

                MessageBox.Show("Estamos implementando esta funcionalidade", "Atenção!", MessageBoxButtons.OK);
            }

            if (valor == "municipio")
            {
                this.Text = "Consulta Rápida - Municipios";

                try
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_TabMunicipio tabMunicipio_bll = new BLL_TabMunicipio(cx);

                    dgv_PesquisaRapida.DataSource = tabMunicipio_bll.lista_Municipio();

                    //Definição de layout das colunas e cabeçalho do dataGrid.
                    dgv_PesquisaRapida.RowHeadersWidth = 24;
                    dgv_PesquisaRapida.Columns[0].HeaderText = "Código";
                    dgv_PesquisaRapida.Columns[0].Width = 80;
                    dgv_PesquisaRapida.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_PesquisaRapida.Columns[1].HeaderText = "UF";
                    dgv_PesquisaRapida.Columns[1].Width = 50;
                    dgv_PesquisaRapida.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_PesquisaRapida.Columns[2].HeaderText = "Nome";
                    dgv_PesquisaRapida.Columns[2].Width = 910;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao listar municipios " + erro);
                }
            }

            if (valor == "empresa")
            {
                this.Text = "Consulta Rápida - Filiais";

                try
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Empresa tabMunicipio_bll = new BLL_Empresa(cx);

                    dgv_PesquisaRapida.DataSource = tabMunicipio_bll.lista_Empresa();

                    //Definição de layout das colunas e cabeçalho do dataGrid.
                    dgv_PesquisaRapida.RowHeadersWidth = 24;
                    dgv_PesquisaRapida.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dgv_PesquisaRapida.Columns[0].HeaderText = "Código";
                    dgv_PesquisaRapida.Columns[0].Width = 60;
                    dgv_PesquisaRapida.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_PesquisaRapida.Columns[1].HeaderText = "Nome";
                    dgv_PesquisaRapida.Columns[1].Width = 500;
                    dgv_PesquisaRapida.Columns[2].HeaderText = "Fantasia";
                    dgv_PesquisaRapida.Columns[2].Width = 260;
                    dgv_PesquisaRapida.Columns[3].HeaderText = "Sigla";
                    dgv_PesquisaRapida.Columns[3].Width = 60;
                    dgv_PesquisaRapida.Columns[4].HeaderText = "Endereço";
                    dgv_PesquisaRapida.Columns[4].Width = 260;
                    dgv_PesquisaRapida.Columns[5].HeaderText = "Bairro";
                    dgv_PesquisaRapida.Columns[5].Width = 150;
                    dgv_PesquisaRapida.Columns[6].HeaderText = "CNPJ";
                    dgv_PesquisaRapida.Columns[6].Width = 150;
                    dgv_PesquisaRapida.Columns[7].HeaderText = "Insc.Est.";
                    dgv_PesquisaRapida.Columns[7].Width = 100;
                    dgv_PesquisaRapida.Columns[8].HeaderText = "Reg.Trib.";
                    dgv_PesquisaRapida.Columns[8].Width = 70;
                    dgv_PesquisaRapida.Columns[9].HeaderText = "Nat.Rec.";
                    dgv_PesquisaRapida.Columns[9].Width = 70;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao listar empresas " + erro);
                }
            }

            if (valor == "cargosFuncoes")
            {
                this.Text = "Consulta Rápida - Cargos e Funções";

                try
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);

                    dgv_PesquisaRapida.DataSource = bll.lista_CargosFuncoes();

                    //Definição de layout das colunas e cabeçalho do dataGrid.
                    dgv_PesquisaRapida.RowHeadersWidth = 24;
                    dgv_PesquisaRapida.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    dgv_PesquisaRapida.Columns[0].HeaderText = "Código";
                    dgv_PesquisaRapida.Columns[0].Width = 60;
                    dgv_PesquisaRapida.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_PesquisaRapida.Columns[1].HeaderText = "Descrição";
                    dgv_PesquisaRapida.Columns[1].Width = 600;
                    dgv_PesquisaRapida.Columns[2].HeaderText = "Vendedor";
                    dgv_PesquisaRapida.Columns[2].Width = 75;
                    dgv_PesquisaRapida.Columns[3].HeaderText = "Tecnico";
                    dgv_PesquisaRapida.Columns[3].Width = 75;
                    dgv_PesquisaRapida.Columns[4].HeaderText = "Motorista";
                    dgv_PesquisaRapida.Columns[4].Width = 75;
                    dgv_PesquisaRapida.Columns[5].HeaderText = "Supervisor";
                    dgv_PesquisaRapida.Columns[5].Width = 75;
                    dgv_PesquisaRapida.Columns[6].HeaderText = "Cobrador";
                    dgv_PesquisaRapida.Columns[6].Width = 75;
                    dgv_PesquisaRapida.Columns[7].HeaderText = "Outros";
                    dgv_PesquisaRapida.Columns[7].Width = 75;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao listar cargos e funções " + erro);
                }
            }
        }

        private void frm_ConsultaRapida_Load(object sender, EventArgs e)
        {         

            if(this.Text == "Consulta Rápida - Caixa")
            {
                cbx_PesquisaRapida.Items.Add("Descrição");
                cbx_PesquisaRapida.Items.Add("Código");
            }

            if (this.Text == "Consulta Rápida - Perfil de Acesso")
            {
                cbx_PesquisaRapida.Items.Add("Nome");
                cbx_PesquisaRapida.Items.Add("Código");
            }

            if (this.Text == "Consulta Rápida - Conta Financeira")
            {
                cbx_PesquisaRapida.Items.Add("Nome");
                cbx_PesquisaRapida.Items.Add("Código");
                cbx_PesquisaRapida.Items.Add("Cód. Conta");
            }

            if (this.Text == "Consulta Rápida - Municipios")
            {
                cbx_PesquisaRapida.Items.Add("Nome");
                cbx_PesquisaRapida.Items.Add("UF");
                cbx_PesquisaRapida.Items.Add("Código");
            }

            if (this.Text == "Consulta Rápida - Filiais")
            {
                cbx_PesquisaRapida.Items.Add("Nome");
                cbx_PesquisaRapida.Items.Add("CNPJ");
                cbx_PesquisaRapida.Items.Add("Código");
            }

            if (this.Text == "Consulta Rápida - Cargos e Funções")
            {
                cbx_PesquisaRapida.Items.Add("Descrição");
                cbx_PesquisaRapida.Items.Add("Código");
            }

            else
            {
                cbx_PesquisaRapida.Items.Add("Nome");
                cbx_PesquisaRapida.Items.Add("Código");
            }

            cbx_PesquisaRapida.SelectedIndex = 0;
        }

        private void btn_PesquisaRapida_Click(object sender, EventArgs e)
        {
            if (this.Text == "Consulta Rápida - Caixa")
            {
                DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Caixa bll = new BLL_Caixa(cx);
                if (cbx_PesquisaRapida.SelectedIndex == 0)
                {
                    dgv_PesquisaRapida.DataSource = bll.pesquisa_Caixa_Nome(txb_PesquisaRapida.Text);
                }
                if (cbx_PesquisaRapida.SelectedIndex == 1)
                {
                    if (txb_PesquisaRapida.Text.Length <= 0)
                    {
                        dgv_PesquisaRapida.DataSource = bll.pesquisa_Caixa_Nome(txb_PesquisaRapida.Text);
                    }
                    else
                    {
                        try
                        {
                            dgv_PesquisaRapida.DataSource = bll.pesquisa_Caixa_Codigo(Convert.ToInt32(txb_PesquisaRapida.Text));
                        }
                        catch (Exception erro)
                        {

                            MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                        }
                    }
                }
            }

            if (this.Text == "Consulta Rápida - Perfil de Acesso")
            {
                MessageBox.Show("Estamos implementando esta funcionalidade", "Atenção!", MessageBoxButtons.OK);
            }

            if (this.Text == "Consulta Rápida - Municipios")
            {
                DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_TabMunicipio bll = new BLL_TabMunicipio(cx);
                if (cbx_PesquisaRapida.SelectedIndex == 0)//Pesquisa por Nome
                {
                    dgv_PesquisaRapida.DataSource = bll.pesquisa_Municipio_Nome(txb_PesquisaRapida.Text);
                }
                if (cbx_PesquisaRapida.SelectedIndex == 1)//Pesquisa por UF
                {
                    dgv_PesquisaRapida.DataSource = bll.pesquisa_Municipio_Nome(txb_PesquisaRapida.Text);
                }
                if (cbx_PesquisaRapida.SelectedIndex == 2)//Pesquisa por Código
                {
                    if (txb_PesquisaRapida.Text.Length <= 0)
                    {
                        dgv_PesquisaRapida.DataSource = bll.pesquisa_Municipio_Nome(txb_PesquisaRapida.Text);
                    }
                    else
                    {
                        try
                        {
                            //dgv_PesquisaRapida.DataSource = bll.pesquisa_Municipio_Nome(Convert.ToInt32(txb_PesquisaRapida.Text));
                        }
                        catch (Exception erro)
                        {

                            MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                        }
                    }
                }
            }

            if (this.Text == "Consulta Rápida - Filiais")
            {
                DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Empresa bll = new BLL_Empresa(cx);
                if (cbx_PesquisaRapida.SelectedIndex == 0)//Pesquisa por Nome
                {
                    dgv_PesquisaRapida.DataSource = bll.pesquisa_Empresa_Nome(txb_PesquisaRapida.Text);
                }
                if (cbx_PesquisaRapida.SelectedIndex == 1)//Pesquisa por CNPJ
                {
                    dgv_PesquisaRapida.DataSource = bll.pesquisa_Empresa_Cnpj(txb_PesquisaRapida.Text);
                }
                if (cbx_PesquisaRapida.SelectedIndex == 2)//Pesquisa por Código
                {
                    if (txb_PesquisaRapida.Text.Length <= 0)
                    {
                        dgv_PesquisaRapida.DataSource = bll.pesquisa_Empresa_Nome(txb_PesquisaRapida.Text);
                    }
                    else
                    {
                        try
                        {
                            dgv_PesquisaRapida.DataSource = bll.pesquisa_Empresa_Codigo(Convert.ToInt32(txb_PesquisaRapida.Text));
                        }
                        catch (Exception erro)
                        {

                            MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                        }
                    }
                }
            }

            if (this.Text == "Consulta Rápida - Cargos e Funções")
            {
                DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);
                if (cbx_PesquisaRapida.SelectedIndex == 0)
                {
                    dgv_PesquisaRapida.DataSource = bll.pesquisa_CargosFuncoes_Nome(txb_PesquisaRapida.Text);
                }
                if (cbx_PesquisaRapida.SelectedIndex == 1)
                {
                    if (txb_PesquisaRapida.Text.Length <= 0)
                    {
                        dgv_PesquisaRapida.DataSource = bll.pesquisa_CargosFuncoes_Nome(txb_PesquisaRapida.Text);
                    }
                    else
                    {
                        try
                        {
                            dgv_PesquisaRapida.DataSource = bll.pesquisa_CargosFuncoes_Codigo(Convert.ToInt32(txb_PesquisaRapida.Text));
                        }
                        catch (Exception erro)
                        {

                            MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                        }
                    }
                }
            }
        }        

        private void dgv_PesquisaRapida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_PesquisaRapida.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
