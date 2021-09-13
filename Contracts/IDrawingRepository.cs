using System;
using System.Collections.Generic;
using Entities.Models;

namespace Contracts
{
    public interface IDrawingRepository
    {
        IEnumerable<Drawing> GetAllDrawings();
        Drawing GetDrawingById(Guid drawingId);
        void CreateDrawing(Drawing drawing);
        void UpdateDrawing(Drawing dbDrawing, Drawing drawing);
        void DeleteDrawing(Drawing drawing);
    }
}