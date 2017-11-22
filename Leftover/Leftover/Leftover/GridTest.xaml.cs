
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
    public partial class GridTest : ContentPage
    {
        
        Grid grid = new Grid();
        public GridTest()
        {
            InitializeComponent();

            for (int i = 0; i <= 9; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(99) } );
                //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(Application.Current.MainPage.Width) }); Gør det automatisk????
                grid.Children.Add(ImageBackground(), 0, i);
                grid.Children.Add(LabelBackground(), 0, i);
                grid.Children.Add(ShopLbl(), 0, i);
                grid.Children.Add(PriceLbl(), 0, i);
                grid.Children.Add(DistanceLbl(), 0, i);
            }

        


            ScrollView Scroll = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical
            };


            Scroll.Content = grid;

            this.Content = grid;
            this.Content = Scroll;




        }



        public Label ShopLbl()
        {
            Label label = new Label
            {
                Text = "Shop",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                //TranslationY = 
                TextColor = Color.White
            };
            return label;
        }

        public Label PriceLbl()
        {
            Label label = new Label
            {
                Text = "Price",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.End,
                //TranslationY = 
                TextColor = Color.White
            };
            return label;
        }

        public Label DistanceLbl()
        {
            Label label = new Label
            {
                Text = "Distance",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                //TranslationY = 
                TextColor = Color.White
            };

            return label;
        }

        public BoxView LabelBackground()
        {
            BoxView boxView = new BoxView
            {

                Color = Color.Black,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 30,
                //TranslationY = + HeightRequest,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                
                
                Opacity = 0.8,

            };

            return boxView;
        }

        public Image ImageBackground()
        {
            Image image = new Image
            {
                Source = ImageSource.FromFile("FoodImage1.jpg"),
                //HeightRequest = grid.Height,
                //MinimumWidthRequest = Application.Current.MainPage.Width
                //HorizontalOptions = LayoutOptions.Center,  // Denne blokere WidthRequest
                //VerticalOptions = LayoutOptions.End // Denne blokere WidthRequest
                
                //TranslationY = LabelBackground().TranslationY - LabelBackground().HeightRequest
                
                
            };
            
            return image;

        }
    }
}