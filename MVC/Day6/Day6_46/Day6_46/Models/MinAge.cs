using System.ComponentModel.DataAnnotations;

namespace Day6_46.Models
{
    public class MinAge : ValidationAttribute
    {
        int AgeValue;
        public MinAge(int num)   //to be checked against
        { 
            AgeValue = num;
        }

        public override bool IsValid(object obj)   // value of user input
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (obj is int)
                {
                    int suppliedValue = (int)obj;
                    if (suppliedValue > AgeValue)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = " **** Age Value Should be + " + AgeValue;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
