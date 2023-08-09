using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using H_W_Mod2_3;

namespace H_W_Mod2_6
{/// <summary>
    /// extension method.
    /// </summary>
    internal static class ExtensionMethods
    {/// <summary>
     /// Initializes a new instance of the <see cref="ExtensionMethods"/> class.
     /// </summary>
     /// <param name="electricalAppliances">electricalAppliances.</param>
     /// <param name="manufacturer">brand.</param>
     /// <returns>return.</returns>
        public static ElectricalAppliances[] FindByManufacturer(this ElectricalAppliances[] electricalAppliances, string manufacturer)
        {
            ElectricalAppliances[] extraArray = new ElectricalAppliances[electricalAppliances.Length];
            int counter = 0;
            foreach (var veh in electricalAppliances)
            {
                if (veh.Manufacturer == manufacturer)
                {
                    extraArray[counter++] = veh;
                }
            }

            ElectricalAppliances[] result = new ElectricalAppliances[counter];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = extraArray[i];
            }

            return result;
        }
    }
}