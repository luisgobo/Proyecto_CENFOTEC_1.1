using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Modelos;

namespace AdminBanda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlPrincipalView
    {
        public ObservableCollection<Modelos.Usuario> Datos { get; set; }
        public Command RefrescarCommand { get; set; }

        public ControlPrincipalView()
        {
            InitializeComponent();
        }
    }
}