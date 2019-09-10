using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //sandbox code
            bool RunRealCode = true;
            bool CollapseCommentedOutCode = true;
            while (RunRealCode == false)
            {
                while (CollapseCommentedOutCode == true)
                {
                    Console.ReadLine();
                    ////Enumerator demo!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //Person[] peopleArray = new Person[3]
                    //{
                    //new Person("John", "Smith"),
                    //new Person("Jim", "Johnson"),
                    //new Person("Sue", "Rabon"),
                    //};

                    //People peopleList = new People(peopleArray);
                    //foreach (Person p in peopleList)
                    //    Console.WriteLine(p.firstName + " " + p.lastName);
                    ////End enumerator demo!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    ///




                    ////dependency injection demo 1   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //Book harryPotter = new Book();
                    //Magazine people = new Magazine();

                    //IReader kindleFire = new Kindle(people);
                    //kindleFire.Read();
                    //Console.ReadLine();
                    ////end dependency injection demo 1   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!





                    ////dependency injection demo 2  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //Customer mike = new Customer();
                    //mike.Register("mike@gmail.com", "123ABC!", new GoogleEmailService()); //new GoogleEmailService part is a very shorthand way to create a 
                    ////new instance of the googleemailservice

                    //Customer larry = new Customer();
                    //larry.Register("larry@outlook.com", "hunter2", new OutlookEmailService());
                    ////end dependency injection demo 2   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!





                    //dependency injection demo pt 2   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //OnlineStore eCommerce = new OnlineStore();
                    //string roleType = eCommerce.GetRoleType();
                    //eCommerce.AddUser(roleType);

                    //Laptop laptop = new Laptop();
                    //Employee employee = new Employee();
                    //employee.SetProductDetails(laptop);
                    //Console.Clear();
                    //laptop.DisplayDetails();

                    //Customer customer = null;
                    //for (int i = 0; i < eCommerce.usersOnlineCount; i++)
                    //{
                    //    Type userRole = eCommerce[i].GetType();
                    //    if (userRole.Name == "Customer")
                    //    {
                    //        customer = (Customer)eCommerce[i];
                    //        break;
                    //    }
                    //}
                    //end of dependency injection demo pt 2   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!



                    //Calculator LINQ demo    !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //Calculator calculator = new Calculator();
                    //calculator.AddTwoNumbers(2, 4);
                    //calculator.MultiplyTwoNumbers(5, 2);
                    //calculator.PrintResult(10, 20, calculator.MultiplyTwoNumbers);
                    //calculator.PrintResult(1, 5, calculator.AddTwoNumbers);
                    //calculator.PrintName(calculator.GetName());
                    //Console.ReadLine();
                    //end of Calcuator LINQ demo   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                }
            }
            //end sandbox code

            //var infiniteEnumerable = new MyInfiniteEnumerable();

            //foreach (var i in infiniteEnumerable)
            //{
            //    Console.WriteLine($"I is {i}");
            //}

            //FunWithLinq demo   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            FunWithLinq demo = new FunWithLinq();

            //demo.HowToContainsMethod();
            //demo.HowToDuplicatesDemo();
            //double thisDemo = demo.CoolMethod();
            //Console.WriteLine(thisDemo);
            string thisDemo = Console.ReadLine();
            demo.AlphaMethod(thisDemo);
            Console.ReadLine();

            //end of funwithlinq demo   !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            //last line of main bits
        }



        //last line of program class
    }
}

//namespace Sandbox
//{
//    public class MyInfiniteEnumerable : IEnumerable<int>
//    {
//        public IEnumerator GetEnumerator()
//        {
//            return new MyINfiniteEnumerator();
//        }

//        IEnumerator<int> IEnumerable<int>.GetEnumerator()
//        {
//            return new MyINfiniteEnumerator();
//        }
//    }
//}

//namespace Sandbox
//{
//    public class MyINfiniteEnumerator : IEnumerator<int>
//    {
//        public int Current { get; private set; } = 0;

//        //int IEnumerator<int>.Current => throw new NotImplementedException();

//        object IEnumerator.Current => Current;

//        public void Dispose()
//        {
            
//        }

//        public bool MoveNext()
//        {
//            Current++;
//            return true;
//        }

//        public void Reset()
//        {
//            Current = 0;
//        }
//    }
//