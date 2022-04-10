using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class LinkedListQueue
    {
        public Node head;
        public void Enqueue(int item)
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("{0} is inserted into Queue", new_node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("" + temp.data);
                    temp = temp.next;
                }
            }
        }
        public void Dequeue()
        {
            //if queue  is empty ,return Null.
            if (this.head == null)
            {
                Console.WriteLine("the Queue is empty");
                return;
            }
            //store previous head and move head pointer one step ahead to delete
            int deleteNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("\n{0} is deleted from queue", deleteNode);
        }
    }
}
