using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tp3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The Name must be between 5 and 50 characters.")]
        public string? Name { get; set; }

        [ForeignKey("MembershiptypeId")]
        public int? membershipTypeId { get; set; }

        //Navigation Property
        public virtual MemberShipType? MembershipTypes { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
