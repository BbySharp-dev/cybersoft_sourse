using System.ComponentModel.DataAnnotations;

class CustomDataAnnotation
{
    public class MinMaxValueAttribute : ValidationAttribute
    {
        private readonly string _minValuePropertyName;
        private readonly string _maxValuePropertyName;

        public MinMaxValueAttribute(string minValuePropertyName, string maxValuePropertyName)
        {
            _minValuePropertyName = minValuePropertyName;
            _maxValuePropertyName = maxValuePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var maxValueProperty = validationContext.ObjectType.GetProperty(_maxValuePropertyName);
            var minValueProperty = validationContext.ObjectType.GetProperty(_minValuePropertyName);
            if (maxValueProperty == null)
            {
                return new ValidationResult($"Property '{_maxValuePropertyName}' not found.");
            }
            if (minValueProperty == null)
            {
                return new ValidationResult($"Property '{_minValuePropertyName}' not found.");
            }

            var maxValue = (double)maxValueProperty.GetValue(validationContext.ObjectInstance);
            var minValue = (double)minValueProperty.GetValue(validationContext.ObjectInstance);
            var currentValue = (double)value;

            if (!(minValue<=currentValue && currentValue <= maxValue))
            {
                return new ValidationResult($"Giá trị phải lớn hơn hoặc bằng {minValue} và nhỏ hơn hoặc bằng {maxValue}.");
            }

            return ValidationResult.Success;
        }
    }
}