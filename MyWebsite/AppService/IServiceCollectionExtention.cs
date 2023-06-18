using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppService;

public static class IServiceCollectionExtention
{
    public static void AddAppServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsService, ProductsService>();
        serviceCollection.AddScoped<IDepartmentService, DepartmentService>();
        //serviceCollection.AddScoped<ICartService, CartService>();
        serviceCollection.AddAutoMapper(config => config.AddProfile<ProductsProfile>());
        //serviceCollection.AddAutoMapper(config => config.AddProfile<TargetsProfile>());
        //serviceCollection.AddAutoMapper(config => config.AddProfile<FundraisingGroupProfile>());
        //serviceCollection.AddAutoMapper(config => config.AddProfile<RaisProfile>());
        //serviceCollection.AddDbContext<MatchingContext>(opt=>opt.UseSqlServer)
        serviceCollection.AddRepositories();
    }
}
