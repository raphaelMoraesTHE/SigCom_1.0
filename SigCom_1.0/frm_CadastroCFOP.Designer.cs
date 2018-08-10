namespace GUI
{
    partial class frm_CadastroCFOP
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
            this.dgv_CadastroCFOP = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_PesquisaCFOP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_PesquisarCFOP = new System.Windows.Forms.ComboBox();
            this.btn_PesquisarCFOP = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtb_NaturezaCFOP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_AtivoImobilizadoCFOP = new System.Windows.Forms.CheckBox();
            this.cbx_EntradaSaidaCFOP = new System.Windows.Forms.ComboBox();
            this.chb_DentroEstadoCFOP = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txb_ComplementoCFOP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_DescricaoCFOP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_ImprimirCFOP = new System.Windows.Forms.Button();
            this.btn_ExcluirCFOP = new System.Windows.Forms.Button();
            this.btn_AlterarCFOP = new System.Windows.Forms.Button();
            this.btn_GravarCFOP = new System.Windows.Forms.Button();
            this.btn_NovoCFOP = new System.Windows.Forms.Button();
            this.mtb_PesquisaCFOP = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroCFOP)).BeginInit();
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
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_CadastroCFOP);
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
            // dgv_CadastroCFOP
            // 
            this.dgv_CadastroCFOP.AllowUserToAddRows = false;
            this.dgv_CadastroCFOP.AllowUserToDeleteRows = false;
            this.dgv_CadastroCFOP.AllowUserToOrderColumns = true;
            this.dgv_CadastroCFOP.AllowUserToResizeColumns = false;
            this.dgv_CadastroCFOP.AllowUserToResizeRows = false;
            this.dgv_CadastroCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CadastroCFOP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CadastroCFOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CadastroCFOP.Location = new System.Drawing.Point(7, 80);
            this.dgv_CadastroCFOP.Name = "dgv_CadastroCFOP";
            this.dgv_CadastroCFOP.ReadOnly = true;
            this.dgv_CadastroCFOP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_CadastroCFOP.RowTemplate.Height = 24;
            this.dgv_CadastroCFOP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_CadastroCFOP.Size = new System.Drawing.Size(1227, 585);
            this.dgv_CadastroCFOP.StandardTab = true;
            this.dgv_CadastroCFOP.TabIndex = 0;
            this.dgv_CadastroCFOP.TabStop = false;
            this.dgv_CadastroCFOP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroCFOP_CellDoubleClick);
            this.dgv_CadastroCFOP.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroCFOP_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbx_PesquisarCFOP);
            this.panel2.Controls.Add(this.btn_PesquisarCFOP);
            this.panel2.Controls.Add(this.mtb_PesquisaCFOP);
            this.panel2.Controls.Add(this.txb_PesquisaCFOP);
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
            // txb_PesquisaCFOP
            // 
            this.txb_PesquisaCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PesquisaCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_PesquisaCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PesquisaCFOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_PesquisaCFOP.Location = new System.Drawing.Point(189, 30);
            this.txb_PesquisaCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_PesquisaCFOP.Name = "txb_PesquisaCFOP";
            this.txb_PesquisaCFOP.Size = new System.Drawing.Size(976, 27);
            this.txb_PesquisaCFOP.TabIndex = 2;
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
            // cbx_PesquisarCFOP
            // 
            this.cbx_PesquisarCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_PesquisarCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PesquisarCFOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_PesquisarCFOP.FormattingEnabled = true;
            this.cbx_PesquisarCFOP.Items.AddRange(new object[] {
            "Descrição",
            "Código"});
            this.cbx_PesquisarCFOP.Location = new System.Drawing.Point(3, 29);
            this.cbx_PesquisarCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_PesquisarCFOP.Name = "cbx_PesquisarCFOP";
            this.cbx_PesquisarCFOP.Size = new System.Drawing.Size(163, 28);
            this.cbx_PesquisarCFOP.TabIndex = 1;
            this.cbx_PesquisarCFOP.SelectedIndexChanged += new System.EventHandler(this.cbx_PesquisarCFOP_SelectedIndexChanged);
            // 
            // btn_PesquisarCFOP
            // 
            this.btn_PesquisarCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PesquisarCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarCFOP.Location = new System.Drawing.Point(1165, 28);
            this.btn_PesquisarCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PesquisarCFOP.Name = "btn_PesquisarCFOP";
            this.btn_PesquisarCFOP.Size = new System.Drawing.Size(57, 31);
            this.btn_PesquisarCFOP.TabIndex = 3;
            this.btn_PesquisarCFOP.Text = "Ir";
            this.btn_PesquisarCFOP.UseCompatibleTextRendering = true;
            this.btn_PesquisarCFOP.UseVisualStyleBackColor = true;
            this.btn_PesquisarCFOP.Click += new System.EventHandler(this.btn_PesquisarCFOP_Click);
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
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.mtb_NaturezaCFOP);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.chb_AtivoImobilizadoCFOP);
            this.panel3.Controls.Add(this.cbx_EntradaSaidaCFOP);
            this.panel3.Controls.Add(this.chb_DentroEstadoCFOP);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.txb_ComplementoCFOP);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txb_DescricaoCFOP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 656);
            this.panel3.TabIndex = 0;
            // 
            // mtb_NaturezaCFOP
            // 
            this.mtb_NaturezaCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtb_NaturezaCFOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mtb_NaturezaCFOP.Location = new System.Drawing.Point(39, 33);
            this.mtb_NaturezaCFOP.Mask = "9,999";
            this.mtb_NaturezaCFOP.Name = "mtb_NaturezaCFOP";
            this.mtb_NaturezaCFOP.Size = new System.Drawing.Size(121, 27);
            this.mtb_NaturezaCFOP.TabIndex = 70;
            this.mtb_NaturezaCFOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "CFOP";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // chb_AtivoImobilizadoCFOP
            // 
            this.chb_AtivoImobilizadoCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_AtivoImobilizadoCFOP.AutoSize = true;
            this.chb_AtivoImobilizadoCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_AtivoImobilizadoCFOP.Location = new System.Drawing.Point(48, 369);
            this.chb_AtivoImobilizadoCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_AtivoImobilizadoCFOP.Name = "chb_AtivoImobilizadoCFOP";
            this.chb_AtivoImobilizadoCFOP.Size = new System.Drawing.Size(174, 24);
            this.chb_AtivoImobilizadoCFOP.TabIndex = 16;
            this.chb_AtivoImobilizadoCFOP.Text = "Ativo Imobilizado";
            this.chb_AtivoImobilizadoCFOP.UseVisualStyleBackColor = true;
            // 
            // cbx_EntradaSaidaCFOP
            // 
            this.cbx_EntradaSaidaCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_EntradaSaidaCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_EntradaSaidaCFOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_EntradaSaidaCFOP.FormattingEnabled = true;
            this.cbx_EntradaSaidaCFOP.Items.AddRange(new object[] {
            "ENTRADA",
            "SAIDA"});
            this.cbx_EntradaSaidaCFOP.Location = new System.Drawing.Point(39, 248);
            this.cbx_EntradaSaidaCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_EntradaSaidaCFOP.Name = "cbx_EntradaSaidaCFOP";
            this.cbx_EntradaSaidaCFOP.Size = new System.Drawing.Size(367, 28);
            this.cbx_EntradaSaidaCFOP.TabIndex = 68;
            // 
            // chb_DentroEstadoCFOP
            // 
            this.chb_DentroEstadoCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_DentroEstadoCFOP.AutoSize = true;
            this.chb_DentroEstadoCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_DentroEstadoCFOP.Location = new System.Drawing.Point(48, 339);
            this.chb_DentroEstadoCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_DentroEstadoCFOP.Name = "chb_DentroEstadoCFOP";
            this.chb_DentroEstadoCFOP.Size = new System.Drawing.Size(178, 24);
            this.chb_DentroEstadoCFOP.TabIndex = 14;
            this.chb_DentroEstadoCFOP.Text = "Dentro do Estado";
            this.chb_DentroEstadoCFOP.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(39, 228);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 25);
            this.label23.TabIndex = 69;
            this.label23.Text = "Entrada / Saida";
            this.label23.UseCompatibleTextRendering = true;
            // 
            // txb_ComplementoCFOP
            // 
            this.txb_ComplementoCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_ComplementoCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ComplementoCFOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_ComplementoCFOP.Location = new System.Drawing.Point(39, 170);
            this.txb_ComplementoCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_ComplementoCFOP.Name = "txb_ComplementoCFOP";
            this.txb_ComplementoCFOP.Size = new System.Drawing.Size(614, 27);
            this.txb_ComplementoCFOP.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(37, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 25);
            this.label15.TabIndex = 24;
            this.label15.Text = "Complemento";
            this.label15.UseCompatibleTextRendering = true;
            // 
            // txb_DescricaoCFOP
            // 
            this.txb_DescricaoCFOP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_DescricaoCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DescricaoCFOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_DescricaoCFOP.Location = new System.Drawing.Point(37, 99);
            this.txb_DescricaoCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_DescricaoCFOP.Name = "txb_DescricaoCFOP";
            this.txb_DescricaoCFOP.Size = new System.Drawing.Size(1175, 27);
            this.txb_DescricaoCFOP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descrição";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_ImprimirCFOP);
            this.panel1.Controls.Add(this.btn_ExcluirCFOP);
            this.panel1.Controls.Add(this.btn_AlterarCFOP);
            this.panel1.Controls.Add(this.btn_GravarCFOP);
            this.panel1.Controls.Add(this.btn_NovoCFOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 48);
            this.panel1.TabIndex = 4;
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
            // btn_ImprimirCFOP
            // 
            this.btn_ImprimirCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ImprimirCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirCFOP.Location = new System.Drawing.Point(422, 9);
            this.btn_ImprimirCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ImprimirCFOP.Name = "btn_ImprimirCFOP";
            this.btn_ImprimirCFOP.Size = new System.Drawing.Size(97, 31);
            this.btn_ImprimirCFOP.TabIndex = 20;
            this.btn_ImprimirCFOP.Text = "Imprimir";
            this.btn_ImprimirCFOP.UseCompatibleTextRendering = true;
            this.btn_ImprimirCFOP.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirCFOP
            // 
            this.btn_ExcluirCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ExcluirCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCFOP.Location = new System.Drawing.Point(320, 9);
            this.btn_ExcluirCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirCFOP.Name = "btn_ExcluirCFOP";
            this.btn_ExcluirCFOP.Size = new System.Drawing.Size(97, 31);
            this.btn_ExcluirCFOP.TabIndex = 19;
            this.btn_ExcluirCFOP.Text = "Excluir";
            this.btn_ExcluirCFOP.UseCompatibleTextRendering = true;
            this.btn_ExcluirCFOP.UseVisualStyleBackColor = true;
            this.btn_ExcluirCFOP.Click += new System.EventHandler(this.btn_ExcluirCFOP_Click);
            // 
            // btn_AlterarCFOP
            // 
            this.btn_AlterarCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AlterarCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarCFOP.Location = new System.Drawing.Point(216, 9);
            this.btn_AlterarCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarCFOP.Name = "btn_AlterarCFOP";
            this.btn_AlterarCFOP.Size = new System.Drawing.Size(97, 31);
            this.btn_AlterarCFOP.TabIndex = 18;
            this.btn_AlterarCFOP.Text = "Alterar";
            this.btn_AlterarCFOP.UseCompatibleTextRendering = true;
            this.btn_AlterarCFOP.UseVisualStyleBackColor = true;
            this.btn_AlterarCFOP.Click += new System.EventHandler(this.btn_AlterarCFOP_Click);
            // 
            // btn_GravarCFOP
            // 
            this.btn_GravarCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GravarCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarCFOP.Location = new System.Drawing.Point(113, 9);
            this.btn_GravarCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GravarCFOP.Name = "btn_GravarCFOP";
            this.btn_GravarCFOP.Size = new System.Drawing.Size(97, 31);
            this.btn_GravarCFOP.TabIndex = 17;
            this.btn_GravarCFOP.Text = "Gravar";
            this.btn_GravarCFOP.UseCompatibleTextRendering = true;
            this.btn_GravarCFOP.UseVisualStyleBackColor = true;
            this.btn_GravarCFOP.Click += new System.EventHandler(this.btn_GravarCFOP_Click);
            // 
            // btn_NovoCFOP
            // 
            this.btn_NovoCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NovoCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoCFOP.Location = new System.Drawing.Point(10, 9);
            this.btn_NovoCFOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NovoCFOP.Name = "btn_NovoCFOP";
            this.btn_NovoCFOP.Size = new System.Drawing.Size(97, 31);
            this.btn_NovoCFOP.TabIndex = 4;
            this.btn_NovoCFOP.Text = "Novo";
            this.btn_NovoCFOP.UseCompatibleTextRendering = true;
            this.btn_NovoCFOP.UseVisualStyleBackColor = true;
            this.btn_NovoCFOP.Click += new System.EventHandler(this.btn_NovoCFOP_Click);
            // 
            // mtb_PesquisaCFOP
            // 
            this.mtb_PesquisaCFOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtb_PesquisaCFOP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtb_PesquisaCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.mtb_PesquisaCFOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mtb_PesquisaCFOP.Location = new System.Drawing.Point(189, 30);
            this.mtb_PesquisaCFOP.Mask = "9,999";
            this.mtb_PesquisaCFOP.Name = "mtb_PesquisaCFOP";
            this.mtb_PesquisaCFOP.Size = new System.Drawing.Size(974, 27);
            this.mtb_PesquisaCFOP.TabIndex = 71;
            // 
            // frm_CadastroCFOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroCFOP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_CadastroCFOP";
            this.Load += new System.EventHandler(this.frm_CadastroCFOP_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroCFOP)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_CadastroCFOP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_PesquisaCFOP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_PesquisarCFOP;
        private System.Windows.Forms.Button btn_PesquisarCFOP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox mtb_NaturezaCFOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_AtivoImobilizadoCFOP;
        private System.Windows.Forms.ComboBox cbx_EntradaSaidaCFOP;
        private System.Windows.Forms.CheckBox chb_DentroEstadoCFOP;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txb_ComplementoCFOP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_DescricaoCFOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_ImprimirCFOP;
        private System.Windows.Forms.Button btn_ExcluirCFOP;
        private System.Windows.Forms.Button btn_AlterarCFOP;
        private System.Windows.Forms.Button btn_GravarCFOP;
        private System.Windows.Forms.Button btn_NovoCFOP;
        private System.Windows.Forms.MaskedTextBox mtb_PesquisaCFOP;
    }
}