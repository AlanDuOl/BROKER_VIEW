using BROKER_VIEW.Domain.CustomContracts;

namespace BROKER_VIEW.Domain.ValueObjects
{
    /// <summary>Class that defines a Semester object</summary>
    public class Semester : Period
    {
        /// <summary>Instanciate a new Semester object</summary>
        /// <param name="value">A string value used to assign a value to the Value property of the object</param>
        public Semester(string value) : base(value)
        {
            PeriodContract contract = new PeriodContract();
            contract.ExpectedLength("Semester.Value", value, 1);
            contract.ExpectedValue("Semester.Value", value, @"^[12]$");
            AddNotifications(contract);
        }
    }
}