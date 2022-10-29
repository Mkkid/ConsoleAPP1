using ConsoleApp1.Lessons.Classes;

namespace ConsoleApp1.Lessons
{
    public class Class1
    {
        public static void Test()
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Race = "Golden";
            dog.Age = 12;
            dog.Jump();
            dog.Name = "Burek";
            Console.WriteLine("Attention here is dog " + dog.Name);
            Console.WriteLine("Race: " + dog.Race);
            Dog dogAzor = new Dog();
        }
        public static void Test2()
        {
            Dog westieDog = new Dog();
            westieDog.Race="WHWT";
            westieDog.Age=4;
            westieDog.Name="Azor";
            westieDog.Present();
            DogOffspringStats stats = westieDog.Breed();
            Console.WriteLine(westieDog.Add(2,3));
        }
        public static void WriteSomething()
        {
            Console.WriteLine("Somthing....");
        }
    }
}

