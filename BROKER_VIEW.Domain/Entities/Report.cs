using BROKER_VIEW.Shared.Entities;

namespace BROKER_VIEW.Domain.Entities
{
    /// <summary>Defines an Index object</summary>
    public abstract class Report : Entity
    {
        /// <summary>The Company of the Report object</summary>
        public Company Company { get; private set; }
    }
}