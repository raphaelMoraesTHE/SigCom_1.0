namespace GUI
{
    partial class frm_CadastroCargosFuncoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_CadastroCargosFuncoes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_PesquisaCargosFuncoes = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_PesquisarCargosFuncoes = new System.Windows.Forms.ComboBox();
            this.btn_PesquisarCargosFuncoes = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chb_FuncaoOutros = new System.Windows.Forms.CheckBox();
            this.chb_FuncaoCobrador = new System.Windows.Forms.CheckBox();
            this.chb_FuncaoSupervisor = new System.Windows.Forms.CheckBox();
            this.chb_FuncaoMotorista = new System.Windows.Forms.CheckBox();
            this.chb_FuncaoTecnico = new System.Windows.Forms.CheckBox();
            this.chb_FuncaoVendedor = new System.Windows.Forms.CheckBox();
            this.txb_DescricaoCargosFuncoes = new System.Windows.Forms.TextBox();
            this.txb_CodigoCargosFuncoes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_ImprimirCargosFuncoes = new System.Windows.Forms.Button();
            this.btn_ExcluirCargosFuncoes = new System.Windows.Forms.Button();
            this.btn_AlterarCargosFuncoes = new System.Windows.Forms.Button();
            this.btn_GravarCargosFuncoes = new System.Windows.Forms.Button();
            this.btn_NovoCargosFuncoes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroCargosFuncoes)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 702);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_CadastroCargosFuncoes);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Localizar (1)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_CadastroCargosFuncoes
            // 
            this.dgv_CadastroCargosFuncoes.AllowUserToAddRows = false;
            this.dgv_CadastroCargosFuncoes.AllowUserToDeleteRows = false;
            this.dgv_CadastroCargosFuncoes.AllowUserToOrderColumns = true;
            this.dgv_CadastroCargosFuncoes.AllowUserToResizeColumns = false;
            this.dgv_CadastroCargosFuncoes.AllowUserToResizeRows = false;
            this.dgv_CadastroCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CadastroCargosFuncoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CadastroCargosFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CadastroCargosFuncoes.Location = new System.Drawing.Point(7, 80);
            this.dgv_CadastroCargosFuncoes.Name = "dgv_CadastroCargosFuncoes";
            this.dgv_CadastroCargosFuncoes.ReadOnly = true;
            this.dgv_CadastroCargosFuncoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_CadastroCargosFuncoes.RowTemplate.Height = 24;
            this.dgv_CadastroCargosFuncoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_CadastroCargosFuncoes.Size = new System.Drawing.Size(1227, 585);
            this.dgv_CadastroCargosFuncoes.StandardTab = true;
            this.dgv_CadastroCargosFuncoes.TabIndex = 0;
            this.dgv_CadastroCargosFuncoes.TabStop = false;
            this.dgv_CadastroCargosFuncoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroCargosFuncoes_CellDoubleClick);
            this.dgv_CadastroCargosFuncoes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroCargosFuncoes_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txb_PesquisaCargosFuncoes);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbx_PesquisarCargosFuncoes);
            this.panel2.Controls.Add(this.btn_PesquisarCargosFuncoes);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 66);
            this.panel2.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 44;
            this.label12.Text = "Pesquisar Por";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // txb_PesquisaCargosFuncoes
            // 
            this.txb_PesquisaCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PesquisaCargosFuncoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_PesquisaCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PesquisaCargosFuncoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_PesquisaCargosFuncoes.Location = new System.Drawing.Point(189, 30);
            this.txb_PesquisaCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_PesquisaCargosFuncoes.Name = "txb_PesquisaCargosFuncoes";
            this.txb_PesquisaCargosFuncoes.Size = new System.Drawing.Size(976, 27);
            this.txb_PesquisaCargosFuncoes.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "Digite Aqui";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // cbx_PesquisarCargosFuncoes
            // 
            this.cbx_PesquisarCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_PesquisarCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PesquisarCargosFuncoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_PesquisarCargosFuncoes.FormattingEnabled = true;
            this.cbx_PesquisarCargosFuncoes.Items.AddRange(new object[] {
            "Nome",
            "Código"});
            this.cbx_PesquisarCargosFuncoes.Location = new System.Drawing.Point(3, 29);
            this.cbx_PesquisarCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_PesquisarCargosFuncoes.Name = "cbx_PesquisarCargosFuncoes";
            this.cbx_PesquisarCargosFuncoes.Size = new System.Drawing.Size(163, 28);
            this.cbx_PesquisarCargosFuncoes.TabIndex = 1;
            // 
            // btn_PesquisarCargosFuncoes
            // 
            this.btn_PesquisarCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PesquisarCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarCargosFuncoes.Location = new System.Drawing.Point(1165, 28);
            this.btn_PesquisarCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PesquisarCargosFuncoes.Name = "btn_PesquisarCargosFuncoes";
            this.btn_PesquisarCargosFuncoes.Size = new System.Drawing.Size(57, 31);
            this.btn_PesquisarCargosFuncoes.TabIndex = 3;
            this.btn_PesquisarCargosFuncoes.Text = "Ir";
            this.btn_PesquisarCargosFuncoes.UseCompatibleTextRendering = true;
            this.btn_PesquisarCargosFuncoes.UseVisualStyleBackColor = true;
            this.btn_PesquisarCargosFuncoes.Click += new System.EventHandler(this.btn_PesquisarCargosFuncoes_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro (2)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chb_FuncaoOutros);
            this.panel3.Controls.Add(this.chb_FuncaoCobrador);
            this.panel3.Controls.Add(this.chb_FuncaoSupervisor);
            this.panel3.Controls.Add(this.chb_FuncaoMotorista);
            this.panel3.Controls.Add(this.chb_FuncaoTecnico);
            this.panel3.Controls.Add(this.chb_FuncaoVendedor);
            this.panel3.Controls.Add(this.txb_DescricaoCargosFuncoes);
            this.panel3.Controls.Add(this.txb_CodigoCargosFuncoes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 665);
            this.panel3.TabIndex = 0;
            // 
            // chb_FuncaoOutros
            // 
            this.chb_FuncaoOutros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_FuncaoOutros.AutoSize = true;
            this.chb_FuncaoOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_FuncaoOutros.Location = new System.Drawing.Point(696, 240);
            this.chb_FuncaoOutros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_FuncaoOutros.Name = "chb_FuncaoOutros";
            this.chb_FuncaoOutros.Size = new System.Drawing.Size(88, 24);
            this.chb_FuncaoOutros.TabIndex = 82;
            this.chb_FuncaoOutros.Text = "Outros";
            this.chb_FuncaoOutros.UseVisualStyleBackColor = true;
            // 
            // chb_FuncaoCobrador
            // 
            this.chb_FuncaoCobrador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_FuncaoCobrador.AutoSize = true;
            this.chb_FuncaoCobrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_FuncaoCobrador.Location = new System.Drawing.Point(696, 197);
            this.chb_FuncaoCobrador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_FuncaoCobrador.Name = "chb_FuncaoCobrador";
            this.chb_FuncaoCobrador.Size = new System.Drawing.Size(108, 24);
            this.chb_FuncaoCobrador.TabIndex = 81;
            this.chb_FuncaoCobrador.Text = "Cobrador";
            this.chb_FuncaoCobrador.UseVisualStyleBackColor = true;
            // 
            // chb_FuncaoSupervisor
            // 
            this.chb_FuncaoSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_FuncaoSupervisor.AutoSize = true;
            this.chb_FuncaoSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_FuncaoSupervisor.Location = new System.Drawing.Point(696, 154);
            this.chb_FuncaoSupervisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_FuncaoSupervisor.Name = "chb_FuncaoSupervisor";
            this.chb_FuncaoSupervisor.Size = new System.Drawing.Size(121, 24);
            this.chb_FuncaoSupervisor.TabIndex = 80;
            this.chb_FuncaoSupervisor.Text = "Supervisor";
            this.chb_FuncaoSupervisor.UseVisualStyleBackColor = true;
            // 
            // chb_FuncaoMotorista
            // 
            this.chb_FuncaoMotorista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_FuncaoMotorista.AutoSize = true;
            this.chb_FuncaoMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_FuncaoMotorista.Location = new System.Drawing.Point(348, 240);
            this.chb_FuncaoMotorista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_FuncaoMotorista.Name = "chb_FuncaoMotorista";
            this.chb_FuncaoMotorista.Size = new System.Drawing.Size(110, 24);
            this.chb_FuncaoMotorista.TabIndex = 79;
            this.chb_FuncaoMotorista.Text = "Motorista";
            this.chb_FuncaoMotorista.UseVisualStyleBackColor = true;
            // 
            // chb_FuncaoTecnico
            // 
            this.chb_FuncaoTecnico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_FuncaoTecnico.AutoSize = true;
            this.chb_FuncaoTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_FuncaoTecnico.Location = new System.Drawing.Point(348, 197);
            this.chb_FuncaoTecnico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_FuncaoTecnico.Name = "chb_FuncaoTecnico";
            this.chb_FuncaoTecnico.Size = new System.Drawing.Size(97, 24);
            this.chb_FuncaoTecnico.TabIndex = 78;
            this.chb_FuncaoTecnico.Text = "Técnico";
            this.chb_FuncaoTecnico.UseVisualStyleBackColor = true;
            // 
            // chb_FuncaoVendedor
            // 
            this.chb_FuncaoVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_FuncaoVendedor.AutoSize = true;
            this.chb_FuncaoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_FuncaoVendedor.Location = new System.Drawing.Point(348, 154);
            this.chb_FuncaoVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_FuncaoVendedor.Name = "chb_FuncaoVendedor";
            this.chb_FuncaoVendedor.Size = new System.Drawing.Size(110, 24);
            this.chb_FuncaoVendedor.TabIndex = 77;
            this.chb_FuncaoVendedor.Text = "Vendedor";
            this.chb_FuncaoVendedor.UseVisualStyleBackColor = true;
            // 
            // txb_DescricaoCargosFuncoes
            // 
            this.txb_DescricaoCargosFuncoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_DescricaoCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DescricaoCargosFuncoes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_DescricaoCargosFuncoes.Location = new System.Drawing.Point(9, 94);
            this.txb_DescricaoCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_DescricaoCargosFuncoes.Name = "txb_DescricaoCargosFuncoes";
            this.txb_DescricaoCargosFuncoes.Size = new System.Drawing.Size(1156, 27);
            this.txb_DescricaoCargosFuncoes.TabIndex = 5;
            // 
            // txb_CodigoCargosFuncoes
            // 
            this.txb_CodigoCargosFuncoes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_CodigoCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CodigoCargosFuncoes.ForeColor = System.Drawing.Color.Red;
            this.txb_CodigoCargosFuncoes.Location = new System.Drawing.Point(9, 28);
            this.txb_CodigoCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_CodigoCargosFuncoes.Name = "txb_CodigoCargosFuncoes";
            this.txb_CodigoCargosFuncoes.ReadOnly = true;
            this.txb_CodigoCargosFuncoes.Size = new System.Drawing.Size(100, 27);
            this.txb_CodigoCargosFuncoes.TabIndex = 16;
            this.txb_CodigoCargosFuncoes.TabStop = false;
            this.txb_CodigoCargosFuncoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descrição";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_ImprimirCargosFuncoes);
            this.panel1.Controls.Add(this.btn_ExcluirCargosFuncoes);
            this.panel1.Controls.Add(this.btn_AlterarCargosFuncoes);
            this.panel1.Controls.Add(this.btn_GravarCargosFuncoes);
            this.panel1.Controls.Add(this.btn_NovoCargosFuncoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 48);
            this.panel1.TabIndex = 2;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(1133, 9);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(103, 31);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseCompatibleTextRendering = true;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_ImprimirCargosFuncoes
            // 
            this.btn_ImprimirCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ImprimirCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirCargosFuncoes.Location = new System.Drawing.Point(422, 9);
            this.btn_ImprimirCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ImprimirCargosFuncoes.Name = "btn_ImprimirCargosFuncoes";
            this.btn_ImprimirCargosFuncoes.Size = new System.Drawing.Size(97, 31);
            this.btn_ImprimirCargosFuncoes.TabIndex = 20;
            this.btn_ImprimirCargosFuncoes.Text = "Imprimir";
            this.btn_ImprimirCargosFuncoes.UseCompatibleTextRendering = true;
            this.btn_ImprimirCargosFuncoes.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirCargosFuncoes
            // 
            this.btn_ExcluirCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ExcluirCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCargosFuncoes.Location = new System.Drawing.Point(320, 9);
            this.btn_ExcluirCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirCargosFuncoes.Name = "btn_ExcluirCargosFuncoes";
            this.btn_ExcluirCargosFuncoes.Size = new System.Drawing.Size(97, 31);
            this.btn_ExcluirCargosFuncoes.TabIndex = 19;
            this.btn_ExcluirCargosFuncoes.Text = "Excluir";
            this.btn_ExcluirCargosFuncoes.UseCompatibleTextRendering = true;
            this.btn_ExcluirCargosFuncoes.UseVisualStyleBackColor = true;
            this.btn_ExcluirCargosFuncoes.Click += new System.EventHandler(this.btn_ExcluirCargosFuncoes_Click);
            // 
            // btn_AlterarCargosFuncoes
            // 
            this.btn_AlterarCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AlterarCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarCargosFuncoes.Location = new System.Drawing.Point(216, 9);
            this.btn_AlterarCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarCargosFuncoes.Name = "btn_AlterarCargosFuncoes";
            this.btn_AlterarCargosFuncoes.Size = new System.Drawing.Size(97, 31);
            this.btn_AlterarCargosFuncoes.TabIndex = 18;
            this.btn_AlterarCargosFuncoes.Text = "Alterar";
            this.btn_AlterarCargosFuncoes.UseCompatibleTextRendering = true;
            this.btn_AlterarCargosFuncoes.UseVisualStyleBackColor = true;
            this.btn_AlterarCargosFuncoes.Click += new System.EventHandler(this.btn_AlterarCargosFuncoes_Click);
            // 
            // btn_GravarCargosFuncoes
            // 
            this.btn_GravarCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GravarCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarCargosFuncoes.Location = new System.Drawing.Point(113, 9);
            this.btn_GravarCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GravarCargosFuncoes.Name = "btn_GravarCargosFuncoes";
            this.btn_GravarCargosFuncoes.Size = new System.Drawing.Size(97, 31);
            this.btn_GravarCargosFuncoes.TabIndex = 17;
            this.btn_GravarCargosFuncoes.Text = "Gravar";
            this.btn_GravarCargosFuncoes.UseCompatibleTextRendering = true;
            this.btn_GravarCargosFuncoes.UseVisualStyleBackColor = true;
            this.btn_GravarCargosFuncoes.Click += new System.EventHandler(this.btn_GravarCargosFuncoes_Click);
            // 
            // btn_NovoCargosFuncoes
            // 
            this.btn_NovoCargosFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NovoCargosFuncoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoCargosFuncoes.Location = new System.Drawing.Point(10, 9);
            this.btn_NovoCargosFuncoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NovoCargosFuncoes.Name = "btn_NovoCargosFuncoes";
            this.btn_NovoCargosFuncoes.Size = new System.Drawing.Size(97, 31);
            this.btn_NovoCargosFuncoes.TabIndex = 4;
            this.btn_NovoCargosFuncoes.Text = "Novo";
            this.btn_NovoCargosFuncoes.UseCompatibleTextRendering = true;
            this.btn_NovoCargosFuncoes.UseVisualStyleBackColor = true;
            this.btn_NovoCargosFuncoes.Click += new System.EventHandler(this.btn_NovoCargosFuncoes_Click);
            // 
            // frm_CadastroCargosFuncoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroCargosFuncoes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CadastroCargosFuncoes";
            this.Load += new System.EventHandler(this.frm_CadastroCargosFuncoes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroCargosFuncoes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_CadastroCargosFuncoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_PesquisaCargosFuncoes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_PesquisarCargosFuncoes;
        private System.Windows.Forms.Button btn_PesquisarCargosFuncoes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_DescricaoCargosFuncoes;
        private System.Windows.Forms.TextBox txb_CodigoCargosFuncoes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_ImprimirCargosFuncoes;
        private System.Windows.Forms.Button btn_ExcluirCargosFuncoes;
        private System.Windows.Forms.Button btn_AlterarCargosFuncoes;
        private System.Windows.Forms.Button btn_GravarCargosFuncoes;
        private System.Windows.Forms.Button btn_NovoCargosFuncoes;
        private System.Windows.Forms.CheckBox chb_FuncaoOutros;
        private System.Windows.Forms.CheckBox chb_FuncaoCobrador;
        private System.Windows.Forms.CheckBox chb_FuncaoSupervisor;
        private System.Windows.Forms.CheckBox chb_FuncaoMotorista;
        private System.Windows.Forms.CheckBox chb_FuncaoTecnico;
        private System.Windows.Forms.CheckBox chb_FuncaoVendedor;
    }
}