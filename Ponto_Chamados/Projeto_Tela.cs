using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ponto_Chamados
{
    public partial class Projeto_Tela : Form
    {
        public Projeto_Tela()
        {
            InitializeComponent();
        }

        private void Projeto_Tela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pCDataSet_PROJETO_2.PROJETO' table. You can move, or remove it, as needed.
            this.pROJETOTableAdapter1.Fill(this.pCDataSet_PROJETO_2.PROJETO);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_projeto cad_projeto = new Cad_projeto();
            cad_projeto.Show();
        }
    }
}
