using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "bU tasKI metHodla yAzmAliSiz";
            string str1 = str.ToLower();

            string[] substr1 = str1.Split(' ');
            foreach (var sub in substr1)
            {
                Console.WriteLine($"substring: {sub}");
            }

            //string str2 = str1.ToTitleCase();
            //Console.WriteLine(str2);
        }
    }
}
