﻿using NetCoreWebAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Repository.Interfaces
{
    public interface ISpeakerRepository
    {
        Task<List<Speaker>> GetAllAsync(bool includeEvent = false);

        Task<Speaker> GetByIdAsync(int id, bool includeEvent = false);

        Task<List<Speaker>> GetByNameAsync(string name, bool includeEvent = false);
    }
}
