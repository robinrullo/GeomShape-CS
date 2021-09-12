using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface ICircleRepository
    {
        IEnumerable<Circle> GetAllCircles();
        Circle GetCircleById(Guid circleId);
        void CreateCircle(Circle circle);
        void UpdateCircle(Circle dbCircle, Circle circle);
        void DeleteCircle(Circle circle);
    }
}