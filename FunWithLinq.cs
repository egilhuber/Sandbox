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


        public void CoolMethod()
        {
            foreach (string el in classGrades)
            {
                string[] tempString =  
                List<string> tempList = new List<string>()
                {
                    el.Split(",").ToList<string>();
                };
                
                //tempList.Add(el);
                
            }
            //for each i in the list 
            //    parse things between commas (if statement?) into ints
            //            then add them together with +=

        }



    }
}
