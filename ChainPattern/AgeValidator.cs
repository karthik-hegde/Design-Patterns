using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChainPattern
{
    public class AgeValidator : Validator
    {
        public override bool ValidateInput(RegistrationForm form)
        {
            if (form.Age < 18)
            {
                Console.WriteLine("Minors not allowed!");
                return false;
            }
            return true;
        }
    }
}