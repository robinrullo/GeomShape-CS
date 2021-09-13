using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public class Drawing : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Shape> Shapes { get; set; }
        
    }
}