﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CatPetHotelApp.ValidationAttributes
{
    public class DateGreaterThanAttribute:ValidationAttribute
    {
        private readonly string comparison;

        public DateGreaterThanAttribute(string comparisonString)
        {
         comparison=comparisonString;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var propertyInfo = validationContext.ObjectType.GetProperty(comparison);
            var comparisonValue = (DateTime)propertyInfo.GetValue(validationContext.ObjectInstance);

            if (value != null && comparisonValue >= (DateTime)value)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
