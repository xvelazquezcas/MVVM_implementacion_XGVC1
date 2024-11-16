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
        public List<Mmenuprincipal> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
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
        public void MostrarUsuarios()
        {
            listausuarios = new List<Mmenuprincipal>
            {
               new Mmenuprincipal
               {
                   Pagina= "Entry, datepicker, label, navegation",
                   Icono= "https://i.ibb.co/L5nmRz0/cinco-estrellas.png"

               },
               new Mmenuprincipal
               {
                   Pagina= "ColectionView sin enlace a Base de datos",
                   Icono = "https://i.ibb.co/7r5sJ4r/patito-de-goma.png"
               },
               new Mmenuprincipal
               {
                   Pagina = "Crud Pokemon",
                   Icono = "https://i.ibb.co/wQr5F7x/luna.png"
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