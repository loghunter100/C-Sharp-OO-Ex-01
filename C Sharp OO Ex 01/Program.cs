using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OO_Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {



            Temperature Temp = new Temperature(-271, 'c');

            SondeSpatiale mars1 = new SondeSpatiale(Temp);

            Console.WriteLine();
            mars1.augmenterTemp(15,'f');
            mars1.AfficherTempSonde();
           
        }
    }
}
