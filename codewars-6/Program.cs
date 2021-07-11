using System;
using System.Linq;
namespace codewars_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abracadabra";
        }
        public static int GetVowelCount(string str)
        {
            var strGL = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var vowelCount = str.Count(s => strGL.Contains(s));
            return vowelCount;
        }
    }
}
