using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlBasic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        int dem = 1;
        private void Button_Clicked(object sender, EventArgs e)
        {
            xlabel.Text = string.Format("Click {0} times", dem++);
        }
    }
}