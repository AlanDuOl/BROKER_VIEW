
using BROKER_VIEW.Shared.Entities;

namespace BROKER_VIEW.Domain.Entities
{
    /// <summary>Class that defines a Sector object</summary>
    public class Sector : Entity
    {
        /// <summary>Name of a Sector object</summary>
        public string Name { get; private set; }
    }
}