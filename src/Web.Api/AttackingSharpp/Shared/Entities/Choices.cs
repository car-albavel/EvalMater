using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Web.Api.AttackingSharpp.Shared.Entities
{
    public class Choices
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        //public string NumberChoice { get; set; }
        public string Item { get; set; }

    }
}
