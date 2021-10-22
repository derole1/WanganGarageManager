using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WanganGarageManager
{
    class GameVersion
    {
        public static Dictionary<ushort, int> versions = new Dictionary<ushort, int>
        {
            { 0x0688, 0 },
            { 0x0001, 1 },  //Placeholder
            { 0x85E8, 2 },
            { 0x3FF8, 3 },
            { 0x0000, 4 }   //Placeholder
        };
    }
}
