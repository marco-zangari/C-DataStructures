using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    public class Node
    {
        public int val { get; set; }
        public Node next { get; set; }
        public Node prev { get; set; }

        public Node()
        {
        }
        public Node(int value)
        {
            val = value;
            next = null;
            prev = null;
        }

    }
}
