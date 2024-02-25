using ReproductorMusica.Datos;
using ReproductorMusica.Modelo;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ReproductorMusica.VistaModelo
{
    public class VMlistamusica : BaseViewModel
    {
        #region VARIABLES
        List<Mmusica> _listamusica;
        #endregion
        #region CONSTRUCTOR
        public VMlistamusica(INavigation navigation)
        {
            Navigation = navigation;
            MostrarMusica();
        }
        #endregion
        #region OBJETOS
        public List<Mmusica> ListaMusica
        {
            get { return _listamusica; }
            set { SetValue(ref _listamusica, value); }
        }
        #endregion
        #region PROCESOS
        public async Task MostrarMusica()
        {
            var funcion = new Dmusica();
            ListaMusica = await funcion.ListarMusica();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        //public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
