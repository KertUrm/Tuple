using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    TupleSix();
                    break;
                case "2":
                    TupleWithValues();
                    break;
                case "3":
                    WithSortedList();
                    break;
                default:
                    break;
            }
        }
        public static void TupleSix()
        {
            var tuple = Tuple.Create(1,2,3,4,5,6);
            TupleParam(tuple);
        }
        public static void TupleParam(Tuple<int, int, int, int, int, int> tuple)
        {
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
            Console.WriteLine(tuple.Item5);
            Console.WriteLine(tuple.Item6);
        }
        public static void TupleWithValues()
        {
            ValueTuple<int, string, string> tuple = (1,"2","2");
            Console.WriteLine(tuple.ToString());
        }
        public static void WithSortedList()
        {
            // key ja value paarid. sorteeritakse key järgi
            SortedList<int,string> list = new SortedList<int, string>()
            {
                {1,"1"},
                {3,"3"},
                {2,"2"},
                {4,"4"},
                {6,"6"},
                {5,"5"},
            };
            foreach (var item in list)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
