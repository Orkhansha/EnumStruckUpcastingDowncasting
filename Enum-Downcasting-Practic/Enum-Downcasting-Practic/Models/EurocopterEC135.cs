using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Downcasting_Practic.Models
{
    public class EurocopterEC135: Eurocopter
    {
        public string Color { get; set; } = "Black";

        public override void Speed()
        {
            Console.WriteLine("EurocopterEC135 is fast");
        }
    }
}
