using System.ComponentModel.DataAnnotations;


namespace Ef_practice_Model.Models
{
    public class Fluent_Publisher
    {
        public int PublisherId { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public List<Fluent_Book> Books { get; set; }
    }
}
