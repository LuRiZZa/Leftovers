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
        SearchBar searchBar;
        static Label sResultLabel;

        public Shop()
        {
            InitializeComponent();




            var page = new NavigationPage();



            NavigationPage.SetTitleIcon(page, "FoodImage1.jpg");




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
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 50,
                Aspect = Aspect.AspectFill,
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

            sResultLabel = new Label
            {
                Text = "The result is:",
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = 25
            };


            searchBar = new SearchBar
            {
                Placeholder = "Enter your search terms here:",
                SearchCommand = new Command(() => { sResultLabel.Text = "result:" + searchBar.Text; }),
                HeightRequest = 50

            };





            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children =
                   {
                        imageFirst,
                        imageSecond,
                       new Label
                       {
                           HorizontalTextAlignment = TextAlignment.Center,
                           Text = "SearchBar",
                           FontSize = 50
                       },
                       searchBar,
                       new ScrollView
                       {
                           Content = sResultLabel,
                           VerticalOptions = LayoutOptions.FillAndExpand
                       }


                   },
                Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5)
            };
            


            var toolbar1 = new ToolbarItem
            {
                Text = "item 1 ",



            };

            this.ToolbarItems.Add(toolbar1);

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