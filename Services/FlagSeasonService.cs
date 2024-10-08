﻿using dbc_FlagRoutePro.Entities;
using dbc_FlagRoutePro.Interfaces;

namespace dbc_FlagRoutePro.Services
{
    public class FlagSeasonService : IFlagSeasonService
    {
        private IEntityRepository<FlagSeason> _entityRepository;
        private readonly ILogger<FlagSeason> _logger;

        public FlagSeasonService(ILogger<FlagSeason> logger, IEntityRepository<FlagSeason> entityRepository)
        {
            _entityRepository = entityRepository;
            _logger = logger;
        }
        public async Task AddAsync(FlagSeason item)
        {
            if (item == null)
            {
                _logger.LogWarning("Attempted to add a null item.");
                throw new ArgumentNullException(nameof(item));
            }
            try
            {
                await _entityRepository.AddAsync(item);
                _logger.LogInformation("FlagSeason added: {ItemName}", item.Name);
            }
            catch (Exception ex)
            {
                _logger.LogError("There was a problem adding: {ItemName} | {ex}", item.Name, ex.Message);
            }
        }
        public async Task DeleteAsync(int id)
        {
            try
            {
                await _entityRepository.DeleteAsync(id);
                _logger.LogInformation("FlagSeaslon {Id} Removed", id);
            }
            catch (Exception ex)
            {
                _logger.LogError("There was a problem removing FlagSeason ID: {Id} | {ex}", id, ex.Message);
            }
        }
        public async Task UpdateAsync(FlagSeason item)
        {
            if (item == null)
            {
                _logger.LogWarning("Attempted to update a null item.");
                throw new ArgumentNullException(nameof(item));
            }
            try
            {
                await _entityRepository.UpdateAsync(item);
                _logger.LogInformation("FlagSeason updated: {ItemName}", item.Name);
            }
            catch (Exception ex)
            {
                _logger.LogError("There was a problem updating: {ItemName} | {ex}", item.Name, ex.Message);
            }
        }
        public async Task<FlagSeason> GetByIdAsync(int id)
        {
            try
            {
                var item = await _entityRepository.GetByIdAsync(id);
                if (item == null)
                {
                    _logger.LogWarning("No FlagSeason found for ID: {Id}", id);
                    return null;
                }
                _logger.LogInformation("FlagSeason found for ID: {Id}", id);
                return item;
            }
            catch (Exception ex)
            {
                _logger.LogError("There was a problem retrieving FlagSeason ID: {Id} | {ex}", id, ex.Message);
                throw;
            }
        }
        public async Task<IEnumerable<FlagSeason>> GetAllAsync()
        {
            try
            {
                var items = await _entityRepository.GetAllAsync();
                _logger.LogInformation("Retrieved all FlagSeasons");
                return items;
            }
            catch (Exception ex)
            {
                _logger.LogError("There was a problem retrieving all FlagSeasons | {ex}", ex.Message);
                throw;
            }
        }

    }
}
