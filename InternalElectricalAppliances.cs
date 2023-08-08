using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod2_3
{/// <summary>
 /// class InternalElectricalAppliances.
 /// </summary>
    public class InternalElectricalAppliances : ElectricalAppliances
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalElectricalAppliances"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="manufacturer">brand.</param>
        /// <param name="watt">Energy consumption.</param>
        public InternalElectricalAppliances(string name, string manufacturer, int watt)
            : base(name, manufacturer, watt)
        {
        }

        /// <summary>
        /// info.
        /// </summary>
        public override void ShowInfo()
        {
            Console.WriteLine($"Device {this.Name} from manufacturer {this.Manufacturer} has a power of {this.Watt} watts");
        }
    }
}