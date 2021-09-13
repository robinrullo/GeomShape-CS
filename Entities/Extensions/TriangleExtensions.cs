using Entities.Models;

namespace Entities.Extensions
{
    public static class TriangleExtensions
    {
        
        public static void Map(this Triangle dbTriangle, Triangle triangle)
        {
            dbTriangle.OffsetX = triangle.OffsetX;
            dbTriangle.OffsetY = triangle.OffsetY;
            dbTriangle.LengthA = triangle.LengthA;
            dbTriangle.LengthB = triangle.LengthB;
            dbTriangle.LengthC = triangle.LengthC;
        }
    }
}