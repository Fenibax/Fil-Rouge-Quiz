using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace QuiizCodeFirts.Data
{
    public class Supplier
    {
        public int SupplierID { get; set; }
       [StringLength(100)]
       public string Name { get; set;}

        public virtual ICollection<Product> Products { get; set; }
    }
}
