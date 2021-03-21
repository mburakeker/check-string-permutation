using System;
using System.Collections.Generic;
using System.Text;

namespace check_string_permutation
{
    public static class StringHelper
    {
        public static bool CheckPermutation(string firstWord, string secondWord)
        {
            var firstWordDict = firstWord.ToCharCountKeyValuePair();
            var secondWordDict = secondWord.ToCharCountKeyValuePair();

            var oneOfThePermutationOfFirstWordEqualsToSecondWord = true;
            foreach (var (key, val) in firstWordDict)
            {
                try
                {
                    if (secondWordDict[key] < firstWordDict[key])
                    {
                        oneOfThePermutationOfFirstWordEqualsToSecondWord = false;
                    }
                }
                catch (KeyNotFoundException)
                {
                    oneOfThePermutationOfFirstWordEqualsToSecondWord = false;
                }
            }

            var oneOfThePermutationOfSecondWordEqualsToFirstWord = true;
            foreach (var (key, val) in secondWordDict)
            {
                try
                {
                    if (firstWordDict[key] < secondWordDict[key])
                    {
                        oneOfThePermutationOfSecondWordEqualsToFirstWord = false;
                    }
                }
                catch (KeyNotFoundException)
                {
                    oneOfThePermutationOfSecondWordEqualsToFirstWord = false;
                }
            }

            return oneOfThePermutationOfFirstWordEqualsToSecondWord || oneOfThePermutationOfSecondWordEqualsToFirstWord;
        }
        public static Dictionary<char, int> ToCharCountKeyValuePair(this string str)
        {
            var charCountKvp = new Dictionary<char, int>();
            foreach (char character in str)
            {
                if (!charCountKvp.ContainsKey(character))
                {
                    charCountKvp[character] = 0;
                }
                charCountKvp[character] += 1;
            }
            return charCountKvp;
        }
    }
}
