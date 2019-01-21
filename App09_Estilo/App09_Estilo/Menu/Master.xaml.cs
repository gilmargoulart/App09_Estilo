using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App09_Estilo.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoStyle1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ImplicitStylePage());
            IsPresented = false;
        }
        private void GoStyle2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.ExplicitStylePage());
            IsPresented = false;
        }
        private void GoStyle3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.GlobalStylePage());
            IsPresented = false;
        }
        private void GoStyle4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.InheritStylePage());
            IsPresented = false;
        }
        private void GoStyle5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pagina.DynamicPageStyle());
            IsPresented = false;
        }
    }
}