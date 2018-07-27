using System;

namespace TechDevelopsConwaysGameOfLife
{
    class Game
    {

        public Game()
        {
            var grid = new Grid();
        }


        class Grid
        {
            public readonly int height = 2;
            public readonly int width = 2;
            private Cell[,] grid;

            public Grid()
            {
                grid = new Cell[height, width];
                var seed = new Seed(height, width);
            }
        }

        class Seed
        {
            private int height;
            private int width;

            public Seed(int height, int width)
            {
                this.height = height;
                this.width = width;
                CreateSeed();
            }

            private void CreateSeed()
            {     
                Random seedCoordinates = new Random();
                for(int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                       Console.WriteLine("Cell coordinates: {0}, {1}", y, x);

                    }
                }


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
                var myGame = new Game();
            }
        }
    }
}