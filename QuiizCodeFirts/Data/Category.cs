namespace QuiizCodeFirts.Data
{
    public class Category
    {
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
