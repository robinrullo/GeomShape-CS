using System;

namespace Entities.Models
{
    public abstract class Shape : IEntity
    {
        public Guid Id { get; set; }
        
        public Guid DrawingId { get; set; }
        public double OffsetX { get; set; }
        public double OffsetY { get; set; }
    }
}