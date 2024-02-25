using ReproductorMusica.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReproductorMusica.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaMusica : ContentPage
    {
        public ListaMusica()
        {
            InitializeComponent();
            BindingContext = new VMlistamusica(Navigation);
        }
    }
}