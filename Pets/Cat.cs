using System;
namespace Pets
{
    class Cat : Pet
    {
        public void MakeCat(string pName, string pOwner, double pWeight)
        {
            name = pName;
            owner = pOwner;
            weight = pWeight;
        }

        public string Meow(int count)
        {
            string sound = "Meow.";
            string blank = "";
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(sound);
            }
            return blank;
        }
    }
}
