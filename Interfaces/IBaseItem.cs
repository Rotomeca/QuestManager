namespace QuestManager.Interfaces
{

    public interface IBaseItemDescription
    {
        string Description { get; set; }
    }

    public interface IBaseItemName
    {
        string Name { get; set; }
    }

    public interface IBaseItem: IBaseItemDescription, IBaseItemName
    {
    }
}
