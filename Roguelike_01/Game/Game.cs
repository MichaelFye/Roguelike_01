using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roguelike_01.Core;

namespace Roguelike_01
{
    class Game
    {
        #region Internal

        internal static Game Instance { get; set; }

        internal static Dungeon Dungeon { get; set; }

        #endregion

        public Game()
        {
            if (Instance != null)
                return;
            Instance = this;
            Instance.Init();
        }

        public void Init()
        {
            Console.WriteLine($"Initializing {GetType()}");
            Console.WriteLine("Initializing Dungeon...");
            Dungeon = new Dungeon();
        }
    }
}
