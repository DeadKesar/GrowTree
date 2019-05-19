using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GrowTree
{
    public delegate void tree();
    public class Tree
    {
        
        public int Stadia { get; private set; } = 1;
        public double Hunger { get; private set; } = 100;
        public double exp { get; private set; } = 0;
        public int ExpStadiaUp
        {
            get
            {
                return (int)Math.Pow(Stadia, 2) * 1000;
            }
            private set
            { }
        }
        public bool Life { get; private set; } = true;
        
        
        public Tree()
        {

        }


       // public event tree Grrow;
        public void Grow()
        {
        stadiaUP:
            while ((Hunger > 0) && (ExpStadiaUp>=exp))
            {
                
                Hunger -= 0.01;
                exp += 0.01;
                Thread.Sleep(1);
            }
            if (Hunger == 0)
            {
                Console.Clear();
                Console.WriteLine("It die");
                Life = false;
            }
            if (exp >= ExpStadiaUp)
            {
                Stadia += 1;
                Console.WriteLine("Congratulation");
                goto stadiaUP;
            }
        }
        public void GrowVisual()
        {
            while (Life)
            {
                TreeAllSide.DrowAllTree(Stadia);
                Console.WriteLine(Hunger);
                Console.WriteLine("Полить - 1");
                Thread.Sleep(2000);

                Console.Clear();
            }

        }
        

        public void polive()
        {
            Hunger += 100;
            if (Hunger>1000)
            {
                Hunger = 1000;
            }
        }

        public void Live()
        {
            while (Life)
            {
                
                if (int.TryParse(Console.ReadLine(),out int res))
                {
                    switch (res)
                    {
                        case 1:
                            {
                                polive();
                                Console.WriteLine($"Hunger now:{Hunger}");
                                Console.WriteLine($"Exp is now: {exp}");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Ещё не реализовано");
                                break;
                            }
                    }
                }
            }

        }
        
    }
}
