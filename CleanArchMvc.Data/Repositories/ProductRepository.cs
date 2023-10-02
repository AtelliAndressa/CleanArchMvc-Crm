using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _productContext;

        public ProductRepository(ApplicationDbContext context)
        {
            _productContext = context;
        }

        /// <summary>
        /// Criar um produto.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> CreateAsync(Product product)
        {
            _productContext.Add(product);
            await _productContext.SaveChangesAsync();

            return product;
        }

        /// <summary>
        /// Remover o produto.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> DeleteAsync(Product product)
        {
            _productContext.Remove(product);
            await _productContext.SaveChangesAsync();

            return product;
        }

        /// <summary>
        /// Retorna o produto.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productContext.Products.FindAsync(id);
        }

        /// <summary>
        /// Carregamento adiantado.
        /// Retorna o produto e a categoria que está relacionada com ele.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product> GetProductCategoryAsync(int? id)
        {
            return await _productContext.Products
                .Include(x => x.Category)
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        /// <summary>
        /// Traz uma lista de produtos.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productContext.Products.ToListAsync();
        }

        /// <summary>
        /// Atualiza o produto.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> UpdateAsync(Product product)
        {
            _productContext.Update(product);
            await _productContext.SaveChangesAsync();

            return product;
        }
    }
}
