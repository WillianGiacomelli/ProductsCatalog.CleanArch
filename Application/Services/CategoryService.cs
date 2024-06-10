using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _repository = categoryRepository;
            _mapper = mapper;
        }

        public async Task Add(CategoryDTO categoryDTO)
        {
            var categorieEntity = _mapper.Map<Category>(categoryDTO);
            await _repository.Create(categorieEntity);
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            var categoriesEntity = await _repository.GetCategoryiesAsync();
            return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
        }

        public async Task<CategoryDTO> GetCategoryByIdAsync(int id)
        {
            var categorieEntity = await _repository.GetCategoriesByIdAsync(id);
            return _mapper.Map<CategoryDTO>(categorieEntity);
        }

        public async Task Remove(int id)
        {
            var categorieEntity = _repository.GetCategoriesByIdAsync(id).Result;
            if (categorieEntity != null) 
            {
                await _repository.Delete(categorieEntity);
            }
        }

        public async Task Update(CategoryDTO categoryDTO)
        {
            var categorieEntity = _mapper.Map<Category>(categoryDTO);
            await _repository.Update(categorieEntity);
        }
    }
}
