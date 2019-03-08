using System;
namespace Pets
{
    class Dog : Pet
    {
        public void MakeDog(string pName, string pOwner, double pWeight)
        {
            name = pName;
            owner = pOwner;
            weight = pWeight;
        }

        public string Bark(int count)
        {
            string sound = "Bark!";
            string blank = "";
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(sound);
            }
            return blank;
        }
    }
}
