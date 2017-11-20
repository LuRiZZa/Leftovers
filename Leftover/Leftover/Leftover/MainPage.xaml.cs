using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Leftover
{
	public partial class MainPage : ContentPage
	{
        public Page p;
        
        public MainPage()
		{
            
                InitializeComponent();
            

        }
        

        void LoginClick(object sender, EventArgs e)
        {
            if (UsernameEntry.Text == "Admin" && PasswordEntry.Text == "Admin")
            {
                //Navigation.PushModalAsync(new Shop());
                p = new NavigationPage(new Leftover.Shop());

                Navigation.PushModalAsync(p);
                    
            }
        }
    }
}
