
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
            // This for loop will populate the page with all the shops/items. (Needs to be implemented: Need the shops/items(data) from somewhere else, distance need to be calculated)
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

        

            // adding a scroll to the grid. So you can view data if it is outside the mobile screen.
            ScrollView Scroll = new ScrollView
            {
                Orientation = ScrollOrientation.Vertical
            };


            Scroll.Content = grid;

            this.Content = grid;
            this.Content = Scroll;
            




        }


        /// <summary>
        /// Labels, boxview and image for one shop/item. Can be edited for the future (Need to be fixed: work on all screens)
        /// </summary>
        /// <returns></returns>
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
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
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