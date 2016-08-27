using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.Entities;

namespace Game.Core
{
    class Floor
    {
        #region Private 

        private static List<TileEntity> _tiles { get; set; }

        #endregion 

        #region Public

        public static TileEntity CurrentTile { get; private set; }

        #endregion

        public Floor()
        {
            Console.WriteLine($"Initializing {GetType()}");
            _tiles = new List<TileEntity> { new TileEntity() };
            CurrentTile = _tiles.FirstOrDefault();
        }
    }
}
