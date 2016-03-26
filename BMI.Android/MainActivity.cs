using System;

using Android.App;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;

namespace BMI.Android
{
    [Activity(Label = "BMI", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);
            SetContentView (Resource.Layout.Main);

            var toolbar = FindViewById<V7Toolbar> (Resource.Id.toolbar);

            SetSupportActionBar (toolbar);
            SupportActionBar.Title = "BMI Calculator";
        }
    }
}


