using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList1
{
    class Node
    {
        private int data;
        private Node next;
        private Node prev;

        public int Data { get => data; set => data = value; }
        public Node Next { get => next; set => next = value; }

        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public Node(int data) : this(data, null) { }

        public Node(Node next) : this(0, next) { }

        public Node() : this(0, null) { }
    }
}
