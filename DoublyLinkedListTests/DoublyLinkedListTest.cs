using System;
using Xunit;

namespace DoublyLinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void NodeConstructorTest()
        {
            DoubleLinkedList.Node expected = new DoubleLinkedList.Node();
            expected.val = 7;

            // Node with test values
            DoubleLinkedList.Node test = new DoubleLinkedList.Node(7);

            Assert.Equal(expected.val, test.val);
            Assert.Equal(expected.next, test.next);
            Assert.Equal(expected.prev, test.prev);

        }
        public void DoublyLinkedListTest()
        {
            DoubleLinkedList.DoublyLinkedList test = new DoubleLinkedList.DoublyLinkedList();
            Assert.Null(test.Head);
            Assert.Null(test.Tail);
        }

        public void AddToTailTest()
        {
            Node seven = new Node(7);

            DoubleLinkedList.DoublyLinkedList expected = new DoubleLinkedList.DoublyLinkedList();
            expected.Tail = seven;


            DoubleLinkedList.DoublyLinkedList test = new DoubleLinkedList.DoublyLinkedList();
            test.AddToTail(seven);

            Assert.Equal(expected.Tail, test.Tail);

        }

    }
}
