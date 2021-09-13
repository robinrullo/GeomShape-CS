using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("triangle")]
    public class Triangle : Shape
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public float LengthA { get; set; }
        public float LengthB { get; set; }
        public float LengthC { get; set; }
    }
}