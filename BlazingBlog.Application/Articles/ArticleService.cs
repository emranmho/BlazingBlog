using BlazingBlog.Domain.Articles;

namespace BlazingBlog.Application.Articles;

public class ArticleService : IArticleService
{
    private readonly IArticleRepository _repository;

    public ArticleService(IArticleRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<Article>> GetArticles()
    {
        return await _repository.GetAllArticlesAsync();
    }
}