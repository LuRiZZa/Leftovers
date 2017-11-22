using Android.Widget;
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
		public Food ()
		{
			InitializeComponent ();

            var stackL = new StackLayout();

            stackL.Children.Add(TextDescriptionLabel());

            this.Content = stackL;


		}
        public Label TextDescriptionLabel()
        {
            Label descriptionLabel = new Label
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean pellentesque libero ut ligula eleifend placerat. Morbi quam velit, sollicitudin eu ipsum non, vestibulum auctor purus. In volutpat urna non est sollicitudin sollicitudin. Quisque ornare ante sed velit tristique, quis dignissim nisi imperdiet. Nunc in ultricies massa, facilisis suscipit est. Pellentesque gravida tincidunt nisi, non mattis nisi euismod nec. Ut eu consectetur nisl. Nunc in faucibus orci, ac venenatis neque. Cras tristique, eros eu ultricies interdum, lacus felis hendrerit purus, et ultrices magna arcu et sapien. Morbi non justo sapien. Mauris egestas arcu vitae luctus laoreet. Proin posuere magna sit amet ex malesuada, id volutpat orci dictum. Mauris tempor eget leo et sagittis. Vivamus risus mi, ullamcorper id nibh vel, pretium porttitor arcu. Nullam ut egestas velit. Fusce lacus tortor, ullamcorper volutpat tincidunt at, imperdiet vitae lectus.",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            
            };
            return descriptionLabel;
        }

	}
}