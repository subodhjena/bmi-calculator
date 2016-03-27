using System;

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using V7AlertDialog = Android.Support.V7.App.AlertDialog;

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
            FragmentTransaction ft = FragmentManager.BeginTransaction();
            //Remove fragment else it will crash as it is already added to backstack
            Fragment prev = FragmentManager.FindFragmentByTag("dialog");
            if (prev != null) {
                ft.Remove(prev);
            }

            ft.AddToBackStack(null);

            // Create and show the dialog.
            ResultDialogFragment newFragment = ResultDialogFragment.NewInstance(null);

            //Add fragment
            newFragment.Show(ft, "dialog");
        }
    }
}


