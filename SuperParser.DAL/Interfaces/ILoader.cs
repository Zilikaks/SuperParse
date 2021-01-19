using System.Threading.Tasks;

namespace SuperParser.DAL.Interfaces
{
    public interface ILoader<T>
    {
        Task<T> GetResponseAsync(string url);
    }
}
