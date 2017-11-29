using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leftover
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasDetPage : MasterDetailPage
	{
        //Use "Application.Current.MainPage = new MasDetPage(new PageName());" so master page can work with all the other pages or something like this "var mdp = Application.Current.MainPage as MasDetPage;  await mdp.Detail.Navigation.PushAsync(myNextPage);"
        public MasDetPage (Page page)
		{
			InitializeComponent ();
            this.Master = new Master();
            this.Detail = new NavigationPage(page);
        }
	}
}