using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class Book
    {
        [Key]
        public int Book_ID { get; set; }
        public string Book_Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year_of_publish { get; set; }
    }
}
