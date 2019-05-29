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
	public partial class MasterView : MasterDetailPage
	{
        public static MasterDetailPage NavegacaoMasterDetail { get; set; }
		public MasterView ()
		{
			InitializeComponent ();

            this.Detail = new NavigationPage(new HomeView()
            {
                Title = "Inicio CWBlue",
                Icon = "",
            });

            this.Master = new MenuView()
            {
                Title = "Menu",
            };
            this.MasterBehavior = MasterBehavior.Popover;

            NavegacaoMasterDetail = this;
            
		}
	}
}