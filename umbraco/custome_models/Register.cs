using System.ComponentModel.DataAnnotations;

namespace BurnSociety.umbraco.custome_models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }
        public Guid FullNames { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Country { get; set; }
        public required string Password { get; set; }


    }
}
