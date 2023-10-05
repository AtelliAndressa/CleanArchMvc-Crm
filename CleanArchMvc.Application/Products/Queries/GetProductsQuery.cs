using CleanArchMvc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Queries
{
    /// <summary>
    /// Retorna uma lista de produtos.
    /// </summary>
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
