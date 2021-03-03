using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> employeeQueue = new Queue<string>();
            employeeQueue.Enqueue("Ruhul");
            employeeQueue.Enqueue("Kuddus");
            employeeQueue.Enqueue("Nayem");
            employeeQueue.Enqueue("Jumman");
            employeeQueue.Enqueue("Ahmed");

            employeeQueue.Dequeue();
            employeeQueue.Dequeue();

            foreach (string s in employeeQueue)
            {
                Console.WriteLine(s);
            }



            //Stack<string> customerNameStack = new Stack<string>();
            //customerNameStack.Push("Ruhul");
            //customerNameStack.Push("Kuddus");
            //customerNameStack.Push("Nayem");
            //customerNameStack.Push("Jumman");
            //customerNameStack.Push("Ahmed");

            //Console.WriteLine(customerNameStack.Peek());
                        

            //foreach (string s in customerNameStack)
            //{
            //    Console.WriteLine(s);
            //}
        }
    }
}
