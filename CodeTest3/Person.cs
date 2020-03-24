using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest3
{
    class Person
    {
        public Person(int iAge, double iHeight, double iWeight, string iFName, string iLName)
        {
            age = iAge;
            height = iHeight;
            weight = iWeight;
            fName = iFName;
            lName = iLName;
        }
        private int age;
        private double height;
        private double weight;
        private string fName;
        private string lName;

        public int Age { get => age; set => age = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }

    }
}

