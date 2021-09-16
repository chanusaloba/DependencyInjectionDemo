using System.Threading.Tasks;

namespace DependencyInjectionDemo.Interfaces
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}
