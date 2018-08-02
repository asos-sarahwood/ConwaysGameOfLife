using System;

namespace TechDevelopsConwaysGameOfLife
{

    class Grid
    {
        public readonly int Height;
        public readonly int Width;
        private readonly Cell[,] _grid;
        
        public Grid() : this(20, 20)
        {

        }

        public Grid(int height, int width)
        {
            Height = height;
            Width = width;
            _grid = new Cell[height, width];
            SeedGrid();
        }

        private void SeedGrid()
        {
            Random seedCoordinates = new Random();
            for (int x = 0; x < Height; x++)
            {
                for (int y = 0; y < Width; y++)
                {
                    int cellIsAlive = seedCoordinates.Next(2);
                    if (cellIsAlive == 1)
                    {
                        _grid[x, y] = new Alive();
                    }
                    else
                    {
                        _grid[x, y] = new Dead();
                    }
                }
            }
        }

        public override string ToString()
        {
            string grid = "";
            for (int x = 0; x < Height; x++)
            {
                for (int y = 0; y < Width; y++)
                {
                    var cell = _grid[x, y];
                    grid += cell.ToString();
                }

                grid += "\n";
            }

            return grid;
        }

        public void Advance()
        {
            for (int x = 0; x < Height; x++)
            {
                for (int y = 0; y < Width; y++)
                {
                    _grid[x, y].NumberOfLiveNeighbours = GetCountOfLiveNeighbours(x,y);
                }
            }

            for (int x = 0; x < Height; x++)
            {
                for (int y = 0; y < Width; y++)
                {
                    var cell = _grid[x, y];
                    if (cell is Alive)
                    {
                        if (cell.NumberOfLiveNeighbours < 2)
                        {
                            _grid[x, y] = new Dead();
                        }
                        if (cell.NumberOfLiveNeighbours == 2 || cell.NumberOfLiveNeighbours == 3)
                        {
                            _grid[x, y] = new Alive();
                        }
                        if (cell.NumberOfLiveNeighbours > 3)
                        {
                            _grid[x, y] = new Dead();
                        }
                    }

                    if (cell is Dead)
                    {
                        if (cell.NumberOfLiveNeighbours == 3)
                        {
                            _grid[x,y] = new Alive();
                        }
                    }
                }
            }
        }

        private int GetCountOfLiveNeighbours(int height, int width)
        {
            int count = 0;
            for (int i = height-1; i < height + 2; i++ )
            {
                for (int j = width-1; j < width + 2; j++)
                {
                    if (CoordinateIsWithinGrid(i, j))
                    {
                        if (!IsCurrentCell(height, width, i, j))
                        {
                            var cell = _grid[i, j];
                            if (cell is Alive)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }

        private static bool IsCurrentCell(int height, int width, int i, int j)
        {
            return (i == height && j == width);
        }

        private bool CoordinateIsWithinGrid(int i, int j)
        {
            return (i >= 0 && i < Height) && (j >= 0 && j < Width);
        }
    }
}
