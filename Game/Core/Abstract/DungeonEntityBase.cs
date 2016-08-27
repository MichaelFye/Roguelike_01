using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Core.Abstract
{
    public abstract class DungeonEntityBase
    {
        #region Public

        public int X { get; private set; }

        public int Y { get; private set; }

        #endregion

        protected DungeonEntityBase(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
    }
}
