using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class FunWithLinq
    {
        //member variables
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
        List<string> classGrades = new List<string>()
        {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
        };


        //ctor
        public FunWithLinq()
        {

        }

        //member methods

        public void HowToContainsMethod()
        {

            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Contains("th"))
                {
                    Console.WriteLine(words[i]);
                }
            }

        }


        public void HowToDuplicatesDemo()
        {
            List<string> distinct = names.Distinct().ToList();
            foreach (string el in distinct)
            {
                Console.WriteLine(el);
            }
        }


        public double CoolMethod()
        {
            List<double> averageSets = new List<double>();
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };
            foreach (string el in classGrades)
            {
                double gradeSet = ThisIsAMethod(el);
                averageSets.Add(gradeSet);
            }
            double sum = averageSets[0] + averageSets[1] + averageSets[2] + averageSets[3];
            double allAverage = sum / 4;
            return allAverage;
        }

        public double ThisIsAMethod(string el)
        {
            List<string> temp = new List<string>(el.Split(new char[] { ',' }));
            List<int> intList = new List<int>();
            foreach (string t in temp)
            {
                var i = int.Parse(t);
                intList.Add(i);
            }

            var orderByAscendingScore = from n in intList
                                        orderby n ascending
                                        select n;

            List<int> sortedInts = new List<int>();
            foreach (var i in orderByAscendingScore)
            {
                sortedInts.Add(i);
            }
            sortedInts.RemoveAt(0);
            int sum = sortedInts[0] + sortedInts[1] + sortedInts[2] + sortedInts[3];
            double average = sum / 4;
            return average;
        }
    }
}
