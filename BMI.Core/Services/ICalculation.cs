using System;

namespace BMI.Core.Services
{
    public interface ICalculation
    {
        float BMIValue(int feet, int inches, int age, int weight);
    }
}

