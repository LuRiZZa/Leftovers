
//using Android.Views;
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
    public partial class Food : ContentPage
    {


        ScrollView scroller = new ScrollView();

        Grid stackL = new Grid();
        Label descriptionLabel = new Label();
        Label label = new Label();
        //public double fisse;
        List<ContentPage> listConView = new List<ContentPage>();

        //BoxView boxView;
        public Food()
        {
            InitializeComponent();

            ContentPresenter p;


            //AbsoluteLayout al = new AbsoluteLayout()
            //{
            //    WidthRequest = Application.Current.MainPage.Width,
            //    BackgroundColor = Color.White,
            //    //HorizontalOptions = LayoutOptions.Center,
            //    // VerticalOptions = LayoutOptions.Center
            //};





            //AbsoluteLayout.SetLayoutBounds(scroller, new Rectangle(.10, .20, 0.8, 0.8));
            // AbsoluteLayout.SetLayoutFlags(scroller, AbsoluteLayoutFlags.All);



            var absoluteLayout = new AbsoluteLayout();

            //--var stackLayout = new StackLayout
            //{
            //    Children =
            //    {
            //        DescriptionImage,
                                                //Bruges til hvis indholdet i denne klasse ikke skal opdeles i metoder.
            //        descriptionLabel,
            //        scroller,

            //    }
            //};

            //--absoluteLayout.Children.Add(stackLayout, new Rectangle(.05, .05, 3, 3), AbsoluteLayoutFlags.All);


            StackLayout stackLayout = new StackLayout();


            stackLayout.Children.Add(DescriptionImg());
            stackLayout.Children.Add(DescriptionLabel());
            stackLayout.Children.Add(DescriptScroll());

            stackLayout.Children.Add(BuyButton());
            stackLayout.Children.Add(BuyLabel());

            //DescriptionImage.WidthRequest = Application.Current.MainPage.Width;



            //};
            //for (int i = 0; i < al.Children.Count; i++)
            //{
            //    al.Children[i].ScaleTo(0.7f, 250, Easing.BounceIn);
            //    al.Children[i].HeightRequest = (Application.Current.MainPage.Height * 0.5f);
            //    al.Children[i].WidthRequest = (Application.Current.MainPage.Width * 0.5f);
            //}
            //scroller.Scale = 0.6f;
            scroller.Content = descriptionLabel;
            this.Content = descriptionLabel;

            this.Content = stackLayout;
        }
        public ScrollView DescriptScroll()
        {
            scroller = new Xamarin.Forms.ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                HeightRequest = 180,
                WidthRequest = Application.Current.MainPage.Width - 100,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
                

            };

            return scroller;
        }
        public Image DescriptionImg()
        {
            Image DescriptionImage = new Image
            {
                Source = ImageSource.FromFile("FoodImage1.jpg"),
                // Aspect = Aspect.AspectFit,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 180,

                //TranslationY = 10

            };

            return DescriptionImage;
        }
        public Label DescriptionLabel()
        {

            descriptionLabel = new Label
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean pellentesque libero ut ligula eleifend placerat. Morbi quam velit, sollicitudin eu ipsum non, vestibulum auctor purus. In volutpat urna non est sollicitudin sollicitudin. Quisque ornare ante sed velit tristique, quis dignissim nisi imperdiet. Nunc in ultricies massa, facilisis suscipit est. Pellentesque gravida tincidunt nisi, non mattis nisi euismod nec. Ut eu consectetur nisl. Nunc in faucibus orci, ac venenatis neque. Cras tristique, eros eu ultricies interdum, lacus felis hendrerit purus, et ultrices magna arcu et sapien. Morbi non justo sapien. Mauris egestas arcu vitae luctus laoreet. Proin posuere magna sit amet ex malesuada, id volutpat orci dictum. Mauris tempor eget leo et sagittis. Vivamus risus mi, ullamcorper id nibh vel, pretium porttitor arcu. Nullam ut egestas velit. Fusce lacus tortor, ullamcorper volutpat tincidunt at, imperdiet vitae lectus.",
                //FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Font)),
                FontSize = 18,
                BackgroundColor = Color.LightGray,
                TextColor = Color.Blue,

               // VerticalOptions = LayoutOptions.Center,
                //HorizontalOptions = LayoutOptions.End,
                //HeightRequest = 300,
                //WidthRequest = Application.Current.MainPage.Width - 50
            };
            
            return descriptionLabel;


        }
        public Button BuyButton()
        {
            Button button = new Button()
            {
                Text = "Køb ",
                TextColor = Color.White,
                BackgroundColor = Color.Green,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                
            };
            button.Clicked += BuyButtonClicked;
            
            return button;
        }
        public void BuyButtonClicked(object sender, EventArgs e)
        {
            label.Text = "Buy button has been pressed";
            
        }
        public Label BuyLabel()
        {
            label = new Label()
            {
                Text = "",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End,
                // TranslationY = -20,
                TextColor = Color.Black,
            };
            return label;
        }



    }
}