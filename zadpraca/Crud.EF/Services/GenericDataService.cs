﻿using Crud.domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.EF.Services
{
    public class GenericDataService<T> : IDataService<T> where T : class
    {
        private readonly ProductContextFactory _contextFactory;
        private readonly NonqueryDataService<T> _nonQueryDataService;

        public GenericDataService(ProductContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonqueryDataService<T>(contextFactory);

        }


        public async Task<T> Create(T entity)
        {

            return await _nonQueryDataService.Create(entity);

        }

        public async Task<bool> Delete(T entity)
        {

            return await _nonQueryDataService.Delete(entity);

        }

        public async Task<T> Get(int id)
        {
            using ProductDBContext context = _contextFactory.CreateDbContext();
            return await context.Set<T>().FindAsync(id);
        }


        public async Task<IEnumerable<T>> GetAll()
        {
            using ProductDBContext context = _contextFactory.CreateDbContext();
            return await context.Set<T>().ToListAsync();

        }

        public async Task<T> Update(T entity)
        {

            return await _nonQueryDataService.Update(entity);
        }
    }
}