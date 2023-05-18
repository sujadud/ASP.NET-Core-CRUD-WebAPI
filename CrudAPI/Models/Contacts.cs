using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Models
{
    public class Contacts
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
