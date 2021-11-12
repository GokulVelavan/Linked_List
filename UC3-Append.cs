using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class UC3_Append
    {
        public Node head;

        public void Add(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;//after getting last node is inserted in the last
            }
            Console.WriteLine("{0} Inserted", new_node.data);
        }
        public void Append(int new_data)//program to append
        {

            Add(new_data);//using already presnt method
            Console.WriteLine("inserted into list: " + new_data);
        }



        public void Display() ///Method to print the data in LinedList
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;

                }
            }
        }

        public void InsertFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;
            }
            this.head = node;
            Console.WriteLine("{0} inserted into linked list", node.data);
        }


    }
}
