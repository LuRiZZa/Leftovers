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
	public partial class Shop : ContentPage
	{

        static Image imageFirst;

        public Shop ()
		{
			InitializeComponent ();

            var page = new NavigationPage();

            NavigationPage.SetTitleIcon(page, "FoodImage1.jpg");

            var toolbar1 = new ToolbarItem
            {
                Text = "item 1 ",



            };

            this.ToolbarItems.Add(toolbar1);



            //this.ToolbarItems.Add(new ToolbarItem("item 1","", () => { }));



            Label label = new Label
            {

                Text = "Leftovers",

                Font = Font.SystemFontOfSize(NamedSize.Large),

                //FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center

            };

            Label imageFirstLabel = new Label
            {

                Text = "Leftovers",
                Font = Font.SystemFontOfSize(NamedSize.Medium),
                //FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center

            };


            imageFirst = new Image
            {
                Source = ImageSource.FromFile("FoodImage1.jpg"),
                TranslationY = 20

            };
            imageFirst.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => ImageFirstTapped())

            });



            Image imageSecond = new Image
            {

                Source = ImageSource.FromFile("FoodImage1.jpg"),

                //TranslationY = imageFirst.TranslationY + 10,
            };

            imageSecond.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() => ImageSecondTapped())
            });


            this.Content = new StackLayout
            {
                Children =
                {

                imageFirst,
                imageSecond
                }
            };

        }

        void ImageFirstTapped()
        {

            Navigation.PushModalAsync(new Food());
        }

        void ImageSecondTapped()
        {
            Navigation.PushModalAsync(new Food());
        }
        void Settingsbutton()
        {

            Navigation.PushModalAsync(new Food());
        }
    }
}