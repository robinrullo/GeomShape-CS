using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface ITriangleRepository
    {
        IEnumerable<Triangle> GetAllTriangles();
        Triangle GetTriangleById(Guid triangleId);
        void CreateTriangle(Triangle triangle);
        void UpdateTriangle(Triangle dbTriangle, Triangle triangle);
        void DeleteTriangle(Triangle triangle);
    }
}