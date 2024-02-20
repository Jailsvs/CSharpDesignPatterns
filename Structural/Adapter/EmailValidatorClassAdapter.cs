using CSharpDesignPatterns.Structural.Adapter.BibliotecaExterna;

namespace CSharpDesignPatterns.Structural.Adapter
{
    public class EmailValidatorClassAdapter : IEmailValidatorProtocol
    {
        public bool IsEmailValid(string email)
        {
			try
			{
                return EmailValidatorLib.IsValidEmail(email);
			}
			catch (Exception)
			{
                return false;
			}
        }
    }
}
