namespace QuiizCodeFirts.Data
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public double Price { get; set; }

        public bool IsDiscontinued { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
