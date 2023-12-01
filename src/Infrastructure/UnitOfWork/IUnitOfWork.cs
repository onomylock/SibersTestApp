using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository ProjectRepository { get; }
        
        void Commit();
        Task CommitAsync();
    }
}
