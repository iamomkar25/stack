using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class LinkedlistStack
    {
        public Node top;
        LinkedList list = new LinkedList();
        public void Push(int newData)
        {
            ///creating a link between newnode and where top is pointing
            ///then pointing top toeard the new node
            ///new node is inserted on the top
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;//newnode will hold the address of 
            }
            this.top = newNode;//top will point to new element
            Console.WriteLine("New node{0} is added", newNode.data);

        }
        //Displaying the value in the stack
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("no Values to display , empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the stack:" + temp.data);
                temp = temp.next;
            }
        }
        public void PushByLinkedList(int newData)
        {
            list.AddAtFirst(newData);
        }
        public void DisplayByLinkedList()
        {
            list.Display();
        }
        public void Peek()
        {
            //Checking if top element is null
            //otherwise printing the top element
            if (this.top == null)
            {
                Console.WriteLine("no element present in stack");
                return;
            }
            Console.WriteLine("\n Top most element" + this.top.data);
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("no element present to pop");
                return;
            }
            else
            {
                //peek();
                int deleteNode = this.top.data;
                this.top = top.next;
                Console.WriteLine("{0} is deleted from the stack", deleteNode);
            }
        }
        public bool isEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            return true;
        }
    }
}
