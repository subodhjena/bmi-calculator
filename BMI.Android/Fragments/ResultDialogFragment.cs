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

            // Set Properties
            EmotionImageView.SetImageResource(Resource.Drawable.underweight);
            NameTextView.Text = "SUBODH,";
            ResultTextView.Text = "22.5";
            Message1TextView.Text = "You are perfectly Healthy";
            Message2TextView.Text = "Enjoy your life and Stay healthy";
            ActionButton.Click += (object sender, EventArgs e) =>
            {
                DismissDialog();
            };

            return view;
        }

        private void DismissDialog()
        {
            Dismiss();
        }
    }
}

