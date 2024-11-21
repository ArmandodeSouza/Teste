using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.ProjetoT.View;

namespace Teste.ProjetoT.Model {
    internal class Helper : InclusaoNascimento {

        public void LimparTela(Form tela) {

            //percorre a tela e salva no ctrPai
            foreach (Control ctrPai in tela.Controls) {

                //percorre o que foi salvo para ver se tem TAB PAGES nessa tela
                foreach (Control ctr1 in ctrPai.Controls) {

                    //Verifica se tem TAB PAGES
                    if (ctr1 is TabPage) {

                        //Percorre o ctr1 caso tenha tab pages e salva as informações dentro do ctr2
                        foreach (Control ctr2 in ctr1.Controls) {

                            //Verifica se o campo é igual a um TextBox
                            if (ctr2 is TextBox) {

                                //Limpa o campo
                                (ctr2 as TextBox).Text = String.Empty;
                            }
                            if (ctr2 is MaskedTextBox) {


                                (ctr2 as MaskedTextBox).Text = String.Empty;
                            }
                            if (ctr2 is ComboBox) {


                                (ctr2 as ComboBox).Text = String.Empty;
                            }

                        }
                    }
                }

            }


        }


        public int CalculaIdade(DateTime dataNasciParte, DateTime dataRegistro) {

            int idade = dataRegistro.Year - dataNasciParte.Year;

            if (dataRegistro.Month > dataNasciParte.Month) {

                idade -= 1;
            }
            if (dataRegistro.Month == dataNasciParte.Month && dataRegistro.Day < dataNasciParte.Day) {
                idade -= 1;

            }

            return idade;

        }
    }
}
