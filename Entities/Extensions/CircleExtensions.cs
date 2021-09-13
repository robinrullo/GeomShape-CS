using Entities.Models;

namespace Entities.Extensions
{
    public static class CircleExtensions
    {
        
        public static void Map(this Circle dbCircle, Circle circle)
        {
            dbCircle.OffsetX = circle.OffsetX;
            dbCircle.OffsetY = circle.OffsetY;
            dbCircle.Radius = circle.Radius;
        }
    }
}