using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
