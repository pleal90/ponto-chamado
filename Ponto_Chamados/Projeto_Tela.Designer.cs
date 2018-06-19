namespace Ponto_Chamados
{
    partial class Projeto_Tela
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pROJETOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCDataSet_Projeto = new Ponto_Chamados.PCDataSet_Projeto();
            this.pCDataSet = new Ponto_Chamados.PCDataSet();
            this.pCDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETOTableAdapter = new Ponto_Chamados.PCDataSet_ProjetoTableAdapters.PROJETOTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pROJETOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOTableAdapter = new Ponto_Chamados.PCDataSetTableAdapters.USUARIOTableAdapter();
            this.pCDataSet_PROJETO_2 = new Ponto_Chamados.PCDataSet_PROJETO_2();
            this.pROJETOBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pROJETOTableAdapter1 = new Ponto_Chamados.PCDataSet_PROJETO_2TableAdapters.PROJETOTableAdapter();
            this.cODPROJETODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCPROJETODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet_Projeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet_PROJETO_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODPROJETODataGridViewTextBoxColumn,
            this.dESCPROJETODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pROJETOBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(11, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(434, 157);
            this.dataGridView1.TabIndex = 1;
            // 
            // pROJETOBindingSource
            // 
            this.pROJETOBindingSource.DataMember = "PROJETO";
            this.pROJETOBindingSource.DataSource = this.pCDataSet_Projeto;
            // 
            // pCDataSet_Projeto
            // 
            this.pCDataSet_Projeto.DataSetName = "PCDataSet_Projeto";
            this.pCDataSet_Projeto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pCDataSet
            // 
            this.pCDataSet.DataSetName = "PCDataSet";
            this.pCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pCDataSetBindingSource
            // 
            this.pCDataSetBindingSource.DataSource = this.pCDataSet;
            this.pCDataSetBindingSource.Position = 0;
            // 
            // pROJETOTableAdapter
            // 
            this.pROJETOTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Projeto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pROJETOBindingSource1
            // 
            this.pROJETOBindingSource1.DataMember = "PROJETO";
            this.pROJETOBindingSource1.DataSource = this.pCDataSet_Projeto;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.pCDataSetBindingSource;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // pCDataSet_PROJETO_2
            // 
            this.pCDataSet_PROJETO_2.DataSetName = "PCDataSet_PROJETO_2";
            this.pCDataSet_PROJETO_2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJETOBindingSource2
            // 
            this.pROJETOBindingSource2.DataMember = "PROJETO";
            this.pROJETOBindingSource2.DataSource = this.pCDataSet_PROJETO_2;
            // 
            // pROJETOTableAdapter1
            // 
            this.pROJETOTableAdapter1.ClearBeforeFill = true;
            // 
            // cODPROJETODataGridViewTextBoxColumn
            // 
            this.cODPROJETODataGridViewTextBoxColumn.DataPropertyName = "COD_PROJETO";
            this.cODPROJETODataGridViewTextBoxColumn.HeaderText = "COD_PROJETO";
            this.cODPROJETODataGridViewTextBoxColumn.Name = "cODPROJETODataGridViewTextBoxColumn";
            this.cODPROJETODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCPROJETODataGridViewTextBoxColumn
            // 
            this.dESCPROJETODataGridViewTextBoxColumn.DataPropertyName = "DESC_PROJETO";
            this.dESCPROJETODataGridViewTextBoxColumn.HeaderText = "DESC_PROJETO";
            this.dESCPROJETODataGridViewTextBoxColumn.Name = "dESCPROJETODataGridViewTextBoxColumn";
            this.dESCPROJETODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Projeto_Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 234);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Projeto_Tela";
            this.Text = "Projeto";
            this.Load += new System.EventHandler(this.Projeto_Tela_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet_Projeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet_PROJETO_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJETOBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pCDataSetBindingSource;
        private PCDataSet pCDataSet;
        private PCDataSet_Projeto pCDataSet_Projeto;
        private System.Windows.Forms.BindingSource pROJETOBindingSource;
        private PCDataSet_ProjetoTableAdapters.PROJETOTableAdapter pROJETOTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource pROJETOBindingSource1;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private PCDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private PCDataSet_PROJETO_2 pCDataSet_PROJETO_2;
        private System.Windows.Forms.BindingSource pROJETOBindingSource2;
        private PCDataSet_PROJETO_2TableAdapters.PROJETOTableAdapter pROJETOTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPROJETODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCPROJETODataGridViewTextBoxColumn;
    }
}