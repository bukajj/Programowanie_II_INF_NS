using System;

namespace Bayt1
{
    public class Program
    {
        internal static bool CheckLength(string s1, string s2)
        {
            return s1.Length == s2.Length ? true : false;
        }

        internal static bool CheckLetterCase(string s1, string s2)
        {
            return String.Equals(s1.ToLower(), s2.ToLower()) ? true : false;
        }

        internal static string StringSort(string s)
        {
            char[] tab = s.ToCharArray();
            Array.Sort(tab);
            return new string(tab);
        }

        internal static bool CheckOrder(string s1, string s2)
        {
            return String.Equals(StringSort(s1), StringSort(s2)) ? true : false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszy łańcuch");
            string s1 = Console.ReadLine();
            Console.WriteLine("Podaj drugi łańcuch");
            string s2 = Console.ReadLine();
        }
    }
}
