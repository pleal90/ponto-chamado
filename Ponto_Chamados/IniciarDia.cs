using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            conexao.fechaBanco();
      
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
            conexao.fechaBanco();            
          }
        
        private void btnConfirma_Click(object sender, EventArgs e)
        {
           try
            {
                Datahora datahora;
                string d, h, t;
                d = DateTime.Now.ToString("dd/MM/yyyy");
                h = DateTime.Now.ToString("HH:mm");
                t = "01";

                    //localiza o projeto no banco

                    Conexao conexao = new Conexao();
                    conexao.conectaBanco();
                    DataTable dt = new DataTable();

                    string pcon = null;
                    string con_sql = null;

                    con_sql = "SELECT ID_PROJETO FROM PROJETO WHERE COD_PROJETO like '%"+cbxProj.Text+"%'";
                    conexao.select(con_sql).Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        pcon = item["ID_PROJETO"].ToString();
                    }
                    conexao.fechaBanco();
                    MessageBox.Show("VARIÁVEL DE TESTE PROJETO: " + pcon);

                    //localiza o usuário no banco

                    con_sql = null;
                    string ucon = null;

                    con_sql = "SELECT ID_USUARIO FROM USUARIO WHERE NM_USUARIO like '%"+cbxUsua.Text+"%'";
                    conexao.select(con_sql).Fill(dt);
                    foreach (DataRow item in dt.Rows)
                    {
                        ucon = item["ID_USUARIO"].ToString();
                    }
                    conexao.fechaBanco();
                    MessageBox.Show("VARIÁVEL DE TESTE USUÁRIO: " + ucon);
                    
                    datahora = new Datahora(d, h, t, pcon, ucon);
                    datahora.IniciaDiaBD();
                    MessageBox.Show("Hora Adicionada com sucesso  " + datahora);
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
