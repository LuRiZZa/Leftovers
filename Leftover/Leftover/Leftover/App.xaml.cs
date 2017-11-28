using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Leftover
{
    public partial class App : Application
    {
        public static Size Screensize;


        public App()
        {
            InitializeComponent();

            

            MainPage = new Leftover.MainPage();
            //MainPage = new NavigationPage(new Leftover.MainPage());



        }

        protected override void OnStart()
        {
            // Handle when your app starts
         

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
