using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IRectangleRepository
    {
        IEnumerable<Rectangle> GetAllRectangles();
        Rectangle GetRectangleById(Guid rectangleId);
        void CreateRectangle(Rectangle rectangle);
        void UpdateRectangle(Rectangle dbRectangle, Rectangle rectangle);
        void DeleteRectangle(Rectangle rectangle);
    }
}