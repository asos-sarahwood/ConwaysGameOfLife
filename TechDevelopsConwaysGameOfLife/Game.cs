using System;
using System.Threading;

namespace TechDevelopsConwaysGameOfLife
{
    class Game
    {
        readonly int _numberOfGenerations;
        readonly Grid _grid;
        
        public Game(int height, int width, int numberOfGenerations)
        {
            _numberOfGenerations = numberOfGenerations;
            _grid = new Grid(height, width);
        }

        public Game()
        {
            _grid = new Grid();
        }

        public override string ToString()
        {
            return _grid.ToString();
        }

        public void Start()
        {
            Console.WriteLine(_grid.ToString());
            for (int i = 1; i <= _numberOfGenerations; i++)
            {
                _grid.Advance();
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(_grid.ToString());
            }


        }
    }
}