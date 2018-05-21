using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdminBanda
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            InitializeComponent();
            Boton1.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Saludos", "Hola Xamarin.Forms!", "Cerrar");

                LabelSalida.Text = $"Fecha:{DatePickerFechaNacimiento.Date}";

            };
            boton2.Clicked += MostrarPantalla;
        }

        private async void MostrarPantalla(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
            //await Navigation.PushAsync(new ContenedorPage());
        }
    }

}