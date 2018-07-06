namespace GUI
{
    partial class frm_ConsultaRapida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_PesquisaRapida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_PesquisaRapida = new System.Windows.Forms.TextBox();
            this.btn_PesquisaRapida = new System.Windows.Forms.Button();
            this.dgv_PesquisaRapida = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaRapida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_PesquisaRapida);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_PesquisaRapida);
            this.panel1.Controls.Add(this.btn_PesquisaRapida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 45);
            this.panel1.TabIndex = 0;
            // 
            // cbx_PesquisaRapida
            // 
            this.cbx_PesquisaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_PesquisaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PesquisaRapida.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_PesquisaRapida.FormattingEnabled = true;
            this.cbx_PesquisaRapida.Location = new System.Drawing.Point(122, 10);
            this.cbx_PesquisaRapida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_PesquisaRapida.Name = "cbx_PesquisaRapida";
            this.cbx_PesquisaRapida.Size = new System.Drawing.Size(206, 28);
            this.cbx_PesquisaRapida.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Buscar por :";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Localizar :";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txb_PesquisaRapida
            // 
            this.txb_PesquisaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PesquisaRapida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_PesquisaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PesquisaRapida.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_PesquisaRapida.Location = new System.Drawing.Point(449, 11);
            this.txb_PesquisaRapida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_PesquisaRapida.Name = "txb_PesquisaRapida";
            this.txb_PesquisaRapida.Size = new System.Drawing.Size(868, 27);
            this.txb_PesquisaRapida.TabIndex = 8;
            // 
            // btn_PesquisaRapida
            // 
            this.btn_PesquisaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PesquisaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisaRapida.Location = new System.Drawing.Point(1323, 9);
            this.btn_PesquisaRapida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PesquisaRapida.Name = "btn_PesquisaRapida";
            this.btn_PesquisaRapida.Size = new System.Drawing.Size(101, 29);
            this.btn_PesquisaRapida.TabIndex = 7;
            this.btn_PesquisaRapida.Text = "Buscar";
            this.btn_PesquisaRapida.UseCompatibleTextRendering = true;
            this.btn_PesquisaRapida.UseVisualStyleBackColor = true;
            this.btn_PesquisaRapida.Click += new System.EventHandler(this.btn_PesquisaRapida_Click);
            // 
            // dgv_PesquisaRapida
            // 
            this.dgv_PesquisaRapida.AllowUserToAddRows = false;
            this.dgv_PesquisaRapida.AllowUserToDeleteRows = false;
            this.dgv_PesquisaRapida.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PesquisaRapida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PesquisaRapida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_PesquisaRapida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PesquisaRapida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_PesquisaRapida.Location = new System.Drawing.Point(0, 51);
            this.dgv_PesquisaRapida.Name = "dgv_PesquisaRapida";
            this.dgv_PesquisaRapida.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PesquisaRapida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_PesquisaRapida.RowTemplate.Height = 24;
            this.dgv_PesquisaRapida.Size = new System.Drawing.Size(1438, 667);
            this.dgv_PesquisaRapida.TabIndex = 0;
            this.dgv_PesquisaRapida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PesquisaRapida_CellDoubleClick);
            // 
            // frm_ConsultaRapida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1438, 718);
            this.Controls.Add(this.dgv_PesquisaRapida);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ConsultaRapida";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Rápida";
            this.Load += new System.EventHandler(this.frm_ConsultaRapida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PesquisaRapida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_PesquisaRapida;
        private System.Windows.Forms.TextBox txb_PesquisaRapida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_PesquisaRapida;
        private System.Windows.Forms.DataGridView dgv_PesquisaRapida;
    }
}