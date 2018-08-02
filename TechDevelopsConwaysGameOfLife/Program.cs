using System;

namespace TechDevelopsConwaysGameOfLife
{

    class Program
    {
        static void Main(string[] args)
        {
            var myGame = new Game(65,220,1000);
            myGame.Start();          
        }
    }
}
