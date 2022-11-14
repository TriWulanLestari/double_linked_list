using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /* Node class represents the node of doubly linkedm list.
         * it consists of the information part and links to
         * its succeding and precceding
         * in terms  of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to precceding node
        public Node prev;

    }

    class DoubleLinkedList
    {
        Node START;
        
        //constructor
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(System.Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.name = nm;
            newNode.noMhs = nim;

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
