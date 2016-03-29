using System;

namespace BMI.Core.ViewModels
{
    public class BMIViewModel
    {
        public BMIViewModel()
        {
        }

        string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        float _bmiValue;

        public float BMIValue
        {
            get { return _bmiValue; }
            set
            {
                _bmiValue = value;
            }
        }

        int _feet;

        public int Feet
        {
            get { return _feet; }
            set
            {
                _feet = value;
            }
        }

        int _inches;

        public int Inches
        {
            get { return _inches; }
            set
            {
                _inches = value;
            }
        }

        int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }

        int _weight;

        public int Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
            }
        }
    }
}

