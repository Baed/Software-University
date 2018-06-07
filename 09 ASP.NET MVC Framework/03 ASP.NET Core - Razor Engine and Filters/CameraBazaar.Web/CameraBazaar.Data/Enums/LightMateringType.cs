using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraBazaar.Data.Enums
{
    [Flags]
    public enum LightMateringType
    {
        Spot = 1,
        CenterWeighted = 2,
        Evaluative = 4
    }
}
