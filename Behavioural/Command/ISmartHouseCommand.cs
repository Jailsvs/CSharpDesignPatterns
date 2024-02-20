namespace CSharpDesignPatterns.Behavioural.Command
{
    public interface ISmartHouseCommand
    {
        void Execute();
        void Undo();
    }
}
