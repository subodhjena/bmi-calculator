using System;
using System.Globalization;

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;

using Android.Support.V7.App;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using V4Fragment = Android.Support.V4.App.Fragment;

using BMI.Android.Fragments;

using BMI.Core.Models;
using BMI.Core.Services;

namespace BMI.Android.Activities
{
    [Activity(Label = "BMI Calculator", MainLauncher = true, Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        private ICalculation _calculation;
        private float _bmiValue;

        private EditText _ageTextField;
        private EditText _nameTextField;
        private TextView _bmiResultTextField;
        private EditText _weightTextField;
        private EditText _heightFeetTextField;
        private EditText _heightInchesTextField;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Activity_Main);

            // Initialize the calculation object
            _calculation = new Calculation();

            var toolbar = FindViewById<V7Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "BMI Calculator";

            // Bind the UI elements
            _nameTextField = FindViewById<EditText>(Resource.Id.txtName);
            _ageTextField = FindViewById<EditText>(Resource.Id.txtAge);
            _weightTextField = FindViewById<EditText>(Resource.Id.txtWeight);
            _heightInchesTextField = FindViewById<EditText>(Resource.Id.txtHeightInches);
            _heightFeetTextField = FindViewById<EditText>(Resource.Id.txtHeightFeet);
            _bmiResultTextField = FindViewById<TextView>(Resource.Id.txtBMIResult);

            Button showCalculation = FindViewById<Button>(Resource.Id.btnCalculate);
            showCalculation.Click += delegate
            {
                CalculateBMIVlaue();
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

        private void CalculateBMIVlaue()
        {
            // Create the person object
            var person = new Person()
            {
                name = _nameTextField.Text,
                age = int.Parse(_ageTextField.Text),
                weight = int.Parse(_weightTextField.Text),
                sex = 'm',
                feet = int.Parse(_heightFeetTextField.Text),
                inches = int.Parse(_heightInchesTextField.Text)
            };
            _bmiValue = _calculation.BMIValue(person);

            // Assign it to Result View
            _bmiResultTextField.Text = _bmiValue.ToString();
        }

        private void ShowResultsDialog()
        {
            // Show the Dialog
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
            resultDialog.BMIValue = _bmiValue;
            resultDialog.Show(fragmentTrans, "BMIResultDialog");
        }
    }
}


