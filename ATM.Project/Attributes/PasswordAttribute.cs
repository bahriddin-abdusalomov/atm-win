using System;
using System.ComponentModel.DataAnnotations;

namespace ATM.Project.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class PasswordAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null || !(value is string))
            {
                return false; // Null qiymat yoki qiymat tipi not string bo'lsa, validatsiya o'tkazilmaydi
            }

            string password = (string)value;

            if (password.Length == 4 && int.TryParse(password, out _))
            {
                return true; // Parol 4 ta raqamdan tashkil topgan bo'lsa
            }

            return false; // Parol 4 ta raqamdan tashkil topmagan bo'lsa
        }
    }
}
