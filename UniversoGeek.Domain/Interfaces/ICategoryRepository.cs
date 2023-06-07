using System.Linq.Expressions;
using UniversoGeek.Domain.Entities;

namespace UniversoGeek.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Category GetById(Guid id);
        Task<Category> GetByIdAsync(Guid id);
        IEnumerable<Category> Search(Expression<Func<Category, bool>> predicate);
        Task<IEnumerable<Category>> SearchAsync(Expression<Func<Category, bool>> predicate);
        IEnumerable<Category> Search(Expression<Func<Category, bool>> predicate,
            int pageNumber,
            int pageSize);
        Category Add(Category entity);
        Task<Category> AddAsync(Category entity);
        Category Update(Category entity);
        void Remove(Guid id);
        void Remove(Expression<Func<Category, bool>> expression);
    }
}
