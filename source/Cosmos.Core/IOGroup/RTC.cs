﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cosmos.Core;

namespace Cosmos.Core.IOGroup {
    /// <summary>
    /// Real time clock class.
    /// </summary>
    public class RTC : IOGroup {
        /// <summary>
        /// Address IOPort.
        /// </summary>
        public readonly ushort Address = 0x70;
        /// <summary>
        /// Data IOPort.
        /// </summary>
        public readonly ushort Data = 0x71;
    }
}
