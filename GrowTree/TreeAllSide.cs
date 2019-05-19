using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowTree
{
    public static class TreeAllSide
    {
        public static Random rnd = new Random();
        private static String stadia11 =
            "**********\n" +
            "**********\n" +
            "***o*|o**o\n" +
            "**o\\o|o*/*\n" +
            "**oo\\|*/o*\n" +
            "***oo|/***\n" +
            "*****|****\n" +
            "_____|____\n" +
            "..../.\\...\n" +
            ".../.\\.\\..\n";

        private static String stadia12 =
            "**********\n" +
            "*****o****\n" +
            "***oo|oo*o\n" +
            "**o\\o|oo/o\n" +
            "**oo\\|*/o*\n" +
            "*o*oo|/*o*\n" +
            "*****|****\n" +
            "_____|____\n" +
            "..../.\\...\n" +
            ".../.\\.\\..\n";
        private static String stadia13 =
            "**********\n" +
            "****o|o***\n" +
            "**ooo|oo*o\n" +
            "*oo\\o|oo/o\n" +
            "*ooo\\|o/o*\n" +
            "***oo|/oo*\n" +
            "**o**|o***\n" +
            "_____|____\n" +
            "..../.\\...\n" +
            ".../.\\.\\..\n";

        private static String stadia21 =
            "***************\n" +
            "***************\n" +
            "***************\n" +
            "***o\\o***/o****\n" +
            "****o\\**/***o**\n" +
            "**_***\\|*oo/o**\n" +
            "**o\\o**|**/o***\n" +
            "***o\\**|*/o****\n" +
            "***oo\\||/o*****\n" +
            "******||*******\n" +
            "******||*******\n" +
            "______||_______\n" +
            "...............\n" +
            "...............\n" +
            "...............\n";
        private static String stadia22 =
            "***************\n" +
            "***************\n" +
            "****o***o*o*o**\n" +
            "***o\\o*oo/o****\n" +
            "****o\\o*/***o**\n" +
            "**_***\\|*oo/o**\n" +
            "**o\\o**|o*/o***\n" +
            "*ooo\\o*|*/oo***\n" +
            "*o*oo\\||/o*****\n" +
            "******||o******\n" +
            "******||*******\n" +
            "______||_______\n" +
            "...............\n" +
            "...............\n" +
            "...............\n";
        private static String stadia23 =
           "***************\n" +
           "*******o*******\n" +
           "****o*ooo*o*o**\n" +
           "***o\\o*oo/o****\n" +
           "****o\\oo/oo*o**\n" +
           "*o_oo*\\|*oo/o**\n" +
           "**o\\oo*|o*/oo**\n" +
           "*ooo\\oo|o/oo***\n" +
           "*o*oo\\||/o*****\n" +
           "*****o||o******\n" +
           "******||*******\n" +
           "______||_______\n" +
           "...............\n" +
           "...............\n" +
           "...............\n";



        public static void DrowAllTree(int stadia)
        {
            switch (stadia)
            {
                case 1:
                    {
                        DrowTree1();
                        break;
                    }
                case 2:
                    {
                        DrowTree2();
                        break;
                    }
            }
        }

        private static void DrowTree1()
        {
            
            switch (rnd.Next(1,3))
            {
                case 1:
                    {
                        Console.WriteLine(stadia11);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(stadia12);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(stadia13);
                        break;
                    }

            }
        }
        private static void DrowTree2()
        {

            switch (rnd.Next(1, 3))
            {
                case 1:
                    {
                        Console.WriteLine(stadia21);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(stadia22);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(stadia23);
                        break;
                    }

            }
        }
    }
}
