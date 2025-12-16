using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new HBL(); 
            Console.WriteLine("HBL Rate of Interest is: " + b.getInterestRate() + "%");
        }
    }
    abstract class Bank
    {
        public virtual void issueCard()
        {
            Console.WriteLine("Card is issued ");
        }
        public abstract int getInterestRate();
    }
    class HBL :Bank
    {
        public override int getInterestRate()
        { 
            return 7;
        }
    }
}
