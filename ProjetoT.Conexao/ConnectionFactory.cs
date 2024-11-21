using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ProjetoT.Conexao {
    internal class ConnectionFactory {

        public NpgsqlConnection getConnection() {
            try {
                string conexao = ConfigurationManager.ConnectionStrings["testeDm"].ConnectionString;

                return new NpgsqlConnection(conexao);


            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;
            }


        }
    }
}
