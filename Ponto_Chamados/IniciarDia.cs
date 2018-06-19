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
    public partial class IniciarDia : Form
    {
        public IniciarDia()
        {
            InitializeComponent();
        }

        private void SelecionaProjeto_Load(object sender, EventArgs e)
        {
            //Carregar ComboBox DO PROJETO
            string q1 = "SELECT * FROM PROJETO";
            Conexao conexao = new Conexao();
            conexao.conectaBanco();
            DataTable dt1 = new DataTable();
            dt1.Clear();
            conexao.select(q1).Fill(dt1);
            cbxProj.DataSource = dt1;
            cbxProj.DisplayMember = "COD_PROJETO"; 
            cbxProj.ValueMember = "ID_PROJETO";

            //Carregar ComboBox DO USUÁRIO
            
            string q2 = "SELECT * FROM USUARIO";
            Conexao conexao2 = new Conexao();
            conexao2.conectaBanco();
            DataTable dt2 = new DataTable();
            dt2.Clear();
            conexao.select(q2).Fill(dt2);
            cbxUsua.DataSource = dt2;
            cbxUsua.DisplayMember = "NM_USUARIO";
            cbxUsua.ValueMember = "ID_USUARIO";
          }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                string d, h, t, p, u;
                d = DateTime.Now.ToString("dd/MM/yyyy");
                h = DateTime.Now.ToString("HH:mm");
                t = "01";
                p = cbxProj.Text.ToString();
                u = cbxUsua.Text.ToString();
                Datahora datahora;
                datahora = new Datahora(d, h, t, p, u);
                datahora.IniciaDiaBD();
                MessageBox.Show("Hora Adicionada com sucesso  " + datahora);
                datahora.IniciaDiaBD();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro: " + err.ToString());
            }
        }

        private void cbxProj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
