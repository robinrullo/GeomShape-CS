using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("triangle")]
    public class Triangle : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        
        public Guid shapeId { get; set; }
        
        public double offsetX { get; set; }
        
        public double offsetY { get; set; }
        
        public float lengthA { get; set; }
        
        public float lengthB { get; set; }
        
        public float lengthC { get; set; }
    }
}