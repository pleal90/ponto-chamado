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
    public partial class Cad_projeto : Form
    {
        public Cad_projeto()
        {
            InitializeComponent();
        }

        private void Cad_projeto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string c, d;
            c = txtCodProj.Text;
            d = txtDescProj.Text;
            Projeto projeto = new Projeto(c, d);
            projeto.InsereProjeto();
            this.Close();

        }
    }
}
