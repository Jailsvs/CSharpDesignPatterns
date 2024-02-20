namespace CSharpDesignPatterns.Structural.Adapter
{
    public interface IEmailValidatorProtocol
    {
        bool IsEmailValid(string email);
    }

    public delegate bool EmailValidatorFnProtocol(string value);

}
