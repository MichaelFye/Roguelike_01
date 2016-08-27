using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_01.Core
{
    class Floor
    {
        #region Private 

        private static List<Tile> _tiles { get; set; }

        #endregion 

        #region Public

        public static Tile CurrentTile { get; private set; }

        #endregion

        public Floor()
        {
            Console.WriteLine($"Initializing {GetType()}");
            _tiles = new List<Tile> { new Tile() };
            CurrentTile = _tiles.FirstOrDefault();
        }
    }
}
