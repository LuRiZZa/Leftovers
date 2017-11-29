
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

        static Image imageFirst;
        SearchBar searchBar;
        static Label sResultLabel;
        Label foodLabel = new Xamarin.Forms.Label();
        Label electronicsLabel = new Label();
        Grid catGrid = new Grid();

        public GridTest()
        {
            InitializeComponent();



            var page = new NavigationPage();



            NavigationPage.SetTitleIcon(page, "FoodImage1.jpg");


            catGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(99) });

            //this.ToolbarItems.Add(new ToolbarItem("item 1","", () => { }));


            for (int i = 0; i <= 4; i++)
            {

                catGrid.Children.Add(FoodImageAdd(), 0, i);
                //catGrid.Children.Add(FoodLabel(i), 0, i);

                //catGrid.Children.Add(ElectronicsFood(i), 0, i);
                //catGrid.Children.Add(ElectronicsLabel(i), 0, i);

                //catGrid.Children.Add(ClothesAccessories(i), 0, i);
                //catGrid.Children.Add(ClothesAccessoriesLabel(i), 0, i);

                //catGrid.Children.Add(ToiletThings(i), 0, i);
                //catGrid.Children.Add(ToiletAccessoriesLabel(i), 0, i);



                catGrid.Children.Add(CatLbl("Mad og råvarer" + i), 0, i);
               // catGrid.Children.Add(LabelBackground(), 0, i);






                //for (int s = i; s <=4; s++)
                //{





                //}




            }




            this.Content = catGrid;



            //Label label = new Label
            //{

            //    Text = "Leftovers",

            //    Font = Font.SystemFontOfSize(NamedSize.Large),

            //    //FontAttributes = FontAttributes.Bold,
            //    HorizontalOptions = LayoutOptions.Center

            //};

            //Label imageFirstLabel = new Label
            //{

            //    Text = "Leftovers",
            //    Font = Font.SystemFontOfSize(NamedSize.Medium),
            //    //FontAttributes = FontAttributes.Bold,
            //    HorizontalOptions = LayoutOptions.Center

            //};



            //imageFirst.GestureRecognizers.Add(new TapGestureRecognizer
            //{
            //    Command = new Command(() => ImageFirstTapped())

            //});





            //imageSecond.GestureRecognizers.Add(new TapGestureRecognizer
            //{
            //    Command = new Command(() => ImageSecondTapped())
            //});

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





            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.Start,
            //    Children =
            //       {
            //            imageFirst,
            //            imageSecond,
            //           new Label
            //           {
            //               HorizontalTextAlignment = TextAlignment.Center,
            //               Text = "SearchBar",
            //               FontSize = 50
            //           },
            //           searchBar,
            //           new ScrollView
            //           {
            //               Content = sResultLabel,
            //               VerticalOptions = LayoutOptions.FillAndExpand
            //           }


            //       },
            //    Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5)
            //};



            //var toolbar1 = new ToolbarItem
            //{
            //    Text = "item 1 ",



            //};

            //this.ToolbarItems.Add(toolbar1);



        }
        public Image FoodImageAdd()
        {
            
            imageFirst = new Image
            {

                Source = ImageSource.FromFile("FoodImage1.jpg"),

                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 100,
                Aspect = Aspect.AspectFill,
                TranslationY = 20
            };
            return imageFirst;
        }


        public Label CatLbl(string name)
        {

            foodLabel = new Label()
            {
                Text = name,

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                //TranslationY = 
                TextColor = Color.Black,
                BackgroundColor = Color.LightGray,
                
            };
            
            //catGrid.Children.Add(foodLabel, 0, i);
            return foodLabel;

        }
        public BoxView LabelBackground()
        {
            BoxView boxView = new BoxView
            {
                Color = Color.LightGray,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 30,
                //TranslationY = + HeightRequest,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,


                Opacity = 0.8,
            };
            return boxView;
        }
        

        //public Label FoodLabel()
        //{

        //    foodLabel = new Label()
        //    {
        //        Text = "Food",

        //        HorizontalOptions = LayoutOptions.Center,
        //        VerticalOptions = LayoutOptions.End,
        //        //TranslationY = 
        //        TextColor = Color.White
        //    };
        //    //i = 0;
        //    //catGrid.Children.Add(foodLabel, 0, i);
        //    return foodLabel;

        //}
        //public Image ElectronicsFood(int i)
        //{
        //    i = 1;
        //    Image electronicsImage = new Image
        //    {

        //        Source = ImageSource.FromFile("FoodImage1.jpg"),
        //        WidthRequest = Application.Current.MainPage.Width,
        //        HeightRequest = 100,
        //        Aspect = Aspect.AspectFill,
        //        TranslationY = 20

        //    };


        //    return electronicsImage;
        //}


        //public Label ElectronicsLabel(int i)
        //{

        //    electronicsLabel = new Label
        //    {
        //        Text = "Electronics",
        //        HorizontalOptions = LayoutOptions.Center,
        //        VerticalOptions = LayoutOptions.End,
        //        //TranslationY = 
        //        TextColor = Color.White
        //    };
        //    i = 1;
        //    //lbl = electronicsLabel;
        //    //catGrid.Children.Add(electronicsLabel, 0, i);
        //    return electronicsLabel;
        //}

        //public Image ClothesAccessories(int i)
        //{
        //    i = 2;
        //    Image clothes = new Image
        //    {
        //        Source = ImageSource.FromFile("FoodImage1.jpg"),
        //        WidthRequest = Application.Current.MainPage.Width,
        //        HeightRequest = 100,
        //        Aspect = Aspect.AspectFill,
        //        TranslationY = 20
        //    };
        //    return clothes;
        //}
        //public Label ClothesAccessoriesLabel(int i)
        //{
        //    i = 2;
        //    Label clothesAccesso = new Label
        //    {
        //        Text = "Tøj og Accessories",
        //        HorizontalOptions = LayoutOptions.Center,
        //        VerticalOptions = LayoutOptions.End,
        //        //TranslationY = 
        //        TextColor = Color.White
        //    };

        //    return clothesAccesso;
        //}
        //public Image ToiletThings(int i)
        //{
        //    i = 3;
        //    Image ToiletAccessories = new Image
        //    {
        //        Source = ImageSource.FromFile("FoodImage1.jpg"),
        //        WidthRequest = Application.Current.MainPage.Width,
        //        HeightRequest = 100,
        //        Aspect = Aspect.AspectFill,
        //        TranslationY = 20
        //    };
        //    return ToiletAccessories;
        //}
        //public Label ToiletAccessoriesLabel(int i)
        //{
        //    i = 3;
        //    Label ToiletAccesso = new Label
        //    {
        //        Text = "Tøj og Accessories",
        //        HorizontalOptions = LayoutOptions.Center,
        //        VerticalOptions = LayoutOptions.End,
        //        //TranslationY = 
        //        TextColor = Color.White
        //    };

        //    return ToiletAccesso;
        //}

        //public Label ElectronicsLabel(int i)
        //{

        //    //return label;
        //}
        void ImageFirstTapped()
        {

            Navigation.PushAsync(new Food());
        }

        void ImageSecondTapped()
        {
            Navigation.PushAsync(new Food());
        }
        void Settingsbutton()
        {

            Navigation.PushAsync(new Food());
        }



    }
}