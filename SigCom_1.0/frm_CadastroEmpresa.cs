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
using Model;

namespace GUI
{
    public partial class frm_CadastroEmpresa : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;        

        public frm_CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void frm_CadastroEmpresa_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();            
            cbx_PesquisarEmpresa.SelectedIndex = 0;            
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Empresa bll = new BLL_Empresa(cx);

                dgv_CadastroEmpresa.DataSource = bll.lista_Empresa();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroEmpresa.RowHeadersWidth = 24;
                dgv_CadastroEmpresa.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroEmpresa.Columns[0].HeaderText = "Código";
                dgv_CadastroEmpresa.Columns[0].Width = 60;
                dgv_CadastroEmpresa.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroEmpresa.Columns[1].HeaderText = "Nome";
                dgv_CadastroEmpresa.Columns[1].Width = 500;
                dgv_CadastroEmpresa.Columns[2].HeaderText = "Fantasia";
                dgv_CadastroEmpresa.Columns[2].Width = 260;
                dgv_CadastroEmpresa.Columns[3].HeaderText = "Sigla";
                dgv_CadastroEmpresa.Columns[3].Width = 60;
                dgv_CadastroEmpresa.Columns[4].HeaderText = "Endereço";
                dgv_CadastroEmpresa.Columns[4].Width = 260;
                dgv_CadastroEmpresa.Columns[5].HeaderText = "Bairro";
                dgv_CadastroEmpresa.Columns[5].Width = 150;
                dgv_CadastroEmpresa.Columns[6].HeaderText = "CNPJ";
                dgv_CadastroEmpresa.Columns[6].Width = 150;
                dgv_CadastroEmpresa.Columns[7].HeaderText = "Insc.Est.";
                dgv_CadastroEmpresa.Columns[7].Width = 100;
                dgv_CadastroEmpresa.Columns[8].HeaderText = "Reg.Trib.";
                dgv_CadastroEmpresa.Columns[8].Width = 70;
                dgv_CadastroEmpresa.Columns[9].HeaderText = "Nat.Rec.";
                dgv_CadastroEmpresa.Columns[9].Width = 70;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar usuário " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_BairroEmpresa.ReadOnly             = true;
            txb_CelularEmpresa.ReadOnly            = true;
            txb_CEPEmpresa.ReadOnly                = true;
            txb_CNAEEmpresa.ReadOnly               = true;
            txb_CNPJEmpresa.ReadOnly               = true;
            txb_EmailEmpresa.ReadOnly              = true;
            txb_EndComplementoEmpresa.ReadOnly     = true;
            txb_EnderecoEmpresa.ReadOnly           = true;
            txb_EndNumeroEmpresa.ReadOnly          = true;
            txb_FantasiaEmpresa.ReadOnly           = true;
            txb_FoneFaxEmpresa.ReadOnly            = true;
            txb_InscricaoEstadualEmpresa.ReadOnly  = true;
            txb_InscricaoMunicipalEmpresa.ReadOnly = true;
            txb_ObservacoesEmpresa.ReadOnly        = true;
            txb_RazaoSocialEmpresa.ReadOnly        = true;
            txb_SiglaEmpresa.ReadOnly              = true;
            txb_SiteEmpresa.ReadOnly               = true;
            txb_TelefoneEmpresa.ReadOnly           = true;
            btn_CodIBGEEmpresa.Enabled             = false;
            cbx_NaturezaReceitaEmpresa.Enabled     = false;
            cbx_RegimeTributarioEmpresa.Enabled    = false;
        }

        public void habilita_Campos()
        {
            txb_BairroEmpresa.ReadOnly               = false;
            txb_CelularEmpresa.ReadOnly              = false;
            txb_CEPEmpresa.ReadOnly                  = false;
            txb_CNAEEmpresa.ReadOnly                 = false;
            txb_CNPJEmpresa.ReadOnly                 = false;
            txb_EmailEmpresa.ReadOnly                = false;
            txb_EndComplementoEmpresa.ReadOnly       = false;
            txb_EnderecoEmpresa.ReadOnly             = false;
            txb_EndNumeroEmpresa.ReadOnly            = false;
            txb_FantasiaEmpresa.ReadOnly             = false;
            txb_FoneFaxEmpresa.ReadOnly              = false;
            txb_InscricaoEstadualEmpresa.ReadOnly    = false;
            txb_InscricaoMunicipalEmpresa.ReadOnly   = false;
            txb_ObservacoesEmpresa.ReadOnly          = false;
            txb_RazaoSocialEmpresa.ReadOnly          = false;
            txb_SiglaEmpresa.ReadOnly                = false;
            txb_SiteEmpresa.ReadOnly                 = false;
            txb_TelefoneEmpresa.ReadOnly             = false;
            btn_CodIBGEEmpresa.Enabled               = true;
            cbx_NaturezaReceitaEmpresa.Enabled       = true;
            cbx_RegimeTributarioEmpresa.Enabled      = true;
        }

        public void limpa_Campos()
        {
            txb_CodigoEmpresa.Clear();
            txb_BairroEmpresa.Clear();
            txb_CelularEmpresa.Clear();
            txb_CEPEmpresa.Clear();
            txb_CNAEEmpresa.Clear();
            txb_CNPJEmpresa.Clear();
            txb_EmailEmpresa.Clear();
            txb_EndComplementoEmpresa.Clear();
            txb_EnderecoEmpresa.Clear();
            txb_EndNumeroEmpresa.Clear();
            txb_FantasiaEmpresa.Clear();
            txb_FoneFaxEmpresa.Clear();
            txb_InscricaoEstadualEmpresa.Clear();
            txb_InscricaoMunicipalEmpresa.Clear();
            txb_ObservacoesEmpresa.Clear();
            txb_RazaoSocialEmpresa.Clear();
            txb_SiglaEmpresa.Clear();
            txb_SiteEmpresa.Clear();
            txb_TelefoneEmpresa.Clear();
            txb_CidadeEmpresa.Clear();
            txb_UFEmpresa.Clear();
            bte_CodIBGEEempresa.ResetText();
            cbx_NaturezaReceitaEmpresa.Text = "Selecione a Natureza da Receita";
            cbx_RegimeTributarioEmpresa.Text = "Selecione o Regime Tributário";
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoEmpresa.Enabled      = false;
            btn_AlterarEmpresa.Enabled   = false;
            btn_PesquisarEmpresa.Enabled = false;
            btn_ExcluirEmpresa.Enabled   = false;
            btn_GravarEmpresa.Enabled    = false;
            btn_ImprimirEmpresa.Enabled  = false;
            btn_Cancelar.Enabled         = false;

            if (op == 1)
            {
                btn_NovoEmpresa.Enabled      = true;
                btn_PesquisarEmpresa.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarEmpresa.Enabled = true;
                btn_Cancelar.Enabled      = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarEmpresa.Enabled = true;
                btn_ExcluirEmpresa.Enabled = true;
                btn_Cancelar.Enabled       = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoEmpresa_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            tabControl1.SelectTab(1);
            txb_FantasiaEmpresa.Focus();
            
            try
            {
                BLL_Empresa bll = new BLL_Empresa(cx);
                ModeloEmpresa modelo = bll.informaProximoCodigo();
                txb_CodigoEmpresa.Text = modelo.Codigo.ToString();
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

        private void btn_AlterarEmpresa_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);            
        }     
        
        private void btn_GravarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloEmpresa obj_Empresa = new ModeloEmpresa();

                obj_Empresa.Nome          = txb_RazaoSocialEmpresa.Text;
                obj_Empresa.Fantasia      = txb_FantasiaEmpresa.Text;
                obj_Empresa.Sigla         = txb_SiglaEmpresa.Text;
                obj_Empresa.Endereco      = txb_EnderecoEmpresa.Text;
                obj_Empresa.EndNumero     = txb_EndNumeroEmpresa.Text;
                obj_Empresa.Complemento   = txb_EndComplementoEmpresa.Text;
                obj_Empresa.Bairro        = txb_BairroEmpresa.Text;
                obj_Empresa.Cep           = txb_CEPEmpresa.Text;
                obj_Empresa.Telefone      = txb_TelefoneEmpresa.Text;
                obj_Empresa.Celular       = txb_CelularEmpresa.Text;
                obj_Empresa.Fax           = txb_FoneFaxEmpresa.Text;
                obj_Empresa.Cnpj          = txb_CNPJEmpresa.Text;
                obj_Empresa.InscEstadual  = txb_InscricaoEstadualEmpresa.Text;
                obj_Empresa.InscMunicipal = txb_InscricaoMunicipalEmpresa.Text;
                obj_Empresa.Cnae          = txb_CNAEEmpresa.Text;
                obj_Empresa.CodMunicipio  = Convert.ToInt32(bte_CodIBGEEempresa.Text);
                obj_Empresa.RegTributario = (cbx_RegimeTributarioEmpresa.SelectedIndex +1).ToString();
                obj_Empresa.NatReceita    = (cbx_NaturezaReceitaEmpresa.SelectedIndex + 1).ToString();
                obj_Empresa.Email         = txb_EmailEmpresa.Text;
                obj_Empresa.Site          = txb_SiteEmpresa.Text;
                obj_Empresa.Observacao    = txb_ObservacoesEmpresa.Text;

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Empresa bll = new BLL_Empresa(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_Empresa(obj_Empresa);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_Empresa.Codigo.ToString());
                }
                else
                {
                    obj_Empresa.Codigo = Convert.ToInt32(txb_CodigoEmpresa.Text);
                    bll.altera_Empresa(obj_Empresa);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar Empresa " + erro);
            }
        }

        private void btn_ExcluirEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Empresa bll = new BLL_Empresa(cx);
                    bll.excluir_Empresa(Convert.ToInt32(txb_CodigoEmpresa.Text));

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

        private void btn_PesquisarEmpresa_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_Empresa bll = new BLL_Empresa(cx);
            if (cbx_PesquisarEmpresa.SelectedIndex == 0)//Pequisa empresa por nome (combobox index 0 = Nome)
            {
                dgv_CadastroEmpresa.DataSource = bll.pesquisa_Empresa_Nome(txb_PesquisaEmpresa.Text);
            }
            if (cbx_PesquisarEmpresa.SelectedIndex == 1)//Pequisa empresa por nome (combobox index 1 = Código)
            {
                if(txb_PesquisaEmpresa.Text.Length <= 0)
                {
                    dgv_CadastroEmpresa.DataSource = bll.pesquisa_Empresa_Nome(txb_PesquisaEmpresa.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroEmpresa.DataSource = bll.pesquisa_Empresa_Codigo(Convert.ToInt32(txb_PesquisaEmpresa.Text));
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                    
                }                
            }
            if (cbx_PesquisarEmpresa.SelectedIndex == 2)//Pequisa empresa por nome (combobox index 2 = CNPJ)
            {
                dgv_CadastroEmpresa.DataSource = bll.pesquisa_Empresa_Cnpj(mtb_PesquisaEmpresa.Text);
            }
        }
        
        private void dgv_CadastroEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroEmpresa.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Empresa bll = new BLL_Empresa(cx);
                    ModeloEmpresa modelo = bll.carregaModeloEmpresa(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoEmpresa.Text = modelo.Codigo.ToString();
                    txb_RazaoSocialEmpresa.Text = modelo.Nome;
                    txb_FantasiaEmpresa.Text = modelo.Fantasia;
                    txb_SiglaEmpresa.Text = modelo.Sigla;
                    txb_EnderecoEmpresa.Text = modelo.Endereco;
                    txb_EndNumeroEmpresa.Text = modelo.EndNumero;
                    txb_EndComplementoEmpresa.Text = modelo.Complemento;
                    txb_BairroEmpresa.Text = modelo.Bairro;
                    txb_CEPEmpresa.Text = modelo.Cep;
                    txb_TelefoneEmpresa.Text = modelo.Telefone;
                    txb_CelularEmpresa.Text = modelo.Celular;
                    txb_FoneFaxEmpresa.Text = modelo.Fax;
                    txb_CNPJEmpresa.Text = modelo.Cnpj;
                    txb_InscricaoEstadualEmpresa.Text = modelo.InscEstadual;
                    txb_InscricaoMunicipalEmpresa.Text = modelo.InscMunicipal;
                    txb_CNAEEmpresa.Text = modelo.Cnae;
                    bte_CodIBGEEempresa.Text = modelo.CodMunicipio.ToString();
                    txb_EmailEmpresa.Text = modelo.Email;
                    txb_SiteEmpresa.Text = modelo.Site;
                    txb_ObservacoesEmpresa.Text = modelo.Observacao;

                    //cbx_RegimeTributarioEmpresa.Text  = modelo.RegTributario.ToString();
                    string crt = modelo.RegTributario.ToString();

                    if (crt == "1")
                        cbx_RegimeTributarioEmpresa.SelectedIndex = 0;
                    if (crt == "2")
                        cbx_RegimeTributarioEmpresa.SelectedIndex = 1;
                    if (crt == "3")
                        cbx_RegimeTributarioEmpresa.SelectedIndex = 2;

                    //1 - Simples Nacional
                    //2 - Simples Nacional com Sublimite
                    //3 - Regime Normal

                    //cbx_NaturezaReceitaEmpresa.Text = modelo.NatReceita.ToString();
                    string ntr = modelo.NatReceita.ToString();
                    if (ntr == "1")
                        cbx_NaturezaReceitaEmpresa.SelectedIndex = 0;
                    if (ntr == "2")
                        cbx_NaturezaReceitaEmpresa.SelectedIndex = 1;
                    if (ntr == "3")
                        cbx_NaturezaReceitaEmpresa.SelectedIndex = 2;

                    //1 - Cumulativo
                    //2 - Não Cumulativo
                    //3 - Regime Especial

                    //Aqui preenche o textbox caixa usuario conforme o valor definido no campo referente ao numero do caixa
                    BLL_TabMunicipio bll_municipio = new BLL_TabMunicipio(cx);
                    ModeloTabMunicipio modelo_municipio = bll_municipio.carregaModeloMunicipio(Convert.ToInt32(bte_CodIBGEEempresa.Text));
                    bte_CodIBGEEempresa.TextBox.Text = modelo_municipio.Codigo.ToString();
                    txb_CidadeEmpresa.Text = modelo_municipio.Nome;
                    txb_UFEmpresa.Text = modelo_municipio.SiglaUF;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroEmpresa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroEmpresa.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Empresa bll = new BLL_Empresa(cx);
                    ModeloEmpresa modelo = bll.carregaModeloEmpresa(codigo);

                    txb_CodigoEmpresa.Text = modelo.Codigo.ToString();
                    txb_RazaoSocialEmpresa.Text = modelo.Nome;
                    txb_FantasiaEmpresa.Text = modelo.Fantasia;
                    txb_SiglaEmpresa.Text = modelo.Sigla;
                    txb_EnderecoEmpresa.Text = modelo.Endereco;
                    txb_EndNumeroEmpresa.Text = modelo.EndNumero;
                    txb_EndComplementoEmpresa.Text = modelo.Complemento;
                    txb_BairroEmpresa.Text = modelo.Bairro;
                    txb_CEPEmpresa.Text = modelo.Cep;
                    txb_TelefoneEmpresa.Text = modelo.Telefone;
                    txb_CelularEmpresa.Text = modelo.Celular;
                    txb_FoneFaxEmpresa.Text = modelo.Fax;
                    txb_CNPJEmpresa.Text = modelo.Cnpj;
                    txb_InscricaoEstadualEmpresa.Text = modelo.InscEstadual;
                    txb_InscricaoMunicipalEmpresa.Text = modelo.InscMunicipal;
                    txb_CNAEEmpresa.Text = modelo.Cnae;
                    bte_CodIBGEEempresa.Text = modelo.CodMunicipio.ToString();                    
                    txb_EmailEmpresa.Text = modelo.Email;
                    txb_SiteEmpresa.Text = modelo.Site;
                    txb_ObservacoesEmpresa.Text = modelo.Observacao;

                    //cbx_RegimeTributarioEmpresa.Text  = modelo.RegTributario.ToString();
                    string crt = modelo.RegTributario.ToString();

                    if (crt == "1")
                        cbx_RegimeTributarioEmpresa.SelectedIndex = 0;
                    if (crt == "2")
                        cbx_RegimeTributarioEmpresa.SelectedIndex = 1;
                    if (crt == "3")
                        cbx_RegimeTributarioEmpresa.SelectedIndex = 2;

                    //1 - Simples Nacional
                    //2 - Simples Nacional com Sublimite
                    //3 - Regime Normal

                    //cbx_NaturezaReceitaEmpresa.Text = modelo.NatReceita.ToString();
                    string ntr = modelo.NatReceita.ToString();
                    if (ntr == "1")
                        cbx_NaturezaReceitaEmpresa.SelectedIndex = 0;
                    if (ntr == "2")
                        cbx_NaturezaReceitaEmpresa.SelectedIndex = 1;
                    if (ntr == "3")
                        cbx_NaturezaReceitaEmpresa.SelectedIndex = 2;

                    //1 - Cumulativo
                    //2 - Não Cumulativo
                    //3 - Regime Especial

                    //Aqui preenche o textbox caixa usuario conforme o valor definido no campo referente ao numero do caixa
                    BLL_TabMunicipio bll_municipio = new BLL_TabMunicipio(cx);
                    ModeloTabMunicipio modelo_municipio = bll_municipio.carregaModeloMunicipio(Convert.ToInt32(bte_CodIBGEEempresa.Text));
                    bte_CodIBGEEempresa.TextBox.Text = modelo_municipio.Codigo.ToString();
                    txb_CidadeEmpresa.Text = modelo_municipio.Nome;
                    txb_UFEmpresa.Text = modelo_municipio.SiglaUF;
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void cbx_PesquisarEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_PesquisarEmpresa.SelectedIndex == 2)
            {
                txb_PesquisaEmpresa.Visible = false;
                txb_PesquisaEmpresa.Clear();
                mtb_PesquisaEmpresa.Visible = true;
                mtb_PesquisaEmpresa.Mask = "99,999,999/9999-99";
                mtb_PesquisaEmpresa.TabIndex = 2;
            }
            else
            {
                txb_PesquisaEmpresa.Visible = true;
                mtb_PesquisaEmpresa.Visible = false;
                mtb_PesquisaEmpresa.Clear();
                txb_PesquisaEmpresa.TabIndex = 2;
            }
        }

        private void btn_CodIBGEEmpresa_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("municipio");
            frmConsultaRapida.ShowDialog();

            if (frmConsultaRapida.codigo != 0)
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_TabMunicipio bll = new BLL_TabMunicipio(cx);
                ModeloTabMunicipio modelo = bll.carregaModeloMunicipio(frmConsultaRapida.codigo);
                bte_CodIBGEEempresa.TextBox.Text = modelo.Codigo.ToString();
                txb_CidadeEmpresa.Text = modelo.Nome;
                txb_UFEmpresa.Text = modelo.SiglaUF;
            }
            frmConsultaRapida.Dispose();
        }       
       
    }
}
