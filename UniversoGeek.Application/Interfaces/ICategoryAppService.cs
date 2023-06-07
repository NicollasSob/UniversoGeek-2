using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Application.ViewModel;
using UniversoGeek.Domain.Entities;

namespace UniversoGeek.Application.Interfaces
{
    public interface ICategoryAppService
    {
        Task<CategoryViewModel> AddAsync(CategoryViewModel Category);
        CategoryViewModel Update(CategoryViewModel Category);

        void Remove(Guid id);
        void Remove(Expression<Func<Category, bool>> expression);

        CategoryViewModel GetById(Guid id);
        Task<CategoryViewModel> GetByIdAsync(Guid id);

        IEnumerable<CategoryViewModel> Search(Expression<Func<Category, bool>> predicate);
        Task<IEnumerable<CategoryViewModel>> SearchAsync(Expression<Func<Category, bool>> predicate);
        IEnumerable<CategoryViewModel> Search(Expression<Func<Category, bool>> predicate,
            int pageNumber,
            int pageSize);
    }
}
