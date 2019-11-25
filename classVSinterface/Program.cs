using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classVSinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("indexFrom = ");
            //int indexFrom = int.Parse(Console.ReadLine());

            //Console.WriteLine("indexTo = ");
            //int indexTo = int.Parse(Console.ReadLine());

            listClass callList = new listClass();
            callList.listInit(5,8);

            Console.ReadLine();
        }
    }
}
