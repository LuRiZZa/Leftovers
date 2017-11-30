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
        public Image Image { get; set; }

        Grid grid = new Grid();

        ListView lv = new ListView();
        List<Grid> lGrid = new List<Grid>();

        public Contact()
        {
            InitializeComponent();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(99) });

            StackLayout stLayout = new StackLayout();
            stLayout.Children.Add(LvView());

            grid.Children.Add(ImagCell(),0,2,0,2);
            grid.Children.Add(Contactlbl("silvio", 10101010, "sili@sili.dk"),2,3,0,1);
            for (int i = 0; i <=4 ; i++)
            {
                lGrid.Add(grid);
            }
            
            lv = new ListView();
            lv.ItemsSource = lGrid;
            lv.RowHeight = 100;


            lv.ItemTemplate = new DataTemplate(() =>
            {
                //ImagCell();
                //Contactlbl("silvio", 10101010, "sili@sili.dk");


                //foreach (var item in lGrid)
                //{
                //    item.TranslationX = 20;
                //}

                return new ViewCell()
                {
                    View = grid
                };
            });


            

            // grid.Children.Add(Image);

            this.Content = lv;



        }
        public Label Contactlbl(string name, int tlfnr, string Email)
        {


            Label lbl = new Label
            {
                Text = "Navn:" + name + "\n" + "Tlf.Nr:" + tlfnr + "\n" + "Email:" + Email + "\n",

            };
            // Image.Source = "FoodImage1";

            return lbl;
        }
        public ListView LvView()
        {
            lv = new ListView()
            {
                RowHeight = 200,

            };

            return lv;
        }
        public Image ImagCell()
        {
            Image imgcell = new Image
            {
                Source = "FoodImage1",
                //HorizontalOptions = LayoutOptions.Start,

            };
            return imgcell;
        }

    }
}