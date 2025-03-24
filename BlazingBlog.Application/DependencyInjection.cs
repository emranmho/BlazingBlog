using BlazingBlog.Application.Articles;
using Microsoft.Extensions.DependencyInjection;

namespace BlazingBlog.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
        });
            
        services.AddScoped<IArticleService, ArticleService>();

        return services;
    }
}