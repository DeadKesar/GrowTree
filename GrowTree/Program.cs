using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/* Идея создаем фикус на рабочем столе, его можно поливать или не поливать а он себе тихонько растет*/

namespace GrowTree
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tree Tree1 = new Tree();

            Thread thread1 = new Thread(Tree1.Grow);
            Thread thread2 = new Thread(Tree1.GrowVisual);
            
            thread1.Start();
            thread2.Start();
            Tree1.Live();

            Console.ReadLine();




        }
    }
}
