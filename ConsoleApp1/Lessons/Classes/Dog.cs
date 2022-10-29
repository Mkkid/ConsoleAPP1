using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lessons.Classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public bool Gooddog;

        public void Jump()
        {
            Console.WriteLine("Boing! Boing!");
        }
        public void Bark()
        {
            Console.WriteLine("Woww!");
        }
        public void Am()
        {
            Console.WriteLine("am am");
        }
        public int GetOlderAge()
        {
            return Age + 1;
        }
        public void GrowOlder(int numberOfYears)
        {
            Age = Age + numberOfYears;
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public DogOffspringStats Breed()
        {
            DogOffspringStats stats = new DogOffspringStats();
            stats.NumberOfMalePups = 5;
            stats.NumberOfFemaiePups = 6;
            return stats;
        }
        public void Present()
        {
            Console.WriteLine("Attention here is dog " + Name);
            Console.WriteLine("Race: " + Race);
            Console.WriteLine("Is he good boy: "+Gooddog);
        }
    }
}
