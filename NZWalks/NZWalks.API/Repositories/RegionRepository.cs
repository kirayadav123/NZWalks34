using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;
        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
           this.nZWalksDbContext = nZWalksDbContext;
        }

        public async Task<Region> AddAsync(Region region)
        {
            region.Id= Guid.NewGuid();
            await nZWalksDbContext.AddAsync(region);
            await nZWalksDbContext.SaveChangesAsync();
            return region;

        }

        public  async Task<Region> DeleteAsync(Guid id)
        {
             var region = await nZWalksDbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
            if (region == null)
            {
                return null;
            }
            //Delete the Region
            nZWalksDbContext.Regions.Remove(region);
            await nZWalksDbContext.SaveChangesAsync();
            return region;
        }

        public async Task <IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalksDbContext.Regions.ToListAsync();
        }

        public async Task<Region> GetAsync(Guid Id)
        {
            return await nZWalksDbContext.Regions.FirstOrDefaultAsync(r => r.Id == Id);
            

        }

        public async Task<Region> UpdateAsync(Guid id, Region r3)
        {
            var existingregion = await nZWalksDbContext.Regions.FirstOrDefaultAsync(r => r.Id == id);
            {
                if (existingregion == null)
                {
                    return null;
                }
                existingregion.Code = r3.Code;
                existingregion.Name = r3.Name;
                existingregion.Area = r3.Area;
                existingregion.Lat = r3.Lat;
                existingregion.Long = r3.Long;
                existingregion.Population = r3.Population;

                await nZWalksDbContext.SaveChangesAsync();

                return existingregion;
            }
        }
    }
}
