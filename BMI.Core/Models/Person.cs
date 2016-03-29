using System;

namespace BMI.Core.Models
{
    public class Person
    {
        public string name;
        public char sex;
        public int weight;
        public int age;
        public int feet;
        public int inches;
        
        public Person()
        {
            name = "Unknown";
            sex = 'm';
            age = 0;
            feet = 0;
            inches = 0;
            weight = 0;
        }
    }
}

