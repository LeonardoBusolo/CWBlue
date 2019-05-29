using CWBlue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CWBlue.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        List<Pagina> paginas;
		public MenuView ()
		{
			InitializeComponent ();
		}

        public void IniciliarLista()
        {
            paginas = new List<Pagina>();

            paginas.Add(new Pagina
            {
                Titulo = "Inicio",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            paginas.Add(new Pagina
            {
                Titulo = "Minhas Reservas",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            paginas.Add(new Pagina
            {
                Titulo = "Cobranças",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            paginas.Add(new Pagina
            {
                Titulo = "Minhas Compras",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

        }

        private void LvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}