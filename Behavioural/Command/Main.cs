namespace CSharpDesignPatterns.Behavioural.Command
{
    public static class Main
    {
        public static void Execute()
        {
            Console.WriteLine("Command");
            // Receiver
            var bedroomLight = new SmartHouseLight("Luz Quarto");
            var bathroomLight = new SmartHouseLight("Luz Banheiro");

            // Command
            var bedroomLightPowerCommand = new LightPowerCommand(bedroomLight);
            var bathroomLightPowerCommand = new LightPowerCommand(bathroomLight);
            var bedroomIntensityCommand = new LightIntensityCommand(bedroomLight);

            // Controle - Invoker
            var smartHouseApp = new SmartHouseApp();
            smartHouseApp.AddCommand("btn-1", bedroomLightPowerCommand);
            smartHouseApp.AddCommand("btn-2", bathroomLightPowerCommand);
            smartHouseApp.AddCommand("btn-3", bedroomIntensityCommand);

            smartHouseApp.ExecuteCommand("btn-1");
            smartHouseApp.UndoCommand("btn-1");

            smartHouseApp.ExecuteCommand("btn-2");
            smartHouseApp.UndoCommand("btn-2");

            for (var i = 0; i < 5; i++)
            {
                smartHouseApp.ExecuteCommand("btn-3");
            }

            for (var i = 0; i < 3; i++)
            {
                smartHouseApp.ExecuteCommand("btn-3");
            }
        }
    }
}
