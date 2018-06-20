namespace Ponto_Chamados
{
    partial class Usuario_tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario_tela));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pCDataSet_usuario = new Ponto_Chamados.PCDataSet_usuario();
            this.uSUARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCDataSet = new Ponto_Chamados.PCDataSet();
            this.uSUARIOTableAdapter = new Ponto_Chamados.PCDataSetTableAdapters.USUARIOTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.usuarioTableAdapter1 = new Ponto_Chamados.PCDataSetTableAdapters.USUARIOTableAdapter();
            this.usuarioTableAdapter2 = new Ponto_Chamados.PCDataSetTableAdapters.USUARIOTableAdapter();
            this.uSUARIOTableAdapter3 = new Ponto_Chamados.PCDataSet_usuarioTableAdapters.USUARIOTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_USUARIO,
            this.nMUSUARIODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSUARIOBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(414, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID_USUARIO
            // 
            this.ID_USUARIO.DataPropertyName = "ID_USUARIO";
            this.ID_USUARIO.HeaderText = "ID_USUARIO";
            this.ID_USUARIO.Name = "ID_USUARIO";
            this.ID_USUARIO.ReadOnly = true;
            // 
            // nMUSUARIODataGridViewTextBoxColumn
            // 
            this.nMUSUARIODataGridViewTextBoxColumn.DataPropertyName = "NM_USUARIO";
            this.nMUSUARIODataGridViewTextBoxColumn.HeaderText = "NM_USUARIO";
            this.nMUSUARIODataGridViewTextBoxColumn.Name = "nMUSUARIODataGridViewTextBoxColumn";
            this.nMUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSUARIOBindingSource1
            // 
            this.uSUARIOBindingSource1.DataMember = "USUARIO";
            this.uSUARIOBindingSource1.DataSource = this.pCDataSet_usuario;
            // 
            // pCDataSet_usuario
            // 
            this.pCDataSet_usuario.DataSetName = "PCDataSet_usuario";
            this.pCDataSet_usuario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOBindingSource
            // 
            this.uSUARIOBindingSource.DataMember = "USUARIO";
            this.uSUARIOBindingSource.DataSource = this.pCDataSet;
            // 
            // pCDataSet
            // 
            this.pCDataSet.DataSetName = "PCDataSet";
            this.pCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSUARIOTableAdapter
            // 
            this.uSUARIOTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
            // 
            // usuarioTableAdapter2
            // 
            this.usuarioTableAdapter2.ClearBeforeFill = true;
            // 
            // uSUARIOTableAdapter3
            // 
            this.uSUARIOTableAdapter3.ClearBeforeFill = true;
            // 
            // Usuario_tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 215);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Usuario_tela";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_tela_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PCDataSet pCDataSet;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource;
        private PCDataSetTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMUSUARIODataGridViewTextBoxColumn;
        private PCDataSetTableAdapters.USUARIOTableAdapter usuarioTableAdapter1;
        private PCDataSetTableAdapters.USUARIOTableAdapter usuarioTableAdapter2;
        private PCDataSet_usuario pCDataSet_usuario;
        private System.Windows.Forms.BindingSource uSUARIOBindingSource1;
        private PCDataSet_usuarioTableAdapters.USUARIOTableAdapter uSUARIOTableAdapter3;
    }
}