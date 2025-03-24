namespace BlazingBlog.Domain.Abstractions;

public abstract class Entity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime? Updated { get; set; }
    public bool IsDeleted { get; set; }
}