using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Entities.Extensions;

namespace Repository
{
    public class TriangleRepository: RepositoryBase<Triangle>, ITriangleRepository
    {
        public TriangleRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public IEnumerable<Triangle> GetAllTriangles()
        {
            return FindAll()
                .OrderBy(t => t.Id);
        }

        public Triangle GetTriangleById(Guid triangleId)
        {
            return FindByCondition(triangle => triangle.Id.Equals(triangleId))
                .DefaultIfEmpty(new Triangle())
                .FirstOrDefault();
        }

        public void CreateTriangle(Triangle triangle)
        {
            triangle.Id = Guid.NewGuid();
            Create(triangle);
            Save();
        }

        public void UpdateTriangle(Triangle dbTriangle, Triangle triangle)
        {
            dbTriangle.Map(triangle);
            Update(dbTriangle);
            Save();
        }

        public void DeleteTriangle(Triangle triangle)
        {
            Delete(triangle);
            Save();
        }
    }
}