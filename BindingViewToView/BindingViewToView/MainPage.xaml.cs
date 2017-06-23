using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindingViewToView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblBindingByCode.SetBinding(Label.TextProperty, "Value",  stringFormat:"By code: {0}");
            lblBindingByCode.BindingContext = sl1;
        }
    }
}
