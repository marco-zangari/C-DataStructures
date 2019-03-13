using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddToTail(int value)
        {
            Node newNode = new Node(value);
            if (Tail == null)
            {
                Tail = newNode;
                Head = newNode;
            }
            else
            {
                // Attach tail to new node
                newNode.prev = Tail;
                Tail.next = newNode;

                // Make new node the tail
                Tail = newNode;
            }
        }
        public void AddToTail(Node newNode)
        {
            
            if (Tail == null)
            {
                Tail = newNode;
                Head = newNode;
            }
            else
            {
                // Attach tail to new node
                newNode.prev = Tail;
                Tail.next = newNode;

                // Make new node the tail
                Tail = newNode;
            }
        }

        public void AddToHead(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Tail = newNode;
                Head = newNode;
            }
            else
            {
                // Attach tail to new node
                newNode.next = Head;
                Head.prev = newNode;

                // Make new node the tail
                Head = newNode;
            }
        }
        
    }
}
