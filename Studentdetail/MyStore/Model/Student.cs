using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyStore.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
       
        public string? name { get; set; }
        [Required]
        public string? Address { get; set; }
        [EmailAddress]
        public string? email { get; set; }

        public long phoneno { get; set; }

    }
}
   