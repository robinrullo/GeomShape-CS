using Entities.Models;

namespace Entities.Extensions
{
    public static class DrawingExtensions
    {
        
        public static void Map(this Drawing dbDrawing, Drawing drawing)
        {
            dbDrawing.Name = drawing.Name;
            dbDrawing.Description = drawing.Description;
            dbDrawing.Shapes = drawing.Shapes;
        }
    }
}