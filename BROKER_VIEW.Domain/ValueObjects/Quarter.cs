using BROKER_VIEW.Domain.CustomContracts;

namespace BROKER_VIEW.Domain.ValueObjects
{
    /// <summary>Class that defines a Quarter object</summary>
    public class Quarter : Period
    {
        /// <summary>Instanciate a new Quarter object</summary>
        /// <param name="value">A string value used to assign a value to the Value property</param>
        public Quarter(string value) : base(value)
        {
            PeriodContract contract = new PeriodContract();
            contract.ExpectedLength("Quarter.Value", value, 1);
            contract.ExpectedValue("Quarter.Value", value, @"^[1-4]$");
            AddNotifications(contract);
        }
    }
}