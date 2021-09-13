using Entities.Models;

namespace Entities.Extensions
{
    public static class RectangleExtensions
    {
        
        public static void Map(this Rectangle dbRectangle, Rectangle rectangle)
        {
            dbRectangle.OffsetX = rectangle.OffsetX;
            dbRectangle.OffsetY = rectangle.OffsetY;
            dbRectangle.LengthA = rectangle.LengthA;
            dbRectangle.LengthB = rectangle.LengthB;
        }
    }
}