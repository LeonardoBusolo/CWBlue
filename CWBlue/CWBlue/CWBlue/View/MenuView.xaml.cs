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
            IniciliarLista();
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
                Titulo = "Fazer Reserva",
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
                Titulo = "Minhas Compras",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            paginas.Add(new Pagina
            {
                Titulo = "Minhas Compras",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            paginas.Add(new Pagina
            {
                Titulo = "Perfil",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            paginas.Add(new Pagina
            {
                Titulo = "Meus Planos",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            paginas.Add(new Pagina
            {
                Titulo = "Sair",
                Icone = "",
                PaginaView = typeof(HomeView)
            });

            lvMenu.ItemsSource = paginas;
        }

        private void LvMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
    }
}