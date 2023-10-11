using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ef_practice_Model.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        [Column("Name")]
        [Required]
        public string CategoryName { get; set; }
        /*public int DisplayOrder { get; set; }*/
    }
}
