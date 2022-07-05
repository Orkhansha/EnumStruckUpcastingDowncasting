using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Downcasting_Practic.Models
{
    public class Bell407: Bell
    {
        public int HorsePower { get; set; } = 600;

        public override void Speed()
        {
            Console.WriteLine("Bell-407 is fast");
        }
    }
}
