﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class LinkedList
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

        internal void InsertBetween(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                Node temp = this.head;
                while (position != 1)
                {
                    temp = temp.next;
                    position--;
                }

                node.next = temp.next;
                temp.next = node;
            }
        }

        public void RemoveFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("The List Is Empty");
            }
            Console.WriteLine("Deleted Node: " + this.head.data);
            this.head = this.head.next;
        }

        internal Node RemoveLastNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;

            }
            Node newNode = this.head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;

            }
            newNode.next = null;
            return head;
        }

        internal int Search(int value)
        {

            int position = 1;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Node is Present");
                    return position;
                }
                position++;
                temp = temp.next;
            }
            Console.WriteLine("Node is not Present");
            return 0;
        }

<<<<<<< HEAD
        internal void InsertNewNode(int search_val, int insert_val)
=======
        internal void InsertNewNode(int search_val,int insert_val)//program to find the present element and insert after the index
>>>>>>> a63901f49e1c5c11ca3a3df0cdc6c9c21a74cbd4
        {
            int n = Search(search_val);
            InsertBetween(n, insert_val);

        }

        internal void Size()
        {
            Node temp = head;
            int position = 1;
            while(temp!=null)
            {
                temp = temp.next;
                position++;
            }
            Console.WriteLine("size,{0}", position-1);

        }
        internal void Search_Delete(int value)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.next.data == value)//when the data is found it will enter the condition
                    {
                        temp.next = temp.next.next;
                        Console.WriteLine("Deleted");

                        Size();//program to find size

                        break;
                    }
                    temp = temp.next;

                }
            }
        }
    }
}
