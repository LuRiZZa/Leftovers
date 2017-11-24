﻿
using Android.Views;
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

        ScrollView descriptionScroll;
        ScrollView scroller;
        Label descriptionLabel;
        Grid stackL = new Grid();
        //public double fisse;
        List<ContentPage> listConView = new List<ContentPage>();

        //BoxView boxView;
        public Food()
        {
            InitializeComponent();

            ContentPresenter p;



            AbsoluteLayout al = new AbsoluteLayout()
            {
                WidthRequest = Application.Current.MainPage.Width,
            BackgroundColor = Color.White,
            //HorizontalOptions = LayoutOptions.Center,
           // VerticalOptions = LayoutOptions.Center
            };
            string style = "Rectangle";

            
           BoxView boxView = new BoxView
            {
                
                BackgroundColor = Color.Green,
                WidthRequest = 50,
                HeightRequest = 20
                //HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center

            };
            AbsoluteLayout.SetLayoutBounds(boxView, new Rectangle( .10, .10, 1, 1));
            AbsoluteLayout.SetLayoutFlags(boxView, AbsoluteLayoutFlags.All);


            descriptionLabel = new Label
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean pellentesque libero ut ligula eleifend placerat. Morbi quam velit, sollicitudin eu ipsum non, vestibulum auctor purus. In volutpat urna non est sollicitudin sollicitudin. Quisque ornare ante sed velit tristique, quis dignissim nisi imperdiet. Nunc in ultricies massa, facilisis suscipit est. Pellentesque gravida tincidunt nisi, non mattis nisi euismod nec. Ut eu consectetur nisl. Nunc in faucibus orci, ac venenatis neque. Cras tristique, eros eu ultricies interdum, lacus felis hendrerit purus, et ultrices magna arcu et sapien. Morbi non justo sapien. Mauris egestas arcu vitae luctus laoreet. Proin posuere magna sit amet ex malesuada, id volutpat orci dictum. Mauris tempor eget leo et sagittis. Vivamus risus mi, ullamcorper id nibh vel, pretium porttitor arcu. Nullam ut egestas velit. Fusce lacus tortor, ullamcorper volutpat tincidunt at, imperdiet vitae lectus.",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Font)),
                //FontSize = 30,
                TextColor = Color.Blue,
                //VerticalOptions = LayoutOptions.Center,
                //HorizontalOptions = LayoutOptions.End,
                //HeightRequest = 300,
                //WidthRequest = Application.Current.MainPage.Width - 50
            };
            
            AbsoluteLayout.SetLayoutBounds(descriptionLabel, new Rectangle(.10, .10, 1, 1));
            AbsoluteLayout.SetLayoutFlags(descriptionLabel, AbsoluteLayoutFlags.All);

            scroller = new Xamarin.Forms.ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                HeightRequest = 300,
                WidthRequest = Application.Current.MainPage.Width - 50
            };

            
            AbsoluteLayout.SetLayoutBounds(scroller, new Rectangle(.10, .10, 1, 1));
            AbsoluteLayout.SetLayoutFlags(scroller, AbsoluteLayoutFlags.All);
            //scroller.Content = al;
       

            al.Children.Add(boxView);
            //al.Children.Add(descriptionLabel);
            al.Children.Add(scroller);
            for (int i = 0; i < al.Children.Count; i++)
            {
                al.Children[i].ScaleTo(0.5f, 250, Easing.BounceIn);
                //al.Children[i].HeightRequest = (Application.Current.MainPage.Height * 0.5f);
                //al.Children[i].WidthRequest = (Application.Current.MainPage.Width * 0.5f) ;
            }

            scroller.Content = descriptionLabel;
           // scroller.Content = al.Children[1];
            
            this.Content = al;
            //this.Content = scroller;
            // this.Content = scroller;
            //BoxView box = new BoxView()
            //{
            //    Color = Color.Green,
            //    WidthRequest = Application.Current.MainPage.Width - 50,
            //    HeightRequest = 300,
            //    //TranslationY = + HeightRequest,
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.End,
            //};





            //StackLayout stack = new StackLayout
            //{
            //    Children =
            //    {
            //        box,
            //        descriptionLabel,

            //    }
            //};




            //scroller.Content = box;
            //this.Content = stack;
            //this.Content = scroller;
            //fisse = descriptionLabel.Width;
            //App.Current.MainPage = new ContentPage()
            //{
            //    Content = new ContentView
            //    {
            //        Content = new Label
            //        {
            //            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean pellentesque libero ut ligula eleifend placerat. Morbi quam velit, sollicitudin eu ipsum non, vestibulum auctor purus. In volutpat urna non est sollicitudin sollicitudin. Quisque ornare ante sed velit tristique, quis dignissim nisi imperdiet. Nunc in ultricies massa, facilisis suscipit est. Pellentesque gravida tincidunt nisi, non mattis nisi euismod nec. Ut eu consectetur nisl. Nunc in faucibus orci, ac venenatis neque. Cras tristique, eros eu ultricies interdum, lacus felis hendrerit purus, et ultrices magna arcu et sapien. Morbi non justo sapien. Mauris egestas arcu vitae luctus laoreet. Proin posuere magna sit amet ex malesuada, id volutpat orci dictum. Mauris tempor eget leo et sagittis. Vivamus risus mi, ullamcorper id nibh vel, pretium porttitor arcu. Nullam ut egestas velit. Fusce lacus tortor, ullamcorper volutpat tincidunt at, imperdiet vitae lectus."
            //        }
            //    }
            //};

            //this.Content = stackL.Content

            //stackL.RowDefinitions.Add(new RowDefinition { Height = new GridLength(5, GridUnitType.Auto) });
            //stackL.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(Application.Current.MainPage.Width) });

            //stackL.Children.Add(DescriptionBox(scroller, descriptionLabel), 0, 0);

            //stackL.Children.Add(descriptionLabel, 0, 0);

            //scroller.Content = stackL;
            //this.Content = stackL;
            // this.Content = scroller;








        }

        //protected override void LayoutChildren(double x, double y, double width, double height)
        //{
        //    base.LayoutChildren(x, y, width, height);
        //}

        //public BoxView DescriptionBox(ScrollView scroll, Label lbl)
        //{

        //    boxView = new BoxView()
        //    {
        //        Color = Color.Green,
        //        WidthRequest = Application.Current.MainPage.Width - 50,
        //        HeightRequest = 300,
        //        //TranslationY = + HeightRequest,
        //        HorizontalOptions = LayoutOptions.Center,
        //        VerticalOptions = LayoutOptions.End,
        //    };

        //    descriptionLabel.TranslateTo(boxView.X, boxView.Y, 250, Easing.BounceIn);

        //    //scroll = descriptionScroll;
        //    //scroller.Content = scroll;

        //    scroll.Content = lbl;
        //    this.Content = lbl;
        //    scroll.IsClippedToBounds = true;
        //    this.Content = scroll;
        //    //scroll.Content = boxView;
        //    return boxView;
        //}


    }
}