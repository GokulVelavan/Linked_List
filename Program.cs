using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinedList");


            LinkedList obj1 = new LinkedList();
            obj1.Add(56);
            obj1.Add(30);
            obj1.Add(40);
            obj1.Add(70);
            obj1.Display();

            obj1.Search_Delete(40);
            Console.WriteLine();
            obj1.Display();

            Console.ReadLine();
        }
    }
}
