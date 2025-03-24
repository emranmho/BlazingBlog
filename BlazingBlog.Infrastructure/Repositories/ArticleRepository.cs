using BlazingBlog.Domain.Articles;
using Microsoft.EntityFrameworkCore;

namespace BlazingBlog.Infrastructure.Repositories;

public class ArticleRepository(ApplicationDbContext context) : IArticleRepository
{
    public async Task<List<Article>> GetAllArticlesAsync()
    {
       return await context.Articles.ToListAsync();
    }
}