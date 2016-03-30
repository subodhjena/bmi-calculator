using System;
using BMI.Core.Models;

namespace BMI.Core.Services
{
    public class Calculation : ICalculation
    {
        public Calculation()
        {
        }

        public float BMIValue(Person person)
        {
            var heightInCentimeters = person.feet * 30.48;

            return (float)(person.weight / (heightInCentimeters * heightInCentimeters));
        }
    }
}

