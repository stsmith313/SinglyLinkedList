using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList1
{
    class OrderedList : SinglyLinkedList
    {
        public OrderedList() : base() { }

        public void Insert(int data)
        {
            if (Head == null)
            {
                InsertAtHead(data);
            }
            else
            {
                Node prev = null;
                Node curr = Head;

                while (curr.Data < data && curr.Next != null)
                {
                    prev = curr;
                    curr = curr.Next;
                }

                if (curr.Data < data)
                {
                    InsertAfterHead(curr, data);
                }
                else if (curr == Head)
                {
                    InsertAtHead(data);
                }
                else
                {
                    InsertAfterHead(prev, data);
                }
            }
        }

        public void Remove(int data)
        {
            //If the head has no data in it
            //then InserAtHead to add data to the program
            //otherwise move on to the head data
            if (Head == null)
            {
                InsertAtHead(data);
            }
            else
            {
                Node prev = null;
                Node curr = Head;

                //this loop is going to run while the current space has 
                //data inside of it
                while (curr != null)
                {
                    //if the current space's data is equal to that same data being 
                    //looked at then we move on to the next space
                    if (curr.Data == data)
                    {
                        //if the previous data is equal to the data being looked at then it is deleted
                        prev.Next = curr.Next;
                    }

                    prev = curr;
                    curr = curr.Next;
                }
            }
        }
    }
}
