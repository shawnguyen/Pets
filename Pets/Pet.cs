using System;
namespace Pets
{
    class Pet
    {
        protected string type;
        protected string name;
        protected string owner;
        protected string lost = "";
        protected double weight;

        public void MakePet(string pType, string pName, string pOwner, double pWeight)
        {
            type = pType;
            name = pName;
            owner = pOwner;
            weight = pWeight;
        }

        public string Name()
        {
            return name;
        }

        public string Owner()
        {
            return owner;
        }

        public double Weight()
        {
            return weight;
        }

        public string GetTag()
        {
            Console.WriteLine($"If lost, call {owner}");
            return lost;
        }
    }
}
