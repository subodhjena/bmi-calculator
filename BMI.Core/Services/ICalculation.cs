using System;

namespace BMI.Core.Services
{
    public interface ICalculation
    {
        int BMIValue(int feet, int inches, int age, int weight);
    }
}

