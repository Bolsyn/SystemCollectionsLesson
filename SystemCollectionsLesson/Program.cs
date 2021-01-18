using System;
using System.Collections;
using System.Collections.Generic;

namespace SystemCollectionsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            var list = new List<int>();
            for(int i=0; i < 40; i++)
            {
                list.Add(rand.Next()%90+10);
            }            
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }

            for (int i = 0; i < 40; i++)
            {
                if (i % 2 == 1)
                {
                    list[i] = -1;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == -1)
                {
                    list.RemoveAt(i);
                }
            }

            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            int avg = sum / list.Count;

            Console.WriteLine();
            Console.WriteLine();
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine();
            Console.WriteLine();
            foreach (var el in list)
            {
                if (el > avg)
                    {
                    Console.WriteLine(el);
                    }
            }

            var myCollection = new Dictionary<string, List<string>>();

            //var list = new List<int>();
            //list.Add(1);

            //int number = list[0];

            //foreach(var el in list)
            //{
            //    Console.WriteLine(el);
            //}

            //var dictionary = new Dictionary<string, bool>();
            //dictionary.Add("Monday", false);
            //dictionary.Add("Vodka", false);
            //dictionary.Add("Jucie", true);

            //var list = new ArrayList();
            //list.Add("Текст");
            //list.Add(1);
            //list.Remove(1);

            //var hashTable = new Hashtable();
            //hashTable.Add("Test", DayOfWeek.Monday);

        }
    }
}
