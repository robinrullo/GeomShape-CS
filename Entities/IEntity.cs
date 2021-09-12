using System;

public interface IEntity
{
    Guid Id { get; set; }
    
    Guid shapeId { get; set; }
    
    double offsetX { get; set; }
    
    double offsetY { get; set; }
    
}