namespace Store.Web.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Store.Web.Data.Entities;

    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {

        private readonly DataContext context;

        public GenericRepository(DataContext context)
        {
            this.context = context;
        }

        public IQueryable<T> GetAll()
        {
            return this.context.Set<T>().AsNoTracking().OrderBy(e => e.Name);
        }


        public async Task<T> GetByIdAsync(int id)
        {
            return await this.context.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }


        public async Task CreateAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
            await SaveAllAsync();
        }


        public async Task UpdateAsync(T entity)
        {
            this.context.Set<T>().Update(entity);
            await SaveAllAsync();
        }


        public async Task DeleteAsync(T entity)
        {
            this.context.Set<T>().Remove(entity);
            await SaveAllAsync();
        }

        private async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await this.context.Set<T>().AnyAsync(e => e.Id == id);
        }

    }
}