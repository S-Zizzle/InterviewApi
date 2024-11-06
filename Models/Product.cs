using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace InterviewApi.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }
    }

    public class CreateProductDTO
    {
        public required string Name { get; set; }
        public required decimal Price { get; set; }
    }

    // PATCH would be better than this I think, but this still works fine.
    public class UpdateProductDTO
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}