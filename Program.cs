using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tut_HelloW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            InterestEarningAccount IACAccount = new InterestEarningAccount("Vinay",1000);
            
            IACAccount.PerformMonthEndTransactions();

            LineOfCreditAccount LOCAccount = new LineOfCreditAccount("Vinay", 1000);
            Console.WriteLine(LOCAccount.accountName);
            LOCAccount.PerformMonthEndTransactions();

        }
    }
}
