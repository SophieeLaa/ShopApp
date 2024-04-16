using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Shop_temp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Dispay Order")]
        [Range(1, 100, ErrorMessage = "Dispkay Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
