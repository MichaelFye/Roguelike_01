using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Core.Abstract;

namespace Game.Core.Entities
{
    public class TileEntity : DungeonEntityBase
    {
        #region Public
        


        #endregion
        
        public TileEntity(int x = 0, int y = 0) : base(x, y)
        {
            Console.WriteLine($"Initialized TileEntity at {X}, {Y}");
        }
    }
}
