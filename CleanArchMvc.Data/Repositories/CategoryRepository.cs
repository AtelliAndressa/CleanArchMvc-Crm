using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _categoryContext;

        public CategoryRepository(ApplicationDbContext context)
        {
            _categoryContext = context;
        }

        /// <summary>
        /// Cria uma categoria.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<Category> Create(Category category)
        {
            _categoryContext.Add(category);
            await _categoryContext.SaveChangesAsync();

            return category;
        }

        /// <summary>
        /// Deleta uma categoria.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<Category> Delete(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();

            return category;
        }

        /// <summary>
        /// Pesquisa uma categoria pelo id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Category> GetById(int? id)
        {
            return await _categoryContext.Categories.FindAsync(id);
        }

        /// <summary>
        /// Traz uma lista de categorias.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryContext.Categories.ToListAsync();
        }

        /// <summary>
        /// Atualiza uma categoria.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<Category> Update(Category category)
        {
            _categoryContext.Update(category);
            await _categoryContext.SaveChangesAsync();

            return category;
        }
    }
}
