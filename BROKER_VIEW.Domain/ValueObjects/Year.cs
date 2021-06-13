using System;
using BROKER_VIEW.Domain.CustomContracts;

namespace BROKER_VIEW.Domain.ValueObjects
{
    /// <summary>Class that defines a Year object</summary>
    public class Year : Period
    {
        /// <summary>Instanciate a new Year object</summary>
        /// <param name="value">A string value used to assign a value to the Value property of the object</param>
        public Year(string value) : base(value)
        {
            PeriodContract contract = new PeriodContract();
            contract.ExpectedLength("Year.Value", value, 4);
            contract.ExpectedValue("Year.Value", value, @"^[0-9]{4}$");
            contract.IsInRange("Year.Value", value, 1980, DateTime.Now.Year + 5);
            AddNotifications(contract);
        }
    }
}