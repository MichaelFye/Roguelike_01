using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_01.Core
{
    class Dungeon
    {
        #region Private

        private static List<Floor> _floors { get; set; }

        #endregion

        #region Public

        public static Floor CurrentFloor { private set; get; }

        #endregion

        public Dungeon()
        {
            Console.WriteLine($"Initializing {GetType()}");
            _floors = new List<Floor> { new Floor() };
            CurrentFloor = _floors.FirstOrDefault();
        }
    }
}
