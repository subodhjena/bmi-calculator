using System;

using UIKit;
using Foundation;

using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;

using BMI.Core.ViewModels;

namespace BMI.iOS
{
    public partial class MainViewController : MvxViewController
    {
        public MainViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad ()
        {
            this.Request = new MvxViewModelRequest<BMIViewModel>(null, null, new MvxRequestedBy());
            base.ViewDidLoad ();

            this.CreateBinding(NameTextField).To<BMIViewModel>(vm => vm.Name).Apply();
            this.CreateBinding(BMIResultLabel).To<BMIViewModel>(vm => vm.BMIValue).Apply();
            this.CreateBinding(FeetTextField).To<BMIViewModel>(vm => vm.Feet).Apply();
            this.CreateBinding(InchesTextField).To<BMIViewModel>(vm => vm.Inches).Apply();
            this.CreateBinding(WeightTextField).To<BMIViewModel>(vm => vm.Weight).Apply();
            this.CreateBinding(AgeTextField).To<BMIViewModel>(vm => vm.Age).Apply();
        }
            
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

