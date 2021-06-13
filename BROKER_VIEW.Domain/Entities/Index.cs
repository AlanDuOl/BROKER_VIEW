using System;
using BROKER_VIEW.Domain.ValueObjects;
using BROKER_VIEW.Shared.Entities;

namespace BROKER_VIEW.Domain.Entities
{
    /// <summary>Class that defines an Index object</summary>
    public abstract class Index : Entity
    {
        /// <summary>The value of the Index object</summary>
        public double Value { get; private set; }
        /// <summary>The Year of the Index object</summary>
        public Year Year { get; private set; }
        /// <summary>The Semester of the Index object</summary>
        public Semester Semester { get; private set; }
        /// <summary>The Quarter of the Index object</summary>
        public Quarter Quarter { get; private set; }
        /// <summary>The Month of the Index object</summary>
        public Month Month { get; private set; }
    }
}