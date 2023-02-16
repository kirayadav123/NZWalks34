namespace Remotepractice.Repositories
{
    public interface IRemoteRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetAllById(int modelId);

        Task<T> Add(T model);

        void Update(T model);
        void Delete(int modelId);
        void Save();

    }
    }
