using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ATM.Project.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class PhoneAttribute : ValidationAttribute
    {
        private readonly string _pattern = @"^\+[1-9]\d{1,14}$"; // Telefon raqamlari uchun Regex

        public override bool IsValid(object value)
        {
            if (value == null || !(value is string))
            {
                return false; // Null qiymat yoki qiymat tipi not string bo'lsa, validatsiya o'tkazilmaydi
            }

            string phoneNumber = (string)value;

            if (Regex.IsMatch(phoneNumber, _pattern))
            {
                return true; // Telefon raqami formatga mos keladi
            }

            return false; // Telefon raqami formatga mos kelmaydi
        }
    }
}
