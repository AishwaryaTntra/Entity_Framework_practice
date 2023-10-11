﻿using System.ComponentModel.DataAnnotations;


namespace Ef_practice_Model.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        public List<Book> Books { get; set; }
    }
}
