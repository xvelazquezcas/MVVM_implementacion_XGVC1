using MVVM_implementacion_XGVC1.Modelo;
using MVVM_implementacion_XGVC1.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_XGVC1.VistaModelo
{
    internal class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
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
        /*public async Task Volver()
        {
            await Navigation.PopAsync();
        }*/
        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
               new Mmenuprincipal
               {
                   Pagina= "Entry, datepicker, label, navegation",
                   Icono= "https://i.ibb.co/sHgsmSn/bonita.png"

               },
               new Mmenuprincipal
               {
                   Pagina= "ColectionView sin enlace a Base de datos",
                   Icono = "https://i.ibb.co/VxmMsg6/gengar.png"
               },
               new Mmenuprincipal
               {
                   Pagina = "Crud Pokemon",
                   Icono = "https://i.ibb.co/x8cv5YP/bulba.png"
               }
            };
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina1());
            }
            if(pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Pagina2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion
        #region COMANDOS
        //public ICommand VolverCommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        // public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
    }
}