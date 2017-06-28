using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using PlatformSpecific.iOS;

[assembly:Dependency(typeof(Platform_IOS))]
namespace PlatformSpecific.iOS
{
    public class Platform_IOS : IPlatform
    {
        public string GetPlatform()
        {
            return "iOS";
        }
    }
}