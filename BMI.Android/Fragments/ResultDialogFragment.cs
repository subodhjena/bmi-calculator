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
        public ResultDialogFragment()
        {
        }

        public static ResultDialogFragment NewInstance(Bundle bundle)
        {
            ResultDialogFragment dialogFragment = new ResultDialogFragment();
            dialogFragment.Arguments = bundle;
            return dialogFragment;
        }

        public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view =  inflater.Inflate(Resource.Layout.Temp, container, false);
            Button button = view.FindViewById<Button> (Resource.Id.CloseButton);
            button.Click += delegate {
                Dismiss();
                Toast.MakeText(Activity ,"Dialog fragment dismissed!" , ToastLength.Short).Show();
            };

            return view;
        }
    }
}

