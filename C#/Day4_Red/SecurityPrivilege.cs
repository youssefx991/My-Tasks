using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Red
{
    /// <summary>
    /// Defines the security privileges available within the system
    /// </summary>
    /// <remarks>
    /// a security privilege is represented by a byte value, where each bit represents a specific privilege.
    /// </remarks>
    public enum SecurityPrivilege : byte
    {
        guest = 0x01,
        developer = 0x02,
        secretary = 0x04,
        DBA = 0x08,
        FULL = 0x0F
    }
}
