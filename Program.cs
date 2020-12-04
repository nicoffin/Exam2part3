using System;
using System.Collections.Generic;

namespace Exam2part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This weeks QB stats are below!");
            //IGetStats statsObj = new NormalProvider();
            IGetStats statsObj = new NewProviderAdapter(new NewProvider());
            List<QBStats> qbStats = statsObj.GetQBStats();
            foreach(QBStats qb in qbStats){
                Console.WriteLine(qb.ToString());
            }

            Console.WriteLine("\nThis weeks WR stats are below!");
            List<WRStats> wrStats = statsObj.GetWRStats();
            foreach(WRStats wr in wrStats){
                Console.WriteLine(wr.ToString());
            }

            Console.WriteLine("\nThis weeks RB stats are below!");
            List<RBStats> rbStats = statsObj.GetRBStats();
            foreach(RBStats rb in rbStats){
                Console.WriteLine(rb.ToString());
            }
        }
    }
}
