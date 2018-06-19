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
    public partial class HORARIO : Form
    {
        public HORARIO()
        {
            InitializeComponent();
        }

        private void HORARIO_Load(object sender, EventArgs e)
        {
            mskData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnPegHora_Click(object sender, EventArgs e)
        {
            mskHora.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mskHora.Text = null;
            mskData.Text = null;
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Datahora datahora;
            string t;

            if (cbxTipo.Text == "ENTRADA"){
                 t = "01";
                 datahora = new Datahora(mskData.Text, mskHora.Text, t, cbxProj.ToString(), cbxUsuario.ToString());
                 MessageBox.Show(datahora.ToString());
            } else if(cbxTipo.Text == "SAÍDA ALMOÇO"){
                 t = "02";
                 datahora = new Datahora(mskData.Text, mskHora.Text, t, cbxProj.ToString(), cbxUsuario.ToString());
                 MessageBox.Show(datahora.ToString());
            }else if(cbxTipo.Text == "RETORNO ALMOÇO"){
                 t = "03";
                 datahora = new Datahora(mskData.Text, mskHora.Text, t, cbxProj.ToString(), cbxUsuario.ToString());
                 MessageBox.Show(datahora.ToString());
            }else if(cbxTipo.Text == "SAÍDA"){
                 t = "04";
                 datahora = new Datahora(mskData.Text, mskHora.Text, t, cbxProj.ToString(), cbxUsuario.ToString());
                 MessageBox.Show(datahora.ToString());
            }
            this.Close();
        }
    }
}
