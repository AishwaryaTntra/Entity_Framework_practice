using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Ef_practice_Model.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId {  get; set; }

        [Required]
        public string Name { get; set;}

        public string Location { get; set;}

        public List<Book> Books { get; set;}
    }
}
