using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.ProjetoT.Conexao;
using Teste.ProjetoT.Model;

namespace Teste.ProjetoT.DAO {
    public class NascimentoDAO {


        private NpgsqlConnection conexao;

        public NascimentoDAO() {
            this.conexao = new ConnectionFactory().getConnection();
        }


        public void CadastrarRegistrado(Registrado obj) {
            try {

                string sql = @"insert into tb_nascimento (nomeregistrado,sexoregistrado,
datanascimento,horanascimento,nomepai,datanascpai,cidadepai,ufpai,nomemae,datanascmae,cidademae,
ufmae,nomelivro,numlivro,numpaglivro,numregistro,dataregistro,numdnv,prazoreg) values (@nomeregistrado,
@sexoregistrado,@datanascimento,@horanascimento,@nomepai,@datanascpai,@cidadepai,@ufpai,@nomemae,
@datanascmae,@cidademae,@ufmae,@nomelivro,@numlivro,@numpaglivro,@numregistro,@dataregistro,@numdnv,
@prazoreg)";

                NpgsqlCommand executaCmd = new NpgsqlCommand(sql, conexao);

                executaCmd.Parameters.AddWithValue("@nomeregistrado", obj.NomeRegistrado);
                executaCmd.Parameters.AddWithValue("@sexoregistrado", obj.SexoRegistrado);
                executaCmd.Parameters.AddWithValue("@datanascimento", obj.DataNascimento);
                executaCmd.Parameters.AddWithValue("@horanascimento", obj.HoraNascimento);
                executaCmd.Parameters.AddWithValue("@nomepai", obj.NomePai);
                executaCmd.Parameters.AddWithValue("@datanascpai", obj.DataNascPai);
                executaCmd.Parameters.AddWithValue("@cidadepai", obj.CidadePai);
                executaCmd.Parameters.AddWithValue("@ufpai", obj.UfPai);
                executaCmd.Parameters.AddWithValue("@nomemae", obj.NomeMae);
                executaCmd.Parameters.AddWithValue("@datanascmae", obj.DataNascMae);
                executaCmd.Parameters.AddWithValue("@cidademae", obj.Cidademae);
                executaCmd.Parameters.AddWithValue("@ufmae", obj.UfMae);
                executaCmd.Parameters.AddWithValue("@nomelivro", obj.NomeLivro);
                executaCmd.Parameters.AddWithValue("@numlivro", obj.NumLivro);
                executaCmd.Parameters.AddWithValue("@numpaglivro", obj.NumPagLivro);
                executaCmd.Parameters.AddWithValue("@numregistro", obj.NumRegistro);
                executaCmd.Parameters.AddWithValue("@dataregistro", obj.DataRegistro);
                executaCmd.Parameters.AddWithValue("@numdnv", obj.NumDnv);
                executaCmd.Parameters.AddWithValue("@prazoreg", obj.PrazoReg);

                conexao.Open();
                executaCmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluso");
                conexao.Close();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

                throw;
            }

        }
    }
}
