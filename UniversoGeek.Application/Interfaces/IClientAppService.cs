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
    public interface IClientAppService
    {
        Task<ClientViewModel> AddAsync(ClientViewModel Client);
        ClientViewModel Update(ClientViewModel Client);

        void Remove(Guid id);
        void Remove(Expression<Func<Client, bool>> expression);

        ClientViewModel GetById(Guid id);
        Task<ClientViewModel> GetByIdAsync(Guid id);

        IEnumerable<ClientViewModel> Search(Expression<Func<Client, bool>> predicate);
        Task<IEnumerable<ClientViewModel>> SearchAsync(Expression<Func<Client, bool>> predicate);
        IEnumerable<ClientViewModel> Search(Expression<Func<Client, bool>> predicate,
            int pageNumber,
            int pageSize);

        ClientViewModel UpdatePassword(Guid clientId, string newPassword);
    }
}

