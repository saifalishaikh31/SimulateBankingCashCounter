using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounterProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank Cash Counter Problem");
            LLQueue lLQueue = new LLQueue();
            Console.WriteLine("People in Queue : ");
            for (int i = 1; i < 5; i++)
            {
                lLQueue.Enqueue(i);
                int totalBalance = 50000;
                int depositAmt = 0;
                int withdrawAmt = 0;
                Console.WriteLine("1.Cash Withdraw"
                               +"\n2.Cash Deposit"
                               +"\n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("\nYour Total Account Balance : {0}",totalBalance);
                        Console.Write("\nEnter Amount to Withdraw : ");
                        withdrawAmt = Convert.ToInt32(Console.ReadLine());
                        if(withdrawAmt > totalBalance)
                        { 
                            Console.WriteLine("\nYou have Insufficient Account Balance!!!"); 
                        }
                        else
                        {
                            totalBalance -= withdrawAmt;
                            Console.WriteLine("\nPlease collect you Cash Money!!!");
                            Console.WriteLine("\nYour Remaining Balance is : {0}",totalBalance);
                        }
                        lLQueue.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("\nYour Total Account Balance : {0}", totalBalance);
                        Console.Write("\nEnter Amount to Deposit : ");
                        depositAmt = Convert.ToInt32(Console.ReadLine());
                        totalBalance += depositAmt;
                        Console.WriteLine("Your Total Account Balance : {0}",totalBalance);
                        lLQueue.Dequeue();
                        break;
                    case 3:
                        lLQueue.Dequeue();
                        break;
                    default:
                        Console.WriteLine("Enter correct option!!!");
                        break;
                }
                Console.WriteLine("Thank You!!!");
            }
        }
    }
}
