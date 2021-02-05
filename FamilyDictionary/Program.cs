using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Anni" }, { "age", "24" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Molly" }, { "age", "65" } });
            myFamily.Add("dad", new Dictionary<string, string>() { { "name", "Mitch" }, { "age", "67" } });
            myFamily.Add("wife", new Dictionary<string, string>() { { "name", "Dani" }, { "age", "28" } });
            myFamily.Add("dog", new Dictionary<string, string>() { { "name", "Pepper" }, { "age", "2" } });

            foreach (var (relationship, info) in myFamily)
            {
                var infoList = new List<string>();
                foreach (var fact in info)
                {
                    infoList.Add(fact.Value);
                }
                Console.WriteLine($"{infoList[0]} is my {relationship} and is {infoList[1]} years old.");
            }
        }
    }
}
