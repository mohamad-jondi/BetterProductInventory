namespace BetterProductInventory
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class BaseEntity
    {
        public EntityStateOption EntityOption { get; set; }
        public bool IsValid => Validate();
        public abstract bool Validate();
    }
}