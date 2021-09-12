using Entities.Models;

namespace Entities.Extensions
{
    public static class TriangleExtensions
    {
        
        public static void Map(this Triangle dbTriangle, Triangle triangle)
        {
            dbTriangle.shapeId = triangle.shapeId;
            dbTriangle.offsetX = triangle.offsetX;
            dbTriangle.offsetY = triangle.offsetY;
            dbTriangle.lengthA = triangle.lengthA;
            dbTriangle.lengthB = triangle.lengthB;
            dbTriangle.lengthC = triangle.lengthC;
        }
    }
}