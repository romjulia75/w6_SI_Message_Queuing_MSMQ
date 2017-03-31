using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Queuing_MSMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.StockQuoteSoapClient CL = new ServiceReference1.StockQuoteSoapClient();
            Console.WriteLine(CL.GetQuote("BP"));
            //
            Console.ReadLine();

        }
    }
}
