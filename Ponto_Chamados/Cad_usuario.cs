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
    public partial class Cad_usuario : Form
    {
        public Cad_usuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            Cad_usuario cadusuario = new Cad_usuario();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string u = txtNome.Text;
            Usuario usuario = new Usuario(u);
            usuario.InsereUsua();
            this.Close();
        }

        private void Cad_usuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
