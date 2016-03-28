using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

using V7AppCompatDialogFragment = Android.Support.V7.App.AppCompatDialogFragment;

namespace BMI.Android.Fragments
{
    public class ResultDialogFragment : V7AppCompatDialogFragment
    {
        private int _bmiValue;
        public int BMIValue
        {
            get { return _bmiValue;}
            set{ _bmiValue = value;}
        }

        private ImageView EmotionImageView;
        private TextView NameTextView;
        private TextView ResultTextView;
        private TextView Message1TextView;
        private TextView Message2TextView;
        private Button ActionButton;


        public ResultDialogFragment()
        {
        }

        public static ResultDialogFragment NewInstance(Bundle bundle)
        {
            ResultDialogFragment dialogFragment = new ResultDialogFragment();
            dialogFragment.Arguments = bundle;
            return dialogFragment;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Dialog_BMIResult, container, false);

            EmotionImageView = view.FindViewById<ImageView>(Resource.Id.imgEmotion);
            NameTextView = view.FindViewById<TextView>(Resource.Id.txtName);
            ResultTextView = view.FindViewById<TextView>(Resource.Id.txtResult);
            Message1TextView = view.FindViewById<TextView>(Resource.Id.txtMessage1);
            Message2TextView = view.FindViewById<TextView>(Resource.Id.txtMessage2);
            ActionButton = view.FindViewById<Button>(Resource.Id.btnOk);


            ActionButton.Click += (object sender, EventArgs e) =>
                {
                    DismissDialog();
                };

            InitializeResultDialog();

            return view;
        }

        private void InitializeResultDialog()
        {
            // Set Properties
            NameTextView.Text = "SUBODH,";
            ResultTextView.Text = _bmiValue.ToString();

            if (_bmiValue < 18.5)
            {
                // Underweight
                EmotionImageView.SetImageResource(Resource.Drawable.underweight);
                Message1TextView.Text = "You are Underweight";
                Message2TextView.Text = "Eat some food bro";

            }
            else if (_bmiValue >= 18.5 && _bmiValue <= 24.9)
            {
                // Normal Weight
                EmotionImageView.SetImageResource(Resource.Drawable.normal);
                Message1TextView.Text = "You are perfectly Healthy";
                Message2TextView.Text = "Enjoy your life and Stay healthy";
                
            }
            else if (_bmiValue >= 25 && _bmiValue <= 29.9)
            {
                // Overweight
                EmotionImageView.SetImageResource(Resource.Drawable.overweight);
                Message1TextView.Text = "You are Overweight";
                Message2TextView.Text = "Have some control on your diet buddy";
            }
            else if (_bmiValue >= 30)
            {
                // Obesity
                EmotionImageView.SetImageResource(Resource.Drawable.overweight);
                Message1TextView.Text = "OMG, You are More than Overweight";
                Message2TextView.Text = "Go, See a doctor ASAP";
                
            }
        }

        private void DismissDialog()
        {
            Dismiss();
        }
    }
}

