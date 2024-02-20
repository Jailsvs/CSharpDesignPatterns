using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Behavioural.Command
{
    public class SmartHouseLight
    {
        private bool IsOn { get; set; }
        private int Intensity { get; set; }
        public string Name { get; set; }

        public SmartHouseLight(string name)
        {
            Name = name;
        }

        public string GetPowerStatus() => IsOn ? "ON" : "OFF";

        public bool On()
        {
            IsOn = true;
            Console.WriteLine($"{Name} agora está {GetPowerStatus()}");
            return IsOn;
        }

        public bool Off()
        {
            IsOn = false;
            Console.WriteLine($"{Name} agora está {GetPowerStatus()}");
            return IsOn;
        }

        public int IncreaseIntensity()
        {
            if (Intensity >= 100) return Intensity;
            Intensity += 1;
            return Intensity;
        }

        public int DecreaseIntensity()
        {
            if (Intensity <= 0) return Intensity;
            Intensity -= 1;
            return Intensity;
        }

    }
}
