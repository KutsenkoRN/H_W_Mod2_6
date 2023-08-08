using System;
using System.Xml.Linq;

namespace H_W_Mod2_3
{/// <summary>
 /// Base.
 /// </summary>
    public abstract class ElectricalAppliances
    {/// <summary>
     /// Initializes a new instance of the <see cref="ElectricalAppliances"/> class.
     /// </summary>
     /// <param name="name">name.</param>
     /// <param name="manufacturer">brand.</param>
     /// <param name="watt">Energy consumption.</param>
        protected ElectricalAppliances(string name, string manufacturer, int watt)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Watt = watt;
        }

        /// <summary>
        /// Gets name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets Manufacturer.
        /// </summary>
        public string Manufacturer { get; }

        /// <summary>
        /// gets watt.
        /// </summary>
        public int Watt { get; }

        /// <summary>
        /// Info.
        /// </summary>
        public abstract void ShowInfo();
    }
}