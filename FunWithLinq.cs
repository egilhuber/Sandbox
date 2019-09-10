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







        //Write a function that takes in a string of letters {i.e. "Terrill") and returns an 
        //alphabetically ordered string corresponding to the letter frequency (i.e."E1L2R2T1")

        public void AlphaMethod(string demo)
        {

            char[] theseChars = demo.ToCharArray();
            List<string> letters = new List<string>();
            foreach(char s in theseChars)
            {
                string letter = s.ToString();
                letters.Add(letter);
            }
            List<string> newList = letters.OrderBy(x => x).ToList();



            var q = from x in newList
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new { Value = g.Key, Quant = count };

            List<string> qValues = q.Select(a => a.Value).ToList();
            List<int> qQuants = q.Select(b => b.Quant).ToList();

            List<string> z = qValues.OrderBy(x => x).ToList();

            //convert z to strings
            List<string> parsedQuants = new List<string>();
            foreach(int i in qQuants)
            {
                string intsParsed = $"{i}";
                parsedQuants.Add(intsParsed);
            }
            //convert z and parsedQuants to arrays

            var array1 = z.ToArray();
            var array2 = parsedQuants.ToArray();


            //zip and concat z and parsedQuants

            var zip = array1.Zip(array2, (a, b) => (a + b));

            List<string> finalStringList = new List<string>();
            foreach(var v in zip)
            {
                string vString = v.ToString();
                finalStringList.Add(vString);
            }
            string finalString = finalStringList.Aggregate(( m, n) => m + n);

            Console.WriteLine(finalString);


        }









    }


}


