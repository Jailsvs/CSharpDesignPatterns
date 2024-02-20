using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Behavioural.Command
{
    public class LightPowerCommand : ISmartHouseCommand
    {
        private readonly SmartHouseLight Light;
        public LightPowerCommand(SmartHouseLight light)
        {
            Light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
