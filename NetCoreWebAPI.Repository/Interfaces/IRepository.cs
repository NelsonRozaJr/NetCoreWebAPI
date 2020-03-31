﻿using System.Threading.Tasks;

namespace NetCoreWebAPI.Repository.Interfaces
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();
    }
}
