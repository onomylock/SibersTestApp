using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProjectRepository ProjectRepository { get; }

        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            ProjectRepository = new ProjectRepository(context);
        }        

        public void Commit()
        {
            _context.SaveChanges();
        }
        public async Task CommitAsync() =>
            await _context.SaveChangesAsync();


        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    _context.Dispose();
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
