using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList1
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderedList ol = new OrderedList();

            ol.Insert(45);
            ol.Insert(49);
            ol.Insert(42);
            ol.Insert(48);
            ol.Insert(52);
            ol.Insert(12);
            ol.Insert(100);

            Console.WriteLine(ol.ToString());

            ol.Insert(49);

            Console.WriteLine(ol.ToString());

            //Remove the items from the list
            ol.Remove(42);
            ol.Remove(49);
            ol.Remove(100);
            ol.Remove(52);

            //Write the items to the console
            Console.WriteLine(ol.ToString());

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
