using System;

using MvvmCross.Core.ViewModels;

using BMI.Core.Services;

namespace BMI.Core.ViewModels
{
    public class BMIViewModel : MvxViewModel
    {
        readonly ICalculation _calculation;

        public BMIViewModel(ICalculation calculation)
        {
            _calculation = calculation;
        }

        public override void Start()
        {
            base.Start();
            Recalcuate();
        }

        int _bmiValue;
        public int BMIValue
        {
            get { return _bmiValue; }
            set
            {
                _bmiValue = value;
                RaisePropertyChanged(() => BMIValue);
                Recalcuate();
            }
        }

        int _feet;
        public int Feet {
            get { return _feet; }
            set
            {
                _feet = value;
                RaisePropertyChanged(() => Feet);
                Recalcuate();
            }
        }

        int _inches;
        public int Inches {
            get { return _inches; }
            set
            {
                _inches = value;
                RaisePropertyChanged(() => Inches);
                Recalcuate();
            }
        }

        int _age;
        public int Age {
            get { return _age; }
            set
            {
                _age = value;
                RaisePropertyChanged(() => Age);
                Recalcuate();
            }
        }

        int _weight;
        public int Weight {
            get { return _weight; }
            set
            {
                _weight = value;
                RaisePropertyChanged(() => Weight);
                Recalcuate();
            }
        }

        void Recalcuate()
        {
            BMIValue = _calculation.BMIValue(Feet, Inches, Age, Weight);
        }
    }
}

