using System;

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using V7AlertDialog = Android.Support.V7.App.AlertDialog;
using V4Fragment = Android.Support.V4.App.Fragment;

using BMI.Android.Fragments;

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

            Button showCalculation = FindViewById<Button>(Resource.Id.btnCalculate);
            showCalculation.Click += delegate{ShowResultsDialog();};
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

        private void ShowResultsDialog()
        {
            var fragmentTrans = SupportFragmentManager.BeginTransaction();
            V4Fragment fragment = SupportFragmentManager.FindFragmentByTag("dialog");
            if (fragment != null)
            {
                fragmentTrans.Remove(fragment);
            }
            fragmentTrans.AddToBackStack(null);

            // Create and Show the Dialog
            ResultDialogFragment resultDialog =  ResultDialogFragment.NewInstance(null);
            resultDialog.BMIValue = 40;
            resultDialog.Show(fragmentTrans, "dialog");
        }
    }
}


