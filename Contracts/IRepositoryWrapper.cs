namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IDrawingRepository Drawing { get; }
        ICircleRepository Circle { get; }
        IRectangleRepository Rectangle { get; }
        ITriangleRepository Triangle { get; }
    }
}