using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leftover
{
    [System.ComponentModel.Localizable(true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contact : ContentPage
    {
        Editor userName = new Editor();
        Editor lastName = new Editor();
        Editor title = new Editor();
        Editor message = new Editor();
        ScrollView scroll = new ScrollView();
        StackLayout ContactStack = new StackLayout();
      
        public Contact()
        {
            InitializeComponent();


            //ContactStack = new StackLayout();
          
           // ContactStack.Children.Add(Scroller());
            ContactStack.Children.Add(Name());
            ContactStack.Children.Add(LastName());
            ContactStack.Children.Add(Title());
            ContactStack.Children.Add(Message());
            ContactStack.Children.Add(Message2());

            //ContactStack.Children.Add(Message2());



            // var absoluteLay = new AbsoluteLayout();

            //absoluteLay.Children.Add(ContactStack);

            scroll.Content = ContactStack;
            //this.Content = Scroller();
            Content = scroll;
            
           // scroll.Content = ContactStack;


        }
        public ScrollView Scroller()
        {
            scroll = new Xamarin.Forms.ScrollView
            {
                Orientation = ScrollOrientation.Vertical,
                Content = ContactStack,
                WidthRequest = Application.Current.MainPage.Width - 100,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.EndAndExpand,
                BackgroundColor = Color.Black
            };

            return scroll;
        }
        public Editor Name()
        {
            Editor userName = new Editor
            {
                Text = "Name:",
                Keyboard = Keyboard.Default,
                BackgroundColor = Color.Beige,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 60,
                WidthRequest = Application.Current.MainPage.Width - 50

            };
            return userName;
        }
        public Editor LastName()
        {
            Editor lastName = new Editor
            {
                Text = "Last name:",
                Keyboard = Keyboard.Default,
                BackgroundColor = Color.Beige,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 60,
                WidthRequest = Application.Current.MainPage.Width - 50
            };
            return lastName;
        }
        public Editor Title()
        {
            Editor title = new Editor
            {
                Text = "Title:",
                Keyboard = Keyboard.Default,
                BackgroundColor = Color.Beige,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HeightRequest = 60,
                WidthRequest = Application.Current.MainPage.Width - 50

            };
            return title;
        }
        public Editor Message()
        {
            Editor Message = new Editor
            {
                Text = "Write your message here:",
                
                Keyboard = Keyboard.Default,
                BackgroundColor = Color.Beige,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HeightRequest = 200,
                WidthRequest = Application.Current.MainPage.Width - 50
                
            };
            return Message;
        }
        public Editor Message2()
        {
            Editor message = new Editor
            {
                Text = "Write your message here:",

                Keyboard = Keyboard.Default,
                BackgroundColor = Color.Beige,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HeightRequest = 200,
                WidthRequest = Application.Current.MainPage.Width - 50

            };
            return message;
        }

    }
}