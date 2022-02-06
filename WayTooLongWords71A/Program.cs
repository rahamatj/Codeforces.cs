using System;

namespace WayTooLongWords71A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while(n-- > 0)
            {
                string word = Console.ReadLine();

                if (word.Length > 10)
                    Console.WriteLine(word[0] + (word.Length - 2).ToString() + word[word.Length - 1]);
                else
                    Console.WriteLine(word);
            }
        }
    }
}
