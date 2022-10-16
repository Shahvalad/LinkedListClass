using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Linked_List
{
    class Node
    {
        public int Data;
        public Node next;

        public Node(int data)
        {
            Data = data;
            next = null;
        }

        Node head = null;
        public void AddToFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        public void PrintList()
        {
            Node displayer = head;
            while(displayer!=null)
            {
                Console.WriteLine(displayer.Data);
                displayer = displayer.next;
            }
        }

    }
}
