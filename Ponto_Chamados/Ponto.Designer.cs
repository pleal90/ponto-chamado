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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIncHor = new System.Windows.Forms.Button();
            this.btnAltHorario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(284, 226);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(347, 150);
            this.dataGridView1.TabIndex = 2;
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
            this.btnIncHor.Location = new System.Drawing.Point(145, 12);
            this.btnIncHor.Name = "btnIncHor";
            this.btnIncHor.Size = new System.Drawing.Size(93, 23);
            this.btnIncHor.TabIndex = 4;
            this.btnIncHor.Text = "Incluir horários";
            this.btnIncHor.UseVisualStyleBackColor = true;
            this.btnIncHor.Click += new System.EventHandler(this.btnIncHor_Click);
            // 
            // btnAltHorario
            // 
            this.btnAltHorario.Location = new System.Drawing.Point(266, 12);
            this.btnAltHorario.Name = "btnAltHorario";
            this.btnAltHorario.Size = new System.Drawing.Size(93, 23);
            this.btnAltHorario.TabIndex = 5;
            this.btnAltHorario.Text = "Alterar Horário";
            this.btnAltHorario.UseVisualStyleBackColor = true;
            // 
            // Ponto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.btnAltHorario);
            this.Controls.Add(this.btnIncHor);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRetornar);
            this.Name = "Ponto";
            this.Text = "Ponto";
            this.Load += new System.EventHandler(this.Ponto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIncHor;
        private System.Windows.Forms.Button btnAltHorario;
    }
}