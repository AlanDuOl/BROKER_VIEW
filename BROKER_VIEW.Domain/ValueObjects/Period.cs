using BROKER_VIEW.Shared.ValueObjects;

namespace BROKER_VIEW.Domain.ValueObjects
{
    /// <summary>Class that defines a Period object</summary>
    public abstract class Period : ValueObject
    {
        /// <summary>Instanciate a new Period object</summary>
        /// <param name="value">A string value used to assign a value to the Value property</param>
        protected Period(string value)
        {
            Value = value;
        }
        /// <summary>A string value for the period</summary>
        public string Value { get; private set; }
    }
}