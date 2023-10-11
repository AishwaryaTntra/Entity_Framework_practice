using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ef_practice_Model.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
