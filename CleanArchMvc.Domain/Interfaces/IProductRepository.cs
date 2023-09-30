using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Retorna uma lista de produtos.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Product>> GetProductsAsync ();

        /// <summary>
        /// Retorna um produto único.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetByIdAsync (int id);

        /// <summary>
        /// Retorna um produto de uma determinada categoria.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetProductCategoryAsync (int? id);


        Task<Product> CreateAsync (Product product);


        Task<Product> UpdateAsync (Product product);


        Task<Product> DeleteAsync (Product product);
    }
}
