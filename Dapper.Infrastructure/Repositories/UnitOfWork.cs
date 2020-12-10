using Dapper.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductRepository Products { get; }
        public UnitOfWork(IProductRepository productRepository)
        {
            Products = productRepository;
        }
    }
}
