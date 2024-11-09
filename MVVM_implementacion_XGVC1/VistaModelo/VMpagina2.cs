using MVVM_implementacion_XGVC1.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_XGVC1.VistaModelo
{
    internal class VMpagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMpagina2(INavigation navigation)
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
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void MostrarUsuarios()
        {
            listausuarios = new List<Musuarios>
            {
               new Musuarios
               {
                   Nombre= "Star",
                   Imagen= "https://i.ibb.co/L5nmRz0/cinco-estrellas.png"

               },
               new Musuarios
               {
                   Nombre= "Lisa",
                   Imagen = "https://i.ibb.co/7r5sJ4r/patito-de-goma.png"
               },
               new Musuarios
               {
                   Nombre = "Lunita",
                   Imagen = "https://i.ibb.co/wQr5F7x/luna.png"
               }
            };
        }
        #endregion
        #region COMANDOS
        public ICommand VolverCommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion
    }
}
