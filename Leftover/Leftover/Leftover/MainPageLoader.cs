


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms;

namespace Leftover
{
    public partial class MainPageLoader : ContentPage
    {
        
        public MainPageLoader()
        {
            InitializeComponent();
        }

        void LoginClick(object sender, EventArgs e)
        {
            if(UsernameEntry.Text == "Admin" && PasswordEntry.Text == "Admin")
            {
                Navigation.PushModalAsync(new Shop());
            }
        }

       

    }
}
