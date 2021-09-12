using Contracts;
using Entities;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Entities.Extensions;

namespace Repository
{
    public class RectangleRepository: RepositoryBase<Rectangle>, IRectangleRepository
    {
        public RectangleRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public IEnumerable<Rectangle> GetAllRectangles()
        {
            return FindAll()
                .OrderBy(r => r.Id);
        }

        public Rectangle GetRectangleById(Guid rectangleId)
        {
            return FindByCondition(rectangle => rectangle.Id.Equals(rectangleId))
                .DefaultIfEmpty(new Rectangle())
                .FirstOrDefault();
        }

        public void CreateRectangle(Rectangle rectangle)
        {
            rectangle.Id = Guid.NewGuid();
            Create(rectangle);
            Save();
        }

        public void UpdateRectangle(Rectangle dbRectangle, Rectangle rectangle)
        {
            dbRectangle.Map(rectangle);
            Update(dbRectangle);
            Save();
        }

        public void DeleteRectangle(Rectangle rectangle)
        {
            Delete(rectangle);
        }
    }
}