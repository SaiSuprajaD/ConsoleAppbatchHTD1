using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppbatchHTD1
{
    internal class Balance
    {
      
        
            int amount = 0;
            public void balancechecking()
            {
                Console.WriteLine("the balance is :" + amount);
            }
            public void cashdeposit(int depositamount)
            {
                amount = amount + depositamount;
                Console.WriteLine("amount deposited is :" + depositamount);

            }
            public void cashwithdrawl(int amountwithdrawl)
            {
                amount = amount - amountwithdrawl;
                Console.WriteLine("amount withdrawl is :" + amountwithdrawl);
            }
           
            
               

            }
        }
    


