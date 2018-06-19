using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Ponto_Chamados
{
    class Conexao
    {
        public string c = "Data Source=SAO-9650SP2;Initial Catalog=PC;User ID=sa;Password=everis@2018";

        public SqlConnection conectaBanco(){
            SqlConnection sql = new SqlConnection(c);
            return sql;
        }

        public SqlDataAdapter select(string cons)
        {
            SqlDataAdapter adpt = new SqlDataAdapter(cons,conectaBanco());
            return adpt;
        }

        
    }
}
