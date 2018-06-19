using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ponto_Chamados
{
    class Usuario
    {
        public string nome_usua { get; set; }

        public Usuario(string nome_usua){
            this.nome_usua = nome_usua;
        }

        public void InsereUsua()
        {
            Conexao conexao = new Conexao();
            string ins_sql = "INSERT INTO USUARIO (NM_USUARIO) VALUES (@usuario)";

            try
            {
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(ins_sql, conexao.conectaBanco());
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@usuario", nome_usua));
                //Abre a conexão
                conexao.conectaBanco().Open();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                //fecha a conexao
                conexao.conectaBanco().Close();
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
