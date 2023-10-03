using System.ComponentModel.DataAnnotations;

namespace ApiFuncional.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public int QtdEstoque { get; set; }
    }
}
