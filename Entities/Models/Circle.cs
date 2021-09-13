using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    
    public class Circle : Shape
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public float Radius { get; set; }
    }
}