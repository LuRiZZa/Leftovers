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
        public GridTest()
        {
            InitializeComponent();

            var grid = new Grid();

           

            for (int i = 0; i < 10; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(150) });
                grid.Children.Add(ImageBackground(), 0, i);
                grid.Children.Add(LabelBackground(), 0, i);
                grid.Children.Add(ShopLbl(), 0, i);
                grid.Children.Add(PriceLbl(), 0, i);
                grid.Children.Add(DistanceLbl(), 0, i);
            }
            

            ScrollView Scroll = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
            };

            Scroll.Content = grid;

            this.Content = grid;
            this.Content = Scroll;


        }

        

        public Label ShopLbl()
        {
            Label label = new Label
            {
                Text = "ShopName",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
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
                TextColor = Color.White
            };

            return label;
        }

        public BoxView LabelBackground()
        {
            BoxView boxView = new BoxView
            {
                Color = Color.Black,
                WidthRequest = 250,
                HeightRequest = 50,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                Opacity = 0.8

            };

            return boxView;
        }

        public Image ImageBackground()
        {
            Image image = new Image
            {
                Source = ImageSource.FromFile("FoodImage1.jpg"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center


            };

            return image;
        }
    }
}