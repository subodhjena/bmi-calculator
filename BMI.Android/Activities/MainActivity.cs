﻿using System;
using System.Globalization;

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using V4Fragment = Android.Support.V4.App.Fragment;

using BMI.Android.Fragments;

namespace BMI.Android.Activities
{
    [Activity(Label = "BMI Calculator", MainLauncher = true, Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        EditText AgeTextField;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_Main);

            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            AgeTextField = FindViewById<EditText>(Resource.Id.txtAge);

            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "BMI Calculator";

            Button showCalculation = FindViewById<Button>(Resource.Id.btnCalculate);
            showCalculation.Click += delegate
            {
                ShowResultsDialog();
            };
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
          
            // Lets check if the dialog is already displaying
            V4Fragment fragment = SupportFragmentManager.FindFragmentByTag("BMIResultDialog");
            if (fragment != null)
            {
                fragmentTrans.Remove(fragment);
            }
            fragmentTrans.AddToBackStack(null);

            // Create and Show the Dialog
            ResultDialogFragment resultDialog = ResultDialogFragment.NewInstance(null);
            resultDialog.BMIValue = float.Parse(AgeTextField.Text, CultureInfo.InvariantCulture);
            resultDialog.Show(fragmentTrans, "BMIResultDialog");
        }
    }
}


