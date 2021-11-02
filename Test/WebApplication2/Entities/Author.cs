namespace WebApplication2.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
    }
}
