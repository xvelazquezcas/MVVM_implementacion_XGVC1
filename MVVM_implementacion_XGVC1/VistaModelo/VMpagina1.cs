using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_XGVC1.VistaModelo
{
    internal class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMpagina1(INavigation navigation)
        {
             Navigation = navigation;
        }
        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Alerta()
        {
            await DisplayAlert("Titulo", "Mensaje", "Okeyys");
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand AlertaCommand => new Command(async () => await Alerta());
        public ICommand procesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
