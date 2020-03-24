using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest3
{
    class PersonHandler
    {
        public PersonHandler()
        {

        }
        public void SetAge(Person pres, int age)
        {
            pres.Age = age;
        }

        public Person CreatePerson(int age, double height, double weight, string fname, string lname)
        {
            return new Person(age, height, weight, fname, lname);
        }


        internal string PersonStats(Person pers)
        {

            return $" Age: {pers.Age}\n Height: {pers.Height}\n Weight: {pers.Weight}\n First Name: {pers.FName}\n Last Name: {pers.LName}";
        }

    }
}
