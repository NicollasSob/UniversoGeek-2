using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Domain.Entities;
using UniversoGeek.Domain.Interfaces;
using UniversoGeek.Infra.Data.Context;

namespace UniversoGeek.Infra.Data.Repositories
{
       public class CategoryRepository : Repository<Category>, ICategoryRepository
        {
            public CategoryRepository(UniversoGeekDbContext context) : base(context)
            {
            }

            public Category GetById(Guid id)
            {
                var context = DbSet.AsQueryable();
                var Category = context.FirstOrDefault(p => p.Id == id);
                return Category;
            }

            public async Task<Category> GetByIdAsync(Guid id)
            {
                var context = DbSet.AsQueryable();
                var Category = await context.FirstOrDefaultAsync(p => p.Id == id);
                return Category;
            }

            public IEnumerable<Category> Search(Expression<Func<Category, bool>> predicate)
            {
                var context = DbSet.AsQueryable();
                return context.Where(predicate).ToList();
            }

            public async Task<IEnumerable<Category>> SearchAsync(Expression<Func<Category, bool>> predicate)
            {
                var context = DbSet.AsQueryable();
                return await context.Where(predicate).ToListAsync();
            }

            public IEnumerable<Category> Search(Expression<Func<Category, bool>> predicate,
                int pageNumber,
                int pageSize)
            {
                var context = DbSet.AsQueryable();
                var result = context.Where(predicate).Skip((pageNumber - 1) * pageSize).Take(pageSize);
                return result;
            }

            public Category Add(Category entity)
            {
                DbSet.Add(entity);
                return entity;
            }

            public async Task<Category> AddAsync(Category entity)
            {
                await DbSet.AddAsync(entity);
                return entity;
            }

            public Category Update(Category entity)
            {
                DbSet.Update(entity);
                return entity;
            }

            public void Remove(Guid id)
            {
                var obj = GetById(id);
                if (obj != null)
                {
                    DbSet.Remove(obj);
                }
            }

            public void Remove(Expression<Func<Category, bool>> expression)
            {
                var context = DbSet.AsQueryable();
                var entities = context.Where(expression);
                DbSet.RemoveRange(entities);
            }
        }
    
}
