using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest3
{
    class Animal
    {
        public Animal(string animName, int animAge, double animWeight)
        {
            name = animName;
            age = animAge;
            weight = animWeight;
        }
        private string name;
        private int age;
        private double weight;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        // Create method Stats () class Animal having return type string.
        public virtual string Stats()
        {

            return $" Name: {name}\n Age: {age}\n Weight: {weight}\n ";
        }

    }
    class Horse : Animal
    {
        public Horse(string animName, int animAge, double animWeight, string animColor) : base(animName, animAge, animWeight)
        {
            HasColour = animColor;
        }
        public string HasColour { get; set; }

        public override string Stats() => base.Stats()
                                          + $" Has Color: {HasColour}";
    }
    class Dog : Animal
    {
        public Dog(string animName, int animAge, double animWeight, string bread) : base(animName, animAge, animWeight)
        {
            HasBreed = bread;
        }
        public string HasBreed { get; set; }
        // Create a new method with any name in the Dog class that returns only one string.
        public string Eats()
        {
            return "The puppy Eats bones";
        }
        public override string Stats()
        {
            return base.Stats() + $" Has Bread: {HasBreed}";
        }


    }
    class Hedgehog : Animal
    {
        public Hedgehog(string animName, int animAge, double animWeight, int spikes) : base(animName, animAge, animWeight)
        {
            NoOfSpikes = spikes;
        }
        public int NoOfSpikes { get; set; }

        public override string Stats()
        {
            return base.Stats() + $" Number Of Spikes: {NoOfSpikes}";
        }
    }
    class Worm : Animal
    {
        public Worm(string animName, int animAge, double animWeight, int nLega) : base(animName, animAge, animWeight)
        {
            NoOfLegs = nLega;
        }
        public int NoOfLegs { get; set; }

        public override string Stats()
        {
            return base.Stats() + $" Number Of Legs: {NoOfLegs}";
        }

    }
    class Bird : Animal
    {
        public Bird(string animName, int animAge, double animWeight) : base(animName, animAge, animWeight)
        {

        }
        public virtual void Wings()
        {
        }


    }

    class Pelican : Bird
    {
        public Pelican(string animName, int animAge, double animWeight, string cBeak) : base(animName, animAge, animWeight)
        {
            ColourOfBeak = cBeak;
        }
        public string ColourOfBeak { get; set; }

        public override string Stats()
        {
            return base.Stats() + $" Colour Of Beak: {ColourOfBeak}";
        }

    }

    class Flamingo : Bird
    {
        public Flamingo(string animName, int animAge, double animWeight, int lNeck) : base(animName, animAge, animWeight)
        {
            LengthOfNeck = lNeck;
        }
        public int LengthOfNeck { get; set; }

        public override string Stats()
        {
            return base.Stats() + $" Length Of the Neck: {LengthOfNeck}";
        }
    }

    class Swan : Bird
    {
        public Swan(string animName, int animAge, double animWeight, string cWings) : base(animName, animAge, animWeight)
        {
            ColourOfWings = cWings;
        }
        public string ColourOfWings { get; set; }

        public override string Stats()
        {
            return base.Stats() + $" Color of Wings: {ColourOfWings}";
        }
    }
}