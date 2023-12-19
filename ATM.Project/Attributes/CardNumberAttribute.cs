using System;
using System.ComponentModel.DataAnnotations;

namespace ATM.Project.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class CardNumberAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null || !(value is string))
            {
                return false; // Null qiymat yoki qiymat tipi not string bo'lsa, validatsiya o'tkaziladi
            }

            string cardNumber = (string)value;

            if (cardNumber.Length == 16 && long.TryParse(cardNumber, out _))
            {
                return true; // Karta raqami 16 ta raqamdan tashkil topgan bo'lsa
            }

            return false; // Karta raqami 16 ta raqamdan tashkil topmagan bo'lsa
        }
    }
}
