using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace conapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t = new Thread(new ThreadStart(new Test().CreateFiles));
            //t.SetApartmentState(ApartmentState.MTA);
            //t.Start();
            //t.Join();
            new Test().CreateFiles();
            Console.WriteLine("complete");
            
        }


    }

    class Test
    {
        public void CreateFiles()
        {
            for (int i = 1; i <= 4; i++)
            {
                ParameterizedThreadStart ts = new ParameterizedThreadStart(Print);
                Thread t = new Thread(ts);
                t.SetApartmentState(ApartmentState.STA);
                t.Start(i);
                //Print(i);
            }
        }

        private void Print(object para)
        {
            int index = (int)para;   
            for (int j = index * 100; j < index * 100 + 100; j++)
            {
                Console.Write(j + ",");
            }
        }
    }
}
