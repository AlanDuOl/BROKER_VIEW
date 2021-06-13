using BROKER_VIEW.Shared.Entities;

namespace BROKER_VIEW.Domain.Entities
{
    /// <summary>Class that defines a Company object</summary>
    public class Company : Entity
    {
        /// <summary>The name of the Company object</summary>
        public string Name { get; private set; }
        /// <summary>The Sector of the Company object</summary>
        public Sector Sector { get; private set; }
    }
}