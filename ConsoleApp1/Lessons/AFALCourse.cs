using System;
namespace ConsoleApp1.Lessons
{
    public class  AFALCourse
    {
        public static void Test()
        {
            string name = "Mateusz";
            Console.WriteLine(name);
            name = "Ala";
            Console.WriteLine(name);
            name = name + "ma kota";
            Console.WriteLine(name);
            ExpandString(name, "hellow");
            Console.WriteLine(name);
            ExpandString(name, "world");
            Console.WriteLine(name);
            ExpandString(name, "something");
            Console.WriteLine(name);
        }
        public static string ExpandString(string word, string extension)
        {
            word = word + extension;
        }
        public static void ConcatenationTest()
        {
            string word1 = "Ala ma ";
            string word2 = "koty daw ";

            string concat1 = word1 + word2;
            string concat2 = word1 + " " + word2;
            //string interpolation
            string concat3 = $"{word1}{word2} idobrze sie ma";
            Console.WriteLine(concat3);
        }
    }
}
