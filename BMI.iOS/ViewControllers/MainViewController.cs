using System;

using UIKit;
using Foundation;
using CoreGraphics;

using BMI.Core.ViewModels;

namespace BMI.iOS
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            InitializePaperElements();

            /*
            this.CreateBinding(NameTextField).To<BMIViewModel>(vm => vm.Name).Apply();
            this.CreateBinding(BMIResultLabel).To<BMIViewModel>(vm => vm.BMIValue).Apply();
            this.CreateBinding(FeetTextField).To<BMIViewModel>(vm => vm.Feet).Apply();
            this.CreateBinding(InchesTextField).To<BMIViewModel>(vm => vm.Inches).Apply();
            this.CreateBinding(WeightTextField).To<BMIViewModel>(vm => vm.Weight).Apply();
            this.CreateBinding(AgeTextField).To<BMIViewModel>(vm => vm.Age).Apply();
            */
        }
            
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void InitializePaperElements()
        {
            // Border Card 1
            Card1View.Layer.BorderColor = UIColor.LightGray.CGColor;
            Card1View.Layer.BorderWidth = 1.0f;

            // Border Card 2
            Card2View.Layer.BorderColor = UIColor.LightGray.CGColor;
            Card2View.Layer.BorderWidth = 1.0f;

            // Drop Shadow Card 1
            Card1View.Layer.ShadowColor = UIColor.Red.CGColor;
            Card1View.Layer.ShadowOpacity = 0.5f;
            Card1View.Layer.ShadowRadius = 1.0f;
            //Card1View.Layer.ShadowOffset = CGSize(2.0f, 2.0f);

            // Drop Shadow Card 2
            Card2View.Layer.ShadowColor = UIColor.Red.CGColor;
            Card2View.Layer.ShadowOpacity = 0.5f;
            Card2View.Layer.ShadowRadius = 1.0f;
            //Card2View.Layer.ShadowOffset = CGSize(2.0f, 2.0f);
        }

        // Actions 

        partial void TappedShowResult(NSObject sender)
        {
            Console.WriteLine("Yo Yo");
        }

        partial void TappedOnSettings(NSObject sender)
        {
            Console.WriteLine("Yo Yo Yo");
        }
    }
}

