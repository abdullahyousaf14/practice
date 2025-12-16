using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bank b = new MCB();
            Console.WriteLine("MCB Rate of Interest is: " + b.getInterestRate() + "%");
            b.issueCard();
        }
        
    }
    abstract class Bank
    {
        public virtual void issueCard()
        {
            Console.WriteLine("Card is issued");
        }
        public abstract int getInterestRate();
    }
    class MCB : Bank
    {
        public override void issueCard()
        {
            Console.WriteLine("MCB Card is issued");
        }
        public override int getInterestRate()
        {
            return 10;
        }
    }
}
