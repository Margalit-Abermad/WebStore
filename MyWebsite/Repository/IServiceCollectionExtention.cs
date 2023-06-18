using Microsoft.Extensions.DependencyInjection;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository;

public static class IServiceCollectionExtention
{
    public static void AddRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsRepository, ProductsRepository>();
        serviceCollection.AddScoped<IDepartmentRepository, DepartmentRepository>();
        serviceCollection.AddDbContext<StoreContext>();
    }
}
