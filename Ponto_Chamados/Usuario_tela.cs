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
    public partial class Usuario_tela : Form
    {
        public Usuario_tela()
        {
            InitializeComponent();
        }

        private void Usuario_tela_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pCDataSet_usuario.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter3.Fill(this.pCDataSet_usuario.USUARIO);
            
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cad_usuario cadusuario = new Cad_usuario();
            cadusuario.Show();
        }
    }
}
