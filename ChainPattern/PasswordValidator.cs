using System.Text.RegularExpressions;

namespace ChainPattern
{
    public class PasswordValidator : Validator
    {
        public override bool ValidateInput(RegistrationForm form)
        {
            if (form.Password.Length < 8 || !Regex.IsMatch(form.Password, @"[0-9]") ||
            !Regex.IsMatch(form.Password, @"[A-Z]") ||
            !Regex.IsMatch(form.Password, @"[!@#$%^&*(),.?:{}|<>]"))
            {
                Console.WriteLine("Invalid password");
                return false;
            }

            return true;
        }
    }
}