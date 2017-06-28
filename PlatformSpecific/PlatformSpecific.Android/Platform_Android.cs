using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using PlatformSpecific.Droid;

[assembly:Dependency(typeof(Platform_Android))
namespace PlatformSpecific.Droid
{
    public class Platform_Android : IPlatform
    {
        public string GetPlatform()
        {
            return "Android";
        }
    }
}