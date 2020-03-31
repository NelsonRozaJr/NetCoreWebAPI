﻿using NetCoreWebAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Repository.Interfaces
{
    public interface IEventRepository
    {
        Task<List<Event>> GetAllAsync(bool includeSpeaker = false);

        Task<List<Event>> GetByTopicAsync(string topic, bool includeSpeaker = false);

        Task<Event> GetByIdAsync(int id, bool includeSpeaker = false);
    }
}
