using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.ProjetoT.Model {
    public class Registrado {

        public int Id { get; set; }

        public string NomeRegistrado { get; set; }

        public string SexoRegistrado { get; set;}
        public DateTime DataNascimento { get; set;}
        public string HoraNascimento { get; set;}
        public string NomePai { get; set;}
        public DateTime DataNascPai { get; set;}
        public string CidadePai { get; set;}
        public string UfPai { get; set;}
        public string NomeMae { get; set;}
        public DateTime DataNascMae { get; set;}
        public string Cidademae { get; set;}
        public string UfMae { get; set;}
        public string NomeLivro { get; set;}
        public string NumLivro { get; set;}
        public string NumPagLivro { get; set;}
        public string NumRegistro { get; set;}
        public DateTime DataRegistro { get; set;}
        public string NumDnv { get; set;}
        public bool PrazoReg { get; set;}


    }
}
