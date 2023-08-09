using System;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using H_W_Mod2_3;

namespace H_W_Mod2_6
{/// <summary>
    /// Start point to app.
    /// </summary>
    internal class Program
    {/// <summary>
        /// Start of app.
        /// </summary>
        /// <param name ="args">addet via console.</param>
        public static void Main(string[] args)
        {
            ElectricalAppliances[] deviceArray = new ElectricalAppliances[]
            {
                new InternalElectricalAppliances("Oven", "Bosh", 2500),
                new InternalElectricalAppliances("Hob", "Tefal", 6000),
                new InternalElectricalAppliances("TV", "LG", 100),
                new OutdoorElectricalAppliances("Flashlight", "Phillips", 200, 68),
                new OutdoorElectricalAppliances("pump", "Aquatica", 1300, 68),
            };

            ElectricalAppliances[] findByManufacturer = deviceArray.FindByManufacturer("LG");
            foreach (var t in findByManufacturer)
            {
                t.ShowInfo();
            }
        }
    }
}