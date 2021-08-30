using System;
using System.Collections;

namespace SortedListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SortedList my_slist1 = new SortedList();
             my_slist1.Add(1.02, "welcome");
            my_slist1.Add(1.07, "to");
            my_slist1.Add(1.04, "my");
            my_slist1.Add(1.01, "home");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();
            SortedList my_slist2 = new SortedList() {
                                  { "b.01", 1 },
                                  { "b.02",2 },
                                  { "b.03", 3 },
                                  { "b.04", 4 }};

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
        }

    }
}
