namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ICircleRepository Circle { get; }
        IRectangleRepository Rectangle { get; }
        ITriangleRepository Triangle { get; }
    }
}