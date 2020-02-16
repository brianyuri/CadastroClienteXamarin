using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProwayXamarin.Mobile.Shared.Models
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public DateTime DataNacimento { get; set; }


        public Cliente GerarCliente()
        {
            this.Id = 1;
            this.Nome = "Brian Yuri Fachini";
            this.CPF = "55544433333";
            this.CEP = "89087232";
            this.Endereco = "Rua conde de pinhal";
            this.DataNacimento = DateTime.Today;
            return this;
        }
    }
}
