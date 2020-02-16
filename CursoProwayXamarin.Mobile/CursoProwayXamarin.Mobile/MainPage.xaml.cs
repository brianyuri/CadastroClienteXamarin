using CursoProwayXamarin.Mobile.UI;
using System.ComponentModel;
using Xamarin.Forms;

namespace CursoProwayXamarin.Mobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void AbrirCadastroCliente(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CadastroCliente());
        }
    }
}
