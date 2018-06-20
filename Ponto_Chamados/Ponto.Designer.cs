namespace Ponto_Chamados
{
    partial class Ponto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ponto));
            this.btnRetornar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dATAPONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNTRADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAIDAALMOÇODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETORNOALMOÇODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPROJETODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVPONTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCDataSet1_PONTO = new Ponto_Chamados.PCDataSet1_PONTO();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIncHor = new System.Windows.Forms.Button();
            this.btnAltHorario = new System.Windows.Forms.Button();
            this.dGV_PONTOTableAdapter = new Ponto_Chamados.PCDataSet1_PONTOTableAdapters.DGV_PONTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPONTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet1_PONTO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(680, 207);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(75, 23);
            this.btnRetornar.TabIndex = 1;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATAPONTODataGridViewTextBoxColumn,
            this.eNTRADADataGridViewTextBoxColumn,
            this.sAIDAALMOÇODataGridViewTextBoxColumn,
            this.rETORNOALMOÇODataGridViewTextBoxColumn,
            this.sAIDADataGridViewTextBoxColumn,
            this.nMUSUARIODataGridViewTextBoxColumn,
            this.cODPROJETODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dGVPONTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 160);
            this.dataGridView1.TabIndex = 2;
            // 
            // dATAPONTODataGridViewTextBoxColumn
            // 
            this.dATAPONTODataGridViewTextBoxColumn.DataPropertyName = "DATA_PONTO";
            this.dATAPONTODataGridViewTextBoxColumn.HeaderText = "DATA_PONTO";
            this.dATAPONTODataGridViewTextBoxColumn.Name = "dATAPONTODataGridViewTextBoxColumn";
            this.dATAPONTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNTRADADataGridViewTextBoxColumn
            // 
            this.eNTRADADataGridViewTextBoxColumn.DataPropertyName = "ENTRADA";
            this.eNTRADADataGridViewTextBoxColumn.HeaderText = "ENTRADA";
            this.eNTRADADataGridViewTextBoxColumn.Name = "eNTRADADataGridViewTextBoxColumn";
            this.eNTRADADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAIDAALMOÇODataGridViewTextBoxColumn
            // 
            this.sAIDAALMOÇODataGridViewTextBoxColumn.DataPropertyName = "SAIDA ALMOÇO";
            this.sAIDAALMOÇODataGridViewTextBoxColumn.HeaderText = "SAIDA ALMOÇO";
            this.sAIDAALMOÇODataGridViewTextBoxColumn.Name = "sAIDAALMOÇODataGridViewTextBoxColumn";
            this.sAIDAALMOÇODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rETORNOALMOÇODataGridViewTextBoxColumn
            // 
            this.rETORNOALMOÇODataGridViewTextBoxColumn.DataPropertyName = "RETORNO ALMOÇO";
            this.rETORNOALMOÇODataGridViewTextBoxColumn.HeaderText = "RETORNO ALMOÇO";
            this.rETORNOALMOÇODataGridViewTextBoxColumn.Name = "rETORNOALMOÇODataGridViewTextBoxColumn";
            this.rETORNOALMOÇODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAIDADataGridViewTextBoxColumn
            // 
            this.sAIDADataGridViewTextBoxColumn.DataPropertyName = "SAIDA";
            this.sAIDADataGridViewTextBoxColumn.HeaderText = "SAIDA";
            this.sAIDADataGridViewTextBoxColumn.Name = "sAIDADataGridViewTextBoxColumn";
            this.sAIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMUSUARIODataGridViewTextBoxColumn
            // 
            this.nMUSUARIODataGridViewTextBoxColumn.DataPropertyName = "NM_USUARIO";
            this.nMUSUARIODataGridViewTextBoxColumn.HeaderText = "NM_USUARIO";
            this.nMUSUARIODataGridViewTextBoxColumn.Name = "nMUSUARIODataGridViewTextBoxColumn";
            this.nMUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cODPROJETODataGridViewTextBoxColumn
            // 
            this.cODPROJETODataGridViewTextBoxColumn.DataPropertyName = "COD_PROJETO";
            this.cODPROJETODataGridViewTextBoxColumn.HeaderText = "COD_PROJETO";
            this.cODPROJETODataGridViewTextBoxColumn.Name = "cODPROJETODataGridViewTextBoxColumn";
            this.cODPROJETODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dGVPONTOBindingSource
            // 
            this.dGVPONTOBindingSource.DataMember = "DGV_PONTO";
            this.dGVPONTOBindingSource.DataSource = this.pCDataSet1_PONTO;
            // 
            // pCDataSet1_PONTO
            // 
            this.pCDataSet1_PONTO.DataSetName = "PCDataSet1_PONTO";
            this.pCDataSet1_PONTO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar Dia";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnIncHor
            // 
            this.btnIncHor.Location = new System.Drawing.Point(93, 12);
            this.btnIncHor.Name = "btnIncHor";
            this.btnIncHor.Size = new System.Drawing.Size(93, 23);
            this.btnIncHor.TabIndex = 4;
            this.btnIncHor.Text = "Incluir horários";
            this.btnIncHor.UseVisualStyleBackColor = true;
            this.btnIncHor.Click += new System.EventHandler(this.btnIncHor_Click);
            // 
            // btnAltHorario
            // 
            this.btnAltHorario.Location = new System.Drawing.Point(192, 12);
            this.btnAltHorario.Name = "btnAltHorario";
            this.btnAltHorario.Size = new System.Drawing.Size(93, 23);
            this.btnAltHorario.TabIndex = 5;
            this.btnAltHorario.Text = "Alterar Horário";
            this.btnAltHorario.UseVisualStyleBackColor = true;
            // 
            // dGV_PONTOTableAdapter
            // 
            this.dGV_PONTOTableAdapter.ClearBeforeFill = true;
            // 
            // Ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 237);
            this.Controls.Add(this.btnAltHorario);
            this.Controls.Add(this.btnIncHor);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRetornar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ponto";
            this.Text = "Ponto";
            this.Load += new System.EventHandler(this.Ponto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPONTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet1_PONTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIncHor;
        private System.Windows.Forms.Button btnAltHorario;
        private PCDataSet1_PONTO pCDataSet1_PONTO;
        private System.Windows.Forms.BindingSource dGVPONTOBindingSource;
        private PCDataSet1_PONTOTableAdapters.DGV_PONTOTableAdapter dGV_PONTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAPONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNTRADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAIDAALMOÇODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETORNOALMOÇODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMUSUARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPROJETODataGridViewTextBoxColumn;
    }
}