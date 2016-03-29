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
            // Do some calculation with the person object
            return (float)person.age;
        }
    }
}

