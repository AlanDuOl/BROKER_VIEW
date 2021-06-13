using System.Text.RegularExpressions;
using BROKER_VIEW.Domain.CustomContracts;
using Flunt.Validations;

namespace BROKER_VIEW.Domain.ValueObjects
{
    /// <summary>Class that defines a Month object</summary>
    public class Month : Period
    {
        /// <summary>Instanciate a new Month object</summary>
        /// <param name="value">A string value used to assign a value to the Value property</param>
        public Month(string value) : base(value)
        {
            PeriodContract contract = new PeriodContract();
            contract.ExpectedLength("Month.Value", value, 2);
            contract.ExpectedValue("Month.Value", value, @"^(0[1-9])$|^(1[0-2])$");
            AddNotifications(contract);
        }
    }
}