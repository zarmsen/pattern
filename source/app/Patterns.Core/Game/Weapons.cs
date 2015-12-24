using System;

namespace Patterns.Core.Game
{
    [Flags]
    public enum Weapons
    {
        None = 0,

        Gun = 1,

        Sword = 2,

        Axe = 4,

        All = Gun | Sword | Axe
    }
}