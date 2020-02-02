using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LessUsedCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- Generické --
            // List<string>
            Console.WriteLine("--- List");
            List<string> list1 = new List<string> {"Antilopa","Fenek","Bizon","Cvrček","Datel","Emu"};
            list1.Add("Gekon");
            foreach (string l in list1)
            {
                Console.WriteLine(l);
            }
            // Dictionary<string,string>
            Console.WriteLine("--- Dictionary");
            Dictionary<string, string> dict1 = new Dictionary<string, string> { { "Antilopa", "Antelope" }, { "Cvrček", "Cricket" }, { "Datel", "Woodpecker" }, { "Bizon", "Bison" } };
            dict1.Add("Gekon","Gecko");
            foreach (KeyValuePair<string,string> item in dict1)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            // Queue<string>
            Console.WriteLine("--- Queue");
            Queue<string> fronta1 = new Queue<string>();
            fronta1.Enqueue("Antilopa");
            fronta1.Enqueue("Bizon");
            fronta1.Enqueue("Cvrček");
            while (fronta1.Any())
            {
                Console.WriteLine(fronta1.Dequeue());
            }
            // Stack<string>
            Console.WriteLine("--- Stack");
            Stack<string> stack1 = new Stack<string>();
            stack1.Push("Antilopa");
            stack1.Push("Bizon");
            stack1.Push("Cvrček");
            while (stack1.Any())
            {
                Console.WriteLine(stack1.Pop());
            }
            // HashSet<string>
            // https://docs.microsoft.com/cs-cz/dotnet/api/system.collections.generic.hashset-1?view=netcore-3.1
            // Unikátní prvky
            Console.WriteLine("--- HashSet");
            HashSet<string> list2 = new HashSet<string> { "Antilopa", "Fenek", "Bizon", "Cvrček", "Datel", "Emu" };
            list2.Add("Gekon");
            list2.Add("Antilopa");
            foreach (string l in list2)
            {
                Console.WriteLine(l);
            }
            // LinkedList<string>
            // https://docs.microsoft.com/cs-cz/dotnet/api/system.collections.generic.linkedlist-1?view=netcore-3.1
            // Rychlé vkládání a odstraňování
            Console.WriteLine("--- LinkedList");
            LinkedList<string> list3 = new LinkedList<string>();
            list3.AddFirst("Gekon");
            list3.AddFirst("Antilopa");
            list3.AddLast("Bizon");
            list3.AddLast("Cvrček");
            foreach (string l in list3)
            {
                Console.WriteLine(l);
            }
            // SortedList<string,string>
            Console.WriteLine("--- SortedList");
            SortedList<string, string> dict2 = new SortedList<string, string> { { "Antilopa", "Antelope" }, { "Cvrček", "Cricket" }, { "Datel", "Woodpecker" }, { "Bizon", "Bison" } };
            dict2.Add("Gekon", "Gecko");
            foreach (KeyValuePair<string, string> item in dict2)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            // -- Negenerické
            // ArrayList
            Console.WriteLine("--- ArrayList");
            ArrayList list4 = new ArrayList { "Antilopa", "Fenek", "Bizon", "Cvrček", "Datel", "Emu" };
            list4.Add("Gekon");
            foreach (string l in list4)
            {
                // zde je nutné testovat typ objektu, nějak takto:
                if (l is string)
                {
                    Console.WriteLine(l as string);
                }              
            }
            // Hashtable
            Console.WriteLine("--- Hashtable");
            Hashtable dict3 = new Hashtable { { "Antilopa", "Antelope" }, { "Cvrček", "Cricket" }, { "Datel", "Woodpecker" }, { "Bizon", "Bison" } };
            dict3.Add("Gekon", "Gecko");
            foreach (DictionaryEntry item in dict3)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            // Queue
            Console.WriteLine("--- Queue");
            Queue fronta2 = new Queue();
            fronta2.Enqueue("Antilopa");
            fronta2.Enqueue("Bizon");
            fronta2.Enqueue("Cvrček");
            while (fronta2.Count > 0)
            {
                Console.WriteLine(fronta2.Dequeue());
            }
            // Stack
            Console.WriteLine("--- Stack");
            Stack stack2 = new Stack();
            stack2.Push("Antilopa");
            stack2.Push("Bizon");
            stack2.Push("Cvrček");
            while (stack2.Count > 0)
            {
                Console.WriteLine(stack2.Pop());
            }

            // https://www.geeksforgeeks.org/collections-in-c-sharp/
        }
    }
}
