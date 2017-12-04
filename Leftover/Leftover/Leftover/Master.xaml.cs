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
	public partial class Master : ContentPage
	{
        private Grid grid = new Grid();

        private int margin = 5;

        readonly int fontProfileNameSize = 15;
        readonly int fontLabelSize = 12;

        public Master()
        {
            InitializeComponent();

            LoadDataToGrid();
            
            this.Content = grid;
           
        }



        private void LoadDataToGrid()
        {
            grid.RowSpacing = 0.4;


            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(50, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70) });
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) });
            grid.Children.Add(ProfilePicture(), 0, 0);
            //grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(4, GridUnitType.Star) });

            grid.Children.Add(UsernameLbl(), 1, 0);
            
            RowSmallHeight();
            BoxView temp = CreateLine();
            grid.Children.Add(temp, 0, 1);
            Grid.SetColumnSpan(temp, 2);

            RowBigHeight();
            LeftColumnWidth();
            grid.Children.Add(leftIconTest(), 0, 2);
            RightColumnWidth();
            grid.Children.Add(ButtonLabels("Category"), 1, 2);
            grid.Children.Add(CreateBtnCategory(), 1, 2);

            RowSmallHeight();
            BoxView temp2 = CreateLine();
            grid.Children.Add(temp2, 0, 3);
            Grid.SetColumnSpan(temp2, 2);

            RowBigHeight();
            LeftColumnWidth();
            grid.Children.Add(leftIconTest(), 0, 4);
            RightColumnWidth();
            grid.Children.Add(ButtonLabels("History"), 1, 4);
            grid.Children.Add(CreateBtnHistory(), 1, 4);

            RowSmallHeight();
            BoxView temp3 = CreateLine();
            grid.Children.Add(temp3, 0, 5);
            Grid.SetColumnSpan(temp3, 2);

            RowBigHeight();
            LeftColumnWidth();
            grid.Children.Add(leftIconTest(), 0, 6);
            RightColumnWidth();
            grid.Children.Add(ButtonLabels("About us"), 1, 6);
            grid.Children.Add(CreateBtnAbout(), 1, 6);

            RowSmallHeight();
            BoxView temp4 = CreateLine();
            grid.Children.Add(temp4, 0, 7);
            Grid.SetColumnSpan(temp4, 2);

            RowBigHeight();
            LeftColumnWidth();
            grid.Children.Add(leftIconTest(), 0, 8);
            RightColumnWidth();
            grid.Children.Add(ButtonLabels("Contact us"), 1, 8);
            grid.Children.Add(CreateBtnContact(), 1, 8);

            RowSmallHeight();
            BoxView temp5 = CreateLine();
            grid.Children.Add(temp5, 0, 9);
            Grid.SetColumnSpan(temp5, 2);

            RowBigHeight();
            LeftColumnWidth();
            grid.Children.Add(leftIconTest(), 0, 10);
            RightColumnWidth();
            grid.Children.Add(ButtonLabels("Settings"), 1, 10);
            grid.Children.Add(CreateBtnSettings(), 1, 10);

            RowSmallHeight();
            BoxView temp6 = CreateLine();
            grid.Children.Add(temp6, 0, 11);
            Grid.SetColumnSpan(temp6, 2);

            RowBigHeight();
            LeftColumnWidth();
            grid.Children.Add(leftIconTest(), 0, 12);
            RightColumnWidth();
            grid.Children.Add(ButtonLabels("Share"), 1, 12);
            grid.Children.Add(CreateBtnShare(), 1, 12);

            RowSmallHeight();
            BoxView temp7 = CreateLine();
            grid.Children.Add(temp7, 0, 13);
            Grid.SetColumnSpan(temp7, 2);


        }

        private void LeftColumnWidth()
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(35) });
        }

        private void RightColumnWidth()
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(200) });
        }

        private void RowSmallHeight()
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1) });
        }

        private void RowBigHeight()
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(35) });
        }




        private Image leftIconTest()
        {
            Image image = new Image
            {
                Source = ImageSource.FromFile("Icon.png"),
                HorizontalOptions = LayoutOptions.Start,
                TranslationX = margin,
                HeightRequest = 35,
                WidthRequest = 35
            };
            return image;
        }

        private Image CategoryIcon()
        {
            Image image = new Image
            {
                Source = ImageSource.FromFile("CategoryIconSmall.png"),
                HorizontalOptions = LayoutOptions.Start,
                TranslationX = margin,
                HeightRequest = 35,
                WidthRequest = 35
            };
            return image;
        }

        private Image AboutUsIcon()
        {
            Image image = new Image
            {
                Source = ImageSource.FromFile("AboutUsIcon.png"),
                HorizontalOptions = LayoutOptions.Start,
                TranslationX = margin,
                HeightRequest = 35,
                WidthRequest = 35
            };
            return image;
        }



        private Image ProfilePicture()
        {
            Image image = new Image
            {
                Source = ImageSource.FromFile("ProfilePictureIcon.png"),
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 50,
                WidthRequest = 50,
                TranslationX = margin
            };
            return image;
        }

        private Label UsernameLbl()
        {
            Label label = new Label
            {
                Text = "Jens Jens Jensen",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                FontSize = fontProfileNameSize,
                FontAttributes = FontAttributes.Bold
            };
            return label;
        }

        // Line between buttons
        private BoxView CreateLine()
        {
            BoxView boxView = new BoxView
            {
                Color = Color.Black,
                WidthRequest = 200,
                HeightRequest = 1
            };

            return boxView;
        }


        // This is the place where the names on the different buttons will show
        private Label ButtonLabels(string text)
        {
            Label label = new Label
            {
                Text = text,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                TranslationX = margin,
                FontSize = fontLabelSize
            };
            return label;
        }



        //Button getting created here. Dont edit text since it will not get rendered

        private Button CreateBtnCategory()
        {
            Button button = new Button
            {
                Text = " ",
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Opacity = 0

            };
            button.Clicked += CatBtn_Clicked;
            return button;
        }

        private Button CreateBtnHistory()
        {
            Button button = new Button
            {
                Text = "History  ",
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Opacity = 0
            };
            button.Clicked += HisBtn_Clicked;
            return button;
        }

        private Button CreateBtnAbout()
        {
            Button button = new Button
            {
                Text = "About us",
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Opacity = 0
            };
            button.Clicked += AboutBtn_Clicked;
            return button;
        }

        private Button CreateBtnContact()
        {
            Button button = new Button
            {
                Text = "Contact us",
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Opacity = 0
            };
            button.Clicked += ContactBtn_Clicked;
            return button;
        }

        private Button CreateBtnSettings()
        {
            Button button = new Button
            {
                Text = "Settings  ",
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Opacity = 0
            };
            button.Clicked += SetBtn_Clicked;
            return button;
        }

        private Button CreateBtnShare()
        {
            Button button = new Button
            {
                Text = "Share     ",
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Opacity = 0
            };
            button.Clicked += ShareBtn_Clicked;
            return button;
        }

        private Button CreateLogOutBtn()
        {
            Button button = new Button
            {
                Text = "Log out",
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.End
            };
            button.Clicked += LogoutBtn_Clicked;
            return button;
        }


        //BUTTONS. ADD WHAT TO DO INSIDE

        private void CatBtn_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new Page1());
        }

        private void HisBtn_Clicked(object sender, EventArgs e)
        {
           // Navigation.PushModalAsync(new Page2());
        }


        private void AboutBtn_Clicked(object sender, EventArgs e)
        {
            //Navigation.Pop
        }

        private void ContactBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void SetBtn_Clicked(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Strings er der for fremtiden. Hvis nu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShareBtn_Clicked(object sender, EventArgs e)
        {
            string mail = "mailto:";
            string subject = "?subject=Leftovers";
            string body = "&body=Try out this new app from leftovers. www.Google.dk";
            Device.OpenUri(new Uri(mail + subject + body));
        }

        private void LogoutBtn_Clicked(object sender, EventArgs e)
        {

        }

    }
}