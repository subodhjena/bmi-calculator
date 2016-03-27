using System;

namespace BMI.Core.Services
{
    public class Calculation : ICalculation
    {
        public Calculation()
        {
        }

        public float BMIValue(int feet, int inches, int age, int weight)
        {
            float height = (inches / 12) + feet;
            return weight / height;
        }
    }
}

