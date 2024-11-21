using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.ProjetoT.DAO;
using Teste.ProjetoT.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste.ProjetoT.View {
    public partial class InclusaoNascimento : Form {
        public InclusaoNascimento() {
            InitializeComponent();
            toolTip1.IsBalloon = true;
            toolTip1.AutoPopDelay = 0;
            toolTip1.SetToolTip(txtIdadePai, "Insira a data do registro para calcular a idade do pai");
            toolTip1.SetToolTip(txtIdadeMae, "Insira a data do registro para calcular a idade da mãe");
        }

        private void txtDataNascReg_MouseClick(object sender, MouseEventArgs e) {
            txtDataNascReg.Select(0, 0);
        }

        private void txtDataNascPai_MouseClick(object sender, MouseEventArgs e) {
            txtDataNascPai.Select(0, 0);
        }

        private void button1_Click(object sender, EventArgs e) {
            InNascimento.SelectTab(DadosLivro);
        }

        private void txtDataNascMae_MouseClick(object sender, MouseEventArgs e) {
            txtDataNascMae.Select(0, 0);
        }

        private void txtDataRegistro_MouseClick(object sender, MouseEventArgs e) {
            txtDataRegistro.Select(0, 0);
            txtDataRegistro.Text = string.Empty;
        }

        private void txtDnv1_MouseClick(object sender, MouseEventArgs e) {
            txtDnv1.Select(0, 0);
        }

        private void txtDnv2_MouseClick(object sender, MouseEventArgs e) {
            txtDnv2.Select(0, 0);
        }

        private void txtDnv3_MouseClick(object sender, MouseEventArgs e) {
            txtDnv3.Select(0, 0);
        }
        private void txtNomeMae_MouseClick(object sender, MouseEventArgs e) {
            txtHoraNasc.Select(0, 0);
        }

        private void button2_Click(object sender, EventArgs e) {

            Registrado obj = new Registrado();

            obj.NomeRegistrado = txtNomeRegistrado.Text;
            obj.SexoRegistrado = txtSexoRegistrado.Text;
            obj.DataNascimento = DateTime.Parse(txtDataNascReg.Text);
            obj.HoraNascimento = txtHoraNasc.Text;
            obj.NomePai = txtNomePai.Text;
            obj.DataNascPai = DateTime.Parse(txtDataNascPai.Text);
            obj.CidadePai = txtCidadePai.Text;
            obj.UfPai = txtUfPai.Text;
            obj.NomeMae = txtNomeMae.Text;
            obj.DataNascMae = DateTime.Parse(txtDataNascMae.Text);
            obj.Cidademae = txtCidadeMae.Text;
            obj.UfMae = txtUfMae.Text;
            obj.NomeLivro = txtNomeLivro.Text;
            obj.NumLivro = txtNumLivro.Text;
            obj.NumPagLivro = txtNumPag.Text;
            obj.NumRegistro = txtNumRegistro.Text;
            obj.DataRegistro = DateTime.Parse(txtDataRegistro.Text);
            obj.NumDnv = txtDnv1.Text + "" + txtDnv2.Text + "" + txtDnv3.Text;

            if (CheckPrazo.Checked) {

                obj.PrazoReg = true;
            } else {
                obj.PrazoReg = false;
            }


            NascimentoDAO dao = new NascimentoDAO();

            dao.CadastrarRegistrado(obj);


        }


        public void txtDataNascPai_TextChanged(object sender, EventArgs e) {




        }

        private void txtDataNascPai_Leave(object sender, EventArgs e) {

            if (txtDataRegistro.TextLength == 10) {



            }

        }

        private void txtDataNascPai_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {
            if (!e.IsValidInput) {
                toolTip1.ToolTipTitle = "Data inválida";
                toolTip1.Show("A data precisa estar no formato dd/mm/aaaa.", txtDataNascPai, 0, -20, 5000);
            } else {

                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now) {
                    toolTip1.ToolTipTitle = "Data inválida";
                    toolTip1.Show("A data precisa ser anterior o dia de hoje", txtDataNascPai, 0, -20, 5000);
                    e.Cancel = true;
                }
            }

        }

        private void txtDataNascPai_KeyDown(object sender, KeyEventArgs e) {
            toolTip1.Hide(txtDataNascPai);
        }

        private void txtDataNascMae_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {

            if (!e.IsValidInput) {
                toolTip1.ToolTipTitle = "Data inválida";
                toolTip1.Show("A data precisa estar no formato dd/mm/aaaa.", txtDataNascMae, 0, -20, 5000);
            } else {

                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now) {
                    toolTip1.ToolTipTitle = "Data inválida";
                    toolTip1.Show("A data precisa ser anterior o dia de hoje", txtDataNascMae, 0, -20, 5000);
                    e.Cancel = true;
                }
            }


        }

        private void txtDataNascReg_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {
            if (!e.IsValidInput) {
                toolTip1.ToolTipTitle = "Data inválida";
                toolTip1.Show("A data precisa estar no formato dd/mm/aaaa.", txtDataNascReg, 0, -20, 5000);
            } else {

                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now) {
                    toolTip1.ToolTipTitle = "Data inválida";
                    toolTip1.Show("A data precisa ser anterior o dia de hoje", txtDataNascReg, 0, -20, 5000);
                    e.Cancel = true;
                }
            }
        }

        private void txtDataRegistro_TypeValidationCompleted(object sender, TypeValidationEventArgs e) {


            //Calculo das idades
            try {
                DateTime dataRegistro = DateTime.MinValue;
                DateTime dataNasciParte = DateTime.MinValue;
                DateTime dataNasciParte2 = DateTime.MinValue;

                //Validador da entrada de data
                if (!e.IsValidInput) {
                    toolTip1.ToolTipTitle = "Data inválida";
                    toolTip1.Show("A data precisa estar no formato dd/mm/aaaa.", txtDataRegistro, 0, -20, 5000);
                } else {

                    DateTime userDate = (DateTime)e.ReturnValue;
                    if (userDate > DateTime.Now) {
                        toolTip1.ToolTipTitle = "Data inválida";
                        toolTip1.Show("A data precisa ser anterior o dia de hoje", txtDataRegistro, 0, -20, 5000);
                        e.Cancel = true;
                    } else {
                        dataRegistro = DateTime.ParseExact(txtDataRegistro.Text, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));

                    }
                }

                if (!DateTime.TryParse(txtDataNascPai.Text, out dataNasciParte)) {


                } else {

                    txtIdadePai.Text = String.Empty;
                    txtIdadePai.Text = new Helper().CalculaIdade(dataNasciParte, dataRegistro).ToString();

                }

                if (!CheckPrazo.Checked) {

                    if (!e.IsValidInput) {
                        toolTip1.ToolTipTitle = "Data inválida";
                        toolTip1.Show("A data precisa estar no formato dd/mm/aaaa.", txtDataNascMae, 0, -20, 5000);
                    } else {

                        DateTime userDate = (DateTime)e.ReturnValue;
                        if (userDate > DateTime.Now) {
                            toolTip1.ToolTipTitle = "Data inválida";
                            toolTip1.Show("A data precisa ser anterior o dia de hoje", txtDataNascMae, 0, -20, 5000);
                            e.Cancel = true;
                        } else {
                            dataNasciParte2 = DateTime.ParseExact(txtDataNascMae.Text, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));
                        }
                    }

                    txtIdadeMae.Text = String.Empty;
                    txtIdadeMae.Text = new Helper().CalculaIdade(dataNasciParte2, dataRegistro).ToString();

                } else {
                    //pega pela data do nascimento caso o check foi marcado
                    DateTime dataRegistro2 = DateTime.MinValue;
                    if (!DateTime.TryParse(txtDataNascReg.Text, out dataRegistro2)) {
                        txtIdadeMae.Text = String.Empty;
                        MessageBox.Show("Se o registro foi feito no prazo a data de nascimento precisa ser digitada.");
                    } else {
                        dataNasciParte2 = DateTime.ParseExact(txtDataNascMae.Text, "dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR"));

                        txtIdadeMae.Text = String.Empty;
                        txtIdadeMae.Text = new Helper().CalculaIdade(dataNasciParte2, dataRegistro2).ToString();
                    }

                }

            } catch (Exception ex) {

                MessageBox.Show("Erro:" + ex);

                throw;
            }

        }
    }
}
