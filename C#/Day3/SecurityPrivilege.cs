using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    [Flags]
    internal enum SecurityPrivilege : byte
    {
        guest = 0x01,
        developer = 0x02,
        secretary = 0x04,
        DBA = 0x08,
        FULL = 0x0F
    }
}
