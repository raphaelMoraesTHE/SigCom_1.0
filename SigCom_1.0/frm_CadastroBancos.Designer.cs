namespace GUI
{
    partial class frm_CadastroBancos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_CadastroBanco = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_PesquisaBanco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_PesquisarBanco = new System.Windows.Forms.ComboBox();
            this.btn_PesquisarBanco = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_NomeBanco = new System.Windows.Forms.TextBox();
            this.txb_CodigoBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_ImprimirBanco = new System.Windows.Forms.Button();
            this.btn_ExcluirBanco = new System.Windows.Forms.Button();
            this.btn_AlterarBanco = new System.Windows.Forms.Button();
            this.btn_GravarBanco = new System.Windows.Forms.Button();
            this.btn_NovoBanco = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroBanco)).BeginInit();
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
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_CadastroBanco);
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
            // dgv_CadastroBanco
            // 
            this.dgv_CadastroBanco.AllowUserToAddRows = false;
            this.dgv_CadastroBanco.AllowUserToDeleteRows = false;
            this.dgv_CadastroBanco.AllowUserToOrderColumns = true;
            this.dgv_CadastroBanco.AllowUserToResizeColumns = false;
            this.dgv_CadastroBanco.AllowUserToResizeRows = false;
            this.dgv_CadastroBanco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CadastroBanco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CadastroBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CadastroBanco.Location = new System.Drawing.Point(7, 80);
            this.dgv_CadastroBanco.Name = "dgv_CadastroBanco";
            this.dgv_CadastroBanco.ReadOnly = true;
            this.dgv_CadastroBanco.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_CadastroBanco.RowTemplate.Height = 24;
            this.dgv_CadastroBanco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_CadastroBanco.Size = new System.Drawing.Size(1227, 585);
            this.dgv_CadastroBanco.StandardTab = true;
            this.dgv_CadastroBanco.TabIndex = 0;
            this.dgv_CadastroBanco.TabStop = false;
            this.dgv_CadastroBanco.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroBanco_CellDoubleClick);
            this.dgv_CadastroBanco.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroBanco_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txb_PesquisaBanco);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbx_PesquisarBanco);
            this.panel2.Controls.Add(this.btn_PesquisarBanco);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 66);
            this.panel2.TabIndex = 46;
            // 
            // txb_PesquisaBanco
            // 
            this.txb_PesquisaBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PesquisaBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_PesquisaBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PesquisaBanco.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_PesquisaBanco.Location = new System.Drawing.Point(189, 30);
            this.txb_PesquisaBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_PesquisaBanco.Name = "txb_PesquisaBanco";
            this.txb_PesquisaBanco.Size = new System.Drawing.Size(976, 27);
            this.txb_PesquisaBanco.TabIndex = 2;
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
            // cbx_PesquisarBanco
            // 
            this.cbx_PesquisarBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_PesquisarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PesquisarBanco.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_PesquisarBanco.FormattingEnabled = true;
            this.cbx_PesquisarBanco.Items.AddRange(new object[] {
            "Nome",
            "Código"});
            this.cbx_PesquisarBanco.Location = new System.Drawing.Point(3, 29);
            this.cbx_PesquisarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_PesquisarBanco.Name = "cbx_PesquisarBanco";
            this.cbx_PesquisarBanco.Size = new System.Drawing.Size(163, 28);
            this.cbx_PesquisarBanco.TabIndex = 1;
            // 
            // btn_PesquisarBanco
            // 
            this.btn_PesquisarBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PesquisarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarBanco.Location = new System.Drawing.Point(1165, 28);
            this.btn_PesquisarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PesquisarBanco.Name = "btn_PesquisarBanco";
            this.btn_PesquisarBanco.Size = new System.Drawing.Size(57, 31);
            this.btn_PesquisarBanco.TabIndex = 3;
            this.btn_PesquisarBanco.Text = "Ir";
            this.btn_PesquisarBanco.UseCompatibleTextRendering = true;
            this.btn_PesquisarBanco.UseVisualStyleBackColor = true;
            this.btn_PesquisarBanco.Click += new System.EventHandler(this.btn_PesquisarBanco_Click);
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
            this.panel3.Controls.Add(this.txb_NomeBanco);
            this.panel3.Controls.Add(this.txb_CodigoBanco);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 656);
            this.panel3.TabIndex = 0;
            // 
            // txb_NomeBanco
            // 
            this.txb_NomeBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_NomeBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NomeBanco.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_NomeBanco.Location = new System.Drawing.Point(24, 107);
            this.txb_NomeBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_NomeBanco.Name = "txb_NomeBanco";
            this.txb_NomeBanco.Size = new System.Drawing.Size(931, 27);
            this.txb_NomeBanco.TabIndex = 5;
            // 
            // txb_CodigoBanco
            // 
            this.txb_CodigoBanco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_CodigoBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CodigoBanco.ForeColor = System.Drawing.Color.Red;
            this.txb_CodigoBanco.Location = new System.Drawing.Point(26, 45);
            this.txb_CodigoBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_CodigoBanco.Name = "txb_CodigoBanco";
            this.txb_CodigoBanco.ReadOnly = true;
            this.txb_CodigoBanco.Size = new System.Drawing.Size(100, 27);
            this.txb_CodigoBanco.TabIndex = 16;
            this.txb_CodigoBanco.TabStop = false;
            this.txb_CodigoBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome do Banco";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_ImprimirBanco);
            this.panel1.Controls.Add(this.btn_ExcluirBanco);
            this.panel1.Controls.Add(this.btn_AlterarBanco);
            this.panel1.Controls.Add(this.btn_GravarBanco);
            this.panel1.Controls.Add(this.btn_NovoBanco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 48);
            this.panel1.TabIndex = 6;
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
            // btn_ImprimirBanco
            // 
            this.btn_ImprimirBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ImprimirBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirBanco.Location = new System.Drawing.Point(422, 9);
            this.btn_ImprimirBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ImprimirBanco.Name = "btn_ImprimirBanco";
            this.btn_ImprimirBanco.Size = new System.Drawing.Size(97, 31);
            this.btn_ImprimirBanco.TabIndex = 20;
            this.btn_ImprimirBanco.Text = "Imprimir";
            this.btn_ImprimirBanco.UseCompatibleTextRendering = true;
            this.btn_ImprimirBanco.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirBanco
            // 
            this.btn_ExcluirBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ExcluirBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirBanco.Location = new System.Drawing.Point(320, 9);
            this.btn_ExcluirBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirBanco.Name = "btn_ExcluirBanco";
            this.btn_ExcluirBanco.Size = new System.Drawing.Size(97, 31);
            this.btn_ExcluirBanco.TabIndex = 19;
            this.btn_ExcluirBanco.Text = "Excluir";
            this.btn_ExcluirBanco.UseCompatibleTextRendering = true;
            this.btn_ExcluirBanco.UseVisualStyleBackColor = true;
            this.btn_ExcluirBanco.Click += new System.EventHandler(this.btn_ExcluirBanco_Click);
            // 
            // btn_AlterarBanco
            // 
            this.btn_AlterarBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AlterarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarBanco.Location = new System.Drawing.Point(216, 9);
            this.btn_AlterarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarBanco.Name = "btn_AlterarBanco";
            this.btn_AlterarBanco.Size = new System.Drawing.Size(97, 31);
            this.btn_AlterarBanco.TabIndex = 18;
            this.btn_AlterarBanco.Text = "Alterar";
            this.btn_AlterarBanco.UseCompatibleTextRendering = true;
            this.btn_AlterarBanco.UseVisualStyleBackColor = true;
            this.btn_AlterarBanco.Click += new System.EventHandler(this.btn_AlterarBanco_Click);
            // 
            // btn_GravarBanco
            // 
            this.btn_GravarBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GravarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarBanco.Location = new System.Drawing.Point(113, 9);
            this.btn_GravarBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GravarBanco.Name = "btn_GravarBanco";
            this.btn_GravarBanco.Size = new System.Drawing.Size(97, 31);
            this.btn_GravarBanco.TabIndex = 17;
            this.btn_GravarBanco.Text = "Gravar";
            this.btn_GravarBanco.UseCompatibleTextRendering = true;
            this.btn_GravarBanco.UseVisualStyleBackColor = true;
            this.btn_GravarBanco.Click += new System.EventHandler(this.btn_GravarBanco_Click);
            // 
            // btn_NovoBanco
            // 
            this.btn_NovoBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NovoBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoBanco.Location = new System.Drawing.Point(10, 9);
            this.btn_NovoBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NovoBanco.Name = "btn_NovoBanco";
            this.btn_NovoBanco.Size = new System.Drawing.Size(97, 31);
            this.btn_NovoBanco.TabIndex = 4;
            this.btn_NovoBanco.Text = "Novo";
            this.btn_NovoBanco.UseCompatibleTextRendering = true;
            this.btn_NovoBanco.UseVisualStyleBackColor = true;
            this.btn_NovoBanco.Click += new System.EventHandler(this.btn_NovoBanco_Click);
            // 
            // frm_CadastroBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroBancos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CadastroBancos";
            this.Load += new System.EventHandler(this.frm_CadastroBancos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroBanco)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_CadastroBanco;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_PesquisaBanco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_PesquisarBanco;
        private System.Windows.Forms.Button btn_PesquisarBanco;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_NomeBanco;
        private System.Windows.Forms.TextBox txb_CodigoBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_ImprimirBanco;
        private System.Windows.Forms.Button btn_ExcluirBanco;
        private System.Windows.Forms.Button btn_AlterarBanco;
        private System.Windows.Forms.Button btn_GravarBanco;
        private System.Windows.Forms.Button btn_NovoBanco;
    }
}