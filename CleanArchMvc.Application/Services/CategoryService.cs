using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _repository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryDTO> GetById(int? id)
        {
            var categoryEntity = await _repository.GetById(id);
            return _mapper.Map<CategoryDTO>(categoryEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            var categoriesEntity = await _repository.GetCategories();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task Add(CategoryDTO categoryDTO)
        {
            var CategoryEntity = _mapper.Map<Category>(categoryDTO);
            await _repository.Create(CategoryEntity);
        }  

        public async Task Delete(int? id)
        {
            var CategoryEntity = _repository.GetById(id).Result;
            await _repository.Delete(CategoryEntity);
        }

        public async Task Update(CategoryDTO categoryDTO)
        {
            var CategoryEntity = _mapper.Map<Category>(categoryDTO);
            await _repository.Update(CategoryEntity);
        }
    }
}
