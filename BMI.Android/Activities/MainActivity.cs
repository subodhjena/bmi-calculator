using System;

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;

namespace BMI.Android.Activities
{
    [Activity(Label = "BMI", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);
            SetContentView (Resource.Layout.Activity_Main);

            var toolbar = FindViewById<V7Toolbar> (Resource.Id.toolbar);

            SetSupportActionBar (toolbar);
            SupportActionBar.Title = "BMI Calculator";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.main_menu, menu);
            return base.OnPrepareOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            switch (item.ItemId)
            {
                case Resource.Id.action_settings:
                    StartSettingsActity();
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void StartSettingsActity()
        {
            StartActivity(typeof(SettingsActivity));
        }
    }
}


