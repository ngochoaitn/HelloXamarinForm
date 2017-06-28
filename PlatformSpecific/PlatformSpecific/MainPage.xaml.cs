using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlatformSpecific
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGetPlatform_Clicked(object sender, EventArgs e)
        {
            if (Device.RuntimePlatform =="Android")
                lblPlatform.Text = "Android";
            else if (Device.RuntimePlatform == "iOS")
                lblPlatform.Text = "iOS";
            else
                lblPlatform.Text = Device.RuntimePlatform;

            //Cách 2: dùng DepenceyService
            Debug.WriteLine(string.Format("Dependency >> {0}", DependencyService.Get<IPlatform>().GetPlatform()));
        }
    }
}
