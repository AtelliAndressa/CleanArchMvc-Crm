using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();

        Task<Category> GetById (int? id);

        Task<Category> Create (Category category);

        Task<Category> Update (Category category);

        Task<Category> Delete (Category category);
    }
}
