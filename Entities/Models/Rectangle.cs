using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Rectangle : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "The id of Parent shape is required")]
        public Guid shapeId { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public double offsetX { get; set; }

        [Required(ErrorMessage = "Account type is required")]
        public double offsetY { get; set; }

        [Required(ErrorMessage = "Length A is required")]
        public float lengthA { get; set; }

        [Required(ErrorMessage = "Length B is required")]
        public float lengthB { get; set; }
    }
}