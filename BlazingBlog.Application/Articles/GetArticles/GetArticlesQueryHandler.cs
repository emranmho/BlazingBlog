using BlazingBlog.Domain.Articles;
using MediatR;

namespace BlazingBlog.Application.Articles.GetArticles;

public class GetArticlesQueryHandler(IArticleRepository repository) : IRequestHandler<GetArticlesQuery, List<Article>>
{
    public async Task<List<Article>> Handle(GetArticlesQuery request, CancellationToken cancellationToken)
    {
        return await repository.GetAllArticlesAsync();
    }
}