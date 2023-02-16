using Microsoft.EntityFrameworkCore;
using Remotepractice.Data;

namespace Remotepractice.Repositories
{
    public class RemoteRepository<T> : IRemoteRepository<T> where T : class
    {
        private readonly RemotePracticeDbContext _context;
        private DbSet<T> dbEntity = null;
        public RemoteRepository(RemotePracticeDbContext Scontext)
        {
            _context = Scontext;
            dbEntity = _context.Set<T>();
        }
        public async Task<T> Add(T model)
        {
            var result = await dbEntity.AddAsync(model);
            await _context.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbEntity.ToListAsync();
        }

        public async Task<T> GetAllById(int modelId)
        {
            return await dbEntity.FindAsync(modelId);
        }

       

        public async void Update(T model)
        {
             dbEntity.Update(model);
            await _context.SaveChangesAsync();
            
        }
        

        public async void Delete(int modelId)
        {
            //var category = await GetAsync(modelId);

            //if (modelId is null)
            //{
            //    throw new Exception($"CategoryID {modelId} is not found.");
            //}
            //this._context.Set<T>().Remove(category);
            //await _context.SaveChangesAsync();
            var result = await dbEntity.FindAsync();
            if (result != null)
            {
                dbEntity.Remove(result);
                await _context.SaveChangesAsync();
            }

        }


        public async void Save()
        {
            await _context.SaveChangesAsync();
        }

       
    }

}