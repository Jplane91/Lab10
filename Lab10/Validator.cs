using System;
namespace Lab10
{
    public class Validator
    {
        public bool Validate()
        {
            string input = " ";
            int userChoice;
            if (int.TryParse(input, out userChoice))
            {
                return true;
            }

            else
            {
                return Validate();
            }
        }

    
    }
}
