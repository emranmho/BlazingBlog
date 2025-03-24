using BlazingBlog.Domain.Abstractions;

namespace BlazingBlog.Domain.Articles;

public class Article : Entity
{
    public required string Title { get; set; }
    public string? Content { get; set; }
    public DateTime? PublishedDate { get; set; }
    public bool IsPublished { get; set; } = false;
}