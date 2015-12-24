using System;

namespace Patterns.Core.Game
{
    [Flags]
    public enum Players
    {
        None = 0,

        King = 1,

        Soldier = 2,

        Farmer = 4,

        All = King | Soldier | Farmer
    }
}