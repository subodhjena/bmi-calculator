using System;
using BMI.Core.Models;

namespace BMI.Core.Services
{
    public interface ICalculation
    {
        float BMIValue(Person person);
    }
}

