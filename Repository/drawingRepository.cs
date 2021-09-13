using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entities;
using Entities.Extensions;
using Entities.Models;

namespace Repository
{
    public class DrawingRepository: RepositoryBase<Drawing>, IDrawingRepository
    {
        public DrawingRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        public IEnumerable<Drawing> GetAllDrawings()
        {
            return FindAll()
                .OrderBy(c => c.Id);
        }

        public Drawing GetDrawingById(Guid drawingId)
        {
            return FindByCondition(drawing => drawing.Id.Equals(drawingId))
                .DefaultIfEmpty(new Drawing())
                .FirstOrDefault();
        }

        public void CreateDrawing(Drawing drawing)
        {
            drawing.Id = Guid.NewGuid();
            Create(drawing);
            Save();
        }

        public void UpdateDrawing(Drawing dbDrawing, Drawing drawing)
        {
            dbDrawing.Map(drawing);
            Update(drawing);
            Save();
        }

        public void DeleteDrawing(Drawing drawing)
        {
            Delete(drawing);
            Save();
        }
    }
}