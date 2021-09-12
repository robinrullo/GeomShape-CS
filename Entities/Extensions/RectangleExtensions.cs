using Entities.Models;

namespace Entities.Extensions
{
    public static class RectangleExtensions
    {
        
        public static void Map(this Rectangle dbRectangle, Rectangle rectangle)
        {
            dbRectangle.shapeId = rectangle.shapeId;
            dbRectangle.offsetX = rectangle.offsetX;
            dbRectangle.offsetY = rectangle.offsetY;
            dbRectangle.lengthA = rectangle.lengthA;
            dbRectangle.lengthB = rectangle.lengthB;
        }
    }
}