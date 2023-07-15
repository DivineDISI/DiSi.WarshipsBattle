using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiSi.WarshipsBattle.Core.Enums
{
    [Flags]
    public enum CellState
    {
        None = 0,
        Empty = 1,
        Blocked = 2,
        DestroyedShip = 4,
        Ship = 8
    }
}
