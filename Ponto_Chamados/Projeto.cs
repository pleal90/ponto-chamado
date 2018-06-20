using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ponto_Chamados
{
    class Projeto
    {
        public string cod_projeto { get; set; }
        public string desc_projeto { get; set; }

        public Projeto(string cod_projeto, string desc_projeto)
        {
            this.cod_projeto = cod_projeto;
            this.desc_projeto = desc_projeto;
        }

        public void InsereProjeto()
        {
            Conexao conexao = new Conexao();
            string ins_sql = "INSERT INTO PROJETO (COD_PROJETO, DESC_PROJETO) VALUES (@cdproj, @dscproj)";

            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(ins_sql, conexao.conectaBanco());
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@cdproj", cod_projeto));
                comando.Parameters.Add(new SqlParameter("@dscproj", desc_projeto));
                //Abre a conexão
                conexao.conectaBanco();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                //fecha a conexao
                conexao.fechaBanco();
                // referente ao msgbox
                MessageBox.Show("Cadastrado com Sucesso");

            }
            catch (Exception err)
            {
                MessageBox.Show("FALHA NA INSERÇÃO. Erro: " + err);
            }
        }
    }
}
