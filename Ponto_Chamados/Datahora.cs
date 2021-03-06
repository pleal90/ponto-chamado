﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ponto_Chamados
{
    class Datahora
    {
        public string hora { get; set; }
        public string dia { get; set; }
        public string tipo { get; set; }
        public string codtipo { get;  set; }
        public string cod_projeto { get; set; }
        public string nm_usuario { get; set; }

        public Datahora(string dia, string hora, string tipo, string cod_projeto, string nm_usuario)
        {
            this.dia = dia;
            this.hora = hora;
            this.tipo = tipo;
            this.cod_projeto = cod_projeto;
            this.nm_usuario = nm_usuario;
            
            if (tipo == "01")
            {
                codtipo = "ENTRADA";
            }
            else if (tipo == "02")
            {
                codtipo = "SAÍDA ALMOÇO";
            }
            else if (tipo == "03")
            {
                codtipo = "RETORNO ALMOÇO";
            }
            else if (tipo == "04")
            {
                codtipo = "SAÍDA";
            }
        }

        public Datahora(string dia, string hora, string tipo)
        {
            this.dia = dia;
            this.hora = hora;
            this.tipo = tipo;

            if (tipo == "01")
            {
                codtipo = "ENTRADA";
            }
            else if (tipo == "02")
            {
                codtipo = "SAÍDA ALMOÇO";
            }
            else if (tipo == "03")
            {
                codtipo = "RETORNO ALMOÇO";
            }
            else if (tipo == "04")
            {
                codtipo = "SAÍDA";
            }
        }

        public Datahora(string cod_projeto, string nm_usuario)
        {
            this.cod_projeto = cod_projeto;
            this.nm_usuario = nm_usuario;
        }

        public void IniciaDiaBD()
        {
            Conexao conexao = new Conexao();
            string ins_sql = "INSERT INTO PONTO(DATA_PONTO, ENTRADA, ID_PROJETO, ID_USUARIO, INC_SYS)"
                           + " VALUES (@data, @entrada, @id_projeto, @id_usuario, @inc_sys)";  
            try
            {
                
                //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                SqlCommand comando = new SqlCommand(ins_sql, conexao.conectaBanco()); 
                //Adicionando o valor das textBox nos parametros do comando
                comando.Parameters.Add(new SqlParameter("@data", dia));
                comando.Parameters.Add(new SqlParameter("@entrada", hora));
                comando.Parameters.Add(new SqlParameter("@id_projeto", cod_projeto));
                comando.Parameters.Add(new SqlParameter("@id_usuario", nm_usuario));
                comando.Parameters.Add(new SqlParameter("@inc_sys", "N"));
                //abre a conexao
                conexao.conectaBanco();
                //executa o comando com os parametros que foram adicionados acima
                comando.ExecuteNonQuery();
                //fecha a conexao
                conexao.fechaBanco();
                // referente ao msgbox
                MessageBox.Show("Cadastrado com Sucesso");
        
            }catch(Exception err)
            {
                  MessageBox.Show("FALHA NA INSERÇÃO. Erro: " + err);
            }

        }

        public void OutrosHorarios()
        {
            string update;
            Conexao conexao = new Conexao();

            if (tipo == "02")
            {
                update = "UPDATE PONTO SET S_ALMOCO = @S_ALMOCO "
                            + "WHERE DATA_PONTO = @data and ENTRADA is not null "
                            + "and ID_USUARIO = @ID_USUARIO AND ID_PROJETO = @ID_PROJETO";
                try
                {
                    //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                    SqlCommand comando = new SqlCommand(update, conexao.conectaBanco());
                    //Adicionando o valor das textBox nos parametros do comando
                    comando.Parameters.Add(new SqlParameter("@data", dia));
                    comando.Parameters.Add(new SqlParameter("@S_ALMOCO", hora));
                    comando.Parameters.Add(new SqlParameter("@id_projeto", cod_projeto));
                    comando.Parameters.Add(new SqlParameter("@id_usuario", nm_usuario));
                    //abre a conexao
                    conexao.conectaBanco();
                    //executa o comando com os parametros que foram adicionados acima
                    comando.ExecuteNonQuery();
                    //fecha a conexao
                    conexao.fechaBanco();
                    // referente ao msgbox
                    MessageBox.Show("Horário de saída pro almoço incluso com Sucesso");
                }
                catch (Exception err)
                {
                    MessageBox.Show("FALHA NA INSERÇÃO. Erro: " + err);
                }
            }
            else if (tipo == "03")
            {
                update = "UPDATE PONTO SET R_ALMOCO = @R_ALMOCO "
                            + "WHERE DATA_PONTO = @data and ENTRADA is not null "
                            + "and ID_USUARIO = @ID_USUARIO AND ID_PROJETO = @ID_PROJETO";
                try
                {
                    //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                    SqlCommand comando = new SqlCommand(update, conexao.conectaBanco());
                    //Adicionando o valor das textBox nos parametros do comando
                    comando.Parameters.Add(new SqlParameter("@data", dia));
                    comando.Parameters.Add(new SqlParameter("@R_ALMOCO", hora));
                    comando.Parameters.Add(new SqlParameter("@id_projeto", cod_projeto));
                    comando.Parameters.Add(new SqlParameter("@id_usuario", nm_usuario));
                    //abre a conexao
                    conexao.conectaBanco();
                    //executa o comando com os parametros que foram adicionados acima
                    comando.ExecuteNonQuery();
                    //fecha a conexao
                    conexao.fechaBanco();
                    // referente ao msgbox
                    MessageBox.Show("Horário de retorno de almoço incluso com Sucesso");
                }
                catch (Exception err)
                {
                    MessageBox.Show("FALHA NA INSERÇÃO. Erro: " + err);
                }
            }
            else if (tipo == "04")
            {
                update = "UPDATE PONTO SET SAIDA = @SAIDA "
                         + "WHERE DATA_PONTO = @data and ENTRADA is not null "
                         +"and ID_USUARIO = @ID_USUARIO AND ID_PROJETO = @ID_PROJETO";
                try
                {
                    //Cria uma objeto do tipo comando passando como parametro a string sql e a string de conexão
                    SqlCommand comando = new SqlCommand(update, conexao.conectaBanco());
                    //Adicionando o valor das textBox nos parametros do comando
                    comando.Parameters.Add(new SqlParameter("@data", dia));
                    comando.Parameters.Add(new SqlParameter("@SAIDA", hora));
                    comando.Parameters.Add(new SqlParameter("@id_projeto", cod_projeto));
                    comando.Parameters.Add(new SqlParameter("@id_usuario", nm_usuario));
                    //abre a conexao
                    conexao.conectaBanco();
                    //executa o comando com os parametros que foram adicionados acima
                    comando.ExecuteNonQuery();
                    //fecha a conexao
                    conexao.fechaBanco();
                    // referente ao msgbox
                    MessageBox.Show("Horário de saída incluso com Sucesso");
                }
                catch (Exception err)
                {
                    MessageBox.Show("FALHA NA INSERÇÃO. Erro: " + err);
                }
            }
        }

        public override string ToString()
        {
            return "Data: "
                + dia
                + " | "
                + " Hora: "
                + hora
                + " Tipo: "
                + codtipo
                + " Usuario: "
                + nm_usuario
                + " Projeto: "
                + cod_projeto;
        }
    }
}
