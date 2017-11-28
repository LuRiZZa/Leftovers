using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Leftover
{
	public partial class MainPage : MasterDetailPage
    {
        public Page p;

        public MainPage()
        {

            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());

        }
        

        
        
    }
}
