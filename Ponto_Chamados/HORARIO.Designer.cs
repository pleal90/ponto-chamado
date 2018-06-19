namespace Ponto_Chamados
{
    partial class HORARIO
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPegHora = new System.Windows.Forms.Button();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxProj = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUsuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 148);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(66, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(111, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPegHora
            // 
            this.btnPegHora.Location = new System.Drawing.Point(12, 119);
            this.btnPegHora.Name = "btnPegHora";
            this.btnPegHora.Size = new System.Drawing.Size(93, 23);
            this.btnPegHora.TabIndex = 7;
            this.btnPegHora.Text = "Pegar Horário";
            this.btnPegHora.UseVisualStyleBackColor = true;
            this.btnPegHora.Click += new System.EventHandler(this.btnPegHora_Click);
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(50, 6);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(71, 20);
            this.mskData.TabIndex = 8;
            this.mskData.ValidatingType = typeof(System.DateTime);
            // 
            // mskHora
            // 
            this.mskHora.Location = new System.Drawing.Point(134, 121);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(37, 20);
            this.mskHora.TabIndex = 9;
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA ALMOÇO",
            "RETORNO ALMOÇO",
            "SAÍDA"});
            this.cbxTipo.Location = new System.Drawing.Point(50, 34);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Projeto";
            // 
            // cbxProj
            // 
            this.cbxProj.FormattingEnabled = true;
            this.cbxProj.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA ALMOÇO",
            "RETORNO ALMOÇO",
            "SAÍDA"});
            this.cbxProj.Location = new System.Drawing.Point(50, 61);
            this.cbxProj.Name = "cbxProj";
            this.cbxProj.Size = new System.Drawing.Size(121, 21);
            this.cbxProj.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Usuário";
            // 
            // cbxUsuario
            // 
            this.cbxUsuario.FormattingEnabled = true;
            this.cbxUsuario.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA ALMOÇO",
            "RETORNO ALMOÇO",
            "SAÍDA"});
            this.cbxUsuario.Location = new System.Drawing.Point(50, 88);
            this.cbxUsuario.Name = "cbxUsuario";
            this.cbxUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbxUsuario.TabIndex = 16;
            // 
            // HORARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 177);
            this.Controls.Add(this.cbxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxProj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskHora);
            this.Controls.Add(this.mskData);
            this.Controls.Add(this.btnPegHora);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "HORARIO";
            this.Text = "HORARIO";
            this.Load += new System.EventHandler(this.HORARIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPegHora;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxUsuario;
    }
}