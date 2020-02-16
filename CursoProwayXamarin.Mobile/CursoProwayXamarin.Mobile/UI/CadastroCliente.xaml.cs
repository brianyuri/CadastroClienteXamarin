using CursoProwayXamarin.Mobile.Shared.Models;
using CursoProwayXamarin.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CursoProwayXamarin.Mobile.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void SalvarCliente(object sender, System.EventArgs e)
        {
            (sender as Button).IsEnabled = false;
            (sender as Button).Text = "Cliente adicionado com sucesso.";

            var cliente = new Cliente().GerarCliente();
            var clienteViewModel = new ClienteViewModel(cliente);
            nome.Text = clienteViewModel.Nome;
            endereco.Text = clienteViewModel.Endereco;
            cep.Text = clienteViewModel.CEP;
            cpf.Text = clienteViewModel.CPF;
            DataNascimento.Text = clienteViewModel.DataNacimento;


            //Navigation.PushAsync(new MainPage());
        }
    }
}