using System;

using Android.App;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;

namespace BMI.Android.Activities
{
    [Activity(Label = "Settings")]
    public class SettingsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);
            SetContentView (Resource.Layout.Activity_Settings);

            var toolbar = FindViewById<V7Toolbar> (Resource.Id.toolbar);

            SetSupportActionBar (toolbar);
            SupportActionBar.Title = "Settings";
            SupportActionBar.SetDisplayHomeAsUpEnabled (true);
            SupportActionBar.SetHomeButtonEnabled (true);

        }
    }
}


