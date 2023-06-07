using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Application.Interfaces;
using UniversoGeek.Application.ViewModel;
using UniversoGeek.Domain.Entities;
using UniversoGeek.Domain.Interfaces;
using UniversoGeek.Domain.Shared.Transaction;

namespace UniversoGeek.Application.Services
{
    public class CategoryAppService : BaseService, ICategoryAppService
    {
        protected readonly ICategoryRepository _repository;
        protected readonly IMapper _mapper;

        public CategoryAppService(ICategoryRepository repository,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IMediator bus) : base(unitOfWork, bus)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryViewModel> AddAsync(CategoryViewModel viewModel)
        {
            viewModel.Active = true;

            Category domain = _mapper.Map<Category>(viewModel);
            domain = await _repository.AddAsync(domain);
            Commit();

            CategoryViewModel viewModelReturn = _mapper.Map<CategoryViewModel>(domain);
            return viewModelReturn;
        }

        public CategoryViewModel GetById(Guid id)
        {
            var domain = _repository.GetById(id);
            var viewModel = _mapper.Map<CategoryViewModel>(domain);
            return viewModel;
        }

        public async Task<CategoryViewModel> GetByIdAsync(Guid id)
        {
            var domain = await _repository.GetByIdAsync(id);
            var viewModel = _mapper.Map<CategoryViewModel>(domain);
            return viewModel;
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
            Commit();
        }

        public void Remove(Expression<Func<Category, bool>> expression)
        {
            _repository.Remove(expression);
            Commit();
        }

        public IEnumerable<CategoryViewModel> Search(Expression<Func<Category, bool>> predicate)
        {
            var domain = _repository.Search(predicate);
            var viewModels = _mapper.Map<IEnumerable<CategoryViewModel>>(domain);
            return viewModels;
        }

        public async Task<IEnumerable<CategoryViewModel>> SearchAsync(Expression<Func<Category, bool>> predicate)
        {
            var domain = await _repository.SearchAsync(predicate);
            var viewModels = _mapper.Map<IEnumerable<CategoryViewModel>>(domain);
            return viewModels;
        }

        public IEnumerable<CategoryViewModel> Search(Expression<Func<Category,
            bool>> predicate,
            int pageNumber,
            int pageSize)
        {
            var domain = _repository.Search(predicate, pageNumber, pageSize);
            var viewModels = _mapper.Map<IEnumerable<CategoryViewModel>>(domain);
            return viewModels;
        }

        public CategoryViewModel Update(CategoryViewModel viewModel)
        {
            var domain = _mapper.Map<Category>(viewModel);
            domain = _repository.Update(domain);
            Commit();
            CategoryViewModel viewModelReturn = _mapper.Map<CategoryViewModel>(domain);
            return viewModelReturn;
        }
    }
}
