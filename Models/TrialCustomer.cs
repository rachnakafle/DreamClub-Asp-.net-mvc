using System.ComponentModel.DataAnnotations;

namespace DreamClub.Models
{
    public class TrialCustomer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email Id is not valid")]
        public string EmailId { get; set; }
    }
}
