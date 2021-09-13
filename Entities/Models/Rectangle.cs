using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Rectangle : Shape
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public float LengthA { get; set; }
        public float LengthB { get; set; }
    }
}