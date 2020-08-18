using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Dictionary
{
    class Program
    {
       static readonly Dictionary<int, string> town = new Dictionary<int, string>();
        static void Main(string[] args)
        {
            Add(1, "Bishkek");
            Remove(1);
            Add(1, "Bishkek");
            GetValue(1);
            Print();
            
        }
        static void Add(int key, string value)
        {
            foreach (var item in town)
            {
                if (key != item.Key) continue;
                else Console.WriteLine("The key was created"); return;
            }
            town.Add(key, value);
        }
        static void GetValue(int key)
        {
            foreach (var item in town)
            {
                if (key == item.Key) Console.WriteLine(item.Value);
                else Console.WriteLine("Key not found");
            }
        }

        static void Remove(int key)
        {
            foreach (var item in town)
            {
                if (key == item.Key) town.Remove(item.Key); 
                else Console.WriteLine("Key not deleted");
            }
        }

        static void Print()
        {
            foreach (var item in town)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
        }
        
    }
}
