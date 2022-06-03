using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    public static class Extensions
    {
        public static IEnumerable<int> DevideByTwo(this IEnumerable<int> source)
        {
            List<int> list = new List<int>();
            foreach (var item in source)
            {
                list.Add(item / 2);
            }
            return list;
        }
        public static IEnumerable<int> DevideByTwo1(this IEnumerable<int> source)
        {
            List<int> list1 = new List<int>();
            foreach (var item in source)
            {
                yield return item / 2;
            }
        }
        public static IEnumerable<int> MultipleByThree(this IEnumerable<int> source)
        {
            List<int> list2 = new List<int>();
            foreach (var item in source)
            {
                list2.Add(item * 3);
            }
            return list2;
        }
        public static IEnumerable<int> MultipleByThree1(this IEnumerable<int> source)
        {
            List<int> list3 = new List<int>();
            foreach (var item in source)
            {
                yield return item * 3;
            }
        }
        public static IEnumerable<int> MinusTen(this IEnumerable<int> source)
        {
            List<int> list4 = new List<int>();
            foreach (var item in source)
            {
                list4.Add(item - 10);
            }
            return list4;
        }
        public static IEnumerable<int> MinusTen1(this IEnumerable<int> source)
        {
            List<int> list5 = new List<int>();
            foreach (var item in source)
            {
                yield return item - 10;
            }
        }
        public static IEnumerable<int> PlusFour(this IEnumerable<int> source)
        {
            List<int> list6 = new List<int>();
            foreach (var item in source)
            {
                list6.Add(item + 4);
            }
            return list6;
        }
        public static IEnumerable<int> PlusFour1(this IEnumerable<int> source)
        {
            List<int> list7 = new List<int>();
            foreach (var item in source)
            {
                yield return item + 4;
            }
        }
        public static IEnumerable<int> ModulusTwo(this IEnumerable<int> source)
        {
            List<int> list8 = new List<int>();
            foreach (var item in source)
            {
                list8.Add(item % 2);
            }
            return list8;
        }
        public static IEnumerable<int> ModulusTwo1(this IEnumerable<int> source)
        {
            List<int> list9 = new List<int>();
            foreach (var item in source)
            {
                yield return item % 2;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 29, 30, 49 };
            //============================================
            Console.WriteLine("DevideByTwo[return]");
            var devideByTwo = list.DevideByTwo();
            var enumerator = devideByTwo.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            //============================================
            Console.WriteLine("DevideByTwo[yield return]");
            var devideByTwo1 = list.DevideByTwo1();
            var enumerator1 = devideByTwo1.GetEnumerator();
            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);
            }
            //============================================
            Console.WriteLine("MultipleByThree[return]");
            var multipleByThree = list.MultipleByThree();
            var enumerator2 = multipleByThree.GetEnumerator();
            while (enumerator2.MoveNext())
            {
                Console.WriteLine(enumerator2.Current);
            }
            //============================================
            Console.WriteLine("MultipleByThree[yield return]");
            var multipleByThree1 = list.MultipleByThree1();
            var enumerator3 = multipleByThree1.GetEnumerator();
            while (enumerator3.MoveNext())
            {
                Console.WriteLine(enumerator3.Current);
            }
            //============================================
            Console.WriteLine("MinusTen[return]");
            var minusTen = list.MinusTen();
            var enumerator4 = minusTen.GetEnumerator();
            while (enumerator4.MoveNext())
            {
                Console.WriteLine(enumerator4.Current);
            }
            //============================================
            Console.WriteLine("MinusTen[yield return]");
            var minusTen1 = list.MinusTen1();
            var enumerator5 = minusTen1.GetEnumerator();
            while (enumerator5.MoveNext())
            {
                Console.WriteLine(enumerator5.Current);
            }
            //============================================
            Console.WriteLine("PlusFour[return]");
            var plusFour = list.PlusFour();
            var enumerator6 = plusFour.GetEnumerator();
            while (enumerator6.MoveNext())
            {
                Console.WriteLine(enumerator6.Current);
            }
            //============================================
            Console.WriteLine("PlusFour[yield return]");
            var plusFour1 = list.PlusFour1();
            var enumerator7 = plusFour1.GetEnumerator();
            while (enumerator7.MoveNext())
            {
                Console.WriteLine(enumerator7.Current);
            }
            //============================================
            Console.WriteLine("ModulusTwo[return]");
            var modulusTwo = list.ModulusTwo();
            var enumerator8 = modulusTwo.GetEnumerator();
            while (enumerator8.MoveNext())
            {
                Console.WriteLine(enumerator8.Current);
            }
            //============================================
            Console.WriteLine("ModulusTwo[yield return]");
            var modulusTwo1 = list.ModulusTwo1();
            var enumerator9 = modulusTwo.GetEnumerator();
            while (enumerator9.MoveNext())
            {
                Console.WriteLine(enumerator9.Current);
            }
        }

    }
}
