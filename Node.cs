using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int New_Data)
        {
            data = New_Data;
            next = null;
        }
    }
}
