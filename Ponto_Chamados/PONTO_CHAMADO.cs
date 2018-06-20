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
    public partial class PONTO_CHAMADO : Form
    {
        public PONTO_CHAMADO()
        {
            InitializeComponent();
        }


        private void btnPonto_Click(object sender, EventArgs e)
        {
            Ponto pontotela = new Ponto();
            pontotela.Show();
        }

        private void btnChamado_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            try
            {
                conexao.conectaBanco();
                MessageBox.Show("Conectado com sucesso");
                conexao.fechaBanco();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ocorrido: " + err.ToString());
            }
        
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario_tela usuario = new Usuario_tela();
            usuario.Show();
        }

        private void projetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projeto_Tela projeto = new Projeto_Tela();
            projeto.Show();
        }
    }
}
