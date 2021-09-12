using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    
    public class Circle : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        
        public Guid shapeId { get; set; }

        [Required(ErrorMessage = "X offset is required")]
        public double offsetX { get; set; }

        [Required(ErrorMessage = "Y offset is required")]
        public double offsetY { get; set; }

        [Required(ErrorMessage = "Radius is required")]
        public float radius { get; set; }
    }
}