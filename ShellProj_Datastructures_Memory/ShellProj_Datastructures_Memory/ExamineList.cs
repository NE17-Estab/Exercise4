using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellProj_Datastructures_Memory
{
    public class ExamineList
    {
        public static void main()
        {
            List<string> employs = new List<string>();
            Console.WriteLine("\ncapacity:{0}",employs.Capacity);

            employs.Add("ICA");
            employs.Add("Kalle");
            employs.Add("Greta");
            employs.Add("Musa");
            employs.Add("Starla");
            Console.WriteLine();

            foreach (string employ in employs)
            {
                Console.WriteLine(employ);
            }

            Console.WriteLine("\ncapacity:{0}", employs.Capacity);
            Console.WriteLine("count:{0}",employs.Count);

            Console.WriteLine();
            foreach (string employ in employs)
            {
                Console.WriteLine(employ);
            }
            Console.ReadLine();
        }
    }
}
