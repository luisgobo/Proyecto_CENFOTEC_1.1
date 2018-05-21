using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdminBanda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage
    {
		
        public ObservableCollection<MenuItem> Menu { get; set; } = new ObservableCollection<MenuItem>();

        public MenuPage()
        {
            Menu = new ObservableCollection<MenuItem>();

            InitializeComponent();

            BindingContext = this;

            MenuList.ItemSelected += OnMenuSelected;
        }

        private void OnMenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuItem;
            item?.Command.Execute(item);
        }
    }

    public class MenuItem
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public ICommand Command { get; set; }
    }
}