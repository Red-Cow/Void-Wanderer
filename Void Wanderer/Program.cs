﻿using System;

namespace Void_Wanderer
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new VoidWandererGame())
                game.Run();
        }
    }
}
