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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}


        void LoginClick(object sender, EventArgs e)
        {
            if (UsernameEntry.Text == "" && PasswordEntry.Text == "")
            {
                //Navigation.PushModalAsync(new Shop());
                //p = new NavigationPage();

                Navigation.PushModalAsync(new Leftover.Shop());

            }
        }
    }
}