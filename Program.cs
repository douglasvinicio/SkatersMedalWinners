using System;
using System.IO;

namespace MedalWinnersFinalProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var skatersDemo = new SkatersDemo();

            Console.WriteLine("################----Start----####################\n");

            skatersDemo.SkatersFinalScore();

            Console.WriteLine("################-----End-----####################");
        }
    }
}

