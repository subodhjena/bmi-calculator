using System;

using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using BMI.Core.Services;
using BMI.Core.ViewModels;

namespace BMI.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<BMIViewModel>());
        }
    }
}

