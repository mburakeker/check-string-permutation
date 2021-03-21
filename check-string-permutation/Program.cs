using System;

namespace check_string_permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringHelper.CheckPermutation("baba", "abab"));
            Console.WriteLine(StringHelper.CheckPermutation("baba", "abc"));
            Console.WriteLine(StringHelper.CheckPermutation("lds", "loodos"));
        }
    }
}
