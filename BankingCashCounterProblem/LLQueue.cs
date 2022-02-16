using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounterProblem
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    internal class LLQueue
    {
        internal Node head;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("\n{0} Customer Added to Queue", node.data);
            Console.WriteLine(" ");
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty, Dequeue is not possible");
                return;
            }
            while (head != null)
            {
                Node temp = head;
                Console.WriteLine("\nCustomer Left the Queue : {0}", temp.data);
                this.head = head.next;
                temp = null;
            }
        }
    }
}
