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

            //  UC2_Insert_First obj1 = new UC2_Insert_First();
            //  obj1.InsertFirst(70);
            //  obj1.InsertFirst(30);
            //  obj1.InsertFirst(56);
            //  obj1.Display();


            UC3_Append obj1 = new UC3_Append();
            obj1.Append(56);
            obj1.Append(30);
            obj1.Append(70);
            obj1.Display();



            Console.ReadLine();
        }
    }
}
