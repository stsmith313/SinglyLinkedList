using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList1
{
    class SinglyLinkedList
    {
        private Node head;

        internal Node Head { get => head; }

        public SinglyLinkedList()
        {
            head = null;
        }

        public void InsertAtHead(int data)
        {
            Node insert = new Node(data, head);
            head = insert;
            insert = null;
        }

        public void InsertAfterHead(Node prev, int data)
        {
            if (prev != null)
            {
                Node insert = new Node(data, prev.Next);
                prev.Next = insert;
                insert = null;
            }
        }

        public void RemoveAtHead()
        {
            if (head != null)
            {
                Node remove = head;
                head = remove.Next;
                remove.Next = null;
                remove = null;
            }
        }

        public void RemoveAfterHead(Node prev)
        {
            if (prev != null && prev.Next != null)
            {
                Node remove = prev.Next;
                prev.Next = remove.Next;
                remove.Next = null;
                remove = null;
            }
        }

        public override string ToString()
        {
            Node trav = head;
            String list = "head->";

            while (trav != null)
            {
                list += trav.Data + "->";
                trav = trav.Next;
            }

            list += "null";

            return list;
        }
    }
}
