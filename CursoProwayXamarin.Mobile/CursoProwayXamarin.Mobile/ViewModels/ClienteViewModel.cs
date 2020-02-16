using CursoProwayXamarin.Mobile.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProwayXamarin.Mobile.ViewModels
{
    public class ClienteViewModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public String DataNacimento { get; set; }

        public ClienteViewModel(Cliente cliente)
        {
            this.Id = cliente.Id;
            this.Endereco = cliente.Endereco;
            this.Nome = cliente.Nome;
            this.CEP = cliente.CEP;
            this.CPF = cliente.CPF;
            this.DataNacimento = cliente.DataNacimento.ToString("dd/mm/yyyy");
        }

    }
}
