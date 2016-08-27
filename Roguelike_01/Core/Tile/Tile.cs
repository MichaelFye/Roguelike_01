using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_01.Core
{
    class Tile
    {
        #region Private
        
        #endregion

        #region Public

        public int X { get; }

        public int Y { get; }

        public char Display { get; private set; }

        #endregion

        public Tile(int x = 0, int y = 0)
        {
            Console.WriteLine($"Initializing {GetType()}");
            X = x;
            Y = y;
            Console.WriteLine($"Initialized Tile at {X}, {Y}");
        }
    }
}
