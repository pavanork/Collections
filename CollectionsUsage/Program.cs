using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            int[] Array1 = new int[5];
            Array1[0] = 1;
            Console.WriteLine("Array1.Length : " + Array1.Length);
            Console.WriteLine("Array1.LongLength : " + Array1.LongLength);
            //ArrayList
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < 4; i++)
            {
                arrList.Add(1);
                arrList.Add("Pavan");
                arrList.Add(true);
                arrList.Add(3.21m);
                arrList.Add(new Vendor() { CompanyID = 1, CompanyName = "ABC Corp" });
                arrList.Add(false);
                arrList.Add(2);
                arrList.Add(3.14f);
                arrList.Add("Kumar");
            }
            Console.WriteLine("arrList.Capacity : " + arrList.Capacity);
            Console.WriteLine("arrList.Count : " + arrList.Count);

            Console.WriteLine("Hello World!! Lets Learn.....");
            Console.ReadLine();
        }
    }
    class Vendor
    {
        public int CompanyID { get; set; }
        public String CompanyName { get; set; }
    }
}
