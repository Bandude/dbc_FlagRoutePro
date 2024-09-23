
using dbc_FlagRoutePro.Data;
using dbc_FlagRoutePro.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace dbc_FlagRoutePro.Repositories
{
    public class EfRepository<T> : IEntityRepository<T> where T : class
    {
        private readonly SubscriptionDbContext _context;
        private readonly ILogger<EfRepository<T>> _logger;
        private readonly DbSet<T> _dbSet;
        public EfRepository(SubscriptionDbContext context, ILogger<EfRepository<T>> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dbSet = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            _logger.LogInformation("Getting all entities of type {EntityType}", typeof(T).Name);
            return await _dbSet.ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            _logger.LogInformation("Getting entity of type {EntityType} with id {Id}", typeof(T).Name, id);
            return await _dbSet.FindAsync(id);
        }
        public async Task AddAsync(T entity)
        {
            if (entity == null)
            {
                _logger.LogWarning("Attempted to add a null entity of type {EntityType}", typeof(T).Name);
                throw new ArgumentNullException(nameof(entity));
            }
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Added entity of type {EntityType}", typeof(T).Name);
        }
        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                _logger.LogWarning("Attempted to update a null entity of type {EntityType}", typeof(T).Name);
                throw new ArgumentNullException(nameof(entity));
            }
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Updated entity of type {EntityType}", typeof(T).Name);
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                _logger.LogWarning("Attempted to delete a non-existent entity of type {EntityType}", typeof(T).Name);
                throw new KeyNotFoundException($"Entity of type {typeof(T).Name} with id {id} not found");
            }
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Deleted entity of type {EntityType} with id {Id}", typeof(T).Name, id);
        }
    }
}
