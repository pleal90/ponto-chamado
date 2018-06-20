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
                 //localiza o projeto no banco

                 Conexao conexao = new Conexao();
                 conexao.conectaBanco();
                 DataTable dt = new DataTable();

                 string pcon = null;
                 string con_sql = null;

                 con_sql = "SELECT ID_PROJETO FROM PROJETO WHERE COD_PROJETO like '%" + cbxProj.Text + "%'";
                 conexao.select(con_sql).Fill(dt);
                 foreach (DataRow item in dt.Rows)
                 {
                     pcon = item["ID_PROJETO"].ToString();
                 }
                 conexao.fechaBanco();

                 //localiza o usuário no banco

                 con_sql = null;
                 string ucon = null;

                 con_sql = "SELECT ID_USUARIO FROM USUARIO WHERE NM_USUARIO like '%" + cbxUsua.Text + "%'";
                 conexao.select(con_sql).Fill(dt);
                 foreach (DataRow item in dt.Rows)
                 {
                     ucon = item["ID_USUARIO"].ToString();
                 }
                 conexao.fechaBanco();

                 datahora = new Datahora(mskData.Text, mskHora.Text, t, pcon, ucon);
                 MessageBox.Show(datahora.ToString());
            } else if(cbxTipo.Text == "SAÍDA ALMOÇO"){
                 t = "02";
                 //localiza o projeto no banco

                 Conexao conexao = new Conexao();
                 conexao.conectaBanco();
                 DataTable dt = new DataTable();

                 string pcon = null;
                 string con_sql = null;

                 con_sql = "SELECT ID_PROJETO FROM PROJETO WHERE COD_PROJETO like '%" + cbxProj.Text + "%'";
                 conexao.select(con_sql).Fill(dt);
                 foreach (DataRow item in dt.Rows)
                 {
                     pcon = item["ID_PROJETO"].ToString();
                 }
                 conexao.fechaBanco();

                 //localiza o usuário no banco

                 con_sql = null;
                 string ucon = null;

                 con_sql = "SELECT ID_USUARIO FROM USUARIO WHERE NM_USUARIO like '%" + cbxUsua.Text + "%'";
                 conexao.select(con_sql).Fill(dt);
                 foreach (DataRow item in dt.Rows)
                 {
                     ucon = item["ID_USUARIO"].ToString();
                 }
                 conexao.fechaBanco();
                 datahora = new Datahora(mskData.Text, mskHora.Text, t, pcon, ucon);
                 datahora.OutrosHorarios();
            }else if(cbxTipo.Text == "RETORNO ALMOÇO"){
                 t = "03";
                 //localiza o projeto no banco

                 Conexao conexao = new Conexao();
                 conexao.conectaBanco();
                 DataTable dt = new DataTable();

                 string pcon = null;
                 string con_sql = null;

                 con_sql = "SELECT ID_PROJETO FROM PROJETO WHERE COD_PROJETO like '%" + cbxProj.Text + "%'";
                 conexao.select(con_sql).Fill(dt);
                 foreach (DataRow item in dt.Rows)
                 {
                     pcon = item["ID_PROJETO"].ToString();
                 }
                 conexao.fechaBanco();

                 //localiza o usuário no banco
                 con_sql = null;
                 string ucon = null;
                 con_sql = "SELECT ID_USUARIO FROM USUARIO WHERE NM_USUARIO like '%" + cbxUsua.Text + "%'";
                 conexao.select(con_sql).Fill(dt);
                 foreach (DataRow item in dt.Rows)
                 {
                     ucon = item["ID_USUARIO"].ToString();
                 }
                 conexao.fechaBanco();

                 datahora = new Datahora(mskData.Text, mskHora.Text, t, pcon, ucon);
                 datahora.OutrosHorarios();
            }else if(cbxTipo.Text == "SAÍDA"){
                 t = "04";
                 //localiza o projeto no banco
                 Conexao conexao = new Conexao();
                 conexao.conectaBanco();
                 DataTable dt = new DataTable();
                 string pcon = null;
                 string con_sql = null;
                 con_sql = "SELECT ID_PROJETO FROM PROJETO WHERE COD_PROJETO like '%" + cbxProj.Text + "%'";
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
                 con_sql = "SELECT ID_USUARIO FROM USUARIO WHERE NM_USUARIO like '%" + cbxUsua.Text + "%'";
                 conexao.select(con_sql).Fill(dt);
                 foreach (DataRow item in dt.Rows)
                 {
                     ucon = item["ID_USUARIO"].ToString();
                 }
                 conexao.fechaBanco();
                 datahora = new Datahora(mskData.Text, mskHora.Text, t, pcon, ucon);
                 MessageBox.Show(datahora.ToString());
                 datahora.OutrosHorarios();
            }
            this.Close();
        }
    }
}
