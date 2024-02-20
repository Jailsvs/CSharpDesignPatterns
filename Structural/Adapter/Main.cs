using CSharpDesignPatterns.Structural.Adapter.BibliotecaExterna;
using System;

namespace CSharpDesignPatterns.Structural.Adapter
{
    public static class Main
    {
        public static void Execute()
        {
            Console.WriteLine("Adapter");
            var emailValido = "jailsvs@gmail.com";
            var emailInvalido = "jailsvs";

            var mailValidatorClass = new EmailValidatorClassAdapter();
            ExecutarConsole(emailValido, "CLASS", mailValidatorClass.IsEmailValid(emailValido));
            ExecutarConsole(emailInvalido, "CLASS", mailValidatorClass.IsEmailValid(emailInvalido));

            EmailValidatorFnProtocol mailValidatorFn = IsEmailValid;
            ExecutarConsole(emailValido, "FUNCTION", mailValidatorFn(emailValido));
            ExecutarConsole(emailInvalido, "FUNCTION", mailValidatorFn(emailInvalido));
        }

        private static void ExecutarConsole(string email, string tipoExecucao, bool emailValido)
        {
            if (emailValido)
                Console.WriteLine($"Email [{email}] é válido ({tipoExecucao})");
            else
                Console.WriteLine($"Email [{email}] é inválido ({tipoExecucao})");
        }

        private static bool IsEmailValid(string email)
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
