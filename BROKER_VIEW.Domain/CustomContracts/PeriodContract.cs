using System.Text.RegularExpressions;
using BROKER_VIEW.Domain.ValueObjects;
using Flunt.Validations;

namespace BROKER_VIEW.Domain.CustomContracts
{
    /// <summary>Defines generic validation for all Period types</summary>
    public class PeriodContract : Contract<Period>
    {
        /// <summary>Checks if the provided value has the expected length</summary>
        /// <param name="value">A string value to be validated</param>
        /// <param name="expectedLength">A Regex expression defining the expected value</param>
        /// <param name="propertyName">Name of the property to be validated</param>
        public void ExpectedLength(string propertyName, string value, int expectedLength)
        {
            if (value.Length != expectedLength)
            {
                AddNotification(propertyName, $"Comprimento inválido: {value.Length}");
            }
        }

        /// <summary>Checks if the provided value fullfils the requirements defined by pattern param</summary>
        /// <param name="value">A string value to be validated</param>
        /// <param name="pattern">A Regex expression defining the expected value</param>
        /// <param name="propertyName">Name of the property to be validated</param>
        public void ExpectedValue(string propertyName, string value, string pattern)
        {
            if (Regex.IsMatch(value, pattern))
            {
                AddNotification(propertyName, $"Valor inválido: {value}");
            }
        }

        /// <summary>Checks if the provided value fullfils the requirements defined by pattern param</summary>
        /// <param name="value">A string value to be validated</param>
        /// <param name="minValue">The minimum value accepted for the value property</param>
        /// <param name="maxValue">The maximum value accepted for the value property</param>
        /// <param name="propertyName">Name of the property to be validated</param>
        public void IsInRange(string propertyName, string value, int minValue, int maxValue)
        {
            if (int.TryParse(value, out int valueToValidate))
            {
                if (valueToValidate <= maxValue && valueToValidate >= minValue)
                {
                    AddNotification(propertyName, $"Valor fora do intervalo: {minValue} - {maxValue}");
                }
            }
        }
    }
}