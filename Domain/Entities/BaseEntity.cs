namespace Domain.Entities;

public abstract class BaseEntity
{
    protected BaseEntity(int id)
    {
        Id = id;
    }

    public int Id { get; protected set; }
}
