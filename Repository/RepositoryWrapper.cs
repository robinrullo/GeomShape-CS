using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IDrawingRepository _drawing;
        private ICircleRepository _circle;
        private IRectangleRepository _rectangle;
        private ITriangleRepository _triangle;

        
        public IDrawingRepository Drawing
        {
            get
            {
                if (_drawing == null)
                {
                    _drawing = new DrawingRepository(_repoContext);
                }

                return _drawing;
            }
        }
        
        public ICircleRepository Circle
        {
            get
            {
                if (_circle == null)
                {
                    _circle = new CircleRepository(_repoContext);
                }

                return _circle;
            }
        }

        public IRectangleRepository Rectangle
        {
            get
            {
                if (_rectangle == null)
                {
                    _rectangle = new RectangleRepository(_repoContext);
                }

                return _rectangle;
            }
        }
        
        public ITriangleRepository Triangle
        {
            get
            {
                if (_triangle == null)
                {
                    _triangle = new TriangleRepository(_repoContext);
                }

                return _triangle;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}