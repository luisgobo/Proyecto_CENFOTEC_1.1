using AdminBanda.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MaestroDetallePage
	{
		public MaestroDetallePage ()
        {
            InitializeComponent();
            var paginaMenu = new MenuPage();

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Clase 1",
                Command = new Command(() => Navegar(new ContentPage { Content = new Label { Text = "Pagina Principal" } }))
            });

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Usuarios",
                Command = new Command(() => Navegar(new ContenedorUsuarioPage()))
            });

            //paginaMenu.Menu.Add(new MenuItem()
            //{
            //    Icon = "",
            //    Title = "Instrumentos",
            //    Command = new Command(() => Navegar(new MarcadorTelefonico()))
            //});

            //paginaMenu.Menu.Add(new MenuItem()
            //{
            //    Icon = "",
            //    Title = "Eventos",
            //    Command = new Command(() => Navegar(new MediaPage()))
            //});

            Master = paginaMenu;


            /*
            botonNavegar.Command = new Command(() => {
                Detail = new TabulacionPage();
            });
            */
        }

        private void Navegar(Page page)
        {
            Detail = page;

            IsPresented = false;
        }
    }
}