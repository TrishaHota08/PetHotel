using System.ComponentModel.DataAnnotations;

namespace CatPetHotelApp.ValidationAttributes
{
    public class MaxByteLengthAttribute: ValidationAttribute
    {
        private readonly int maxByteLength;

        public MaxByteLengthAttribute(int maxByteLength)
        {
            this.maxByteLength= maxByteLength;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value is byte[] byteArray)
            {
                if(byteArray.Length > maxByteLength)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}
