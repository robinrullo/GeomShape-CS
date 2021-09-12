using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Extensions;
using Entities.Models;

namespace Repository
{
    public class CircleRepository: RepositoryBase<Circle>, ICircleRepository
    {
        public CircleRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public IEnumerable<Circle> GetAllCircles()
        {
            return FindAll()
                .OrderBy(c => c.Id);
        }

        public Circle GetCircleById(Guid circleId)
        {
            return FindByCondition(circle => circle.Id.Equals(circleId))
                .DefaultIfEmpty(new Circle())
                .FirstOrDefault();
        }

        public void CreateCircle(Circle circle)
        {
            circle.Id = Guid.NewGuid();
            Create(circle);
            Save();
        }

        public void UpdateCircle(Circle dbCircle, Circle circle)
        {
            dbCircle.Map(circle);
            Update(circle);
            Save();
        }

        public void DeleteCircle(Circle circle)
        {
            Delete(circle);
            Save();
        }
    }
}