using Entities.Models;

namespace Entities.Extensions
{
    public static class CircleExtensions
    {
        
        public static void Map(this Circle dbCircle, Circle circle)
        {
            dbCircle.shapeId = circle.shapeId;
            dbCircle.offsetX = circle.offsetX;
            dbCircle.offsetY = circle.offsetY;
            dbCircle.radius = circle.radius;
        }
    }
}