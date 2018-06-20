namespace Ponto_Chamados
{
    partial class IniciarDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarDia));
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProj = new System.Windows.Forms.ComboBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.cbxUsua = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Projeto";
            // 
            // cbxProj
            // 
            this.cbxProj.FormattingEnabled = true;
            this.cbxProj.Location = new System.Drawing.Point(16, 29);
            this.cbxProj.Name = "cbxProj";
            this.cbxProj.Size = new System.Drawing.Size(226, 21);
            this.cbxProj.TabIndex = 1;
            this.cbxProj.SelectedIndexChanged += new System.EventHandler(this.cbxProj_SelectedIndexChanged);
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(162, 105);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(75, 23);
            this.btnConfirma.TabIndex = 2;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(81, 105);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 3;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // cbxUsua
            // 
            this.cbxUsua.FormattingEnabled = true;
            this.cbxUsua.Location = new System.Drawing.Point(15, 78);
            this.cbxUsua.Name = "cbxUsua";
            this.cbxUsua.Size = new System.Drawing.Size(226, 21);
            this.cbxUsua.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o Usuário";
            // 
            // IniciarDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 138);
            this.Controls.Add(this.cbxUsua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.cbxProj);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IniciarDia";
            this.Text = "Iniciar Dia";
            this.Load += new System.EventHandler(this.SelecionaProjeto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProj;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.ComboBox cbxUsua;
        private System.Windows.Forms.Label label2;
    }
}