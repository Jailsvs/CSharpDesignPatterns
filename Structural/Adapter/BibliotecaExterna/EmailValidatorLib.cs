using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDesignPatterns.Structural.Adapter.BibliotecaExterna
{
    public class EmailValidationException : Exception
    {
        public EmailValidationException(string message, Exception? innerException = null) : base(message, innerException) { }
    }
    public class EmailValidatorLib
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new EmailValidationException("O e-mail não pode ser nulo ou vazio.");

            try
            {
                // Define a expressão regular para validar o e-mail
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                // Cria um objeto Regex com o padrão
                Regex regex = new Regex(pattern);

                // Testa o e-mail contra a expressão regular
                if (!regex.IsMatch(email))
                    throw new EmailValidationException("O formato do e-mail é inválido.");

                return true;
            }
            catch (RegexMatchTimeoutException ex)
            {
                throw new EmailValidationException("A validação do e-mail excedeu o tempo limite.", ex);
            }
        }
    }
}
