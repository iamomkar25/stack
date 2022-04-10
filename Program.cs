using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Please choose program number to execute");
            Console.WriteLine("1:LinkedList\n2:Stack\n3:Queue\n4:Exit");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Builin");
                    LinkedList<int> list = new LinkedList<int>();
                    list.AddLast(20);
                    list.AddLast(30);
                    list.AddLast(40);
                    break;

                case 2:
                    LinkedlistStack stack = new LinkedlistStack();
                    stack.Push(60);
                    stack.Push(20);
                    stack.Push(46);
                    stack.Display();
                    // stack.Peek();
                    // stack.Pop();
                    Console.WriteLine("is stack empty? {0}", stack.isEmpty());
                    stack.Display();
                    break;
                case 3:
                    LinkedListQueue queue = new LinkedListQueue();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    queue.Dequeue();
                    queue.Display();
                    break;

                case 5:
                    LinkedlistStack customStack = new LinkedlistStack();
                    customStack.PushByLinkedList(70);
                    customStack.PushByLinkedList(30);
                    customStack.PushByLinkedList(56);
                    customStack.DisplayByLinkedList();
                    break;

                default:
                    break;
            }
           
            Console.ReadLine();
        }
    }
}
