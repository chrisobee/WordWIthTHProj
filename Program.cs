using System;

namespace WordWithTH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in substring to search for");
            var substringToFind = Console.ReadLine();
            SubstringIsolater find = new SubstringIsolater(substringToFind);

            var wordsContainingSubstring = find.ReturnStringsContainingSubstring();

            foreach(string word in wordsContainingSubstring)
            {
                Console.WriteLine(word);
            }
        }
    }
}
