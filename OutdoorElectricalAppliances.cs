using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using H_W_Mod2_3;

namespace H_W_Mod2_6
{/// <summary>
 /// OutdoorElectricalAppliances.
 /// </summary>
    public class OutdoorElectricalAppliances : InternalElectricalAppliances
    {
        private int ipClass;

        /// <summary>
        /// Initializes a new instance of the <see cref="OutdoorElectricalAppliances"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="manufacturer">brand.</param>
        /// <param name="watt">Energy consumption.</param>
        /// <param name="ipClass">protection class.</param>
        public OutdoorElectricalAppliances(string name, string manufacturer, int watt, int ipClass)
            : base(name, manufacturer, watt)
        {
            this.ipClass = ipClass;
        }

        /// <summary>
        /// info.
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"The device {this.Name} has the protection class {this.ipClass}");
        }
    }
}