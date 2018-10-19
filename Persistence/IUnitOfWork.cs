using System.Threading.Tasks;

namespace angular_dotnet.Persistence
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}