using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Behavioural.Command
{
    public class LightIntensityCommand : ISmartHouseCommand
    {
        private readonly SmartHouseLight Light;
        public LightIntensityCommand(SmartHouseLight light)
        {
            Light = light ?? throw new ArgumentNullException(nameof(light));
        }

        public void Execute()
        {
            var intensity = Light.IncreaseIntensity();
            Console.WriteLine($"Intensidade de {Light.Name} é {intensity}");
        }

        public void Undo()
        {
            var intensity = Light.DecreaseIntensity();
            Console.WriteLine($"Intensidade de {Light.Name} é {intensity}");
        }
    }
}
