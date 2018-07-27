using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechDevelopsConwaysGameOfLife
{
    class Game
    {
        
        public Game()
        {
            var grid = new Grid();
        }
    }

    class Grid
    {
        private readonly int height = 2;
        private readonly int width = 2;

        public Grid()
        {
            var seed = new Seed(height, width);
        }
    }

    class Seed
    {
        public Seed(int height, int width)
        {
            
        }
    }

    class Cell
    {
    }

    class Alive : Cell
    {
    }

    class Dead : Cell
    {
    }

    class DeadNeighbour : Dead
    {
    }

    class AliveNeighbour : Alive
    {
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
